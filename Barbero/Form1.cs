using CPCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbero
{
    public partial class Form1 : Form
    {
        private static int _numeroConsumidores = 5;
        private static int _numeroProductores = 3;
        private static int _tamBuffer = 10;
        private static int _tiempoConsumidor = 10000;
        private static int _tiempoProductor = 1000;

        ProducerConsumer pc;

        public Form1()
        {
            InitializeComponent();
        }



        private void limpiarCampos()
        {
            foreach (var series in chart_consumidores.Series) series.Points.Clear();
            foreach (var series in chart_productores.Series) series.Points.Clear();
            lbl_producerSC.Text = "NAN";
            lbl_consumidorSC.Text = "NAN";

        }

        private void labels(int consumer, int producer)
        {
            if (consumer == 0)
            {
                lbl_consumidorSC.Text = "NAN";
            }
            else
            {
                lbl_consumidorSC.Text = consumer.ToString();
            }
            if (producer == 0)
            {
                lbl_producerSC.Text = "NAN";
            }
            else
            {
                lbl_producerSC.Text = producer.ToString();
            }
        }

        private void btnStatus(bool x)
        {
            if (x)
            {
                button2.Enabled = true;
                btn_graficar.Enabled = true;
                button1.Enabled = false;
                num_consumidores.Enabled = false;
                num_productores.Enabled = false;
                btn_agregarProductor.Visible = true;
                btn_agregarConsumidor.Visible = true;
                lbl_addConsumer.Visible = true;
                lbl_addProducer.Visible = true;
            }
            else
            {
                button2.Enabled = false;
                btn_graficar.Enabled = false;
                button1.Enabled = true;
                num_productores.Enabled = true;
                num_consumidores.Enabled = true;
                btn_agregarProductor.Visible = false;
                btn_agregarConsumidor.Visible = false;
                lbl_addConsumer.Visible = false;
                lbl_addProducer.Visible = false;
            }
        }

        private void addValues()
        {
            _numeroConsumidores = (int)num_consumidores.Value;
            _numeroProductores = (int)num_productores.Value;
            _tiempoConsumidor = (int)num_msConsumidor.Value;
            _tiempoProductor = (int)num_msProductores.Value;
            _tamBuffer = (int)num_buffer.Value;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            btnStatus(false);
            timer.Stop();
            pc.Detener();
        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {
            string[] series = new string[10];

            int consumerSC = pc.getConsumidorActual();
            int producerSC = pc.getProductorActual();

            int cantidadConsumidores = pc.getConsumer();
            int cantidadProductores = pc.getProducer();

            labels(consumerSC, producerSC);

            //Consumidor
            for (int i = 1; i <= cantidadConsumidores; i++)
            {
                series[i] = ("Barb" + i.ToString());
                if (consumerSC == i)
                {
                    chart_consumidores.Series[series[i]].Points.AddY(1);
                }
                else
                {
                    chart_consumidores.Series[series[i]].Points.AddY(0);
                }

            }
            //Productor
            for (int i = 1; i <= cantidadProductores; i++)
            {
                series[i] = ("Client" + i.ToString());
                if (producerSC == i)
                {
                    chart_productores.Series[series[i]].Points.AddY(1);
                }
                else
                {
                    chart_productores.Series[series[i]].Points.AddY(0);
                }

            }
            //buffer
            chart_buffer.Series["Productos"].Points.Clear();
            chart_buffer.Series["Productos"].Points.AddXY("Sillas", pc.getBuffer() - pc.getQueueLong());
            for (int i = 0; i < pc.getBuffer(); i++)
            {
                int[] buffer = new int[pc.getQueueLong()];
                if (i < buffer.Length)
                {
                    buffer = pc.getQueue();
                    chart_buffer.Series["Productos"].Points.AddXY(buffer[i], 1);
                }

            }
            /*
            if (pc.getQueueLong() == 0)
            {
                btnStatus(false);
                timer.Stop();
                pc.Detener();
            }*/
        }

        private void btn_agregarConsumidor_Click_1(object sender, EventArgs e)
        {
            if (num_consumidores.Value <= 10)
            {
                num_consumidores.Value++;
                pc.AgregarConsumidor();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            btnStatus(true);
            limpiarCampos();
            addValues();
            timer.Start();
            pc = new ProducerConsumer(_numeroConsumidores, _numeroProductores, _tamBuffer, _tiempoConsumidor, _tiempoProductor);
            pc.Comenzar();
        }

        private void btn_agregarProductor_Click(object sender, EventArgs e)
        {
            if (num_productores.Value <= 10)
            {
                num_productores.Value++;
                pc.AgregarProductor();
            }
        }

        private void num_msConsumidor_ValueChanged_1(object sender, EventArgs e)
        {
            pc.setTimeConsumidores((int)num_msConsumidor.Value);
        }

        private void num_msProductores_ValueChanged(object sender, EventArgs e)
        {
            pc.setTimeProductores((int)num_msProductores.Value);
        }

        private void num_buffer_ValueChanged_1(object sender, EventArgs e)
        {
            pc.setBufferSize((int)num_buffer.Value);
        }
    }
}

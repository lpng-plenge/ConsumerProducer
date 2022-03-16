using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPCode
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

        private void button1_Click(object sender, EventArgs e)
        {

            btnStatus(true);
            addValues();
            pc = new ProducerConsumer(_numeroConsumidores, _numeroProductores, _tamBuffer, _tiempoConsumidor, _tiempoProductor);
            pc.Comenzar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnStatus(false);
            pc.Detener();
        }

        private void btnStatus(bool x)
        {
            if (x)
            {
                btn_detener.Enabled = true;
                btn_ejecucion.Enabled = false;
            }
            else {
                btn_detener.Enabled = false;
                btn_ejecucion.Enabled = true;
            }

        }

        private void addValues()
        {
            _numeroConsumidores = (int)num_consumidores.Value;
            _numeroProductores = (int)num_productores.Value;
            _tiempoConsumidor= (int)num_msConsumidor.Value;
            _tiempoProductor = (int)num_msProductores.Value;
            _tamBuffer = (int)num_buffer.Value;
        }

        //Manipulacion Durante La Ejecucion
        private void btn_agregarConsumidores_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_agregarProductores_Click(object sender, EventArgs e)
        {

        }

        private void btn_masBuffer_Click(object sender, EventArgs e)
        {

        }

        private void btn_menosBuffer_Click(object sender, EventArgs e)
        {
            

        }

        private void num_buffer_ValueChanged(object sender, EventArgs e)
        {
            pc.setBufferSize((int)num_buffer.Value);
        }
    }
}

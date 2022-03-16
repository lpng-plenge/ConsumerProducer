
namespace CPCode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ejecucion = new System.Windows.Forms.Button();
            this.btn_detener = new System.Windows.Forms.Button();
            this.num_consumidores = new System.Windows.Forms.NumericUpDown();
            this.lbl_Consumidores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_msConsumidor = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregarConsumidores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_agregarProductores = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.num_msProductores = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_productores = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_buffer = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_consumidores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_msConsumidor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_msProductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_productores)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_buffer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ejecucion
            // 
            this.btn_ejecucion.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ejecucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ejecucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ejecucion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ejecucion.ForeColor = System.Drawing.Color.Snow;
            this.btn_ejecucion.Location = new System.Drawing.Point(12, 592);
            this.btn_ejecucion.Name = "btn_ejecucion";
            this.btn_ejecucion.Size = new System.Drawing.Size(141, 73);
            this.btn_ejecucion.TabIndex = 0;
            this.btn_ejecucion.Text = "Ejecutar";
            this.btn_ejecucion.UseVisualStyleBackColor = false;
            this.btn_ejecucion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_detener
            // 
            this.btn_detener.BackColor = System.Drawing.Color.Maroon;
            this.btn_detener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_detener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detener.Enabled = false;
            this.btn_detener.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detener.ForeColor = System.Drawing.Color.Snow;
            this.btn_detener.Location = new System.Drawing.Point(170, 592);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(141, 71);
            this.btn_detener.TabIndex = 1;
            this.btn_detener.Text = "Pausar";
            this.btn_detener.UseVisualStyleBackColor = false;
            this.btn_detener.Click += new System.EventHandler(this.button2_Click);
            // 
            // num_consumidores
            // 
            this.num_consumidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_consumidores.Location = new System.Drawing.Point(12, 59);
            this.num_consumidores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_consumidores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_consumidores.Name = "num_consumidores";
            this.num_consumidores.Size = new System.Drawing.Size(122, 26);
            this.num_consumidores.TabIndex = 2;
            this.num_consumidores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_consumidores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Consumidores
            // 
            this.lbl_Consumidores.AutoSize = true;
            this.lbl_Consumidores.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_Consumidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consumidores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Consumidores.Location = new System.Drawing.Point(-5, 0);
            this.lbl_Consumidores.Name = "lbl_Consumidores";
            this.lbl_Consumidores.Size = new System.Drawing.Size(162, 25);
            this.lbl_Consumidores.TabIndex = 3;
            this.lbl_Consumidores.Text = "Consumidores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiempo ms ";
            // 
            // num_msConsumidor
            // 
            this.num_msConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_msConsumidor.Location = new System.Drawing.Point(12, 122);
            this.num_msConsumidor.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_msConsumidor.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_msConsumidor.Name = "num_msConsumidor";
            this.num_msConsumidor.Size = new System.Drawing.Size(122, 26);
            this.num_msConsumidor.TabIndex = 6;
            this.num_msConsumidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_msConsumidor.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btn_agregarConsumidores);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_msConsumidor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_Consumidores);
            this.panel1.Controls.Add(this.num_consumidores);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 174);
            this.panel1.TabIndex = 8;
            // 
            // btn_agregarConsumidores
            // 
            this.btn_agregarConsumidores.BackColor = System.Drawing.Color.Orange;
            this.btn_agregarConsumidores.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarConsumidores.ForeColor = System.Drawing.Color.Snow;
            this.btn_agregarConsumidores.Location = new System.Drawing.Point(170, 131);
            this.btn_agregarConsumidores.Name = "btn_agregarConsumidores";
            this.btn_agregarConsumidores.Size = new System.Drawing.Size(129, 43);
            this.btn_agregarConsumidores.TabIndex = 10;
            this.btn_agregarConsumidores.Text = "Mas (+)";
            this.btn_agregarConsumidores.UseVisualStyleBackColor = false;
            this.btn_agregarConsumidores.Click += new System.EventHandler(this.btn_agregarConsumidores_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad de Hilos ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btn_agregarProductores);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.num_msProductores);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.num_productores);
            this.panel2.Location = new System.Drawing.Point(12, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 174);
            this.panel2.TabIndex = 9;
            // 
            // btn_agregarProductores
            // 
            this.btn_agregarProductores.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_agregarProductores.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProductores.ForeColor = System.Drawing.Color.Snow;
            this.btn_agregarProductores.Location = new System.Drawing.Point(170, 131);
            this.btn_agregarProductores.Name = "btn_agregarProductores";
            this.btn_agregarProductores.Size = new System.Drawing.Size(129, 43);
            this.btn_agregarProductores.TabIndex = 11;
            this.btn_agregarProductores.Text = "Mas (+)";
            this.btn_agregarProductores.UseVisualStyleBackColor = false;
            this.btn_agregarProductores.Click += new System.EventHandler(this.btn_agregarProductores_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de Hilos ";
            // 
            // num_msProductores
            // 
            this.num_msProductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_msProductores.Location = new System.Drawing.Point(12, 122);
            this.num_msProductores.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_msProductores.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_msProductores.Name = "num_msProductores";
            this.num_msProductores.Size = new System.Drawing.Size(122, 26);
            this.num_msProductores.TabIndex = 6;
            this.num_msProductores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_msProductores.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiempo ms ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(-5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Productores";
            // 
            // num_productores
            // 
            this.num_productores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_productores.Location = new System.Drawing.Point(12, 59);
            this.num_productores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_productores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_productores.Name = "num_productores";
            this.num_productores.Size = new System.Drawing.Size(122, 26);
            this.num_productores.TabIndex = 2;
            this.num_productores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_productores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.num_buffer);
            this.panel3.Location = new System.Drawing.Point(12, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 122);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tamaño Buffer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkMagenta;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(-5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Buffer";
            // 
            // num_buffer
            // 
            this.num_buffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_buffer.Location = new System.Drawing.Point(12, 59);
            this.num_buffer.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_buffer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_buffer.Name = "num_buffer";
            this.num_buffer.Size = new System.Drawing.Size(122, 26);
            this.num_buffer.TabIndex = 2;
            this.num_buffer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_buffer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_buffer.ValueChanged += new System.EventHandler(this.num_buffer_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_ejecucion);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Consumidor Productor";
            ((System.ComponentModel.ISupportInitialize)(this.num_consumidores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_msConsumidor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_msProductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_productores)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_buffer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ejecucion;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.NumericUpDown num_consumidores;
        private System.Windows.Forms.Label lbl_Consumidores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_msConsumidor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_msProductores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_productores;
        private System.Windows.Forms.Button btn_agregarConsumidores;
        private System.Windows.Forms.Button btn_agregarProductores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_buffer;
    }
}


namespace atvt1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbimportado = new System.Windows.Forms.RadioButton();
            this.rbnacional = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbalinhamento = new System.Windows.Forms.CheckBox();
            this.cbcaster = new System.Windows.Forms.CheckBox();
            this.cbalanceamento = new System.Windows.Forms.CheckBox();
            this.cbcamber = new System.Windows.Forms.CheckBox();
            this.nudhoras = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtvalorpagar = new System.Windows.Forms.TextBox();
            this.proximo = new System.Windows.Forms.Button();
            this.nudrodas = new System.Windows.Forms.NumericUpDown();
            this.btncalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudhoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudrodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela Mão de obras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Camber 30.00 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cáster 20.00 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balanceamento 12.00 p/ roda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alinhamento 25.00 p/h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carro Importado 85.00 p/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro Nacional 60.00 p/h";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbimportado);
            this.groupBox2.Controls.Add(this.rbnacional);
            this.groupBox2.Location = new System.Drawing.Point(256, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modelo:";
            // 
            // rbimportado
            // 
            this.rbimportado.AutoSize = true;
            this.rbimportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbimportado.Location = new System.Drawing.Point(33, 53);
            this.rbimportado.Name = "rbimportado";
            this.rbimportado.Size = new System.Drawing.Size(81, 17);
            this.rbimportado.TabIndex = 1;
            this.rbimportado.TabStop = true;
            this.rbimportado.Text = "Importado";
            this.rbimportado.UseVisualStyleBackColor = true;
            // 
            // rbnacional
            // 
            this.rbnacional.AutoSize = true;
            this.rbnacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnacional.Location = new System.Drawing.Point(33, 21);
            this.rbnacional.Name = "rbnacional";
            this.rbnacional.Size = new System.Drawing.Size(75, 17);
            this.rbnacional.TabIndex = 0;
            this.rbnacional.TabStop = true;
            this.rbnacional.Text = "Nacional";
            this.rbnacional.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 47);
            this.label7.TabIndex = 3;
            this.label7.Text = "Serviços";
            // 
            // cbalinhamento
            // 
            this.cbalinhamento.AutoSize = true;
            this.cbalinhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbalinhamento.Location = new System.Drawing.Point(503, 110);
            this.cbalinhamento.Name = "cbalinhamento";
            this.cbalinhamento.Size = new System.Drawing.Size(119, 22);
            this.cbalinhamento.TabIndex = 4;
            this.cbalinhamento.Text = "Alinhamento";
            this.cbalinhamento.UseVisualStyleBackColor = true;
            // 
            // cbcaster
            // 
            this.cbcaster.AutoSize = true;
            this.cbcaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcaster.Location = new System.Drawing.Point(664, 110);
            this.cbcaster.Name = "cbcaster";
            this.cbcaster.Size = new System.Drawing.Size(77, 22);
            this.cbcaster.TabIndex = 5;
            this.cbcaster.Text = "Cáster";
            this.cbcaster.UseVisualStyleBackColor = true;
            // 
            // cbalanceamento
            // 
            this.cbalanceamento.AutoSize = true;
            this.cbalanceamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbalanceamento.Location = new System.Drawing.Point(503, 157);
            this.cbalanceamento.Name = "cbalanceamento";
            this.cbalanceamento.Size = new System.Drawing.Size(143, 22);
            this.cbalanceamento.TabIndex = 6;
            this.cbalanceamento.Text = "Balanceamento";
            this.cbalanceamento.UseVisualStyleBackColor = true;
            // 
            // cbcamber
            // 
            this.cbcamber.AutoSize = true;
            this.cbcamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcamber.Location = new System.Drawing.Point(664, 157);
            this.cbcamber.Name = "cbcamber";
            this.cbcamber.Size = new System.Drawing.Size(86, 22);
            this.cbcamber.TabIndex = 7;
            this.cbcamber.Text = "Camber";
            this.cbcamber.UseVisualStyleBackColor = true;
            // 
            // nudhoras
            // 
            this.nudhoras.Location = new System.Drawing.Point(459, 239);
            this.nudhoras.Name = "nudhoras";
            this.nudhoras.Size = new System.Drawing.Size(87, 20);
            this.nudhoras.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quantidade de rodas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Horas Trabalhadas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Valor a pagar:";
            // 
            // txtvalorpagar
            // 
            this.txtvalorpagar.Location = new System.Drawing.Point(408, 390);
            this.txtvalorpagar.Name = "txtvalorpagar";
            this.txtvalorpagar.Size = new System.Drawing.Size(187, 20);
            this.txtvalorpagar.TabIndex = 13;
            // 
            // proximo
            // 
            this.proximo.Location = new System.Drawing.Point(724, 424);
            this.proximo.Name = "proximo";
            this.proximo.Size = new System.Drawing.Size(75, 23);
            this.proximo.TabIndex = 15;
            this.proximo.Text = "Próximo";
            this.proximo.UseVisualStyleBackColor = true;
            this.proximo.Click += new System.EventHandler(this.Proximo_Click_1);
            // 
            // nudrodas
            // 
            this.nudrodas.Location = new System.Drawing.Point(684, 199);
            this.nudrodas.Name = "nudrodas";
            this.nudrodas.Size = new System.Drawing.Size(87, 20);
            this.nudrodas.TabIndex = 16;
            // 
            // btncalcular
            // 
            this.btncalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncalcular.BackgroundImage")));
            this.btncalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Location = new System.Drawing.Point(471, 294);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(87, 67);
            this.btncalcular.TabIndex = 14;
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.calcular);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::atvt1.Properties.Resources.moto;
            this.pictureBox1.InitialImage = global::atvt1.Properties.Resources.moto;
            this.pictureBox1.Location = new System.Drawing.Point(66, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudrodas);
            this.Controls.Add(this.proximo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalorpagar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudhoras);
            this.Controls.Add(this.cbcamber);
            this.Controls.Add(this.cbalanceamento);
            this.Controls.Add(this.cbcaster);
            this.Controls.Add(this.cbalinhamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Concessionaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudhoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudrodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbimportado;
        private System.Windows.Forms.RadioButton rbnacional;
        private System.Windows.Forms.CheckBox cbalinhamento;
        private System.Windows.Forms.CheckBox cbcaster;
        private System.Windows.Forms.CheckBox cbalanceamento;
        private System.Windows.Forms.CheckBox cbcamber;
        private System.Windows.Forms.NumericUpDown nudhoras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtvalorpagar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button proximo;
        private System.Windows.Forms.NumericUpDown nudrodas;
    }
}


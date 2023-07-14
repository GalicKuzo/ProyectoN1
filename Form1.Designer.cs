namespace ProyectoN1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_inteligencia = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_dineroAho = new System.Windows.Forms.TextBox();
            this.txt_fondoPen = new System.Windows.Forms.TextBox();
            this.btn_calcularRiqueza = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_riqueza = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.tb_riqueza = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_medirInteligencia = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_escala = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_nivelIn = new System.Windows.Forms.Label();
            this.tb_inteligencia.SuspendLayout();
            this.tb_riqueza.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_inteligencia
            // 
            this.tb_inteligencia.Controls.Add(this.tb_riqueza);
            this.tb_inteligencia.Location = new System.Drawing.Point(14, 15);
            this.tb_inteligencia.Name = "tb_inteligencia";
            this.tb_inteligencia.SelectedIndex = 0;
            this.tb_inteligencia.Size = new System.Drawing.Size(901, 358);
            this.tb_inteligencia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dinero Ahorrado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(87, 38);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(383, 22);
            this.txt_nombres.TabIndex = 4;
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(89, 67);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(382, 22);
            this.txt_apellidos.TabIndex = 5;
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellidos_KeyPress);
            // 
            // txt_dineroAho
            // 
            this.txt_dineroAho.Location = new System.Drawing.Point(131, 97);
            this.txt_dineroAho.Name = "txt_dineroAho";
            this.txt_dineroAho.Size = new System.Drawing.Size(340, 22);
            this.txt_dineroAho.TabIndex = 6;
            this.txt_dineroAho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dineroAho_KeyPress);
            // 
            // txt_fondoPen
            // 
            this.txt_fondoPen.Location = new System.Drawing.Point(131, 129);
            this.txt_fondoPen.Name = "txt_fondoPen";
            this.txt_fondoPen.Size = new System.Drawing.Size(340, 22);
            this.txt_fondoPen.TabIndex = 7;
            this.txt_fondoPen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fondoPen_KeyPress);
            // 
            // btn_calcularRiqueza
            // 
            this.btn_calcularRiqueza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcularRiqueza.Location = new System.Drawing.Point(87, 232);
            this.btn_calcularRiqueza.Name = "btn_calcularRiqueza";
            this.btn_calcularRiqueza.Size = new System.Drawing.Size(324, 40);
            this.btn_calcularRiqueza.TabIndex = 2;
            this.btn_calcularRiqueza.Text = "Calcular Riqueza";
            this.btn_calcularRiqueza.UseVisualStyleBackColor = true;
            this.btn_calcularRiqueza.Click += new System.EventHandler(this.btn_calcularRiqueza_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Riqueza:";
            // 
            // lbl_riqueza
            // 
            this.lbl_riqueza.AutoSize = true;
            this.lbl_riqueza.Location = new System.Drawing.Point(96, 201);
            this.lbl_riqueza.Name = "lbl_riqueza";
            this.lbl_riqueza.Size = new System.Drawing.Size(0, 16);
            this.lbl_riqueza.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombres:";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Location = new System.Drawing.Point(104, 173);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(0, 16);
            this.lbl_nombres.TabIndex = 11;
            // 
            // tb_riqueza
            // 
            this.tb_riqueza.Controls.Add(this.groupBox2);
            this.tb_riqueza.Controls.Add(this.groupBox1);
            this.tb_riqueza.Location = new System.Drawing.Point(4, 25);
            this.tb_riqueza.Name = "tb_riqueza";
            this.tb_riqueza.Padding = new System.Windows.Forms.Padding(3);
            this.tb_riqueza.Size = new System.Drawing.Size(893, 329);
            this.tb_riqueza.TabIndex = 0;
            this.tb_riqueza.Text = "Riqueza e Inteligencia";
            this.tb_riqueza.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Apellidos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fondo Pension:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_nombres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_riqueza);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_calcularRiqueza);
            this.groupBox1.Controls.Add(this.txt_fondoPen);
            this.groupBox1.Controls.Add(this.txt_dineroAho);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 308);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Riqueza";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_nivelIn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_escala);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_medirInteligencia);
            this.groupBox2.Location = new System.Drawing.Point(508, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 308);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inteligencia";
            // 
            // btn_medirInteligencia
            // 
            this.btn_medirInteligencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medirInteligencia.Location = new System.Drawing.Point(35, 232);
            this.btn_medirInteligencia.Name = "btn_medirInteligencia";
            this.btn_medirInteligencia.Size = new System.Drawing.Size(324, 40);
            this.btn_medirInteligencia.TabIndex = 16;
            this.btn_medirInteligencia.Text = "Medir Inteligencia";
            this.btn_medirInteligencia.UseVisualStyleBackColor = true;
            this.btn_medirInteligencia.Click += new System.EventHandler(this.btn_medirInteligencia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Escala: ";
            // 
            // txt_escala
            // 
            this.txt_escala.Location = new System.Drawing.Point(81, 94);
            this.txt_escala.Name = "txt_escala";
            this.txt_escala.Size = new System.Drawing.Size(278, 22);
            this.txt_escala.TabIndex = 16;
            this.txt_escala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_escala_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nivel de Inteligencia:";
            // 
            // lbl_nivelIn
            // 
            this.lbl_nivelIn.AutoSize = true;
            this.lbl_nivelIn.Location = new System.Drawing.Point(20, 173);
            this.lbl_nivelIn.Name = "lbl_nivelIn";
            this.lbl_nivelIn.Size = new System.Drawing.Size(0, 16);
            this.lbl_nivelIn.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 375);
            this.Controls.Add(this.tb_inteligencia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tb_inteligencia.ResumeLayout(false);
            this.tb_riqueza.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tb_inteligencia;
        private System.Windows.Forms.TabPage tb_riqueza;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_riqueza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_calcularRiqueza;
        private System.Windows.Forms.TextBox txt_fondoPen;
        private System.Windows.Forms.TextBox txt_dineroAho;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_nivelIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_escala;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_medirInteligencia;
    }
}


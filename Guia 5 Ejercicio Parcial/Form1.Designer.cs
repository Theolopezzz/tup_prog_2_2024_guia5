namespace Guia_5_Ejercicio_Parcial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btCerrarPresu = new System.Windows.Forms.Button();
            this.bIniciarPresu = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMesa = new System.Windows.Forms.RadioButton();
            this.rbBanco = new System.Windows.Forms.RadioButton();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLista);
            this.groupBox1.Controls.Add(this.btBorrar);
            this.groupBox1.Controls.Add(this.btCerrarPresu);
            this.groupBox1.Controls.Add(this.bIniciarPresu);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // cbLista
            // 
            this.cbLista.BackColor = System.Drawing.Color.RosyBrown;
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(26, 204);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(121, 21);
            this.cbLista.TabIndex = 7;
            // 
            // btBorrar
            // 
            this.btBorrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btBorrar.Location = new System.Drawing.Point(178, 194);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(85, 39);
            this.btBorrar.TabIndex = 6;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = false;
            this.btBorrar.Click += new System.EventHandler(this.bBorrar);
            // 
            // btCerrarPresu
            // 
            this.btCerrarPresu.BackColor = System.Drawing.Color.YellowGreen;
            this.btCerrarPresu.Location = new System.Drawing.Point(178, 135);
            this.btCerrarPresu.Name = "btCerrarPresu";
            this.btCerrarPresu.Size = new System.Drawing.Size(85, 39);
            this.btCerrarPresu.TabIndex = 5;
            this.btCerrarPresu.Text = "Cerrar Presupuesto";
            this.btCerrarPresu.UseVisualStyleBackColor = false;
            this.btCerrarPresu.Click += new System.EventHandler(this.btCerrarPresu_Click);
            // 
            // bIniciarPresu
            // 
            this.bIniciarPresu.BackColor = System.Drawing.Color.YellowGreen;
            this.bIniciarPresu.Location = new System.Drawing.Point(26, 135);
            this.bIniciarPresu.Name = "bIniciarPresu";
            this.bIniciarPresu.Size = new System.Drawing.Size(85, 39);
            this.bIniciarPresu.TabIndex = 4;
            this.bIniciarPresu.Text = "Iniciar Presupuesto";
            this.bIniciarPresu.UseVisualStyleBackColor = false;
            this.bIniciarPresu.Click += new System.EventHandler(this.bIniciarPresu_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(117, 82);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(113, 20);
            this.tbDireccion.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(117, 46);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(113, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMesa);
            this.groupBox2.Controls.Add(this.rbBanco);
            this.groupBox2.Controls.Add(this.btAgregar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbAncho);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Controls.Add(this.tbLargo);
            this.groupBox2.Controls.Add(this.tbGrosor);
            this.groupBox2.Controls.Add(this.tbPrecio);
            this.groupBox2.Location = new System.Drawing.Point(313, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // rbMesa
            // 
            this.rbMesa.AutoSize = true;
            this.rbMesa.Location = new System.Drawing.Point(169, 196);
            this.rbMesa.Name = "rbMesa";
            this.rbMesa.Size = new System.Drawing.Size(51, 17);
            this.rbMesa.TabIndex = 15;
            this.rbMesa.TabStop = true;
            this.rbMesa.Text = "Mesa";
            this.rbMesa.UseVisualStyleBackColor = true;
            // 
            // rbBanco
            // 
            this.rbBanco.AutoSize = true;
            this.rbBanco.Location = new System.Drawing.Point(41, 196);
            this.rbBanco.Name = "rbBanco";
            this.rbBanco.Size = new System.Drawing.Size(56, 17);
            this.rbBanco.TabIndex = 14;
            this.rbBanco.TabStop = true;
            this.rbBanco.Text = "Banco";
            this.rbBanco.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAgregar.Location = new System.Drawing.Point(169, 124);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(85, 39);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grosor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Largo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio B:";
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(64, 85);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(62, 20);
            this.tbAncho.TabIndex = 7;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(64, 121);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(62, 20);
            this.tbCodigo.TabIndex = 6;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(183, 42);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(62, 20);
            this.tbLargo.TabIndex = 5;
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(183, 85);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(62, 20);
            this.tbGrosor.TabIndex = 4;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(64, 42);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(62, 20);
            this.tbPrecio.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(620, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Button bIniciarPresu;
        private System.Windows.Forms.Button btCerrarPresu;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.RadioButton rbBanco;
        private System.Windows.Forms.RadioButton rbMesa;
        private System.Windows.Forms.ComboBox cbLista;
    }
}


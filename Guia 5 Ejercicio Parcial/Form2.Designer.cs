namespace Guia_5_Ejercicio_Parcial
{
    partial class Form2
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
            this.lbResumen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbResumen
            // 
            this.lbResumen.BackColor = System.Drawing.Color.MistyRose;
            this.lbResumen.FormattingEnabled = true;
            this.lbResumen.Location = new System.Drawing.Point(12, 12);
            this.lbResumen.Name = "lbResumen";
            this.lbResumen.Size = new System.Drawing.Size(309, 251);
            this.lbResumen.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(335, 274);
            this.Controls.Add(this.lbResumen);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbResumen;
    }
}
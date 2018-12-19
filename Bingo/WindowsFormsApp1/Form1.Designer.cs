namespace WindowsFormsApp1
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
            this.cmbJugadores = new System.Windows.Forms.ComboBox();
            this.Jugadores = new System.Windows.Forms.Label();
            this.Modalidad = new System.Windows.Forms.Label();
            this.cmbModalidad = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbJugadores
            // 
            this.cmbJugadores.FormattingEnabled = true;
            this.cmbJugadores.Items.AddRange(new object[] {
            "Jugador 1",
            "Jugador 2",
            "Jugador 3"});
            this.cmbJugadores.Location = new System.Drawing.Point(48, 75);
            this.cmbJugadores.Name = "cmbJugadores";
            this.cmbJugadores.Size = new System.Drawing.Size(121, 21);
            this.cmbJugadores.TabIndex = 0;
            // 
            // Jugadores
            // 
            this.Jugadores.AutoSize = true;
            this.Jugadores.Location = new System.Drawing.Point(45, 59);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Size = new System.Drawing.Size(56, 13);
            this.Jugadores.TabIndex = 1;
            this.Jugadores.Text = "Jugadores";
            // 
            // Modalidad
            // 
            this.Modalidad.AutoSize = true;
            this.Modalidad.Location = new System.Drawing.Point(45, 120);
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.Size = new System.Drawing.Size(103, 13);
            this.Modalidad.TabIndex = 3;
            this.Modalidad.Text = "Modalidad de Juego";
            // 
            // cmbModalidad
            // 
            this.cmbModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalidad.FormattingEnabled = true;
            this.cmbModalidad.Items.AddRange(new object[] {
            "Cartón Lleno",
            "CuatroEsquinas",
            "Letra H",
            "Letra X",
            "Letra O",
            "Letra U",
            "Letra P",
            "Letra A",
            "Letra E",
            "Letra W",
            "Letra R"});
            this.cmbModalidad.Location = new System.Drawing.Point(48, 137);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbModalidad.TabIndex = 4;
            this.cmbModalidad.Tag = "";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(35, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(279, 146);
            this.textBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(189, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "b i n g o\n1 4 3 2 4\n2 4 5 6\n3\n4\n5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.Modalidad);
            this.Controls.Add(this.Jugadores);
            this.Controls.Add(this.cmbJugadores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJugadores;
        private System.Windows.Forms.Label Jugadores;
        private System.Windows.Forms.Label Modalidad;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


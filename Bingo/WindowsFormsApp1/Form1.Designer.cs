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
            this.cbCartxJu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNumxCart = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbJugadores
            // 
            this.cmbJugadores.FormattingEnabled = true;
            this.cmbJugadores.Items.AddRange(new object[] {
            "Jugador 1",
            "Jugador 2",
            "Jugador 3",
            "Jugador 4",
            "Jugador 5"});
            this.cmbJugadores.Location = new System.Drawing.Point(29, 78);
            this.cmbJugadores.Name = "cmbJugadores";
            this.cmbJugadores.Size = new System.Drawing.Size(121, 21);
            this.cmbJugadores.TabIndex = 0;
            this.cmbJugadores.SelectedIndexChanged += new System.EventHandler(this.cmbJugadores_SelectedIndexChanged);
            // 
            // Jugadores
            // 
            this.Jugadores.AutoSize = true;
            this.Jugadores.Location = new System.Drawing.Point(55, 60);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Size = new System.Drawing.Size(56, 13);
            this.Jugadores.TabIndex = 1;
            this.Jugadores.Text = "Jugadores";
            // 
            // Modalidad
            // 
            this.Modalidad.AutoSize = true;
            this.Modalidad.Location = new System.Drawing.Point(464, 60);
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
            "Letra X",
            "Letra O",
            "Letra U"});
            this.cmbModalidad.Location = new System.Drawing.Point(456, 78);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbModalidad.TabIndex = 4;
            this.cmbModalidad.Tag = "";
            this.cmbModalidad.SelectedIndexChanged += new System.EventHandler(this.cmbModalidad_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Location = new System.Drawing.Point(194, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(279, 146);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbCartxJu
            // 
            this.cbCartxJu.FormattingEnabled = true;
            this.cbCartxJu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCartxJu.Location = new System.Drawing.Point(183, 78);
            this.cbCartxJu.Name = "cbCartxJu";
            this.cbCartxJu.Size = new System.Drawing.Size(121, 21);
            this.cbCartxJu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cartones x jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione cantidad de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numeros x Carton";
            // 
            // cbNumxCart
            // 
            this.cbNumxCart.FormattingEnabled = true;
            this.cbNumxCart.Items.AddRange(new object[] {
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75"});
            this.cbNumxCart.Location = new System.Drawing.Point(320, 76);
            this.cbNumxCart.Name = "cbNumxCart";
            this.cbNumxCart.Size = new System.Drawing.Size(121, 21);
            this.cbNumxCart.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(500, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(500, 225);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(697, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNumxCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCartxJu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.Modalidad);
            this.Controls.Add(this.Jugadores);
            this.Controls.Add(this.cmbJugadores);
            this.Name = "Form1";
            this.Text = "BINGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJugadores;
        private System.Windows.Forms.Label Jugadores;
        private System.Windows.Forms.Label Modalidad;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbCartxJu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNumxCart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


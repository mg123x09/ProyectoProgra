﻿namespace WindowsFormsApp1
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
            this.cbCartxJu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNumxCart = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.cbCarton = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.dgvCarton = new System.Windows.Forms.DataGridView();
            this.btntirar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarton)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbJugadores
            // 
            this.cmbJugadores.FormattingEnabled = true;
            this.cmbJugadores.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbJugadores.Location = new System.Drawing.Point(39, 96);
            this.cmbJugadores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJugadores.Name = "cmbJugadores";
            this.cmbJugadores.Size = new System.Drawing.Size(160, 24);
            this.cmbJugadores.TabIndex = 0;
            this.cmbJugadores.SelectedIndexChanged += new System.EventHandler(this.cmbJugadores_SelectedIndexChanged);
            // 
            // Jugadores
            // 
            this.Jugadores.AutoSize = true;
            this.Jugadores.Location = new System.Drawing.Point(73, 74);
            this.Jugadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Size = new System.Drawing.Size(75, 17);
            this.Jugadores.TabIndex = 1;
            this.Jugadores.Text = "Jugadores";
            // 
            // Modalidad
            // 
            this.Modalidad.AutoSize = true;
            this.Modalidad.Location = new System.Drawing.Point(619, 74);
            this.Modalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modalidad.Name = "Modalidad";
            this.Modalidad.Size = new System.Drawing.Size(136, 17);
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
            this.cmbModalidad.Location = new System.Drawing.Point(608, 96);
            this.cmbModalidad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModalidad.Name = "cmbModalidad";
            this.cmbModalidad.Size = new System.Drawing.Size(160, 24);
            this.cmbModalidad.TabIndex = 4;
            this.cmbModalidad.Tag = "";
            this.cmbModalidad.SelectedIndexChanged += new System.EventHandler(this.cmbModalidad_SelectedIndexChanged);
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
            this.cbCartxJu.Location = new System.Drawing.Point(244, 96);
            this.cbCartxJu.Margin = new System.Windows.Forms.Padding(4);
            this.cbCartxJu.Name = "cbCartxJu";
            this.cbCartxJu.Size = new System.Drawing.Size(160, 24);
            this.cbCartxJu.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cartones x jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione cantidad de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
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
            this.cbNumxCart.Location = new System.Drawing.Point(427, 94);
            this.cbNumxCart.Margin = new System.Windows.Forms.Padding(4);
            this.cbNumxCart.Name = "cbNumxCart";
            this.cbNumxCart.Size = new System.Drawing.Size(160, 24);
            this.cbNumxCart.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbPlayer
            // 
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPlayer.Location = new System.Drawing.Point(667, 190);
            this.cbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(160, 24);
            this.cbPlayer.TabIndex = 14;
            // 
            // cbCarton
            // 
            this.cbCarton.FormattingEnabled = true;
            this.cbCarton.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCarton.Location = new System.Drawing.Point(667, 277);
            this.cbCarton.Margin = new System.Windows.Forms.Padding(4);
            this.cbCarton.Name = "cbCarton";
            this.cbCarton.Size = new System.Drawing.Size(160, 24);
            this.cbCarton.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Carton";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Jugador";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(727, 353);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(149, 28);
            this.btnTerminar.TabIndex = 18;
            this.btnTerminar.Text = "terminar Juego";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // dgvCarton
            // 
            this.dgvCarton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarton.Location = new System.Drawing.Point(107, 154);
            this.dgvCarton.Name = "dgvCarton";
            this.dgvCarton.RowTemplate.Height = 24;
            this.dgvCarton.Size = new System.Drawing.Size(400, 163);
            this.dgvCarton.TabIndex = 19;
            this.dgvCarton.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btntirar
            // 
            this.btntirar.Location = new System.Drawing.Point(514, 289);
            this.btntirar.Margin = new System.Windows.Forms.Padding(4);
            this.btntirar.Name = "btntirar";
            this.btntirar.Size = new System.Drawing.Size(123, 28);
            this.btntirar.TabIndex = 20;
            this.btntirar.Text = "Sacar numero";
            this.btntirar.UseVisualStyleBackColor = true;
            this.btntirar.Click += new System.EventHandler(this.btntirar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(929, 416);
            this.Controls.Add(this.btntirar);
            this.Controls.Add(this.dgvCarton);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCarton);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNumxCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCartxJu);
            this.Controls.Add(this.cmbModalidad);
            this.Controls.Add(this.Modalidad);
            this.Controls.Add(this.Jugadores);
            this.Controls.Add(this.cmbJugadores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BINGO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJugadores;
        private System.Windows.Forms.Label Jugadores;
        private System.Windows.Forms.Label Modalidad;
        private System.Windows.Forms.ComboBox cmbModalidad;
        private System.Windows.Forms.ComboBox cbCartxJu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNumxCart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.ComboBox cbCarton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.DataGridView dgvCarton;
        private System.Windows.Forms.Button btntirar;
    }
}


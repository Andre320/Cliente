
namespace ClienteVentanas
{
    partial class Juego
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
            this.PanelTablero = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picTableroJugador = new System.Windows.Forms.PictureBox();
            this.panelMano = new System.Windows.Forms.Panel();
            this.picMano3 = new System.Windows.Forms.PictureBox();
            this.picMano2 = new System.Windows.Forms.PictureBox();
            this.picMano1 = new System.Windows.Forms.PictureBox();
            this.panelInicio.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTableroJugador)).BeginInit();
            this.panelMano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMano3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMano2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMano1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTablero
            // 
            this.PanelTablero.BackColor = System.Drawing.Color.Silver;
            this.PanelTablero.Location = new System.Drawing.Point(12, 12);
            this.PanelTablero.Name = "PanelTablero";
            this.PanelTablero.Size = new System.Drawing.Size(914, 912);
            this.PanelTablero.TabIndex = 1;
            this.PanelTablero.Visible = false;
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Controls.Add(this.cbColor);
            this.panelInicio.Controls.Add(this.label3);
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Controls.Add(this.txtNombre);
            this.panelInicio.Controls.Add(this.txtIP);
            this.panelInicio.Controls.Add(this.btnConectar);
            this.panelInicio.Location = new System.Drawing.Point(12, 930);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(26, 28);
            this.panelInicio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP:";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Rojo",
            "Amarillo",
            "Morado",
            "Blanco"});
            this.cbColor.Location = new System.Drawing.Point(95, 109);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(125, 28);
            this.cbColor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(95, 9);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(125, 27);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "25.107.59.124";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(95, 179);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(94, 29);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1104, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picTableroJugador);
            this.panel1.Location = new System.Drawing.Point(1264, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 467);
            this.panel1.TabIndex = 5;
            // 
            // picTableroJugador
            // 
            this.picTableroJugador.Location = new System.Drawing.Point(21, 15);
            this.picTableroJugador.Name = "picTableroJugador";
            this.picTableroJugador.Size = new System.Drawing.Size(567, 436);
            this.picTableroJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTableroJugador.TabIndex = 0;
            this.picTableroJugador.TabStop = false;
            // 
            // panelMano
            // 
            this.panelMano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMano.Controls.Add(this.picMano3);
            this.panelMano.Controls.Add(this.picMano2);
            this.panelMano.Controls.Add(this.picMano1);
            this.panelMano.Location = new System.Drawing.Point(1360, 498);
            this.panelMano.Name = "panelMano";
            this.panelMano.Size = new System.Drawing.Size(510, 148);
            this.panelMano.TabIndex = 6;
            // 
            // picMano3
            // 
            this.picMano3.Location = new System.Drawing.Point(340, 3);
            this.picMano3.Name = "picMano3";
            this.picMano3.Size = new System.Drawing.Size(163, 135);
            this.picMano3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMano3.TabIndex = 2;
            this.picMano3.TabStop = false;
            // 
            // picMano2
            // 
            this.picMano2.Location = new System.Drawing.Point(171, 3);
            this.picMano2.Name = "picMano2";
            this.picMano2.Size = new System.Drawing.Size(163, 135);
            this.picMano2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMano2.TabIndex = 1;
            this.picMano2.TabStop = false;
            // 
            // picMano1
            // 
            this.picMano1.Location = new System.Drawing.Point(3, 3);
            this.picMano1.Name = "picMano1";
            this.picMano1.Size = new System.Drawing.Size(162, 135);
            this.picMano1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMano1.TabIndex = 0;
            this.picMano1.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.Controls.Add(this.panelMano);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.PanelTablero);
            this.Name = "Juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTableroJugador)).EndInit();
            this.panelMano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMano3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMano2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMano1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTablero;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picTableroJugador;
        private System.Windows.Forms.Panel panelMano;
        private System.Windows.Forms.PictureBox picMano3;
        private System.Windows.Forms.PictureBox picMano2;
        private System.Windows.Forms.PictureBox picMano1;
    }
}
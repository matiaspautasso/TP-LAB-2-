namespace PrySamuraiVsNinja
{
    partial class FrmPelea
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPersonaje = new System.Windows.Forms.Label();
            this.btnAtaqueEspecial = new System.Windows.Forms.Button();
            this.btnDescansar = new System.Windows.Forms.Button();
            this.btnAtaqueSimple = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.lblVida2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tckVida = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblPersonaje);
            this.panel2.Controls.Add(this.btnAtaqueEspecial);
            this.panel2.Controls.Add(this.btnDescansar);
            this.panel2.Controls.Add(this.btnAtaqueSimple);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Controls.Add(this.lblRes2);
            this.panel2.Controls.Add(this.lblVida2);
            this.panel2.Location = new System.Drawing.Point(1, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 69);
            this.panel2.TabIndex = 11;
            // 
            // lblPersonaje
            // 
            this.lblPersonaje.AutoSize = true;
            this.lblPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaje.Location = new System.Drawing.Point(547, 20);
            this.lblPersonaje.Name = "lblPersonaje";
            this.lblPersonaje.Size = new System.Drawing.Size(141, 31);
            this.lblPersonaje.TabIndex = 18;
            this.lblPersonaje.Text = "Jugador x";
            // 
            // btnAtaqueEspecial
            // 
            this.btnAtaqueEspecial.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAtaqueEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueEspecial.ForeColor = System.Drawing.Color.White;
            this.btnAtaqueEspecial.Location = new System.Drawing.Point(427, 8);
            this.btnAtaqueEspecial.Name = "btnAtaqueEspecial";
            this.btnAtaqueEspecial.Size = new System.Drawing.Size(96, 43);
            this.btnAtaqueEspecial.TabIndex = 17;
            this.btnAtaqueEspecial.Text = "Ataque especial";
            this.btnAtaqueEspecial.UseVisualStyleBackColor = false;
            this.btnAtaqueEspecial.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDescansar
            // 
            this.btnDescansar.BackColor = System.Drawing.Color.Green;
            this.btnDescansar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescansar.ForeColor = System.Drawing.Color.White;
            this.btnDescansar.Location = new System.Drawing.Point(294, 8);
            this.btnDescansar.Name = "btnDescansar";
            this.btnDescansar.Size = new System.Drawing.Size(96, 43);
            this.btnDescansar.TabIndex = 16;
            this.btnDescansar.Text = "Descansar";
            this.btnDescansar.UseVisualStyleBackColor = false;
            this.btnDescansar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtaqueSimple
            // 
            this.btnAtaqueSimple.BackColor = System.Drawing.Color.Red;
            this.btnAtaqueSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueSimple.ForeColor = System.Drawing.Color.White;
            this.btnAtaqueSimple.Location = new System.Drawing.Point(163, 8);
            this.btnAtaqueSimple.Name = "btnAtaqueSimple";
            this.btnAtaqueSimple.Size = new System.Drawing.Size(96, 43);
            this.btnAtaqueSimple.TabIndex = 15;
            this.btnAtaqueSimple.Text = "ataque simple";
            this.btnAtaqueSimple.UseVisualStyleBackColor = false;
            this.btnAtaqueSimple.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Black;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(3, 11);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(128, 40);
            this.btnIniciar.TabIndex = 14;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Location = new System.Drawing.Point(80, 172);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(0, 13);
            this.lblRes2.TabIndex = 13;
            // 
            // lblVida2
            // 
            this.lblVida2.AutoSize = true;
            this.lblVida2.Location = new System.Drawing.Point(46, 101);
            this.lblVida2.Name = "lblVida2";
            this.lblVida2.Size = new System.Drawing.Size(0, 13);
            this.lblVida2.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PrySamuraiVsNinja.Properties.Resources.Fondo_pelea_gif2;
            this.pictureBox3.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(758, 281);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::PrySamuraiVsNinja.Properties.Resources.ninja;
            this.pictureBox4.Location = new System.Drawing.Point(554, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 154);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::PrySamuraiVsNinja.Properties.Resources.samurai;
            this.pictureBox5.Location = new System.Drawing.Point(84, 95);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 154);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PrySamuraiVsNinja.Properties.Resources.barra_VIDA;
            this.pictureBox1.Location = new System.Drawing.Point(449, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::PrySamuraiVsNinja.Properties.Resources.barra_Mana2;
            this.pictureBox6.Location = new System.Drawing.Point(492, 40);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(265, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::PrySamuraiVsNinja.Properties.Resources.barra_VIDA2;
            this.pictureBox7.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(308, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::PrySamuraiVsNinja.Properties.Resources.barra_Mana;
            this.pictureBox9.Location = new System.Drawing.Point(-1, 40);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(265, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // tckVida
            // 
            this.tckVida.AutoSize = false;
            this.tckVida.BackColor = System.Drawing.Color.Red;
            this.tckVida.Location = new System.Drawing.Point(1, 6);
            this.tckVida.Name = "tckVida";
            this.tckVida.Size = new System.Drawing.Size(287, 16);
            this.tckVida.TabIndex = 22;
            this.tckVida.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.Red;
            this.trackBar1.Location = new System.Drawing.Point(475, 6);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(282, 16);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // trackBar4
            // 
            this.trackBar4.AutoSize = false;
            this.trackBar4.BackColor = System.Drawing.Color.Cyan;
            this.trackBar4.Location = new System.Drawing.Point(4, 40);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(243, 17);
            this.trackBar4.TabIndex = 27;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // trackBar5
            // 
            this.trackBar5.AutoSize = false;
            this.trackBar5.BackColor = System.Drawing.Color.Cyan;
            this.trackBar5.Location = new System.Drawing.Point(514, 40);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(243, 17);
            this.trackBar5.TabIndex = 28;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // lstLogs
            // 
            this.lstLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLogs.ForeColor = System.Drawing.SystemColors.Window;
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.ItemHeight = 15;
            this.lstLogs.Location = new System.Drawing.Point(276, 167);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(238, 109);
            this.lstLogs.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo2.ForeColor = System.Drawing.Color.White;
            this.lblTiempo2.Location = new System.Drawing.Point(359, 21);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(60, 45);
            this.lblTiempo2.TabIndex = 31;
            this.lblTiempo2.Text = "00";
            // 
            // FrmPelea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrySamuraiVsNinja.Properties.Resources.Fondo_pelea_gif2;
            this.ClientSize = new System.Drawing.Size(757, 338);
            this.Controls.Add(this.lblTiempo2);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tckVida);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FrmPelea";
            this.Text = "Pelea";
            this.Load += new System.EventHandler(this.FrmPelea_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Label lblVida2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TrackBar tckVida;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAtaqueEspecial;
        private System.Windows.Forms.Button btnDescansar;
        private System.Windows.Forms.Button btnAtaqueSimple;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.Label lblPersonaje;
    }
}
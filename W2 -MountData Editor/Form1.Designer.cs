namespace W2___MountData_Editor
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.Carregar = new System.Windows.Forms.Button();
            this.MountList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.box13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.box12 = new System.Windows.Forms.TextBox();
            this.box11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.box10 = new System.Windows.Forms.TextBox();
            this.box9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.box8 = new System.Windows.Forms.TextBox();
            this.box7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.box6 = new System.Windows.Forms.TextBox();
            this.box5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box4 = new System.Windows.Forms.TextBox();
            this.box3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.TextBox();
            this.box1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Salvar);
            this.groupBox1.Controls.Add(this.Carregar);
            this.groupBox1.Controls.Add(this.MountList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MountData";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Gerar CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(84, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "-1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Skill Index:";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(130, 17);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(94, 23);
            this.Salvar.TabIndex = 2;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Carregar
            // 
            this.Carregar.Location = new System.Drawing.Point(18, 17);
            this.Carregar.Name = "Carregar";
            this.Carregar.Size = new System.Drawing.Size(94, 23);
            this.Carregar.TabIndex = 1;
            this.Carregar.Text = "Recarregar";
            this.Carregar.UseVisualStyleBackColor = true;
            this.Carregar.Click += new System.EventHandler(this.Carregar_Click);
            // 
            // MountList
            // 
            this.MountList.FormattingEnabled = true;
            this.MountList.Location = new System.Drawing.Point(7, 72);
            this.MountList.Name = "MountList";
            this.MountList.Size = new System.Drawing.Size(229, 459);
            this.MountList.TabIndex = 0;
            this.MountList.SelectedIndexChanged += new System.EventHandler(this.MountList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(262, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.box13);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.box12);
            this.groupBox5.Controls.Add(this.box11);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.box10);
            this.groupBox5.Controls.Add(this.box9);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.box8);
            this.groupBox5.Controls.Add(this.box7);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.box6);
            this.groupBox5.Controls.Add(this.box5);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.box4);
            this.groupBox5.Controls.Add(this.box3);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.box2);
            this.groupBox5.Controls.Add(this.box1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 512);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Propriedades";
            // 
            // box13
            // 
            this.box13.Location = new System.Drawing.Point(93, 410);
            this.box13.MaxLength = 4;
            this.box13.Name = "box13";
            this.box13.Size = new System.Drawing.Size(100, 20);
            this.box13.TabIndex = 67;
            this.box13.Text = "0";
            this.box13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "Unk_13";
            // 
            // box12
            // 
            this.box12.Location = new System.Drawing.Point(93, 375);
            this.box12.MaxLength = 4;
            this.box12.Name = "box12";
            this.box12.Size = new System.Drawing.Size(100, 20);
            this.box12.TabIndex = 65;
            this.box12.Text = "0";
            this.box12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box11
            // 
            this.box11.Location = new System.Drawing.Point(93, 344);
            this.box11.MaxLength = 4;
            this.box11.Name = "box11";
            this.box11.Size = new System.Drawing.Size(100, 20);
            this.box11.TabIndex = 64;
            this.box11.Text = "0";
            this.box11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Movimento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Imunidade";
            // 
            // box10
            // 
            this.box10.Location = new System.Drawing.Point(93, 313);
            this.box10.MaxLength = 4;
            this.box10.Name = "box10";
            this.box10.Size = new System.Drawing.Size(100, 20);
            this.box10.TabIndex = 61;
            this.box10.Text = "0";
            this.box10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box9
            // 
            this.box9.Location = new System.Drawing.Point(93, 282);
            this.box9.MaxLength = 4;
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(100, 20);
            this.box9.TabIndex = 60;
            this.box9.Text = "0";
            this.box9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Evasão";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Ataq. Mágico";
            // 
            // box8
            // 
            this.box8.Location = new System.Drawing.Point(93, 252);
            this.box8.MaxLength = 4;
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(100, 20);
            this.box8.TabIndex = 57;
            this.box8.Text = "0";
            this.box8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box7
            // 
            this.box7.Location = new System.Drawing.Point(93, 221);
            this.box7.MaxLength = 4;
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(100, 20);
            this.box7.TabIndex = 56;
            this.box7.Text = "0";
            this.box7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Dano";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Montaria";
            // 
            // box6
            // 
            this.box6.Location = new System.Drawing.Point(93, 186);
            this.box6.MaxLength = 4;
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(100, 20);
            this.box6.TabIndex = 53;
            this.box6.Text = "0";
            this.box6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box5
            // 
            this.box5.Location = new System.Drawing.Point(93, 155);
            this.box5.MaxLength = 4;
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(100, 20);
            this.box5.TabIndex = 52;
            this.box5.Text = "0";
            this.box5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Unk_6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Unk_5";
            // 
            // box4
            // 
            this.box4.Location = new System.Drawing.Point(93, 124);
            this.box4.MaxLength = 4;
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(100, 20);
            this.box4.TabIndex = 49;
            this.box4.Text = "0";
            this.box4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box3
            // 
            this.box3.Location = new System.Drawing.Point(93, 93);
            this.box3.MaxLength = 4;
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(100, 20);
            this.box3.TabIndex = 48;
            this.box3.Text = "0";
            this.box3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cria de Montaria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Unk_3";
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(93, 60);
            this.box2.MaxLength = 4;
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 20);
            this.box2.TabIndex = 45;
            this.box2.Text = "0";
            this.box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(93, 29);
            this.box1.MaxLength = 4;
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(100, 20);
            this.box1.TabIndex = 44;
            this.box1.Text = "0";
            this.box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Unk_2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Index";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 550);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "SeiTbNao - 2020 - 773";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(493, 572);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.ShowInTaskbar = false;
            this.Text = "W2 - MountData Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Carregar;
        private System.Windows.Forms.ListBox MountList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox box12;
        private System.Windows.Forms.TextBox box11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox box10;
        private System.Windows.Forms.TextBox box9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox box8;
        private System.Windows.Forms.TextBox box7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox box6;
        private System.Windows.Forms.TextBox box5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box4;
        private System.Windows.Forms.TextBox box3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
    }
}


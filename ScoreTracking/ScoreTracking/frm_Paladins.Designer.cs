namespace ScoreTracking
{
    partial class frm_Paladins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Paladins));
            this.pb_ally1 = new System.Windows.Forms.PictureBox();
            this.lb_ally = new System.Windows.Forms.Label();
            this.pb_ally2 = new System.Windows.Forms.PictureBox();
            this.pb_ally3 = new System.Windows.Forms.PictureBox();
            this.pb_ally4 = new System.Windows.Forms.PictureBox();
            this.pb_ally5 = new System.Windows.Forms.PictureBox();
            this.cb_ally1 = new System.Windows.Forms.ComboBox();
            this.cb_ally2 = new System.Windows.Forms.ComboBox();
            this.cb_ally3 = new System.Windows.Forms.ComboBox();
            this.cb_ally4 = new System.Windows.Forms.ComboBox();
            this.cb_ally5 = new System.Windows.Forms.ComboBox();
            this.cb_enemy5 = new System.Windows.Forms.ComboBox();
            this.cb_enemy4 = new System.Windows.Forms.ComboBox();
            this.cb_enemy3 = new System.Windows.Forms.ComboBox();
            this.cb_enemy2 = new System.Windows.Forms.ComboBox();
            this.cb_enemy1 = new System.Windows.Forms.ComboBox();
            this.pb_enemy5 = new System.Windows.Forms.PictureBox();
            this.pb_enemy4 = new System.Windows.Forms.PictureBox();
            this.pb_enemy3 = new System.Windows.Forms.PictureBox();
            this.pb_enemy2 = new System.Windows.Forms.PictureBox();
            this.lb_enemy = new System.Windows.Forms.Label();
            this.pb_enemy1 = new System.Windows.Forms.PictureBox();
            this.lb_mapa = new System.Windows.Forms.Label();
            this.cb_mapa = new System.Windows.Forms.ComboBox();
            this.lb_ally1_class = new System.Windows.Forms.Label();
            this.mtxb_ally_points = new System.Windows.Forms.MaskedTextBox();
            this.mtxb_enemy_points = new System.Windows.Forms.MaskedTextBox();
            this.lb_vs = new System.Windows.Forms.Label();
            this.lb_pontuacao = new System.Windows.Forms.Label();
            this.lb_ally2_class = new System.Windows.Forms.Label();
            this.lb_ally3_class = new System.Windows.Forms.Label();
            this.lb_ally4_class = new System.Windows.Forms.Label();
            this.lb_ally5_class = new System.Windows.Forms.Label();
            this.lb_enemy1_class = new System.Windows.Forms.Label();
            this.lb_enemy2_class = new System.Windows.Forms.Label();
            this.lb_enemy3_class = new System.Windows.Forms.Label();
            this.lb_enemy4_class = new System.Windows.Forms.Label();
            this.lb_enemy5_class = new System.Windows.Forms.Label();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.mn_menu = new System.Windows.Forms.MenuStrip();
            this.estatísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_selecao_heroi = new System.Windows.Forms.Panel();
            this.pb_mapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy1)).BeginInit();
            this.mn_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mapa)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ally1
            // 
            this.pb_ally1.Location = new System.Drawing.Point(149, 87);
            this.pb_ally1.Name = "pb_ally1";
            this.pb_ally1.Size = new System.Drawing.Size(123, 85);
            this.pb_ally1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ally1.TabIndex = 0;
            this.pb_ally1.TabStop = false;
            this.pb_ally1.Click += new System.EventHandler(this.SelecionaHeroi);
            // 
            // lb_ally
            // 
            this.lb_ally.AutoSize = true;
            this.lb_ally.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ally.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_ally.Location = new System.Drawing.Point(84, 24);
            this.lb_ally.Name = "lb_ally";
            this.lb_ally.Size = new System.Drawing.Size(122, 20);
            this.lb_ally.TabIndex = 1;
            this.lb_ally.Text = "TIME ALIADO";
            // 
            // pb_ally2
            // 
            this.pb_ally2.Location = new System.Drawing.Point(149, 194);
            this.pb_ally2.Name = "pb_ally2";
            this.pb_ally2.Size = new System.Drawing.Size(123, 85);
            this.pb_ally2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ally2.TabIndex = 2;
            this.pb_ally2.TabStop = false;
            this.pb_ally2.Click += new System.EventHandler(this.SelecionaHeroi);
            // 
            // pb_ally3
            // 
            this.pb_ally3.Location = new System.Drawing.Point(149, 306);
            this.pb_ally3.Name = "pb_ally3";
            this.pb_ally3.Size = new System.Drawing.Size(123, 85);
            this.pb_ally3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ally3.TabIndex = 3;
            this.pb_ally3.TabStop = false;
            this.pb_ally3.Click += new System.EventHandler(this.SelecionaHeroi);
            // 
            // pb_ally4
            // 
            this.pb_ally4.Location = new System.Drawing.Point(149, 417);
            this.pb_ally4.Name = "pb_ally4";
            this.pb_ally4.Size = new System.Drawing.Size(123, 85);
            this.pb_ally4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ally4.TabIndex = 4;
            this.pb_ally4.TabStop = false;
            this.pb_ally4.Click += new System.EventHandler(this.SelecionaHeroi);
            // 
            // pb_ally5
            // 
            this.pb_ally5.Location = new System.Drawing.Point(149, 530);
            this.pb_ally5.Name = "pb_ally5";
            this.pb_ally5.Size = new System.Drawing.Size(123, 85);
            this.pb_ally5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ally5.TabIndex = 5;
            this.pb_ally5.TabStop = false;
            this.pb_ally5.Click += new System.EventHandler(this.SelecionaHeroi);
            // 
            // cb_ally1
            // 
            this.cb_ally1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ally1.FormattingEnabled = true;
            this.cb_ally1.Location = new System.Drawing.Point(6, 114);
            this.cb_ally1.Name = "cb_ally1";
            this.cb_ally1.Size = new System.Drawing.Size(127, 21);
            this.cb_ally1.TabIndex = 6;
            // 
            // cb_ally2
            // 
            this.cb_ally2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ally2.FormattingEnabled = true;
            this.cb_ally2.Location = new System.Drawing.Point(6, 226);
            this.cb_ally2.Name = "cb_ally2";
            this.cb_ally2.Size = new System.Drawing.Size(127, 21);
            this.cb_ally2.TabIndex = 7;
            // 
            // cb_ally3
            // 
            this.cb_ally3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ally3.FormattingEnabled = true;
            this.cb_ally3.Location = new System.Drawing.Point(6, 335);
            this.cb_ally3.Name = "cb_ally3";
            this.cb_ally3.Size = new System.Drawing.Size(127, 21);
            this.cb_ally3.TabIndex = 8;
            // 
            // cb_ally4
            // 
            this.cb_ally4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ally4.FormattingEnabled = true;
            this.cb_ally4.Location = new System.Drawing.Point(6, 444);
            this.cb_ally4.Name = "cb_ally4";
            this.cb_ally4.Size = new System.Drawing.Size(127, 21);
            this.cb_ally4.TabIndex = 9;
            // 
            // cb_ally5
            // 
            this.cb_ally5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ally5.FormattingEnabled = true;
            this.cb_ally5.Location = new System.Drawing.Point(6, 560);
            this.cb_ally5.Name = "cb_ally5";
            this.cb_ally5.Size = new System.Drawing.Size(127, 21);
            this.cb_ally5.TabIndex = 10;
            // 
            // cb_enemy5
            // 
            this.cb_enemy5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_enemy5.FormattingEnabled = true;
            this.cb_enemy5.Location = new System.Drawing.Point(802, 560);
            this.cb_enemy5.Name = "cb_enemy5";
            this.cb_enemy5.Size = new System.Drawing.Size(127, 21);
            this.cb_enemy5.TabIndex = 21;
            // 
            // cb_enemy4
            // 
            this.cb_enemy4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_enemy4.FormattingEnabled = true;
            this.cb_enemy4.Location = new System.Drawing.Point(802, 444);
            this.cb_enemy4.Name = "cb_enemy4";
            this.cb_enemy4.Size = new System.Drawing.Size(127, 21);
            this.cb_enemy4.TabIndex = 20;
            // 
            // cb_enemy3
            // 
            this.cb_enemy3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_enemy3.FormattingEnabled = true;
            this.cb_enemy3.Location = new System.Drawing.Point(802, 335);
            this.cb_enemy3.Name = "cb_enemy3";
            this.cb_enemy3.Size = new System.Drawing.Size(127, 21);
            this.cb_enemy3.TabIndex = 19;
            // 
            // cb_enemy2
            // 
            this.cb_enemy2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_enemy2.FormattingEnabled = true;
            this.cb_enemy2.Location = new System.Drawing.Point(802, 226);
            this.cb_enemy2.Name = "cb_enemy2";
            this.cb_enemy2.Size = new System.Drawing.Size(127, 21);
            this.cb_enemy2.TabIndex = 18;
            // 
            // cb_enemy1
            // 
            this.cb_enemy1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_enemy1.FormattingEnabled = true;
            this.cb_enemy1.Location = new System.Drawing.Point(802, 114);
            this.cb_enemy1.Name = "cb_enemy1";
            this.cb_enemy1.Size = new System.Drawing.Size(127, 21);
            this.cb_enemy1.TabIndex = 17;
            // 
            // pb_enemy5
            // 
            this.pb_enemy5.Location = new System.Drawing.Point(673, 530);
            this.pb_enemy5.Name = "pb_enemy5";
            this.pb_enemy5.Size = new System.Drawing.Size(123, 85);
            this.pb_enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_enemy5.TabIndex = 16;
            this.pb_enemy5.TabStop = false;
            // 
            // pb_enemy4
            // 
            this.pb_enemy4.Location = new System.Drawing.Point(673, 417);
            this.pb_enemy4.Name = "pb_enemy4";
            this.pb_enemy4.Size = new System.Drawing.Size(123, 85);
            this.pb_enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_enemy4.TabIndex = 15;
            this.pb_enemy4.TabStop = false;
            // 
            // pb_enemy3
            // 
            this.pb_enemy3.Location = new System.Drawing.Point(673, 306);
            this.pb_enemy3.Name = "pb_enemy3";
            this.pb_enemy3.Size = new System.Drawing.Size(123, 85);
            this.pb_enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_enemy3.TabIndex = 14;
            this.pb_enemy3.TabStop = false;
            // 
            // pb_enemy2
            // 
            this.pb_enemy2.Location = new System.Drawing.Point(673, 194);
            this.pb_enemy2.Name = "pb_enemy2";
            this.pb_enemy2.Size = new System.Drawing.Size(123, 85);
            this.pb_enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_enemy2.TabIndex = 13;
            this.pb_enemy2.TabStop = false;
            // 
            // lb_enemy
            // 
            this.lb_enemy.AutoSize = true;
            this.lb_enemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_enemy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_enemy.Location = new System.Drawing.Point(751, 24);
            this.lb_enemy.Name = "lb_enemy";
            this.lb_enemy.Size = new System.Drawing.Size(127, 20);
            this.lb_enemy.TabIndex = 12;
            this.lb_enemy.Text = "TIME INIMIGO";
            // 
            // pb_enemy1
            // 
            this.pb_enemy1.Location = new System.Drawing.Point(673, 87);
            this.pb_enemy1.Name = "pb_enemy1";
            this.pb_enemy1.Size = new System.Drawing.Size(123, 85);
            this.pb_enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_enemy1.TabIndex = 11;
            this.pb_enemy1.TabStop = false;
            // 
            // lb_mapa
            // 
            this.lb_mapa.AutoSize = true;
            this.lb_mapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mapa.Location = new System.Drawing.Point(378, 88);
            this.lb_mapa.Name = "lb_mapa";
            this.lb_mapa.Size = new System.Drawing.Size(58, 20);
            this.lb_mapa.TabIndex = 22;
            this.lb_mapa.Text = "MAPA:";
            // 
            // cb_mapa
            // 
            this.cb_mapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mapa.FormattingEnabled = true;
            this.cb_mapa.Location = new System.Drawing.Point(442, 87);
            this.cb_mapa.Name = "cb_mapa";
            this.cb_mapa.Size = new System.Drawing.Size(121, 21);
            this.cb_mapa.TabIndex = 23;
            this.cb_mapa.SelectedIndexChanged += new System.EventHandler(this.cb_mapa_SelectedIndexChanged);
            // 
            // lb_ally1_class
            // 
            this.lb_ally1_class.AutoSize = true;
            this.lb_ally1_class.Location = new System.Drawing.Point(8, 142);
            this.lb_ally1_class.Name = "lb_ally1_class";
            this.lb_ally1_class.Size = new System.Drawing.Size(10, 13);
            this.lb_ally1_class.TabIndex = 24;
            this.lb_ally1_class.Text = "-";
            // 
            // mtxb_ally_points
            // 
            this.mtxb_ally_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxb_ally_points.Location = new System.Drawing.Point(419, 342);
            this.mtxb_ally_points.Mask = "0";
            this.mtxb_ally_points.Name = "mtxb_ally_points";
            this.mtxb_ally_points.Size = new System.Drawing.Size(36, 26);
            this.mtxb_ally_points.TabIndex = 25;
            this.mtxb_ally_points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxb_ally_points.Click += new System.EventHandler(this.mtxb_ally_points_Click);
            // 
            // mtxb_enemy_points
            // 
            this.mtxb_enemy_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxb_enemy_points.Location = new System.Drawing.Point(495, 342);
            this.mtxb_enemy_points.Mask = "0";
            this.mtxb_enemy_points.Name = "mtxb_enemy_points";
            this.mtxb_enemy_points.Size = new System.Drawing.Size(35, 26);
            this.mtxb_enemy_points.TabIndex = 26;
            this.mtxb_enemy_points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxb_enemy_points.Click += new System.EventHandler(this.mtxb_enemy_points_Click);
            // 
            // lb_vs
            // 
            this.lb_vs.AutoSize = true;
            this.lb_vs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vs.Location = new System.Drawing.Point(464, 344);
            this.lb_vs.Name = "lb_vs";
            this.lb_vs.Size = new System.Drawing.Size(20, 20);
            this.lb_vs.TabIndex = 27;
            this.lb_vs.Text = "X";
            // 
            // lb_pontuacao
            // 
            this.lb_pontuacao.AutoSize = true;
            this.lb_pontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pontuacao.Location = new System.Drawing.Point(415, 306);
            this.lb_pontuacao.Name = "lb_pontuacao";
            this.lb_pontuacao.Size = new System.Drawing.Size(135, 24);
            this.lb_pontuacao.TabIndex = 28;
            this.lb_pontuacao.Text = "PONTUAÇÃO:";
            // 
            // lb_ally2_class
            // 
            this.lb_ally2_class.AutoSize = true;
            this.lb_ally2_class.Location = new System.Drawing.Point(8, 250);
            this.lb_ally2_class.Name = "lb_ally2_class";
            this.lb_ally2_class.Size = new System.Drawing.Size(10, 13);
            this.lb_ally2_class.TabIndex = 29;
            this.lb_ally2_class.Text = "-";
            // 
            // lb_ally3_class
            // 
            this.lb_ally3_class.AutoSize = true;
            this.lb_ally3_class.Location = new System.Drawing.Point(8, 359);
            this.lb_ally3_class.Name = "lb_ally3_class";
            this.lb_ally3_class.Size = new System.Drawing.Size(10, 13);
            this.lb_ally3_class.TabIndex = 30;
            this.lb_ally3_class.Text = "-";
            // 
            // lb_ally4_class
            // 
            this.lb_ally4_class.AutoSize = true;
            this.lb_ally4_class.Location = new System.Drawing.Point(8, 468);
            this.lb_ally4_class.Name = "lb_ally4_class";
            this.lb_ally4_class.Size = new System.Drawing.Size(10, 13);
            this.lb_ally4_class.TabIndex = 31;
            this.lb_ally4_class.Text = "-";
            // 
            // lb_ally5_class
            // 
            this.lb_ally5_class.AutoSize = true;
            this.lb_ally5_class.Location = new System.Drawing.Point(8, 584);
            this.lb_ally5_class.Name = "lb_ally5_class";
            this.lb_ally5_class.Size = new System.Drawing.Size(10, 13);
            this.lb_ally5_class.TabIndex = 32;
            this.lb_ally5_class.Text = "-";
            // 
            // lb_enemy1_class
            // 
            this.lb_enemy1_class.AutoSize = true;
            this.lb_enemy1_class.Location = new System.Drawing.Point(802, 142);
            this.lb_enemy1_class.Name = "lb_enemy1_class";
            this.lb_enemy1_class.Size = new System.Drawing.Size(10, 13);
            this.lb_enemy1_class.TabIndex = 33;
            this.lb_enemy1_class.Text = "-";
            // 
            // lb_enemy2_class
            // 
            this.lb_enemy2_class.AutoSize = true;
            this.lb_enemy2_class.Location = new System.Drawing.Point(802, 250);
            this.lb_enemy2_class.Name = "lb_enemy2_class";
            this.lb_enemy2_class.Size = new System.Drawing.Size(10, 13);
            this.lb_enemy2_class.TabIndex = 34;
            this.lb_enemy2_class.Text = "-";
            // 
            // lb_enemy3_class
            // 
            this.lb_enemy3_class.AutoSize = true;
            this.lb_enemy3_class.Location = new System.Drawing.Point(802, 359);
            this.lb_enemy3_class.Name = "lb_enemy3_class";
            this.lb_enemy3_class.Size = new System.Drawing.Size(10, 13);
            this.lb_enemy3_class.TabIndex = 35;
            this.lb_enemy3_class.Text = "-";
            // 
            // lb_enemy4_class
            // 
            this.lb_enemy4_class.AutoSize = true;
            this.lb_enemy4_class.Location = new System.Drawing.Point(802, 468);
            this.lb_enemy4_class.Name = "lb_enemy4_class";
            this.lb_enemy4_class.Size = new System.Drawing.Size(10, 13);
            this.lb_enemy4_class.TabIndex = 36;
            this.lb_enemy4_class.Text = "-";
            // 
            // lb_enemy5_class
            // 
            this.lb_enemy5_class.AutoSize = true;
            this.lb_enemy5_class.Location = new System.Drawing.Point(802, 584);
            this.lb_enemy5_class.Name = "lb_enemy5_class";
            this.lb_enemy5_class.Size = new System.Drawing.Size(10, 13);
            this.lb_enemy5_class.TabIndex = 37;
            this.lb_enemy5_class.Text = "-";
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(11, 648);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(94, 39);
            this.bt_Voltar.TabIndex = 38;
            this.bt_Voltar.Text = "<-   &Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(835, 648);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(94, 39);
            this.bt_Salvar.TabIndex = 39;
            this.bt_Salvar.Text = "&Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // mn_menu
            // 
            this.mn_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estatísticaToolStripMenuItem,
            this.visualizarPartidaToolStripMenuItem});
            this.mn_menu.Location = new System.Drawing.Point(0, 0);
            this.mn_menu.Name = "mn_menu";
            this.mn_menu.Size = new System.Drawing.Size(942, 24);
            this.mn_menu.TabIndex = 40;
            this.mn_menu.Text = "menuStrip1";
            // 
            // estatísticaToolStripMenuItem
            // 
            this.estatísticaToolStripMenuItem.Name = "estatísticaToolStripMenuItem";
            this.estatísticaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticaToolStripMenuItem.Text = "&Estatísticas";
            this.estatísticaToolStripMenuItem.Click += new System.EventHandler(this.estatísticaToolStripMenuItem_Click);
            // 
            // visualizarPartidaToolStripMenuItem
            // 
            this.visualizarPartidaToolStripMenuItem.Name = "visualizarPartidaToolStripMenuItem";
            this.visualizarPartidaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.visualizarPartidaToolStripMenuItem.Text = "&Visualizar Partida";
            this.visualizarPartidaToolStripMenuItem.Click += new System.EventHandler(this.visualizarPartidaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Selecione seu herói:";
            // 
            // pn_selecao_heroi
            // 
            this.pn_selecao_heroi.BackColor = System.Drawing.Color.Red;
            this.pn_selecao_heroi.Location = new System.Drawing.Point(139, 78);
            this.pn_selecao_heroi.Name = "pn_selecao_heroi";
            this.pn_selecao_heroi.Size = new System.Drawing.Size(143, 105);
            this.pn_selecao_heroi.TabIndex = 42;
            // 
            // pb_mapa
            // 
            this.pb_mapa.Location = new System.Drawing.Point(321, 122);
            this.pb_mapa.Name = "pb_mapa";
            this.pb_mapa.Size = new System.Drawing.Size(325, 181);
            this.pb_mapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_mapa.TabIndex = 43;
            this.pb_mapa.TabStop = false;
            // 
            // frm_Paladins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 695);
            this.Controls.Add(this.pb_mapa);
            this.Controls.Add(this.pn_selecao_heroi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_ally1);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.lb_enemy5_class);
            this.Controls.Add(this.lb_enemy4_class);
            this.Controls.Add(this.lb_enemy3_class);
            this.Controls.Add(this.lb_enemy2_class);
            this.Controls.Add(this.lb_enemy1_class);
            this.Controls.Add(this.lb_ally5_class);
            this.Controls.Add(this.lb_ally4_class);
            this.Controls.Add(this.lb_ally3_class);
            this.Controls.Add(this.lb_ally2_class);
            this.Controls.Add(this.lb_pontuacao);
            this.Controls.Add(this.lb_vs);
            this.Controls.Add(this.mtxb_enemy_points);
            this.Controls.Add(this.mtxb_ally_points);
            this.Controls.Add(this.lb_ally1_class);
            this.Controls.Add(this.cb_mapa);
            this.Controls.Add(this.lb_mapa);
            this.Controls.Add(this.cb_enemy5);
            this.Controls.Add(this.cb_enemy4);
            this.Controls.Add(this.cb_enemy3);
            this.Controls.Add(this.cb_enemy2);
            this.Controls.Add(this.cb_enemy1);
            this.Controls.Add(this.pb_enemy5);
            this.Controls.Add(this.pb_enemy4);
            this.Controls.Add(this.pb_enemy3);
            this.Controls.Add(this.pb_enemy2);
            this.Controls.Add(this.lb_enemy);
            this.Controls.Add(this.pb_enemy1);
            this.Controls.Add(this.cb_ally5);
            this.Controls.Add(this.cb_ally4);
            this.Controls.Add(this.cb_ally3);
            this.Controls.Add(this.cb_ally2);
            this.Controls.Add(this.cb_ally1);
            this.Controls.Add(this.pb_ally5);
            this.Controls.Add(this.pb_ally4);
            this.Controls.Add(this.pb_ally3);
            this.Controls.Add(this.pb_ally2);
            this.Controls.Add(this.lb_ally);
            this.Controls.Add(this.mn_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mn_menu;
            this.MaximizeBox = false;
            this.Name = "frm_Paladins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paladins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Paladins_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy1)).EndInit();
            this.mn_menu.ResumeLayout(false);
            this.mn_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ally1;
        private System.Windows.Forms.Label lb_ally;
        private System.Windows.Forms.PictureBox pb_ally2;
        private System.Windows.Forms.PictureBox pb_ally3;
        private System.Windows.Forms.PictureBox pb_ally4;
        private System.Windows.Forms.PictureBox pb_ally5;
        private System.Windows.Forms.ComboBox cb_ally1;
        private System.Windows.Forms.ComboBox cb_ally2;
        private System.Windows.Forms.ComboBox cb_ally3;
        private System.Windows.Forms.ComboBox cb_ally4;
        private System.Windows.Forms.ComboBox cb_ally5;
        private System.Windows.Forms.ComboBox cb_enemy5;
        private System.Windows.Forms.ComboBox cb_enemy4;
        private System.Windows.Forms.ComboBox cb_enemy3;
        private System.Windows.Forms.ComboBox cb_enemy2;
        private System.Windows.Forms.ComboBox cb_enemy1;
        private System.Windows.Forms.PictureBox pb_enemy5;
        private System.Windows.Forms.PictureBox pb_enemy4;
        private System.Windows.Forms.PictureBox pb_enemy3;
        private System.Windows.Forms.PictureBox pb_enemy2;
        private System.Windows.Forms.Label lb_enemy;
        private System.Windows.Forms.PictureBox pb_enemy1;
        private System.Windows.Forms.Label lb_mapa;
        private System.Windows.Forms.ComboBox cb_mapa;
        private System.Windows.Forms.Label lb_ally1_class;
        private System.Windows.Forms.MaskedTextBox mtxb_ally_points;
        private System.Windows.Forms.MaskedTextBox mtxb_enemy_points;
        private System.Windows.Forms.Label lb_vs;
        private System.Windows.Forms.Label lb_pontuacao;
        private System.Windows.Forms.Label lb_ally2_class;
        private System.Windows.Forms.Label lb_ally3_class;
        private System.Windows.Forms.Label lb_ally4_class;
        private System.Windows.Forms.Label lb_ally5_class;
        private System.Windows.Forms.Label lb_enemy1_class;
        private System.Windows.Forms.Label lb_enemy2_class;
        private System.Windows.Forms.Label lb_enemy3_class;
        private System.Windows.Forms.Label lb_enemy4_class;
        private System.Windows.Forms.Label lb_enemy5_class;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.MenuStrip mn_menu;
        private System.Windows.Forms.ToolStripMenuItem estatísticaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_selecao_heroi;
        private System.Windows.Forms.PictureBox pb_mapa;
        private System.Windows.Forms.ToolStripMenuItem visualizarPartidaToolStripMenuItem;
    }
}
﻿namespace ScoreTracking
{
    partial class frm_HS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HS));
            this.lb_ally = new System.Windows.Forms.Label();
            this.lb_enemy = new System.Windows.Forms.Label();
            this.cb_ally_hero = new System.Windows.Forms.ComboBox();
            this.cb_Vencedor = new System.Windows.Forms.ComboBox();
            this.pb_ally = new System.Windows.Forms.PictureBox();
            this.pb_enemy = new System.Windows.Forms.PictureBox();
            this.lb_Tempo = new System.Windows.Forms.Label();
            this.lb_Vencedor = new System.Windows.Forms.Label();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.cb_enemy_hero = new System.Windows.Forms.ComboBox();
            this.lb_ally_hero = new System.Windows.Forms.Label();
            this.lb_enemy_hero = new System.Windows.Forms.Label();
            this.cb_ally_class = new System.Windows.Forms.Label();
            this.lb_enemy_class = new System.Windows.Forms.Label();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.mb_TempoPartida = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ally
            // 
            this.lb_ally.AutoSize = true;
            this.lb_ally.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ally.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_ally.Location = new System.Drawing.Point(141, 22);
            this.lb_ally.Name = "lb_ally";
            this.lb_ally.Size = new System.Drawing.Size(54, 20);
            this.lb_ally.TabIndex = 2;
            this.lb_ally.Text = "VOCÊ";
            // 
            // lb_enemy
            // 
            this.lb_enemy.AutoSize = true;
            this.lb_enemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_enemy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_enemy.Location = new System.Drawing.Point(432, 22);
            this.lb_enemy.Name = "lb_enemy";
            this.lb_enemy.Size = new System.Drawing.Size(96, 20);
            this.lb_enemy.TabIndex = 3;
            this.lb_enemy.Text = "OPONENTE";
            // 
            // cb_ally_hero
            // 
            this.cb_ally_hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ally_hero.FormattingEnabled = true;
            this.cb_ally_hero.Location = new System.Drawing.Point(12, 96);
            this.cb_ally_hero.Name = "cb_ally_hero";
            this.cb_ally_hero.Size = new System.Drawing.Size(127, 21);
            this.cb_ally_hero.TabIndex = 7;
            // 
            // cb_Vencedor
            // 
            this.cb_Vencedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Vencedor.FormattingEnabled = true;
            this.cb_Vencedor.Items.AddRange(new object[] {
            "Você",
            "Oponente"});
            this.cb_Vencedor.Location = new System.Drawing.Point(274, 232);
            this.cb_Vencedor.Name = "cb_Vencedor";
            this.cb_Vencedor.Size = new System.Drawing.Size(100, 21);
            this.cb_Vencedor.TabIndex = 8;
            // 
            // pb_ally
            // 
            this.pb_ally.Location = new System.Drawing.Point(145, 58);
            this.pb_ally.Name = "pb_ally";
            this.pb_ally.Size = new System.Drawing.Size(123, 85);
            this.pb_ally.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ally.TabIndex = 9;
            this.pb_ally.TabStop = false;
            // 
            // pb_enemy
            // 
            this.pb_enemy.Location = new System.Drawing.Point(436, 58);
            this.pb_enemy.Name = "pb_enemy";
            this.pb_enemy.Size = new System.Drawing.Size(123, 85);
            this.pb_enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_enemy.TabIndex = 10;
            this.pb_enemy.TabStop = false;
            // 
            // lb_Tempo
            // 
            this.lb_Tempo.AutoSize = true;
            this.lb_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tempo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Tempo.Location = new System.Drawing.Point(99, 204);
            this.lb_Tempo.Name = "lb_Tempo";
            this.lb_Tempo.Size = new System.Drawing.Size(169, 20);
            this.lb_Tempo.TabIndex = 11;
            this.lb_Tempo.Text = "TEMPO DA PARTIDA:";
            // 
            // lb_Vencedor
            // 
            this.lb_Vencedor.AutoSize = true;
            this.lb_Vencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Vencedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Vencedor.Location = new System.Drawing.Point(164, 230);
            this.lb_Vencedor.Name = "lb_Vencedor";
            this.lb_Vencedor.Size = new System.Drawing.Size(104, 20);
            this.lb_Vencedor.TabIndex = 12;
            this.lb_Vencedor.Text = "VENCEDOR:";
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(12, 302);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(90, 27);
            this.bt_Voltar.TabIndex = 13;
            this.bt_Voltar.Text = "<-   Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // cb_enemy_hero
            // 
            this.cb_enemy_hero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_enemy_hero.FormattingEnabled = true;
            this.cb_enemy_hero.Location = new System.Drawing.Point(303, 96);
            this.cb_enemy_hero.Name = "cb_enemy_hero";
            this.cb_enemy_hero.Size = new System.Drawing.Size(127, 21);
            this.cb_enemy_hero.TabIndex = 15;
            // 
            // lb_ally_hero
            // 
            this.lb_ally_hero.AutoSize = true;
            this.lb_ally_hero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ally_hero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_ally_hero.Location = new System.Drawing.Point(49, 73);
            this.lb_ally_hero.Name = "lb_ally_hero";
            this.lb_ally_hero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_ally_hero.Size = new System.Drawing.Size(61, 20);
            this.lb_ally_hero.TabIndex = 16;
            this.lb_ally_hero.Text = "HERÓI";
            // 
            // lb_enemy_hero
            // 
            this.lb_enemy_hero.AutoSize = true;
            this.lb_enemy_hero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_enemy_hero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_enemy_hero.Location = new System.Drawing.Point(334, 73);
            this.lb_enemy_hero.Name = "lb_enemy_hero";
            this.lb_enemy_hero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_enemy_hero.Size = new System.Drawing.Size(61, 20);
            this.lb_enemy_hero.TabIndex = 17;
            this.lb_enemy_hero.Text = "HERÓI";
            // 
            // cb_ally_class
            // 
            this.cb_ally_class.AutoSize = true;
            this.cb_ally_class.Location = new System.Drawing.Point(50, 130);
            this.cb_ally_class.Name = "cb_ally_class";
            this.cb_ally_class.Size = new System.Drawing.Size(10, 13);
            this.cb_ally_class.TabIndex = 25;
            this.cb_ally_class.Text = "-";
            // 
            // lb_enemy_class
            // 
            this.lb_enemy_class.AutoSize = true;
            this.lb_enemy_class.Location = new System.Drawing.Point(335, 130);
            this.lb_enemy_class.Name = "lb_enemy_class";
            this.lb_enemy_class.Size = new System.Drawing.Size(10, 13);
            this.lb_enemy_class.TabIndex = 26;
            this.lb_enemy_class.Text = "-";
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(463, 302);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(90, 27);
            this.bt_Salvar.TabIndex = 27;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            // 
            // mb_TempoPartida
            // 
            this.mb_TempoPartida.Location = new System.Drawing.Point(274, 204);
            this.mb_TempoPartida.Mask = "00:00";
            this.mb_TempoPartida.Name = "mb_TempoPartida";
            this.mb_TempoPartida.Size = new System.Drawing.Size(100, 20);
            this.mb_TempoPartida.TabIndex = 28;
            this.mb_TempoPartida.ValidatingType = typeof(System.DateTime);
            // 
            // frm_HS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 341);
            this.Controls.Add(this.mb_TempoPartida);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.lb_enemy_class);
            this.Controls.Add(this.cb_ally_class);
            this.Controls.Add(this.lb_enemy_hero);
            this.Controls.Add(this.lb_ally_hero);
            this.Controls.Add(this.cb_enemy_hero);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.lb_Vencedor);
            this.Controls.Add(this.lb_Tempo);
            this.Controls.Add(this.pb_enemy);
            this.Controls.Add(this.pb_ally);
            this.Controls.Add(this.cb_Vencedor);
            this.Controls.Add(this.cb_ally_hero);
            this.Controls.Add(this.lb_enemy);
            this.Controls.Add(this.lb_ally);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HearthStone";
            ((System.ComponentModel.ISupportInitialize)(this.pb_ally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ally;
        private System.Windows.Forms.Label lb_enemy;
        private System.Windows.Forms.ComboBox cb_ally_hero;
        private System.Windows.Forms.ComboBox cb_Vencedor;
        private System.Windows.Forms.PictureBox pb_ally;
        private System.Windows.Forms.PictureBox pb_enemy;
        private System.Windows.Forms.Label lb_Tempo;
        private System.Windows.Forms.Label lb_Vencedor;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.ComboBox cb_enemy_hero;
        private System.Windows.Forms.Label lb_ally_hero;
        private System.Windows.Forms.Label lb_enemy_hero;
        private System.Windows.Forms.Label cb_ally_class;
        private System.Windows.Forms.Label lb_enemy_class;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.MaskedTextBox mb_TempoPartida;

    }
}
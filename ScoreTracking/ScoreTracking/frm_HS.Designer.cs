namespace ScoreTracking
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_heroi = new System.Windows.Forms.ComboBox();
            this.cb_Vencedor = new System.Windows.Forms.ComboBox();
            this.pb_Heroi = new System.Windows.Forms.PictureBox();
            this.pb_Oponente = new System.Windows.Forms.PictureBox();
            this.lb_Tempo = new System.Windows.Forms.Label();
            this.lb_Vencedor = new System.Windows.Forms.Label();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.cb_HeroiOponente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Hero_Class = new System.Windows.Forms.Label();
            this.lb_Op_Class = new System.Windows.Forms.Label();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.mb_TempoPartida = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heroi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Oponente)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(432, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPONENTE";
            // 
            // cb_heroi
            // 
            this.cb_heroi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_heroi.FormattingEnabled = true;
            this.cb_heroi.Location = new System.Drawing.Point(12, 96);
            this.cb_heroi.Name = "cb_heroi";
            this.cb_heroi.Size = new System.Drawing.Size(127, 21);
            this.cb_heroi.TabIndex = 7;
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
            // pb_Heroi
            // 
            this.pb_Heroi.Location = new System.Drawing.Point(145, 58);
            this.pb_Heroi.Name = "pb_Heroi";
            this.pb_Heroi.Size = new System.Drawing.Size(123, 85);
            this.pb_Heroi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Heroi.TabIndex = 9;
            this.pb_Heroi.TabStop = false;
            // 
            // pb_Oponente
            // 
            this.pb_Oponente.Location = new System.Drawing.Point(436, 58);
            this.pb_Oponente.Name = "pb_Oponente";
            this.pb_Oponente.Size = new System.Drawing.Size(123, 85);
            this.pb_Oponente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Oponente.TabIndex = 10;
            this.pb_Oponente.TabStop = false;
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
            // cb_HeroiOponente
            // 
            this.cb_HeroiOponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_HeroiOponente.FormattingEnabled = true;
            this.cb_HeroiOponente.Location = new System.Drawing.Point(303, 96);
            this.cb_HeroiOponente.Name = "cb_HeroiOponente";
            this.cb_HeroiOponente.Size = new System.Drawing.Size(127, 21);
            this.cb_HeroiOponente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "HERÓI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(334, 73);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "HERÓI";
            // 
            // lb_Hero_Class
            // 
            this.lb_Hero_Class.AutoSize = true;
            this.lb_Hero_Class.Location = new System.Drawing.Point(50, 130);
            this.lb_Hero_Class.Name = "lb_Hero_Class";
            this.lb_Hero_Class.Size = new System.Drawing.Size(10, 13);
            this.lb_Hero_Class.TabIndex = 25;
            this.lb_Hero_Class.Text = "-";
            // 
            // lb_Op_Class
            // 
            this.lb_Op_Class.AutoSize = true;
            this.lb_Op_Class.Location = new System.Drawing.Point(335, 130);
            this.lb_Op_Class.Name = "lb_Op_Class";
            this.lb_Op_Class.Size = new System.Drawing.Size(10, 13);
            this.lb_Op_Class.TabIndex = 26;
            this.lb_Op_Class.Text = "-";
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
            this.Controls.Add(this.lb_Op_Class);
            this.Controls.Add(this.lb_Hero_Class);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_HeroiOponente);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.lb_Vencedor);
            this.Controls.Add(this.lb_Tempo);
            this.Controls.Add(this.pb_Oponente);
            this.Controls.Add(this.pb_Heroi);
            this.Controls.Add(this.cb_Vencedor);
            this.Controls.Add(this.cb_heroi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ally);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HS";
            this.Text = "HearthStone";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Heroi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Oponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ally;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_heroi;
        private System.Windows.Forms.ComboBox cb_Vencedor;
        private System.Windows.Forms.PictureBox pb_Heroi;
        private System.Windows.Forms.PictureBox pb_Oponente;
        private System.Windows.Forms.Label lb_Tempo;
        private System.Windows.Forms.Label lb_Vencedor;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.ComboBox cb_HeroiOponente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Hero_Class;
        private System.Windows.Forms.Label lb_Op_Class;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.MaskedTextBox mb_TempoPartida;

    }
}
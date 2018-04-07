namespace ScoreTracking
{
    partial class frm_Estatistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Estatistica));
            this.cb_por_heroi = new System.Windows.Forms.ComboBox();
            this.lb_heroi = new System.Windows.Forms.Label();
            this.pn_por_heroi = new System.Windows.Forms.Panel();
            this.lb_val_win_rate_heroi = new System.Windows.Forms.Label();
            this.lb_num_partidas_heroi = new System.Windows.Forms.Label();
            this.lb_win_rate_heroi = new System.Windows.Forms.Label();
            this.lb_partidas_heroi = new System.Windows.Forms.Label();
            this.lb_por_heroi = new System.Windows.Forms.Label();
            this.pn_geral = new System.Windows.Forms.Panel();
            this.lb_val_win_rate_geral = new System.Windows.Forms.Label();
            this.lb_num_partidas_geral = new System.Windows.Forms.Label();
            this.lb_win_rate_geral = new System.Windows.Forms.Label();
            this.lb_partidas_geral = new System.Windows.Forms.Label();
            this.lb_geral = new System.Windows.Forms.Label();
            this.mn_menu = new System.Windows.Forms.MenuStrip();
            this.limparEstatisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_por_heroi.SuspendLayout();
            this.pn_geral.SuspendLayout();
            this.mn_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_por_heroi
            // 
            this.cb_por_heroi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_por_heroi.FormattingEnabled = true;
            this.cb_por_heroi.Location = new System.Drawing.Point(75, 34);
            this.cb_por_heroi.Name = "cb_por_heroi";
            this.cb_por_heroi.Size = new System.Drawing.Size(121, 21);
            this.cb_por_heroi.TabIndex = 0;
            this.cb_por_heroi.SelectedIndexChanged += new System.EventHandler(this.cb_por_heroi_SelectedIndexChanged);
            // 
            // lb_heroi
            // 
            this.lb_heroi.AutoSize = true;
            this.lb_heroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_heroi.Location = new System.Drawing.Point(18, 35);
            this.lb_heroi.Name = "lb_heroi";
            this.lb_heroi.Size = new System.Drawing.Size(51, 20);
            this.lb_heroi.TabIndex = 1;
            this.lb_heroi.Text = "Herói:";
            // 
            // pn_por_heroi
            // 
            this.pn_por_heroi.Controls.Add(this.lb_val_win_rate_heroi);
            this.pn_por_heroi.Controls.Add(this.lb_num_partidas_heroi);
            this.pn_por_heroi.Controls.Add(this.lb_win_rate_heroi);
            this.pn_por_heroi.Controls.Add(this.lb_partidas_heroi);
            this.pn_por_heroi.Controls.Add(this.lb_por_heroi);
            this.pn_por_heroi.Controls.Add(this.cb_por_heroi);
            this.pn_por_heroi.Controls.Add(this.lb_heroi);
            this.pn_por_heroi.Location = new System.Drawing.Point(12, 39);
            this.pn_por_heroi.Name = "pn_por_heroi";
            this.pn_por_heroi.Size = new System.Drawing.Size(303, 147);
            this.pn_por_heroi.TabIndex = 2;
            // 
            // lb_val_win_rate_heroi
            // 
            this.lb_val_win_rate_heroi.AutoSize = true;
            this.lb_val_win_rate_heroi.Location = new System.Drawing.Point(160, 109);
            this.lb_val_win_rate_heroi.Name = "lb_val_win_rate_heroi";
            this.lb_val_win_rate_heroi.Size = new System.Drawing.Size(10, 13);
            this.lb_val_win_rate_heroi.TabIndex = 5;
            this.lb_val_win_rate_heroi.Text = "-";
            // 
            // lb_num_partidas_heroi
            // 
            this.lb_num_partidas_heroi.AutoSize = true;
            this.lb_num_partidas_heroi.Location = new System.Drawing.Point(160, 77);
            this.lb_num_partidas_heroi.Name = "lb_num_partidas_heroi";
            this.lb_num_partidas_heroi.Size = new System.Drawing.Size(10, 13);
            this.lb_num_partidas_heroi.TabIndex = 4;
            this.lb_num_partidas_heroi.Text = "-";
            // 
            // lb_win_rate_heroi
            // 
            this.lb_win_rate_heroi.AutoSize = true;
            this.lb_win_rate_heroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_win_rate_heroi.Location = new System.Drawing.Point(28, 104);
            this.lb_win_rate_heroi.Name = "lb_win_rate_heroi";
            this.lb_win_rate_heroi.Size = new System.Drawing.Size(126, 20);
            this.lb_win_rate_heroi.TabIndex = 4;
            this.lb_win_rate_heroi.Text = "Taxa de Vitórias:";
            // 
            // lb_partidas_heroi
            // 
            this.lb_partidas_heroi.AutoSize = true;
            this.lb_partidas_heroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_partidas_heroi.Location = new System.Drawing.Point(18, 72);
            this.lb_partidas_heroi.Name = "lb_partidas_heroi";
            this.lb_partidas_heroi.Size = new System.Drawing.Size(136, 20);
            this.lb_partidas_heroi.TabIndex = 3;
            this.lb_partidas_heroi.Text = "Partidas Jogadas:";
            // 
            // lb_por_heroi
            // 
            this.lb_por_heroi.AutoSize = true;
            this.lb_por_heroi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_por_heroi.Location = new System.Drawing.Point(71, 7);
            this.lb_por_heroi.Name = "lb_por_heroi";
            this.lb_por_heroi.Size = new System.Drawing.Size(173, 20);
            this.lb_por_heroi.TabIndex = 2;
            this.lb_por_heroi.Text = "Estatística por Herói";
            // 
            // pn_geral
            // 
            this.pn_geral.Controls.Add(this.lb_val_win_rate_geral);
            this.pn_geral.Controls.Add(this.lb_num_partidas_geral);
            this.pn_geral.Controls.Add(this.lb_win_rate_geral);
            this.pn_geral.Controls.Add(this.lb_partidas_geral);
            this.pn_geral.Controls.Add(this.lb_geral);
            this.pn_geral.Location = new System.Drawing.Point(321, 39);
            this.pn_geral.Name = "pn_geral";
            this.pn_geral.Size = new System.Drawing.Size(303, 147);
            this.pn_geral.TabIndex = 3;
            // 
            // lb_val_win_rate_geral
            // 
            this.lb_val_win_rate_geral.AutoSize = true;
            this.lb_val_win_rate_geral.Location = new System.Drawing.Point(157, 109);
            this.lb_val_win_rate_geral.Name = "lb_val_win_rate_geral";
            this.lb_val_win_rate_geral.Size = new System.Drawing.Size(10, 13);
            this.lb_val_win_rate_geral.TabIndex = 7;
            this.lb_val_win_rate_geral.Text = "-";
            // 
            // lb_num_partidas_geral
            // 
            this.lb_num_partidas_geral.AutoSize = true;
            this.lb_num_partidas_geral.Location = new System.Drawing.Point(157, 77);
            this.lb_num_partidas_geral.Name = "lb_num_partidas_geral";
            this.lb_num_partidas_geral.Size = new System.Drawing.Size(10, 13);
            this.lb_num_partidas_geral.TabIndex = 6;
            this.lb_num_partidas_geral.Text = "-";
            // 
            // lb_win_rate_geral
            // 
            this.lb_win_rate_geral.AutoSize = true;
            this.lb_win_rate_geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_win_rate_geral.Location = new System.Drawing.Point(25, 104);
            this.lb_win_rate_geral.Name = "lb_win_rate_geral";
            this.lb_win_rate_geral.Size = new System.Drawing.Size(126, 20);
            this.lb_win_rate_geral.TabIndex = 2;
            this.lb_win_rate_geral.Text = "Taxa de Vitórias:";
            // 
            // lb_partidas_geral
            // 
            this.lb_partidas_geral.AutoSize = true;
            this.lb_partidas_geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_partidas_geral.Location = new System.Drawing.Point(15, 72);
            this.lb_partidas_geral.Name = "lb_partidas_geral";
            this.lb_partidas_geral.Size = new System.Drawing.Size(136, 20);
            this.lb_partidas_geral.TabIndex = 1;
            this.lb_partidas_geral.Text = "Partidas Jogadas:";
            // 
            // lb_geral
            // 
            this.lb_geral.AutoSize = true;
            this.lb_geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_geral.Location = new System.Drawing.Point(89, 7);
            this.lb_geral.Name = "lb_geral";
            this.lb_geral.Size = new System.Drawing.Size(143, 20);
            this.lb_geral.TabIndex = 0;
            this.lb_geral.Text = "Estatística Geral";
            // 
            // mn_menu
            // 
            this.mn_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparEstatisticaToolStripMenuItem});
            this.mn_menu.Location = new System.Drawing.Point(0, 0);
            this.mn_menu.Name = "mn_menu";
            this.mn_menu.Size = new System.Drawing.Size(633, 24);
            this.mn_menu.TabIndex = 4;
            this.mn_menu.Text = "menuStrip1";
            // 
            // limparEstatisticaToolStripMenuItem
            // 
            this.limparEstatisticaToolStripMenuItem.Name = "limparEstatisticaToolStripMenuItem";
            this.limparEstatisticaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.limparEstatisticaToolStripMenuItem.Text = "&Limpar Estatistica";
            this.limparEstatisticaToolStripMenuItem.Click += new System.EventHandler(this.limparEstatisticaToolStripMenuItem_Click);
            // 
            // frm_Estatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 202);
            this.Controls.Add(this.pn_geral);
            this.Controls.Add(this.pn_por_heroi);
            this.Controls.Add(this.mn_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mn_menu;
            this.MaximizeBox = false;
            this.Name = "frm_Estatistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatística";
            this.pn_por_heroi.ResumeLayout(false);
            this.pn_por_heroi.PerformLayout();
            this.pn_geral.ResumeLayout(false);
            this.pn_geral.PerformLayout();
            this.mn_menu.ResumeLayout(false);
            this.mn_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_por_heroi;
        private System.Windows.Forms.Label lb_heroi;
        private System.Windows.Forms.Panel pn_por_heroi;
        private System.Windows.Forms.Label lb_por_heroi;
        private System.Windows.Forms.Panel pn_geral;
        private System.Windows.Forms.Label lb_geral;
        private System.Windows.Forms.Label lb_win_rate_geral;
        private System.Windows.Forms.Label lb_partidas_geral;
        private System.Windows.Forms.Label lb_win_rate_heroi;
        private System.Windows.Forms.Label lb_partidas_heroi;
        private System.Windows.Forms.Label lb_val_win_rate_heroi;
        private System.Windows.Forms.Label lb_num_partidas_heroi;
        private System.Windows.Forms.Label lb_val_win_rate_geral;
        private System.Windows.Forms.Label lb_num_partidas_geral;
        private System.Windows.Forms.MenuStrip mn_menu;
        private System.Windows.Forms.ToolStripMenuItem limparEstatisticaToolStripMenuItem;
    }
}
namespace ScoreTracking
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.lb_info = new System.Windows.Forms.Label();
            this.btn_Paladins = new System.Windows.Forms.Button();
            this.btn_HS = new System.Windows.Forms.Button();
            this.btn_Lol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info.Location = new System.Drawing.Point(20, 43);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(130, 20);
            this.lb_info.TabIndex = 3;
            this.lb_info.Text = "Selecione o jogo:";
            // 
            // btn_Paladins
            // 
            this.btn_Paladins.BackgroundImage = global::ScoreTracking.Properties.Resources.qJY7LuHX_400x400;
            this.btn_Paladins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Paladins.Location = new System.Drawing.Point(275, 77);
            this.btn_Paladins.Name = "btn_Paladins";
            this.btn_Paladins.Size = new System.Drawing.Size(103, 89);
            this.btn_Paladins.TabIndex = 2;
            this.btn_Paladins.UseVisualStyleBackColor = true;
            this.btn_Paladins.Click += new System.EventHandler(this.btn_Paladins_Click);
            // 
            // btn_HS
            // 
            this.btn_HS.BackColor = System.Drawing.Color.White;
            this.btn_HS.BackgroundImage = global::ScoreTracking.Properties.Resources._1393ff58b34cbdfbe28ee8f2c7380508;
            this.btn_HS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HS.Location = new System.Drawing.Point(150, 77);
            this.btn_HS.Name = "btn_HS";
            this.btn_HS.Size = new System.Drawing.Size(103, 89);
            this.btn_HS.TabIndex = 1;
            this.btn_HS.UseVisualStyleBackColor = false;
            // 
            // btn_Lol
            // 
            this.btn_Lol.BackColor = System.Drawing.Color.White;
            this.btn_Lol.BackgroundImage = global::ScoreTracking.Properties.Resources.League_of_Legends_Icon;
            this.btn_Lol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Lol.Location = new System.Drawing.Point(24, 77);
            this.btn_Lol.Name = "btn_Lol";
            this.btn_Lol.Size = new System.Drawing.Size(103, 89);
            this.btn_Lol.TabIndex = 0;
            this.btn_Lol.UseVisualStyleBackColor = false;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 198);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.btn_Paladins);
            this.Controls.Add(this.btn_HS);
            this.Controls.Add(this.btn_Lol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Lol;
        private System.Windows.Forms.Button btn_HS;
        private System.Windows.Forms.Button btn_Paladins;
        private System.Windows.Forms.Label lb_info;
    }
}


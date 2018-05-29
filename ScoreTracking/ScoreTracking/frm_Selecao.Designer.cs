namespace ScoreTracking
{
    partial class frm_Selecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Selecao));
            this.dataGridPartida = new System.Windows.Forms.DataGridView();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartida)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPartida
            // 
            this.dataGridPartida.AllowUserToAddRows = false;
            this.dataGridPartida.AllowUserToDeleteRows = false;
            this.dataGridPartida.AllowUserToResizeRows = false;
            this.dataGridPartida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPartida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPartida.Location = new System.Drawing.Point(1, 63);
            this.dataGridPartida.Name = "dataGridPartida";
            this.dataGridPartida.ReadOnly = true;
            this.dataGridPartida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridPartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPartida.Size = new System.Drawing.Size(620, 255);
            this.dataGridPartida.TabIndex = 0;
            this.dataGridPartida.DoubleClick += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Ok
            // 
            this.bt_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ok.Location = new System.Drawing.Point(542, 324);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(66, 29);
            this.bt_Ok.TabIndex = 1;
            this.bt_Ok.Text = "&OK";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione sua partida:";
            // 
            // frm_Selecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.dataGridPartida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Selecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPartida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPartida;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Label label1;
    }
}
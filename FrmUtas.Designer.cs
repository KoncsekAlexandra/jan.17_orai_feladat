namespace WFA220117
{
    partial class FrmUtas
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUtasKod = new System.Windows.Forms.TextBox();
            this.rtbCim = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTorles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUresUrlap = new System.Windows.Forms.ToolStripMenuItem();
            this.cbJelentkezes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utas kód:";
            // 
            // tbUtasKod
            // 
            this.tbUtasKod.Enabled = false;
            this.tbUtasKod.Location = new System.Drawing.Point(131, 40);
            this.tbUtasKod.Name = "tbUtasKod";
            this.tbUtasKod.Size = new System.Drawing.Size(100, 26);
            this.tbUtasKod.TabIndex = 1;
            this.tbUtasKod.TextChanged += new System.EventHandler(this.TbUtasKod_TextChanged);
            // 
            // rtbCim
            // 
            this.rtbCim.Location = new System.Drawing.Point(131, 160);
            this.rtbCim.Name = "rtbCim";
            this.rtbCim.Size = new System.Drawing.Size(254, 81);
            this.rtbCim.TabIndex = 2;
            this.rtbCim.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmiKereses,
            this.tsmiMentes,
            this.tsmiTorles,
            this.tsmiUresUrlap});
            this.menuStrip1.Location = new System.Drawing.Point(444, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 40, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(79, 341);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 4);
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Image = global::WFA220117.Properties.Resources.keres;
            this.tsmiKereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(66, 55);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiKereses.Click += new System.EventHandler(this.TsmiKereses_Click);
            // 
            // tsmiMentes
            // 
            this.tsmiMentes.Image = global::WFA220117.Properties.Resources.ment;
            this.tsmiMentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMentes.Name = "tsmiMentes";
            this.tsmiMentes.Size = new System.Drawing.Size(66, 55);
            this.tsmiMentes.Text = "Mentés";
            this.tsmiMentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiMentes.Click += new System.EventHandler(this.TsmiMentes_Click);
            // 
            // tsmiTorles
            // 
            this.tsmiTorles.Enabled = false;
            this.tsmiTorles.Image = global::WFA220117.Properties.Resources.delete;
            this.tsmiTorles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTorles.Name = "tsmiTorles";
            this.tsmiTorles.Size = new System.Drawing.Size(66, 55);
            this.tsmiTorles.Text = "Törlés";
            this.tsmiTorles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiTorles.Click += new System.EventHandler(this.TsmiTorles_Click);
            // 
            // tsmiUresUrlap
            // 
            this.tsmiUresUrlap.Image = global::WFA220117.Properties.Resources.ures;
            this.tsmiUresUrlap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUresUrlap.Name = "tsmiUresUrlap";
            this.tsmiUresUrlap.Size = new System.Drawing.Size(66, 55);
            this.tsmiUresUrlap.Text = "Üres Űrlap";
            this.tsmiUresUrlap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiUresUrlap.Click += new System.EventHandler(this.TsmiUresUrlap_Click);
            // 
            // cbJelentkezes
            // 
            this.cbJelentkezes.FormattingEnabled = true;
            this.cbJelentkezes.Location = new System.Drawing.Point(131, 276);
            this.cbJelentkezes.Name = "cbJelentkezes";
            this.cbJelentkezes.Size = new System.Drawing.Size(100, 28);
            this.cbJelentkezes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cím:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jelentkezés:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(131, 102);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(254, 26);
            this.tbNev.TabIndex = 1;
            // 
            // FrmUtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 341);
            this.Controls.Add(this.cbJelentkezes);
            this.Controls.Add(this.rtbCim);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbUtasKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUtas";
            this.Text = "Utas";
            this.Load += new System.EventHandler(this.FrmUtas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.ToolStripMenuItem tsmiMentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiTorles;
        private System.Windows.Forms.ToolStripMenuItem tsmiUresUrlap;
        internal System.Windows.Forms.TextBox tbUtasKod;
        internal System.Windows.Forms.RichTextBox rtbCim;
        internal System.Windows.Forms.ComboBox cbJelentkezes;
        internal System.Windows.Forms.TextBox tbNev;
    }
}
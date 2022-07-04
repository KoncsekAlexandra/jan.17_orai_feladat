namespace WFA220117
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUtas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzerkesztes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIdegenvezeto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzallas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUtvonal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTura = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUtas,
            this.tsmiIdegenvezeto,
            this.tsmiSzallas,
            this.tsmiUtvonal,
            this.tsmiTura});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 87);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUtas
            // 
            this.tsmiUtas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSzerkesztes,
            this.tsmiKereses});
            this.tsmiUtas.Image = global::WFA220117.Properties.Resources.utas1;
            this.tsmiUtas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUtas.Name = "tsmiUtas";
            this.tsmiUtas.Size = new System.Drawing.Size(76, 83);
            this.tsmiUtas.Text = "Utas";
            this.tsmiUtas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiSzerkesztes
            // 
            this.tsmiSzerkesztes.Name = "tsmiSzerkesztes";
            this.tsmiSzerkesztes.Size = new System.Drawing.Size(180, 22);
            this.tsmiSzerkesztes.Text = "Szerkesztés";
            this.tsmiSzerkesztes.Click += new System.EventHandler(this.TsmiSzerkesztes_Click);
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Size = new System.Drawing.Size(180, 22);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.Click += new System.EventHandler(this.TsmiKereses_Click);
            // 
            // tsmiIdegenvezeto
            // 
            this.tsmiIdegenvezeto.Image = global::WFA220117.Properties.Resources.idegenvezeto;
            this.tsmiIdegenvezeto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiIdegenvezeto.Name = "tsmiIdegenvezeto";
            this.tsmiIdegenvezeto.Size = new System.Drawing.Size(89, 83);
            this.tsmiIdegenvezeto.Text = "Idegenvezető";
            this.tsmiIdegenvezeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiSzallas
            // 
            this.tsmiSzallas.Image = global::WFA220117.Properties.Resources.szallas;
            this.tsmiSzallas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSzallas.Name = "tsmiSzallas";
            this.tsmiSzallas.Size = new System.Drawing.Size(76, 83);
            this.tsmiSzallas.Text = "Szállás";
            this.tsmiSzallas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiUtvonal
            // 
            this.tsmiUtvonal.Image = global::WFA220117.Properties.Resources.utvonal;
            this.tsmiUtvonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUtvonal.Name = "tsmiUtvonal";
            this.tsmiUtvonal.Size = new System.Drawing.Size(76, 83);
            this.tsmiUtvonal.Text = "Útvonal";
            this.tsmiUtvonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiTura
            // 
            this.tsmiTura.Image = global::WFA220117.Properties.Resources.tura;
            this.tsmiTura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTura.Name = "tsmiTura";
            this.tsmiTura.Size = new System.Drawing.Size(76, 83);
            this.tsmiTura.Text = "Túra";
            this.tsmiTura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Túrák:";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvMain.Location = new System.Drawing.Point(12, 178);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(813, 190);
            this.dgvMain.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "kód";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "cél";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "kezdet";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "vége";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "idegenvezető";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "szállás";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ár (Ft)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(35, 419);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(136, 20);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "###maiDatum###";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 474);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Napos Oldal Utazási Iroda";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtas;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzerkesztes;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.ToolStripMenuItem tsmiIdegenvezeto;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzallas;
        private System.Windows.Forms.ToolStripMenuItem tsmiUtvonal;
        private System.Windows.Forms.ToolStripMenuItem tsmiTura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblDatum;
    }
}


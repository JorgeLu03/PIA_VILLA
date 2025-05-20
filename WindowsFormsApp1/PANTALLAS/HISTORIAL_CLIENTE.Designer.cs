namespace WindowsFormsApp1.PANTALLAS
{
    partial class HISTORIAL_CLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HISTORIAL_CLIENTE));
            this.DG_CLIENT = new System.Windows.Forms.DataGridView();
            this.DG_HIST = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.GB_FILTRO = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_AÑO = new System.Windows.Forms.NumericUpDown();
            this.CB_FILTRO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_PDF = new System.Windows.Forms.Button();
            this.CHK_EVER = new System.Windows.Forms.CheckBox();
            this.TB_BUSQ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_HIST)).BeginInit();
            this.GB_FILTRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AÑO)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_CLIENT
            // 
            this.DG_CLIENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CLIENT.Location = new System.Drawing.Point(115, 154);
            this.DG_CLIENT.Name = "DG_CLIENT";
            this.DG_CLIENT.RowHeadersWidth = 51;
            this.DG_CLIENT.RowTemplate.Height = 24;
            this.DG_CLIENT.Size = new System.Drawing.Size(1046, 245);
            this.DG_CLIENT.TabIndex = 26;
            this.DG_CLIENT.SelectionChanged += new System.EventHandler(this.DG_CLIENT_SelectionChanged);
            // 
            // DG_HIST
            // 
            this.DG_HIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_HIST.Location = new System.Drawing.Point(115, 466);
            this.DG_HIST.Name = "DG_HIST";
            this.DG_HIST.RowHeadersWidth = 51;
            this.DG_HIST.RowTemplate.Height = 24;
            this.DG_HIST.Size = new System.Drawing.Size(1046, 237);
            this.DG_HIST.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 35);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GB_FILTRO
            // 
            this.GB_FILTRO.Controls.Add(this.TB_BUSQ);
            this.GB_FILTRO.Controls.Add(this.CB_FILTRO);
            this.GB_FILTRO.Controls.Add(this.label6);
            this.GB_FILTRO.Location = new System.Drawing.Point(115, 52);
            this.GB_FILTRO.Name = "GB_FILTRO";
            this.GB_FILTRO.Size = new System.Drawing.Size(300, 82);
            this.GB_FILTRO.TabIndex = 40;
            this.GB_FILTRO.TabStop = false;
            this.GB_FILTRO.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Año";
            // 
            // NUD_AÑO
            // 
            this.NUD_AÑO.Location = new System.Drawing.Point(115, 425);
            this.NUD_AÑO.Name = "NUD_AÑO";
            this.NUD_AÑO.Size = new System.Drawing.Size(120, 22);
            this.NUD_AÑO.TabIndex = 31;
            this.NUD_AÑO.ValueChanged += new System.EventHandler(this.NUD_AÑO_ValueChanged);
            // 
            // CB_FILTRO
            // 
            this.CB_FILTRO.FormattingEnabled = true;
            this.CB_FILTRO.Location = new System.Drawing.Point(92, 18);
            this.CB_FILTRO.Name = "CB_FILTRO";
            this.CB_FILTRO.Size = new System.Drawing.Size(121, 24);
            this.CB_FILTRO.TabIndex = 27;
            this.CB_FILTRO.SelectedIndexChanged += new System.EventHandler(this.CB_FILTRO_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Búsqueda:";
            // 
            // BTN_PDF
            // 
            this.BTN_PDF.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PDF.Location = new System.Drawing.Point(997, 726);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.Size = new System.Drawing.Size(164, 37);
            this.BTN_PDF.TabIndex = 42;
            this.BTN_PDF.Text = "GUARDAR PDF";
            this.BTN_PDF.UseVisualStyleBackColor = true;
            this.BTN_PDF.Click += new System.EventHandler(this.BTN_PDF_Click);
            // 
            // CHK_EVER
            // 
            this.CHK_EVER.AutoSize = true;
            this.CHK_EVER.Location = new System.Drawing.Point(294, 425);
            this.CHK_EVER.Name = "CHK_EVER";
            this.CHK_EVER.Size = new System.Drawing.Size(122, 20);
            this.CHK_EVER.TabIndex = 43;
            this.CHK_EVER.Text = "Toda la historia";
            this.CHK_EVER.UseVisualStyleBackColor = true;
            this.CHK_EVER.CheckedChanged += new System.EventHandler(this.CHK_EVER_CheckedChanged);
            // 
            // TB_BUSQ
            // 
            this.TB_BUSQ.Location = new System.Drawing.Point(10, 48);
            this.TB_BUSQ.Name = "TB_BUSQ";
            this.TB_BUSQ.Size = new System.Drawing.Size(203, 22);
            this.TB_BUSQ.TabIndex = 68;
            this.TB_BUSQ.TextChanged += new System.EventHandler(this.TB_BUSQ_TextChanged);
            // 
            // HISTORIAL_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 794);
            this.Controls.Add(this.CHK_EVER);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GB_FILTRO);
            this.Controls.Add(this.NUD_AÑO);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DG_HIST);
            this.Controls.Add(this.DG_CLIENT);
            this.Name = "HISTORIAL_CLIENTE";
            this.Text = "HISTORIAL_CLIENTE";
            this.Load += new System.EventHandler(this.HISTORIAL_CLIENTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_CLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_HIST)).EndInit();
            this.GB_FILTRO.ResumeLayout(false);
            this.GB_FILTRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AÑO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_CLIENT;
        private System.Windows.Forms.DataGridView DG_HIST;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox GB_FILTRO;
        private System.Windows.Forms.ComboBox CB_FILTRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_AÑO;
        private System.Windows.Forms.Button BTN_PDF;
        private System.Windows.Forms.CheckBox CHK_EVER;
        private System.Windows.Forms.TextBox TB_BUSQ;
    }
}
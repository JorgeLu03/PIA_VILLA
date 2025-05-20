namespace WindowsFormsApp1.PANTALLAS
{
    partial class REPORTE_VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORTE_VENTAS));
            this.BTN_PDF = new System.Windows.Forms.Button();
            this.DG_VEN = new System.Windows.Forms.DataGridView();
            this.GB_FILTRO = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_AÑO = new System.Windows.Forms.NumericUpDown();
            this.CB_HOTEL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_CD = new System.Windows.Forms.ComboBox();
            this.CB_PAIS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_VEN)).BeginInit();
            this.GB_FILTRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AÑO)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_PDF
            // 
            this.BTN_PDF.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PDF.Location = new System.Drawing.Point(788, 574);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.Size = new System.Drawing.Size(164, 37);
            this.BTN_PDF.TabIndex = 41;
            this.BTN_PDF.Text = "GUARDAR PDF";
            this.BTN_PDF.UseVisualStyleBackColor = true;
            this.BTN_PDF.Click += new System.EventHandler(this.BTN_PDF_Click);
            // 
            // DG_VEN
            // 
            this.DG_VEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_VEN.Location = new System.Drawing.Point(101, 188);
            this.DG_VEN.Name = "DG_VEN";
            this.DG_VEN.RowHeadersWidth = 51;
            this.DG_VEN.RowTemplate.Height = 24;
            this.DG_VEN.Size = new System.Drawing.Size(851, 364);
            this.DG_VEN.TabIndex = 40;
            // 
            // GB_FILTRO
            // 
            this.GB_FILTRO.Controls.Add(this.label4);
            this.GB_FILTRO.Controls.Add(this.NUD_AÑO);
            this.GB_FILTRO.Controls.Add(this.CB_HOTEL);
            this.GB_FILTRO.Controls.Add(this.label3);
            this.GB_FILTRO.Controls.Add(this.CB_CD);
            this.GB_FILTRO.Controls.Add(this.CB_PAIS);
            this.GB_FILTRO.Controls.Add(this.label2);
            this.GB_FILTRO.Controls.Add(this.label1);
            this.GB_FILTRO.Location = new System.Drawing.Point(101, 44);
            this.GB_FILTRO.Name = "GB_FILTRO";
            this.GB_FILTRO.Size = new System.Drawing.Size(300, 138);
            this.GB_FILTRO.TabIndex = 39;
            this.GB_FILTRO.TabStop = false;
            this.GB_FILTRO.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Año";
            // 
            // NUD_AÑO
            // 
            this.NUD_AÑO.Location = new System.Drawing.Point(159, 92);
            this.NUD_AÑO.Name = "NUD_AÑO";
            this.NUD_AÑO.Size = new System.Drawing.Size(120, 22);
            this.NUD_AÑO.TabIndex = 31;
            this.NUD_AÑO.ValueChanged += new System.EventHandler(this.NUD_AÑO_ValueChanged);
            // 
            // CB_HOTEL
            // 
            this.CB_HOTEL.FormattingEnabled = true;
            this.CB_HOTEL.Location = new System.Drawing.Point(159, 42);
            this.CB_HOTEL.Name = "CB_HOTEL";
            this.CB_HOTEL.Size = new System.Drawing.Size(121, 24);
            this.CB_HOTEL.TabIndex = 30;
            this.CB_HOTEL.SelectedIndexChanged += new System.EventHandler(this.CB_HOTEL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hotel";
            // 
            // CB_CD
            // 
            this.CB_CD.FormattingEnabled = true;
            this.CB_CD.Location = new System.Drawing.Point(10, 92);
            this.CB_CD.Name = "CB_CD";
            this.CB_CD.Size = new System.Drawing.Size(121, 24);
            this.CB_CD.TabIndex = 28;
            this.CB_CD.SelectedIndexChanged += new System.EventHandler(this.CB_CD_SelectedIndexChanged);
            // 
            // CB_PAIS
            // 
            this.CB_PAIS.FormattingEnabled = true;
            this.CB_PAIS.Location = new System.Drawing.Point(10, 42);
            this.CB_PAIS.Name = "CB_PAIS";
            this.CB_PAIS.Size = new System.Drawing.Size(121, 24);
            this.CB_PAIS.TabIndex = 27;
            this.CB_PAIS.SelectedIndexChanged += new System.EventHandler(this.CB_PAIS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "País";
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
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // REPORTE_VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 724);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.DG_VEN);
            this.Controls.Add(this.GB_FILTRO);
            this.Name = "REPORTE_VENTAS";
            this.Text = "REPORTE_VENTAS";
            this.Load += new System.EventHandler(this.REPORTE_VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_VEN)).EndInit();
            this.GB_FILTRO.ResumeLayout(false);
            this.GB_FILTRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AÑO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_PDF;
        private System.Windows.Forms.DataGridView DG_VEN;
        private System.Windows.Forms.GroupBox GB_FILTRO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_AÑO;
        private System.Windows.Forms.ComboBox CB_HOTEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_CD;
        private System.Windows.Forms.ComboBox CB_PAIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}
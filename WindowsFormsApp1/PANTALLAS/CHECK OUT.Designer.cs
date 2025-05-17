namespace WindowsFormsApp1.PANTALLAS
{
    partial class CHECK_OUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHECK_OUT));
            this.BTN_COUT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_COD = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.DG_RSV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_PDF = new System.Windows.Forms.Button();
            this.DG_SERV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CLB_SERV = new System.Windows.Forms.CheckedListBox();
            this.LB_FOLIO = new System.Windows.Forms.Label();
            this.LB_COST = new System.Windows.Forms.Label();
            this.TB_DESC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_RSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_SERV)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_COUT
            // 
            this.BTN_COUT.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COUT.Location = new System.Drawing.Point(1093, 485);
            this.BTN_COUT.Name = "BTN_COUT";
            this.BTN_COUT.Size = new System.Drawing.Size(132, 37);
            this.BTN_COUT.TabIndex = 27;
            this.BTN_COUT.Text = "CHECK OUT";
            this.BTN_COUT.UseVisualStyleBackColor = true;
            this.BTN_COUT.Click += new System.EventHandler(this.BTN_COUT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "CÓDIGO DE RESERVACIÓN";
            // 
            // TB_COD
            // 
            this.TB_COD.Location = new System.Drawing.Point(534, 139);
            this.TB_COD.Name = "TB_COD";
            this.TB_COD.Size = new System.Drawing.Size(181, 22);
            this.TB_COD.TabIndex = 25;
            this.TB_COD.TextChanged += new System.EventHandler(this.TB_COD_TextChanged);
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
            this.button4.TabIndex = 28;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DG_RSV
            // 
            this.DG_RSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DG_RSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_RSV.Location = new System.Drawing.Point(48, 215);
            this.DG_RSV.Name = "DG_RSV";
            this.DG_RSV.RowHeadersWidth = 51;
            this.DG_RSV.RowTemplate.Height = 24;
            this.DG_RSV.Size = new System.Drawing.Size(1177, 247);
            this.DG_RSV.TabIndex = 29;
            this.DG_RSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_RSV_CellClick);
            this.DG_RSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_RSV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "COSTO TOTAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "FOLIO:";
            // 
            // BTN_PDF
            // 
            this.BTN_PDF.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PDF.Location = new System.Drawing.Point(1061, 133);
            this.BTN_PDF.Name = "BTN_PDF";
            this.BTN_PDF.Size = new System.Drawing.Size(164, 37);
            this.BTN_PDF.TabIndex = 36;
            this.BTN_PDF.Text = "GUARDAR PDF";
            this.BTN_PDF.UseVisualStyleBackColor = true;
            // 
            // DG_SERV
            // 
            this.DG_SERV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_SERV.Location = new System.Drawing.Point(48, 506);
            this.DG_SERV.Name = "DG_SERV";
            this.DG_SERV.RowHeadersWidth = 51;
            this.DG_SERV.RowTemplate.Height = 24;
            this.DG_SERV.Size = new System.Drawing.Size(432, 189);
            this.DG_SERV.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "SERVICIOS UTILIZADOS:";
            // 
            // CLB_SERV
            // 
            this.CLB_SERV.FormattingEnabled = true;
            this.CLB_SERV.Location = new System.Drawing.Point(534, 546);
            this.CLB_SERV.Name = "CLB_SERV";
            this.CLB_SERV.Size = new System.Drawing.Size(162, 123);
            this.CLB_SERV.TabIndex = 38;
            // 
            // LB_FOLIO
            // 
            this.LB_FOLIO.AutoSize = true;
            this.LB_FOLIO.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FOLIO.Location = new System.Drawing.Point(607, 502);
            this.LB_FOLIO.Name = "LB_FOLIO";
            this.LB_FOLIO.Size = new System.Drawing.Size(103, 20);
            this.LB_FOLIO.TabIndex = 39;
            this.LB_FOLIO.Text = "COSTO TOTAL:";
            this.LB_FOLIO.Visible = false;
            // 
            // LB_COST
            // 
            this.LB_COST.AutoSize = true;
            this.LB_COST.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_COST.Location = new System.Drawing.Point(654, 675);
            this.LB_COST.Name = "LB_COST";
            this.LB_COST.Size = new System.Drawing.Size(103, 20);
            this.LB_COST.TabIndex = 40;
            this.LB_COST.Text = "COSTO TOTAL:";
            this.LB_COST.Visible = false;
            // 
            // TB_DESC
            // 
            this.TB_DESC.Location = new System.Drawing.Point(864, 500);
            this.TB_DESC.Name = "TB_DESC";
            this.TB_DESC.Size = new System.Drawing.Size(181, 22);
            this.TB_DESC.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(860, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Descuento:";
            // 
            // CHECK_OUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 728);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_DESC);
            this.Controls.Add(this.LB_COST);
            this.Controls.Add(this.LB_FOLIO);
            this.Controls.Add(this.CLB_SERV);
            this.Controls.Add(this.DG_SERV);
            this.Controls.Add(this.BTN_PDF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_RSV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_COUT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_COD);
            this.Name = "CHECK_OUT";
            this.Text = "CHECK_OUT";
            this.Load += new System.EventHandler(this.CHECK_OUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_RSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_SERV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_COUT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_COD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DG_RSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_PDF;
        private System.Windows.Forms.DataGridView DG_SERV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CLB_SERV;
        private System.Windows.Forms.Label LB_FOLIO;
        private System.Windows.Forms.Label LB_COST;
        private System.Windows.Forms.TextBox TB_DESC;
        private System.Windows.Forms.Label label4;
    }
}
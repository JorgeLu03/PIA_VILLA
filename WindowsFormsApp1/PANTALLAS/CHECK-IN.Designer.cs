namespace WindowsFormsApp1.PANTALLAS
{
    partial class CHECK_IN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHECK_IN));
            this.BTN_CHECKIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_COD = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.DG_RSV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DG_RSV)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CHECKIN
            // 
            this.BTN_CHECKIN.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CHECKIN.Location = new System.Drawing.Point(447, 486);
            this.BTN_CHECKIN.Name = "BTN_CHECKIN";
            this.BTN_CHECKIN.Size = new System.Drawing.Size(132, 37);
            this.BTN_CHECKIN.TabIndex = 24;
            this.BTN_CHECKIN.Text = "CHECK IN";
            this.BTN_CHECKIN.UseVisualStyleBackColor = true;
            this.BTN_CHECKIN.Click += new System.EventHandler(this.BTN_CHECKIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "CÓDIGO DE RESERVACIÓN";
            // 
            // TB_COD
            // 
            this.TB_COD.Location = new System.Drawing.Point(423, 93);
            this.TB_COD.Name = "TB_COD";
            this.TB_COD.Size = new System.Drawing.Size(181, 22);
            this.TB_COD.TabIndex = 22;
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
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DG_RSV
            // 
            this.DG_RSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_RSV.Location = new System.Drawing.Point(96, 167);
            this.DG_RSV.Name = "DG_RSV";
            this.DG_RSV.RowHeadersWidth = 51;
            this.DG_RSV.RowTemplate.Height = 24;
            this.DG_RSV.Size = new System.Drawing.Size(834, 277);
            this.DG_RSV.TabIndex = 26;
            // 
            // CHECK_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 554);
            this.Controls.Add(this.DG_RSV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_CHECKIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_COD);
            this.Name = "CHECK_IN";
            this.Text = "CHECK_IN";
            this.Load += new System.EventHandler(this.CHECK_IN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_RSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CHECKIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_COD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DG_RSV;
    }
}
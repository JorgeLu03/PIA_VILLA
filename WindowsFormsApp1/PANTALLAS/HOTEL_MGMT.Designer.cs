namespace WindowsFormsApp1.PANTALLAS
{
    partial class HOTEL_MGMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOTEL_MGMT));
            this.BTN_CLS = new System.Windows.Forms.Button();
            this.DG_HOTEL = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_DEL = new System.Windows.Forms.Button();
            this.BTN_MOD = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.TB_DOM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_PAIS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_ED = new System.Windows.Forms.TextBox();
            this.TB_CD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_SERV = new System.Windows.Forms.CheckedListBox();
            this.NUD_PISOS = new System.Windows.Forms.NumericUpDown();
            this.CB_ZONATUR = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_HOTEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PISOS)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CLS
            // 
            this.BTN_CLS.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLS.Location = new System.Drawing.Point(594, 24);
            this.BTN_CLS.Name = "BTN_CLS";
            this.BTN_CLS.Size = new System.Drawing.Size(80, 37);
            this.BTN_CLS.TabIndex = 35;
            this.BTN_CLS.Text = "LIMPIAR";
            this.BTN_CLS.UseVisualStyleBackColor = true;
            this.BTN_CLS.Click += new System.EventHandler(this.BTN_CLS_Click);
            // 
            // DG_HOTEL
            // 
            this.DG_HOTEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_HOTEL.Location = new System.Drawing.Point(106, 320);
            this.DG_HOTEL.Name = "DG_HOTEL";
            this.DG_HOTEL.RowHeadersWidth = 51;
            this.DG_HOTEL.RowTemplate.Height = 24;
            this.DG_HOTEL.Size = new System.Drawing.Size(1009, 212);
            this.DG_HOTEL.TabIndex = 34;
            this.DG_HOTEL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_HOTEL_CellClick);
            this.DG_HOTEL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_HOTEL_CellContentClick);
            this.DG_HOTEL.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DG_HOTEL_DataBindingComplete);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(30, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 35);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_DEL
            // 
            this.BTN_DEL.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DEL.Location = new System.Drawing.Point(983, 566);
            this.BTN_DEL.Name = "BTN_DEL";
            this.BTN_DEL.Size = new System.Drawing.Size(132, 37);
            this.BTN_DEL.TabIndex = 31;
            this.BTN_DEL.Text = "ELIMINAR";
            this.BTN_DEL.UseVisualStyleBackColor = true;
            this.BTN_DEL.Click += new System.EventHandler(this.BTN_DEL_Click);
            // 
            // BTN_MOD
            // 
            this.BTN_MOD.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MOD.Location = new System.Drawing.Point(562, 566);
            this.BTN_MOD.Name = "BTN_MOD";
            this.BTN_MOD.Size = new System.Drawing.Size(132, 37);
            this.BTN_MOD.TabIndex = 30;
            this.BTN_MOD.Text = "MODIFICAR";
            this.BTN_MOD.UseVisualStyleBackColor = true;
            this.BTN_MOD.Click += new System.EventHandler(this.BTN_MOD_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD.Location = new System.Drawing.Point(106, 566);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(132, 37);
            this.BTN_ADD.TabIndex = 28;
            this.BTN_ADD.Text = "AÑADIR";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // TB_DOM
            // 
            this.TB_DOM.Location = new System.Drawing.Point(183, 126);
            this.TB_DOM.Name = "TB_DOM";
            this.TB_DOM.Size = new System.Drawing.Size(170, 22);
            this.TB_DOM.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Domicilio:";
            // 
            // TB_PAIS
            // 
            this.TB_PAIS.Location = new System.Drawing.Point(880, 234);
            this.TB_PAIS.Name = "TB_PAIS";
            this.TB_PAIS.Size = new System.Drawing.Size(170, 22);
            this.TB_PAIS.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pisos:";
            // 
            // TB_ED
            // 
            this.TB_ED.Location = new System.Drawing.Point(880, 182);
            this.TB_ED.Name = "TB_ED";
            this.TB_ED.Size = new System.Drawing.Size(170, 22);
            this.TB_ED.TabIndex = 22;
            // 
            // TB_CD
            // 
            this.TB_CD.Location = new System.Drawing.Point(880, 130);
            this.TB_CD.Name = "TB_CD";
            this.TB_CD.Size = new System.Drawing.Size(170, 22);
            this.TB_CD.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(926, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ubicación";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(183, 86);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(170, 22);
            this.TB_NAME.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Servicios:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(936, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ciudad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(937, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(946, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "País:";
            // 
            // LB_SERV
            // 
            this.LB_SERV.FormattingEnabled = true;
            this.LB_SERV.Location = new System.Drawing.Point(515, 88);
            this.LB_SERV.Name = "LB_SERV";
            this.LB_SERV.Size = new System.Drawing.Size(220, 208);
            this.LB_SERV.TabIndex = 43;
            // 
            // NUD_PISOS
            // 
            this.NUD_PISOS.Location = new System.Drawing.Point(183, 169);
            this.NUD_PISOS.Name = "NUD_PISOS";
            this.NUD_PISOS.Size = new System.Drawing.Size(170, 22);
            this.NUD_PISOS.TabIndex = 44;
            // 
            // CB_ZONATUR
            // 
            this.CB_ZONATUR.AutoSize = true;
            this.CB_ZONATUR.Location = new System.Drawing.Point(909, 276);
            this.CB_ZONATUR.Name = "CB_ZONATUR";
            this.CB_ZONATUR.Size = new System.Drawing.Size(114, 20);
            this.CB_ZONATUR.TabIndex = 45;
            this.CB_ZONATUR.Text = "Zona Turística";
            this.CB_ZONATUR.UseVisualStyleBackColor = true;
            // 
            // HOTEL_MGMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 669);
            this.Controls.Add(this.CB_ZONATUR);
            this.Controls.Add(this.NUD_PISOS);
            this.Controls.Add(this.LB_SERV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_CLS);
            this.Controls.Add(this.DG_HOTEL);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_DEL);
            this.Controls.Add(this.BTN_MOD);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_DOM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_PAIS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_ED);
            this.Controls.Add(this.TB_CD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.label1);
            this.Name = "HOTEL_MGMT";
            this.Text = "HOTEL_MGMT";
            this.Load += new System.EventHandler(this.HOTEL_MGMT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_HOTEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PISOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CLS;
        private System.Windows.Forms.DataGridView DG_HOTEL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTN_DEL;
        private System.Windows.Forms.Button BTN_MOD;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.TextBox TB_DOM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_PAIS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_ED;
        private System.Windows.Forms.TextBox TB_CD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox LB_SERV;
        private System.Windows.Forms.NumericUpDown NUD_PISOS;
        private System.Windows.Forms.CheckBox CB_ZONATUR;
    }
}
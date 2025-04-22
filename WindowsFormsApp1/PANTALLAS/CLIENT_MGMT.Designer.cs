namespace WindowsFormsApp1.PANTALLAS
{
    partial class CLIENT_MGMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENT_MGMT));
            this.BTN_CLS = new System.Windows.Forms.Button();
            this.DG_CLIENTES = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_DEL = new System.Windows.Forms.Button();
            this.BTN_MOD = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.TB_TEL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_CORREO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_EDOCIV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_PAIS = new System.Windows.Forms.TextBox();
            this.TB_ED = new System.Windows.Forms.TextBox();
            this.TB_CD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DTP_FECHANAC = new System.Windows.Forms.DateTimePicker();
            this.TB_CEL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CLS
            // 
            this.BTN_CLS.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLS.Location = new System.Drawing.Point(642, 23);
            this.BTN_CLS.Name = "BTN_CLS";
            this.BTN_CLS.Size = new System.Drawing.Size(80, 37);
            this.BTN_CLS.TabIndex = 35;
            this.BTN_CLS.Text = "LIMPIAR";
            this.BTN_CLS.UseVisualStyleBackColor = true;
            this.BTN_CLS.Click += new System.EventHandler(this.BTN_CLS_Click);
            // 
            // DG_CLIENTES
            // 
            this.DG_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CLIENTES.Location = new System.Drawing.Point(87, 288);
            this.DG_CLIENTES.Name = "DG_CLIENTES";
            this.DG_CLIENTES.RowHeadersWidth = 51;
            this.DG_CLIENTES.RowTemplate.Height = 24;
            this.DG_CLIENTES.Size = new System.Drawing.Size(1181, 272);
            this.DG_CLIENTES.TabIndex = 34;
            this.DG_CLIENTES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CLIENTES_CellClick);
            this.DG_CLIENTES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CLIENTES_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(11, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 35);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_DEL
            // 
            this.BTN_DEL.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DEL.Location = new System.Drawing.Point(1136, 577);
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
            this.BTN_MOD.Location = new System.Drawing.Point(607, 577);
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
            this.BTN_ADD.Location = new System.Drawing.Point(87, 577);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(132, 37);
            this.BTN_ADD.TabIndex = 28;
            this.BTN_ADD.Text = "AÑADIR";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // TB_TEL
            // 
            this.TB_TEL.Location = new System.Drawing.Point(642, 147);
            this.TB_TEL.Name = "TB_TEL";
            this.TB_TEL.Size = new System.Drawing.Size(222, 22);
            this.TB_TEL.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Teléfono:";
            // 
            // TB_RFC
            // 
            this.TB_RFC.Location = new System.Drawing.Point(624, 99);
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(240, 22);
            this.TB_RFC.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "RFC:";
            // 
            // TB_CORREO
            // 
            this.TB_CORREO.Location = new System.Drawing.Point(148, 195);
            this.TB_CORREO.Name = "TB_CORREO";
            this.TB_CORREO.Size = new System.Drawing.Size(296, 22);
            this.TB_CORREO.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(164, 99);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(280, 22);
            this.TB_NAME.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Estado civil:";
            // 
            // CB_EDOCIV
            // 
            this.CB_EDOCIV.FormattingEnabled = true;
            this.CB_EDOCIV.Location = new System.Drawing.Point(173, 246);
            this.CB_EDOCIV.Name = "CB_EDOCIV";
            this.CB_EDOCIV.Size = new System.Drawing.Size(207, 24);
            this.CB_EDOCIV.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1137, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1128, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1127, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Ciudad:";
            // 
            // TB_PAIS
            // 
            this.TB_PAIS.Location = new System.Drawing.Point(1044, 193);
            this.TB_PAIS.Name = "TB_PAIS";
            this.TB_PAIS.Size = new System.Drawing.Size(224, 22);
            this.TB_PAIS.TabIndex = 44;
            // 
            // TB_ED
            // 
            this.TB_ED.Location = new System.Drawing.Point(1044, 147);
            this.TB_ED.Name = "TB_ED";
            this.TB_ED.Size = new System.Drawing.Size(224, 22);
            this.TB_ED.TabIndex = 43;
            // 
            // TB_CD
            // 
            this.TB_CD.Location = new System.Drawing.Point(1044, 101);
            this.TB_CD.Name = "TB_CD";
            this.TB_CD.Size = new System.Drawing.Size(224, 22);
            this.TB_CD.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1117, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Ubicación";
            // 
            // DTP_FECHANAC
            // 
            this.DTP_FECHANAC.CustomFormat = "";
            this.DTP_FECHANAC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FECHANAC.Location = new System.Drawing.Point(246, 147);
            this.DTP_FECHANAC.Name = "DTP_FECHANAC";
            this.DTP_FECHANAC.Size = new System.Drawing.Size(198, 22);
            this.DTP_FECHANAC.TabIndex = 48;
            // 
            // TB_CEL
            // 
            this.TB_CEL.Location = new System.Drawing.Point(642, 197);
            this.TB_CEL.Name = "TB_CEL";
            this.TB_CEL.Size = new System.Drawing.Size(222, 22);
            this.TB_CEL.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(567, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Celular:";
            // 
            // CLIENT_MGMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 641);
            this.Controls.Add(this.TB_CEL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DTP_FECHANAC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TB_PAIS);
            this.Controls.Add(this.TB_ED);
            this.Controls.Add(this.TB_CD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CB_EDOCIV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_CLS);
            this.Controls.Add(this.DG_CLIENTES);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_DEL);
            this.Controls.Add(this.BTN_MOD);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_TEL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_RFC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_CORREO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.label1);
            this.Name = "CLIENT_MGMT";
            this.Text = "CLIENT_MGMT";
            this.Load += new System.EventHandler(this.CLIENT_MGMT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_CLIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CLS;
        private System.Windows.Forms.DataGridView DG_CLIENTES;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTN_DEL;
        private System.Windows.Forms.Button BTN_MOD;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.TextBox TB_TEL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_RFC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_CORREO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_EDOCIV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_PAIS;
        private System.Windows.Forms.TextBox TB_ED;
        private System.Windows.Forms.TextBox TB_CD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTP_FECHANAC;
        private System.Windows.Forms.TextBox TB_CEL;
        private System.Windows.Forms.Label label11;
    }
}
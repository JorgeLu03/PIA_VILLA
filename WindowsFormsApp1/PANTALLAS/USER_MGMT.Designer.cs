namespace WindowsFormsApp1.PANTALLAS
{
    partial class USER_MGMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_MGMT));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.TB_FECNAC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_CORREO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_PSW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_NUMNOMINA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_TEL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_MOD = new System.Windows.Forms.Button();
            this.BTN_ELIM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DG_USERS = new System.Windows.Forms.DataGridView();
            this.BTN_CLS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_USERS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(177, 82);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(170, 22);
            this.TB_NAME.TabIndex = 1;
            // 
            // TB_FECNAC
            // 
            this.TB_FECNAC.Location = new System.Drawing.Point(270, 130);
            this.TB_FECNAC.Name = "TB_FECNAC";
            this.TB_FECNAC.Size = new System.Drawing.Size(170, 22);
            this.TB_FECNAC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // TB_CORREO
            // 
            this.TB_CORREO.Location = new System.Drawing.Point(161, 178);
            this.TB_CORREO.Name = "TB_CORREO";
            this.TB_CORREO.Size = new System.Drawing.Size(170, 22);
            this.TB_CORREO.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
            // 
            // TB_PSW
            // 
            this.TB_PSW.Location = new System.Drawing.Point(584, 178);
            this.TB_PSW.Name = "TB_PSW";
            this.TB_PSW.Size = new System.Drawing.Size(170, 22);
            this.TB_PSW.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // TB_NUMNOMINA
            // 
            this.TB_NUMNOMINA.Location = new System.Drawing.Point(639, 80);
            this.TB_NUMNOMINA.Name = "TB_NUMNOMINA";
            this.TB_NUMNOMINA.Size = new System.Drawing.Size(170, 22);
            this.TB_NUMNOMINA.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número de nómina:";
            // 
            // TB_TEL
            // 
            this.TB_TEL.Location = new System.Drawing.Point(557, 128);
            this.TB_TEL.Name = "TB_TEL";
            this.TB_TEL.Size = new System.Drawing.Size(170, 22);
            this.TB_TEL.TabIndex = 5;
            this.TB_TEL.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono:";
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD.Location = new System.Drawing.Point(100, 471);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(132, 37);
            this.BTN_ADD.TabIndex = 7;
            this.BTN_ADD.Text = "AÑADIR";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            // 
            // BTN_MOD
            // 
            this.BTN_MOD.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MOD.Location = new System.Drawing.Point(406, 471);
            this.BTN_MOD.Name = "BTN_MOD";
            this.BTN_MOD.Size = new System.Drawing.Size(132, 37);
            this.BTN_MOD.TabIndex = 8;
            this.BTN_MOD.Text = "MODIFICAR";
            this.BTN_MOD.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ELIM.Location = new System.Drawing.Point(737, 471);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(132, 37);
            this.BTN_ELIM.TabIndex = 9;
            this.BTN_ELIM.Text = "ELIMINAR";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
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
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DG_USERS
            // 
            this.DG_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_USERS.Location = new System.Drawing.Point(100, 225);
            this.DG_USERS.Name = "DG_USERS";
            this.DG_USERS.RowHeadersWidth = 51;
            this.DG_USERS.RowTemplate.Height = 24;
            this.DG_USERS.Size = new System.Drawing.Size(769, 212);
            this.DG_USERS.TabIndex = 16;
            // 
            // BTN_CLS
            // 
            this.BTN_CLS.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLS.Location = new System.Drawing.Point(429, 20);
            this.BTN_CLS.Name = "BTN_CLS";
            this.BTN_CLS.Size = new System.Drawing.Size(80, 37);
            this.BTN_CLS.TabIndex = 17;
            this.BTN_CLS.Text = "LIMPIAR";
            this.BTN_CLS.UseVisualStyleBackColor = true;
            this.BTN_CLS.Click += new System.EventHandler(this.BTN_CLS_Click);
            // 
            // USER_MGMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 538);
            this.Controls.Add(this.BTN_CLS);
            this.Controls.Add(this.DG_USERS);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_ELIM);
            this.Controls.Add(this.BTN_MOD);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_TEL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_NUMNOMINA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_PSW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_CORREO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_FECNAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "USER_MGMT";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DG_USERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.TextBox TB_FECNAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_CORREO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_PSW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_NUMNOMINA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_TEL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_MOD;
        private System.Windows.Forms.Button BTN_ELIM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DG_USERS;
        private System.Windows.Forms.Button BTN_CLS;
    }
}
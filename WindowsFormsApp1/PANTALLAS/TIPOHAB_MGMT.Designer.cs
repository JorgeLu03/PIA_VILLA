namespace WindowsFormsApp1.PANTALLAS
{
    partial class TIPOHAB_MGMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIPOHAB_MGMT));
            this.BTN_CLS = new System.Windows.Forms.Button();
            this.DG_TIPOHAB = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_DEL = new System.Windows.Forms.Button();
            this.BTN_MOD = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_HOTEL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_COSTO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NIVEL = new System.Windows.Forms.TextBox();
            this.CLB_AMENIDADES = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_CAR = new System.Windows.Forms.TextBox();
            this.NUD_NUMCAMAS = new System.Windows.Forms.NumericUpDown();
            this.CB_TIPOCAMAS = new System.Windows.Forms.ComboBox();
            this.NUD_CAPACIDAD = new System.Windows.Forms.NumericUpDown();
            this.DG_CAR = new System.Windows.Forms.DataGridView();
            this.NUD_CANTHAB = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TIPOHAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NUMCAMAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CAPACIDAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CANTHAB)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CLS
            // 
            this.BTN_CLS.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLS.Location = new System.Drawing.Point(562, 25);
            this.BTN_CLS.Name = "BTN_CLS";
            this.BTN_CLS.Size = new System.Drawing.Size(80, 37);
            this.BTN_CLS.TabIndex = 35;
            this.BTN_CLS.Text = "LIMPIAR";
            this.BTN_CLS.UseVisualStyleBackColor = true;
            this.BTN_CLS.Click += new System.EventHandler(this.button5_Click);
            // 
            // DG_TIPOHAB
            // 
            this.DG_TIPOHAB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TIPOHAB.Location = new System.Drawing.Point(61, 306);
            this.DG_TIPOHAB.Name = "DG_TIPOHAB";
            this.DG_TIPOHAB.RowHeadersWidth = 51;
            this.DG_TIPOHAB.RowTemplate.Height = 24;
            this.DG_TIPOHAB.Size = new System.Drawing.Size(789, 368);
            this.DG_TIPOHAB.TabIndex = 34;
            this.DG_TIPOHAB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TIPOHAB_CellClick);
            this.DG_TIPOHAB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TIPOHAB_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(28, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 35);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_DEL
            // 
            this.BTN_DEL.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DEL.Location = new System.Drawing.Point(1079, 711);
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
            this.BTN_MOD.Location = new System.Drawing.Point(595, 711);
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
            this.BTN_ADD.Location = new System.Drawing.Point(61, 711);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(132, 37);
            this.BTN_ADD.TabIndex = 28;
            this.BTN_ADD.Text = "AÑADIR";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nivel:";
            // 
            // CB_HOTEL
            // 
            this.CB_HOTEL.FormattingEnabled = true;
            this.CB_HOTEL.Location = new System.Drawing.Point(123, 78);
            this.CB_HOTEL.Name = "CB_HOTEL";
            this.CB_HOTEL.Size = new System.Drawing.Size(170, 24);
            this.CB_HOTEL.TabIndex = 36;
            this.CB_HOTEL.SelectedIndexChanged += new System.EventHandler(this.CB_HOTEL_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "HOTEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Número de camas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tipo de camas:";
            // 
            // TB_COSTO
            // 
            this.TB_COSTO.Location = new System.Drawing.Point(410, 144);
            this.TB_COSTO.Name = "TB_COSTO";
            this.TB_COSTO.Size = new System.Drawing.Size(170, 22);
            this.TB_COSTO.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Costo por noche:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Capacidad:";
            // 
            // TB_NIVEL
            // 
            this.TB_NIVEL.Location = new System.Drawing.Point(121, 138);
            this.TB_NIVEL.Name = "TB_NIVEL";
            this.TB_NIVEL.Size = new System.Drawing.Size(210, 22);
            this.TB_NIVEL.TabIndex = 22;
            // 
            // CLB_AMENIDADES
            // 
            this.CLB_AMENIDADES.FormattingEnabled = true;
            this.CLB_AMENIDADES.Location = new System.Drawing.Point(966, 138);
            this.CLB_AMENIDADES.Name = "CLB_AMENIDADES";
            this.CLB_AMENIDADES.Size = new System.Drawing.Size(245, 123);
            this.CLB_AMENIDADES.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(966, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Amenidades:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(639, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Características:";
            // 
            // TB_CAR
            // 
            this.TB_CAR.Location = new System.Drawing.Point(643, 138);
            this.TB_CAR.Multiline = true;
            this.TB_CAR.Name = "TB_CAR";
            this.TB_CAR.Size = new System.Drawing.Size(281, 123);
            this.TB_CAR.TabIndex = 49;
            // 
            // NUD_NUMCAMAS
            // 
            this.NUD_NUMCAMAS.Location = new System.Drawing.Point(121, 190);
            this.NUD_NUMCAMAS.Name = "NUD_NUMCAMAS";
            this.NUD_NUMCAMAS.Size = new System.Drawing.Size(210, 22);
            this.NUD_NUMCAMAS.TabIndex = 50;
            // 
            // CB_TIPOCAMAS
            // 
            this.CB_TIPOCAMAS.FormattingEnabled = true;
            this.CB_TIPOCAMAS.Location = new System.Drawing.Point(123, 242);
            this.CB_TIPOCAMAS.Name = "CB_TIPOCAMAS";
            this.CB_TIPOCAMAS.Size = new System.Drawing.Size(208, 24);
            this.CB_TIPOCAMAS.TabIndex = 41;
            // 
            // NUD_CAPACIDAD
            // 
            this.NUD_CAPACIDAD.Location = new System.Drawing.Point(410, 194);
            this.NUD_CAPACIDAD.Name = "NUD_CAPACIDAD";
            this.NUD_CAPACIDAD.Size = new System.Drawing.Size(170, 22);
            this.NUD_CAPACIDAD.TabIndex = 51;
            // 
            // DG_CAR
            // 
            this.DG_CAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CAR.Location = new System.Drawing.Point(873, 306);
            this.DG_CAR.Name = "DG_CAR";
            this.DG_CAR.RowHeadersWidth = 51;
            this.DG_CAR.RowTemplate.Height = 24;
            this.DG_CAR.Size = new System.Drawing.Size(338, 368);
            this.DG_CAR.TabIndex = 52;
            // 
            // NUD_CANTHAB
            // 
            this.NUD_CANTHAB.Location = new System.Drawing.Point(410, 244);
            this.NUD_CANTHAB.Name = "NUD_CANTHAB";
            this.NUD_CANTHAB.Size = new System.Drawing.Size(170, 22);
            this.NUD_CANTHAB.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Cantidad de habitaciones:";
            // 
            // TIPOHAB_MGMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1276, 775);
            this.Controls.Add(this.NUD_CANTHAB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DG_CAR);
            this.Controls.Add(this.NUD_CAPACIDAD);
            this.Controls.Add(this.NUD_NUMCAMAS);
            this.Controls.Add(this.TB_CAR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CLB_AMENIDADES);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_COSTO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_TIPOCAMAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_HOTEL);
            this.Controls.Add(this.BTN_CLS);
            this.Controls.Add(this.DG_TIPOHAB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_DEL);
            this.Controls.Add(this.BTN_MOD);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_NIVEL);
            this.Controls.Add(this.label1);
            this.Name = "TIPOHAB_MGMT";
            this.Text = "TIPOHAB_MGMT";
            this.Load += new System.EventHandler(this.TIPOHAB_MGMT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_TIPOHAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NUMCAMAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CAPACIDAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CANTHAB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_CLS;
        private System.Windows.Forms.DataGridView DG_TIPOHAB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTN_DEL;
        private System.Windows.Forms.Button BTN_MOD;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_HOTEL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_COSTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NIVEL;
        private System.Windows.Forms.CheckedListBox CLB_AMENIDADES;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_CAR;
        private System.Windows.Forms.NumericUpDown NUD_NUMCAMAS;
        private System.Windows.Forms.ComboBox CB_TIPOCAMAS;
        private System.Windows.Forms.NumericUpDown NUD_CAPACIDAD;
        private System.Windows.Forms.DataGridView DG_CAR;
        private System.Windows.Forms.NumericUpDown NUD_CANTHAB;
        private System.Windows.Forms.Label label9;
    }
}
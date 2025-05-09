namespace WindowsFormsApp1.PANTALLAS
{
    partial class RESERVACIONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RESERVACIONES));
            this.TB_BUSQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_CD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_CLIENTES = new System.Windows.Forms.DataGridView();
            this.DG_HOTELES = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_CANTHAB = new System.Windows.Forms.NumericUpDown();
            this.NUD_CANTPER = new System.Windows.Forms.NumericUpDown();
            this.DTP_ENTRADA = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTP_SALIDA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_ANTICIPO = new System.Windows.Forms.TextBox();
            this.BTN_RSV = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DG_CAR = new System.Windows.Forms.DataGridView();
            this.DG_TIPOHAB = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CB_BUSQ = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BTN_CLS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_HOTELES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CANTHAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CANTPER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TIPOHAB)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_BUSQ
            // 
            this.TB_BUSQ.Location = new System.Drawing.Point(497, 59);
            this.TB_BUSQ.Name = "TB_BUSQ";
            this.TB_BUSQ.Size = new System.Drawing.Size(181, 22);
            this.TB_BUSQ.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Búsqueda:";
            // 
            // CB_CD
            // 
            this.CB_CD.FormattingEnabled = true;
            this.CB_CD.Location = new System.Drawing.Point(427, 264);
            this.CB_CD.Name = "CB_CD";
            this.CB_CD.Size = new System.Drawing.Size(121, 24);
            this.CB_CD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad:";
            // 
            // DG_CLIENTES
            // 
            this.DG_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CLIENTES.Location = new System.Drawing.Point(95, 91);
            this.DG_CLIENTES.Name = "DG_CLIENTES";
            this.DG_CLIENTES.RowHeadersWidth = 51;
            this.DG_CLIENTES.RowTemplate.Height = 24;
            this.DG_CLIENTES.Size = new System.Drawing.Size(583, 125);
            this.DG_CLIENTES.TabIndex = 4;
            // 
            // DG_HOTELES
            // 
            this.DG_HOTELES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_HOTELES.Location = new System.Drawing.Point(95, 299);
            this.DG_HOTELES.Name = "DG_HOTELES";
            this.DG_HOTELES.RowHeadersWidth = 51;
            this.DG_HOTELES.RowTemplate.Height = 24;
            this.DG_HOTELES.Size = new System.Drawing.Size(674, 174);
            this.DG_HOTELES.TabIndex = 5;
            this.DG_HOTELES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_HOTELES_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de habitaciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad de personas:";
            // 
            // NUD_CANTHAB
            // 
            this.NUD_CANTHAB.Location = new System.Drawing.Point(91, 572);
            this.NUD_CANTHAB.Name = "NUD_CANTHAB";
            this.NUD_CANTHAB.Size = new System.Drawing.Size(120, 22);
            this.NUD_CANTHAB.TabIndex = 12;
            // 
            // NUD_CANTPER
            // 
            this.NUD_CANTPER.Location = new System.Drawing.Point(91, 517);
            this.NUD_CANTPER.Name = "NUD_CANTPER";
            this.NUD_CANTPER.Size = new System.Drawing.Size(120, 22);
            this.NUD_CANTPER.TabIndex = 13;
            // 
            // DTP_ENTRADA
            // 
            this.DTP_ENTRADA.Location = new System.Drawing.Point(415, 547);
            this.DTP_ENTRADA.Name = "DTP_ENTRADA";
            this.DTP_ENTRADA.Size = new System.Drawing.Size(200, 22);
            this.DTP_ENTRADA.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Entrada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salida";
            // 
            // DTP_SALIDA
            // 
            this.DTP_SALIDA.Location = new System.Drawing.Point(415, 597);
            this.DTP_SALIDA.Name = "DTP_SALIDA";
            this.DTP_SALIDA.Size = new System.Drawing.Size(200, 22);
            this.DTP_SALIDA.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 599);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Anticipo:";
            // 
            // TB_ANTICIPO
            // 
            this.TB_ANTICIPO.Location = new System.Drawing.Point(91, 624);
            this.TB_ANTICIPO.Name = "TB_ANTICIPO";
            this.TB_ANTICIPO.Size = new System.Drawing.Size(181, 22);
            this.TB_ANTICIPO.TabIndex = 18;
            // 
            // BTN_RSV
            // 
            this.BTN_RSV.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RSV.Location = new System.Drawing.Point(1279, 642);
            this.BTN_RSV.Name = "BTN_RSV";
            this.BTN_RSV.Size = new System.Drawing.Size(133, 37);
            this.BTN_RSV.TabIndex = 20;
            this.BTN_RSV.Text = "RESERVAR";
            this.BTN_RSV.UseVisualStyleBackColor = true;
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
            this.button4.TabIndex = 21;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DG_CAR
            // 
            this.DG_CAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CAR.Location = new System.Drawing.Point(810, 485);
            this.DG_CAR.Name = "DG_CAR";
            this.DG_CAR.RowHeadersWidth = 51;
            this.DG_CAR.RowTemplate.Height = 24;
            this.DG_CAR.Size = new System.Drawing.Size(300, 182);
            this.DG_CAR.TabIndex = 54;
            // 
            // DG_TIPOHAB
            // 
            this.DG_TIPOHAB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TIPOHAB.Location = new System.Drawing.Point(810, 299);
            this.DG_TIPOHAB.Name = "DG_TIPOHAB";
            this.DG_TIPOHAB.RowHeadersWidth = 51;
            this.DG_TIPOHAB.RowTemplate.Height = 24;
            this.DG_TIPOHAB.Size = new System.Drawing.Size(533, 174);
            this.DG_TIPOHAB.TabIndex = 53;
            this.DG_TIPOHAB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TIPOHAB_CellClick);
            this.DG_TIPOHAB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TIPOHAB_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Akira Expanded", 30F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(86, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 52);
            this.label10.TabIndex = 55;
            this.label10.Text = "HOTEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Akira Expanded", 30F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(810, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 52);
            this.label5.TabIndex = 56;
            this.label5.Text = "TIPO HAB.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(834, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Monto del hospedaje:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(834, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Anticipo ingresado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(834, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Saldo por liquidar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Akira Expanded", 30F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(86, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(313, 52);
            this.label13.TabIndex = 60;
            this.label13.Text = "CLIENTE";
            // 
            // CB_BUSQ
            // 
            this.CB_BUSQ.FormattingEnabled = true;
            this.CB_BUSQ.Location = new System.Drawing.Point(557, 29);
            this.CB_BUSQ.Name = "CB_BUSQ";
            this.CB_BUSQ.Size = new System.Drawing.Size(121, 24);
            this.CB_BUSQ.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1000, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "label";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(985, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 63;
            this.label15.Text = "label";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(980, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 64;
            this.label16.Text = "label";
            this.label16.Visible = false;
            // 
            // BTN_CLS
            // 
            this.BTN_CLS.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLS.Location = new System.Drawing.Point(1140, 642);
            this.BTN_CLS.Name = "BTN_CLS";
            this.BTN_CLS.Size = new System.Drawing.Size(133, 37);
            this.BTN_CLS.TabIndex = 65;
            this.BTN_CLS.Text = "LIMPIAR";
            this.BTN_CLS.UseVisualStyleBackColor = true;
            // 
            // RESERVACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 691);
            this.Controls.Add(this.BTN_CLS);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CB_BUSQ);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DG_CAR);
            this.Controls.Add(this.DG_TIPOHAB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTN_RSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_ANTICIPO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTP_SALIDA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTP_ENTRADA);
            this.Controls.Add(this.NUD_CANTPER);
            this.Controls.Add(this.NUD_CANTHAB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DG_HOTELES);
            this.Controls.Add(this.DG_CLIENTES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_CD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_BUSQ);
            this.Name = "RESERVACIONES";
            this.Text = "RESERVACIONES";
            this.Load += new System.EventHandler(this.RESERVACIONES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_CLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_HOTELES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CANTHAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CANTPER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_CAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TIPOHAB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_BUSQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_CD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_CLIENTES;
        private System.Windows.Forms.DataGridView DG_HOTELES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_CANTHAB;
        private System.Windows.Forms.NumericUpDown NUD_CANTPER;
        private System.Windows.Forms.DateTimePicker DTP_ENTRADA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_SALIDA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_ANTICIPO;
        private System.Windows.Forms.Button BTN_RSV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DG_CAR;
        private System.Windows.Forms.DataGridView DG_TIPOHAB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CB_BUSQ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BTN_CLS;
    }
}
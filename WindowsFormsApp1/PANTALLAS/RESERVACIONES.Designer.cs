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
            this.lbCost = new System.Windows.Forms.Label();
            this.lbFSal = new System.Windows.Forms.Label();
            this.lbMiss = new System.Windows.Forms.Label();
            this.BTN_CLS = new System.Windows.Forms.Button();
            this.BTN_CLF = new System.Windows.Forms.Button();
            this.lbFEn = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbTipoHab = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbCantHab = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbHotel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbIVA = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.lbCostFin = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.TB_BUSQ.TextChanged += new System.EventHandler(this.TB_BUSQ_TextChanged);
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
            this.CB_CD.Location = new System.Drawing.Point(427, 309);
            this.CB_CD.Name = "CB_CD";
            this.CB_CD.Size = new System.Drawing.Size(121, 24);
            this.CB_CD.TabIndex = 2;
            this.CB_CD.SelectedIndexChanged += new System.EventHandler(this.CB_CD_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudad:";
            // 
            // DG_CLIENTES
            // 
            this.DG_CLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DG_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CLIENTES.Location = new System.Drawing.Point(95, 91);
            this.DG_CLIENTES.Name = "DG_CLIENTES";
            this.DG_CLIENTES.RowHeadersWidth = 51;
            this.DG_CLIENTES.RowTemplate.Height = 24;
            this.DG_CLIENTES.Size = new System.Drawing.Size(583, 169);
            this.DG_CLIENTES.TabIndex = 4;
            this.DG_CLIENTES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CLIENTES_CellContentClick);
            this.DG_CLIENTES.SelectionChanged += new System.EventHandler(this.DG_CLIENTES_SelectionChanged);
            // 
            // DG_HOTELES
            // 
            this.DG_HOTELES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DG_HOTELES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_HOTELES.Location = new System.Drawing.Point(95, 344);
            this.DG_HOTELES.Name = "DG_HOTELES";
            this.DG_HOTELES.RowHeadersWidth = 51;
            this.DG_HOTELES.RowTemplate.Height = 24;
            this.DG_HOTELES.Size = new System.Drawing.Size(674, 174);
            this.DG_HOTELES.TabIndex = 5;
            this.DG_HOTELES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_HOTELES_CellClick);
            this.DG_HOTELES.SelectionChanged += new System.EventHandler(this.DG_HOTELES_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de habitaciones:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad de personas:";
            // 
            // NUD_CANTHAB
            // 
            this.NUD_CANTHAB.Location = new System.Drawing.Point(91, 617);
            this.NUD_CANTHAB.Name = "NUD_CANTHAB";
            this.NUD_CANTHAB.Size = new System.Drawing.Size(120, 22);
            this.NUD_CANTHAB.TabIndex = 12;
            this.NUD_CANTHAB.ValueChanged += new System.EventHandler(this.NUD_CANTHAB_ValueChanged);
            // 
            // NUD_CANTPER
            // 
            this.NUD_CANTPER.Location = new System.Drawing.Point(91, 562);
            this.NUD_CANTPER.Name = "NUD_CANTPER";
            this.NUD_CANTPER.Size = new System.Drawing.Size(120, 22);
            this.NUD_CANTPER.TabIndex = 13;
            this.NUD_CANTPER.ValueChanged += new System.EventHandler(this.NUD_CANTPER_ValueChanged);
            // 
            // DTP_ENTRADA
            // 
            this.DTP_ENTRADA.Location = new System.Drawing.Point(415, 592);
            this.DTP_ENTRADA.Name = "DTP_ENTRADA";
            this.DTP_ENTRADA.Size = new System.Drawing.Size(200, 22);
            this.DTP_ENTRADA.TabIndex = 14;
            this.DTP_ENTRADA.ValueChanged += new System.EventHandler(this.DTP_ENTRADA_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Entrada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salida";
            // 
            // DTP_SALIDA
            // 
            this.DTP_SALIDA.Location = new System.Drawing.Point(415, 642);
            this.DTP_SALIDA.Name = "DTP_SALIDA";
            this.DTP_SALIDA.Size = new System.Drawing.Size(200, 22);
            this.DTP_SALIDA.TabIndex = 16;
            this.DTP_SALIDA.ValueChanged += new System.EventHandler(this.DTP_SALIDA_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Anticipo:";
            // 
            // TB_ANTICIPO
            // 
            this.TB_ANTICIPO.Location = new System.Drawing.Point(91, 669);
            this.TB_ANTICIPO.Name = "TB_ANTICIPO";
            this.TB_ANTICIPO.Size = new System.Drawing.Size(181, 22);
            this.TB_ANTICIPO.TabIndex = 18;
            this.TB_ANTICIPO.TextChanged += new System.EventHandler(this.TB_ANTICIPO_TextChanged);
            // 
            // BTN_RSV
            // 
            this.BTN_RSV.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RSV.Location = new System.Drawing.Point(1279, 687);
            this.BTN_RSV.Name = "BTN_RSV";
            this.BTN_RSV.Size = new System.Drawing.Size(133, 37);
            this.BTN_RSV.TabIndex = 20;
            this.BTN_RSV.Text = "RESERVAR";
            this.BTN_RSV.UseVisualStyleBackColor = true;
            this.BTN_RSV.Click += new System.EventHandler(this.BTN_RSV_Click);
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
            this.DG_CAR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DG_CAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_CAR.Location = new System.Drawing.Point(810, 530);
            this.DG_CAR.Name = "DG_CAR";
            this.DG_CAR.RowHeadersWidth = 51;
            this.DG_CAR.RowTemplate.Height = 24;
            this.DG_CAR.Size = new System.Drawing.Size(300, 182);
            this.DG_CAR.TabIndex = 54;
            // 
            // DG_TIPOHAB
            // 
            this.DG_TIPOHAB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DG_TIPOHAB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TIPOHAB.Location = new System.Drawing.Point(810, 344);
            this.DG_TIPOHAB.Name = "DG_TIPOHAB";
            this.DG_TIPOHAB.RowHeadersWidth = 51;
            this.DG_TIPOHAB.RowTemplate.Height = 24;
            this.DG_TIPOHAB.Size = new System.Drawing.Size(533, 174);
            this.DG_TIPOHAB.TabIndex = 53;
            this.DG_TIPOHAB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TIPOHAB_CellClick);
            this.DG_TIPOHAB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_TIPOHAB_CellContentClick);
            this.DG_TIPOHAB.SelectionChanged += new System.EventHandler(this.DG_TIPOHAB_SelectionChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Akira Expanded", 30F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(86, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 52);
            this.label10.TabIndex = 55;
            this.label10.Text = "HOTEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Akira Expanded", 30F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(810, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 52);
            this.label5.TabIndex = 56;
            this.label5.Text = "TIPO HAB.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(819, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Monto del hospedaje:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(819, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Salida:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(819, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
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
            this.CB_BUSQ.SelectedIndexChanged += new System.EventHandler(this.CB_BUSQ_SelectedIndexChanged);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(1044, 153);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(40, 20);
            this.lbCost.TabIndex = 62;
            this.lbCost.Text = "label";
            this.lbCost.Visible = false;
            // 
            // lbFSal
            // 
            this.lbFSal.AutoSize = true;
            this.lbFSal.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFSal.Location = new System.Drawing.Point(1044, 129);
            this.lbFSal.Name = "lbFSal";
            this.lbFSal.Size = new System.Drawing.Size(40, 20);
            this.lbFSal.TabIndex = 63;
            this.lbFSal.Text = "label";
            this.lbFSal.Visible = false;
            // 
            // lbMiss
            // 
            this.lbMiss.AutoSize = true;
            this.lbMiss.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiss.Location = new System.Drawing.Point(1044, 201);
            this.lbMiss.Name = "lbMiss";
            this.lbMiss.Size = new System.Drawing.Size(40, 20);
            this.lbMiss.TabIndex = 64;
            this.lbMiss.Text = "label";
            this.lbMiss.Visible = false;
            // 
            // BTN_CLS
            // 
            this.BTN_CLS.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLS.Location = new System.Drawing.Point(1140, 687);
            this.BTN_CLS.Name = "BTN_CLS";
            this.BTN_CLS.Size = new System.Drawing.Size(133, 37);
            this.BTN_CLS.TabIndex = 65;
            this.BTN_CLS.Text = "LIMPIAR";
            this.BTN_CLS.UseVisualStyleBackColor = true;
            this.BTN_CLS.Click += new System.EventHandler(this.BTN_CLS_Click);
            // 
            // BTN_CLF
            // 
            this.BTN_CLF.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLF.Location = new System.Drawing.Point(557, 303);
            this.BTN_CLF.Name = "BTN_CLF";
            this.BTN_CLF.Size = new System.Drawing.Size(78, 37);
            this.BTN_CLF.TabIndex = 66;
            this.BTN_CLF.Text = "LIMPIAR";
            this.BTN_CLF.UseVisualStyleBackColor = true;
            this.BTN_CLF.Click += new System.EventHandler(this.BTN_CLF_Click);
            // 
            // lbFEn
            // 
            this.lbFEn.AutoSize = true;
            this.lbFEn.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFEn.Location = new System.Drawing.Point(1044, 105);
            this.lbFEn.Name = "lbFEn";
            this.lbFEn.Size = new System.Drawing.Size(40, 20);
            this.lbFEn.TabIndex = 68;
            this.lbFEn.Text = "label";
            this.lbFEn.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(819, 105);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 20);
            this.label18.TabIndex = 67;
            this.label18.Text = "Entrada:";
            // 
            // lbTipoHab
            // 
            this.lbTipoHab.AutoSize = true;
            this.lbTipoHab.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoHab.Location = new System.Drawing.Point(1044, 57);
            this.lbTipoHab.Name = "lbTipoHab";
            this.lbTipoHab.Size = new System.Drawing.Size(40, 20);
            this.lbTipoHab.TabIndex = 70;
            this.lbTipoHab.Text = "label";
            this.lbTipoHab.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(819, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 20);
            this.label20.TabIndex = 69;
            this.label20.Text = "Tipo de habitación:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // lbCantHab
            // 
            this.lbCantHab.AutoSize = true;
            this.lbCantHab.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantHab.Location = new System.Drawing.Point(1044, 81);
            this.lbCantHab.Name = "lbCantHab";
            this.lbCantHab.Size = new System.Drawing.Size(40, 20);
            this.lbCantHab.TabIndex = 72;
            this.lbCantHab.Text = "label";
            this.lbCantHab.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(819, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(187, 20);
            this.label22.TabIndex = 71;
            this.label22.Text = "Cantidad de habitaciones:";
            // 
            // lbHotel
            // 
            this.lbHotel.AutoSize = true;
            this.lbHotel.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHotel.Location = new System.Drawing.Point(1044, 33);
            this.lbHotel.Name = "lbHotel";
            this.lbHotel.Size = new System.Drawing.Size(40, 20);
            this.lbHotel.TabIndex = 74;
            this.lbHotel.Text = "label";
            this.lbHotel.Visible = false;
            this.lbHotel.Click += new System.EventHandler(this.lbHotel_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(819, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 20);
            this.label23.TabIndex = 73;
            this.label23.Text = "Hotel:";
            // 
            // lbIVA
            // 
            this.lbIVA.AutoSize = true;
            this.lbIVA.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIVA.Location = new System.Drawing.Point(1044, 177);
            this.lbIVA.Name = "lbIVA";
            this.lbIVA.Size = new System.Drawing.Size(40, 20);
            this.lbIVA.TabIndex = 76;
            this.lbIVA.Text = "label";
            this.lbIVA.Visible = false;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(819, 177);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(35, 20);
            this.label100.TabIndex = 75;
            this.label100.Text = "IVA:";
            // 
            // lbCostFin
            // 
            this.lbCostFin.AutoSize = true;
            this.lbCostFin.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostFin.Location = new System.Drawing.Point(1002, 240);
            this.lbCostFin.Name = "lbCostFin";
            this.lbCostFin.Size = new System.Drawing.Size(40, 20);
            this.lbCostFin.TabIndex = 78;
            this.lbCostFin.Text = "label";
            this.lbCostFin.Visible = false;
            this.lbCostFin.Click += new System.EventHandler(this.lbCostFin_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(889, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 20);
            this.label15.TabIndex = 77;
            this.label15.Text = "COSTO FINAL:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // RESERVACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 744);
            this.Controls.Add(this.lbCostFin);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbIVA);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.lbHotel);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lbCantHab);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbTipoHab);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lbFEn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BTN_CLF);
            this.Controls.Add(this.BTN_CLS);
            this.Controls.Add(this.lbMiss);
            this.Controls.Add(this.lbFSal);
            this.Controls.Add(this.lbCost);
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
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbFSal;
        private System.Windows.Forms.Label lbMiss;
        private System.Windows.Forms.Button BTN_CLS;
        private System.Windows.Forms.Button BTN_CLF;
        private System.Windows.Forms.Label lbFEn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbTipoHab;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbCantHab;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbHotel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbIVA;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label lbCostFin;
        private System.Windows.Forms.Label label15;
    }
}
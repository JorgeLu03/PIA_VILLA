namespace PIA_VILLA
{
    partial class LOGIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_USER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PSW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_OK = new System.Windows.Forms.Button();
            this.TB_BYE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // TB_USER
            // 
            this.TB_USER.Location = new System.Drawing.Point(199, 96);
            this.TB_USER.Name = "TB_USER";
            this.TB_USER.Size = new System.Drawing.Size(179, 22);
            this.TB_USER.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // TB_PSW
            // 
            this.TB_PSW.Location = new System.Drawing.Point(199, 152);
            this.TB_PSW.Name = "TB_PSW";
            this.TB_PSW.PasswordChar = '*';
            this.TB_PSW.Size = new System.Drawing.Size(179, 22);
            this.TB_PSW.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "BIENVENIDO";
            // 
            // TB_OK
            // 
            this.TB_OK.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_OK.Location = new System.Drawing.Point(91, 213);
            this.TB_OK.Name = "TB_OK";
            this.TB_OK.Size = new System.Drawing.Size(100, 38);
            this.TB_OK.TabIndex = 3;
            this.TB_OK.Text = "ACEPTAR";
            this.TB_OK.UseVisualStyleBackColor = true;
            this.TB_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_BYE
            // 
            this.TB_BYE.Font = new System.Drawing.Font("Montserrat Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_BYE.Location = new System.Drawing.Point(265, 213);
            this.TB_BYE.Name = "TB_BYE";
            this.TB_BYE.Size = new System.Drawing.Size(100, 38);
            this.TB_BYE.TabIndex = 4;
            this.TB_BYE.Text = "SALIR";
            this.TB_BYE.UseVisualStyleBackColor = true;
            this.TB_BYE.Click += new System.EventHandler(this.TB_BYE_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 282);
            this.Controls.Add(this.TB_BYE);
            this.Controls.Add(this.TB_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_PSW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_USER);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_USER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PSW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TB_OK;
        private System.Windows.Forms.Button TB_BYE;
    }
}


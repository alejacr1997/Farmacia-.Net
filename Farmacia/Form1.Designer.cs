namespace Farmacia
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.rdbEmsephar = new System.Windows.Forms.RadioButton();
            this.chkSecundaria = new System.Windows.Forms.CheckBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCemefar = new System.Windows.Forms.RadioButton();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.rdbCofarma = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.chkSecundaria);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.chkPrincipal);
            this.panel1.Controls.Add(this.txtMedicamento);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 454);
            this.panel1.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(86, 366);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(87, 33);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // rdbEmsephar
            // 
            this.rdbEmsephar.AutoSize = true;
            this.rdbEmsephar.Location = new System.Drawing.Point(3, 44);
            this.rdbEmsephar.Name = "rdbEmsephar";
            this.rdbEmsephar.Size = new System.Drawing.Size(90, 20);
            this.rdbEmsephar.TabIndex = 1;
            this.rdbEmsephar.TabStop = true;
            this.rdbEmsephar.Text = "Emsephar";
            this.rdbEmsephar.UseVisualStyleBackColor = true;
            // 
            // chkSecundaria
            // 
            this.chkSecundaria.AutoSize = true;
            this.chkSecundaria.Location = new System.Drawing.Point(289, 324);
            this.chkSecundaria.Name = "chkSecundaria";
            this.chkSecundaria.Size = new System.Drawing.Size(153, 20);
            this.chkSecundaria.TabIndex = 12;
            this.chkSecundaria.Text = "Sucursal Secundaria";
            this.chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(289, 298);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(136, 20);
            this.chkPrincipal.TabIndex = 10;
            this.chkPrincipal.Text = "Sucursal Principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCemefar);
            this.groupBox1.Controls.Add(this.rdbEmsephar);
            this.groupBox1.Controls.Add(this.rdbCofarma);
            this.groupBox1.Location = new System.Drawing.Point(289, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rdbCemefar
            // 
            this.rdbCemefar.AutoSize = true;
            this.rdbCemefar.Location = new System.Drawing.Point(3, 74);
            this.rdbCemefar.Name = "rdbCemefar";
            this.rdbCemefar.Size = new System.Drawing.Size(79, 20);
            this.rdbCemefar.TabIndex = 2;
            this.rdbCemefar.TabStop = true;
            this.rdbCemefar.Text = "Cemefar";
            this.rdbCemefar.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibióticos"});
            this.cmbTipo.Location = new System.Drawing.Point(289, 89);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 8;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(289, 48);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(100, 22);
            this.txtMedicamento.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(212, 366);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(95, 33);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(289, 138);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 9;
            // 
            // rdbCofarma
            // 
            this.rdbCofarma.AutoSize = true;
            this.rdbCofarma.Location = new System.Drawing.Point(3, 18);
            this.rdbCofarma.Name = "rdbCofarma";
            this.rdbCofarma.Size = new System.Drawing.Size(79, 20);
            this.rdbCofarma.TabIndex = 0;
            this.rdbCofarma.TabStop = true;
            this.rdbCofarma.Text = "Cofarma";
            this.rdbCofarma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Escriba el nombre del medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccione el tipo de medicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Escriba la cantidad de medicamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seleccione el distribuidor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Seleccione la sucursal de entrega";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCemefar;
        private System.Windows.Forms.RadioButton rdbEmsephar;
        private System.Windows.Forms.RadioButton rdbCofarma;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


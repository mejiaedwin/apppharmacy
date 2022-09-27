namespace App_Pharmacy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected  void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelcod = new System.Windows.Forms.Label();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelprod = new System.Windows.Forms.Label();
            this.labeldescrip = new System.Windows.Forms.Label();
            this.textBox1Valor = new System.Windows.Forms.TextBox();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcod
            // 
            this.labelcod.AutoSize = true;
            this.labelcod.Location = new System.Drawing.Point(58, 84);
            this.labelcod.Name = "labelcod";
            this.labelcod.Size = new System.Drawing.Size(46, 15);
            this.labelcod.TabIndex = 0;
            this.labelcod.Text = "Codigo";
            this.labelcod.UseMnemonic = false;
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Location = new System.Drawing.Point(151, 76);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.Size = new System.Drawing.Size(100, 23);
            this.textBoxcodigo.TabIndex = 1;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(58, 136);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(33, 15);
            this.labelValor.TabIndex = 2;
            this.labelValor.Text = "Valor";
            // 
            // labelprod
            // 
            this.labelprod.AutoSize = true;
            this.labelprod.Location = new System.Drawing.Point(58, 189);
            this.labelprod.Name = "labelprod";
            this.labelprod.Size = new System.Drawing.Size(56, 15);
            this.labelprod.TabIndex = 3;
            this.labelprod.Text = "Producto";
            // 
            // labeldescrip
            // 
            this.labeldescrip.AutoSize = true;
            this.labeldescrip.Location = new System.Drawing.Point(58, 238);
            this.labeldescrip.Name = "labeldescrip";
            this.labeldescrip.Size = new System.Drawing.Size(69, 15);
            this.labeldescrip.TabIndex = 4;
            this.labeldescrip.Text = "Descripción";
            // 
            // textBox1Valor
            // 
            this.textBox1Valor.Location = new System.Drawing.Point(151, 128);
            this.textBox1Valor.Name = "textBox1Valor";
            this.textBox1Valor.Size = new System.Drawing.Size(100, 23);
            this.textBox1Valor.TabIndex = 5;
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Location = new System.Drawing.Point(151, 181);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(194, 23);
            this.textBoxProducto.TabIndex = 6;
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Location = new System.Drawing.Point(151, 230);
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(194, 23);
            this.textBoxdescripcion.TabIndex = 7;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(58, 307);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(808, 476);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.textBoxProducto);
            this.Controls.Add(this.textBox1Valor);
            this.Controls.Add(this.labeldescrip);
            this.Controls.Add(this.labelprod);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.labelcod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelCodigo;
        private TextBox textBoxCod;
        private TextBox textBoxValor;
        private Label label1Valor;
        private Label labelProducto;
        private TextBox textBoxProd;
        private Label labelDescripcion;
        private TextBox textBox1;
        private Button btnGuardar;
        private Label labelcod;
        private TextBox textBoxcodigo;
        private Label labelValor;
        private Label labelprod;
        private Label labeldescrip;
        private TextBox textBox1Valor;
        private TextBox textBoxProducto;
        private TextBox textBoxdescripcion;
        private Button buttonGuardar;
    }
}
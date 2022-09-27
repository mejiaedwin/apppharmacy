using App_Pharmacy.CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Pharmacy
{
    public partial class App_Pharmacy : Form
    {
        BLLproducto objetoCN = new BLLproducto();
        public App_Pharmacy()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objetoCN.Create(int.Parse(textBoxcodigo.Text), float.Parse(textBoxvalor.Text), textBoxproducto.Text, textBoxdescripcion.Text);
            MessageBox.Show("Se guardo correctamente el producto");
            viewAllProducts();
        }

        private void viewAllProducts()
        {
            BLLproducto objeto = new BLLproducto();
            dataGridView1.DataSource = objeto.View();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewAllProducts();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objetoCN.Delete(int.Parse(textBoxcodigo.Text));
            MessageBox.Show("Se elimino correctamente el producto");
            viewAllProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objetoCN.Update(int.Parse(textBoxcodigo.Text), float.Parse(textBoxvalor.Text), textBoxproducto.Text, textBoxdescripcion.Text);
            MessageBox.Show("Se actualizo correctamente el producto");
            viewAllProducts();
        }

        private Button buttonGuardar;
        private Label labelcodigo;
        private Label labelvalor;
        private Label label3;
        private Label labeldescripcion;
        private TextBox textBoxcodigo;
        private TextBox textBoxvalor;
        private TextBox textBoxproducto;
        private TextBox textBoxdescripcion;
        private Label labelproducto;

        private void InitializeComponent()
        {
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.labelvalor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldescripcion = new System.Windows.Forms.Label();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.textBoxvalor = new System.Windows.Forms.TextBox();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.labelproducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(61, 265);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Location = new System.Drawing.Point(61, 74);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(46, 15);
            this.labelcodigo.TabIndex = 1;
            this.labelcodigo.Text = "Codigo";
            // 
            // labelvalor
            // 
            this.labelvalor.AutoSize = true;
            this.labelvalor.Location = new System.Drawing.Point(61, 125);
            this.labelvalor.Name = "labelvalor";
            this.labelvalor.Size = new System.Drawing.Size(33, 15);
            this.labelvalor.TabIndex = 2;
            this.labelvalor.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 3;
            // 
            // labeldescripcion
            // 
            this.labeldescripcion.AutoSize = true;
            this.labeldescripcion.Location = new System.Drawing.Point(61, 221);
            this.labeldescripcion.Name = "labeldescripcion";
            this.labeldescripcion.Size = new System.Drawing.Size(69, 15);
            this.labeldescripcion.TabIndex = 4;
            this.labeldescripcion.Text = "Descripción";
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Location = new System.Drawing.Point(181, 66);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.Size = new System.Drawing.Size(100, 23);
            this.textBoxcodigo.TabIndex = 5;
            // 
            // textBoxvalor
            // 
            this.textBoxvalor.Location = new System.Drawing.Point(181, 117);
            this.textBoxvalor.Name = "textBoxvalor";
            this.textBoxvalor.Size = new System.Drawing.Size(100, 23);
            this.textBoxvalor.TabIndex = 6;
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(181, 163);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(177, 23);
            this.textBoxproducto.TabIndex = 7;
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Location = new System.Drawing.Point(181, 213);
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(177, 23);
            this.textBoxdescripcion.TabIndex = 8;
            // 
            // labelproducto
            // 
            this.labelproducto.AutoSize = true;
            this.labelproducto.Location = new System.Drawing.Point(61, 171);
            this.labelproducto.Name = "labelproducto";
            this.labelproducto.Size = new System.Drawing.Size(56, 15);
            this.labelproducto.TabIndex = 9;
            this.labelproducto.Text = "Producto";
            // 
            // App_Pharmacy
            // 
            this.ClientSize = new System.Drawing.Size(738, 335);
            this.Controls.Add(this.labelproducto);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.textBoxvalor);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.labeldescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelvalor);
            this.Controls.Add(this.labelcodigo);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "App_Pharmacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
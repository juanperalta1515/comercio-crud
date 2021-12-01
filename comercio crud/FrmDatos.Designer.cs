
namespace comercio_crud
{
    partial class FrmDatos
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
            this.btproductos = new System.Windows.Forms.Button();
            this.btAgregarProd = new System.Windows.Forms.Button();
            this.btBaja = new System.Windows.Forms.Button();
            this.btaLeer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.producto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btproductos
            // 
            this.btproductos.Location = new System.Drawing.Point(0, 0);
            this.btproductos.Name = "btproductos";
            this.btproductos.Size = new System.Drawing.Size(75, 23);
            this.btproductos.TabIndex = 0;
            this.btproductos.Text = "crear tabla";
            this.btproductos.UseVisualStyleBackColor = true;
            this.btproductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAgregarProd
            // 
            this.btAgregarProd.Location = new System.Drawing.Point(110, 0);
            this.btAgregarProd.Name = "btAgregarProd";
            this.btAgregarProd.Size = new System.Drawing.Size(103, 23);
            this.btAgregarProd.TabIndex = 1;
            this.btAgregarProd.Text = "Agregar Producto";
            this.btAgregarProd.UseVisualStyleBackColor = true;
            this.btAgregarProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btBaja
            // 
            this.btBaja.AllowDrop = true;
            this.btBaja.Location = new System.Drawing.Point(241, 0);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(75, 23);
            this.btBaja.TabIndex = 2;
            this.btBaja.Text = "Grabar";
            this.btBaja.UseVisualStyleBackColor = true;
            this.btBaja.Click += new System.EventHandler(this.btBaja_Click);
            // 
            // btaLeer
            // 
            this.btaLeer.Location = new System.Drawing.Point(366, 0);
            this.btaLeer.Name = "btaLeer";
            this.btaLeer.Size = new System.Drawing.Size(75, 23);
            this.btaLeer.TabIndex = 3;
            this.btaLeer.Text = "Leer";
            this.btaLeer.UseVisualStyleBackColor = true;
            this.btaLeer.Click += new System.EventHandler(this.btagregarproducto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 250);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(392, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // producto
            // 
            this.producto.AutoSize = true;
            this.producto.Location = new System.Drawing.Point(406, 29);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(49, 13);
            this.producto.TabIndex = 8;
            this.producto.Text = "producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "codigo";
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btaLeer);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.btAgregarProd);
            this.Controls.Add(this.btproductos);
            this.Name = "FrmDatos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btproductos;
        private System.Windows.Forms.Button btAgregarProd;
        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Button btaLeer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


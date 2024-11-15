namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.siguiente = new System.Windows.Forms.Button();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(190, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENVIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre
            // 
            this.nombre.ForeColor = System.Drawing.Color.Gray;
            this.nombre.Location = new System.Drawing.Point(127, 102);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(209, 20);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Ingrese su nombre";
            this.nombre.Enter += new System.EventHandler(this.nombreEnter);
            this.nombre.Leave += new System.EventHandler(this.nombreLeave);
            // 
            // siguiente
            // 
            this.siguiente.AutoSize = true;
            this.siguiente.BackColor = System.Drawing.Color.LimeGreen;
            this.siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguiente.ForeColor = System.Drawing.Color.Transparent;
            this.siguiente.Location = new System.Drawing.Point(180, 266);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(106, 36);
            this.siguiente.TabIndex = 3;
            this.siguiente.Text = "SIGUIENTE";
            this.siguiente.UseVisualStyleBackColor = false;
            this.siguiente.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // direccion
            // 
            this.direccion.ForeColor = System.Drawing.Color.Gray;
            this.direccion.Location = new System.Drawing.Point(127, 159);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(209, 20);
            this.direccion.TabIndex = 5;
            this.direccion.Text = "Ingrese su direccion";
            this.direccion.Enter += new System.EventHandler(this.direccionEnter);
            this.direccion.Leave += new System.EventHandler(this.direccionLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Domiciliarios";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pedido
            // 
            this.pedido.ForeColor = System.Drawing.Color.Gray;
            this.pedido.Location = new System.Drawing.Point(127, 220);
            this.pedido.Name = "pedido";
            this.pedido.Size = new System.Drawing.Size(209, 20);
            this.pedido.TabIndex = 8;
            this.pedido.Text = "Ingrese su pedido";
            this.pedido.Enter += new System.EventHandler(this.pedidoEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pedido:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(477, 383);
            this.Controls.Add(this.pedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pedido;
        private System.Windows.Forms.Label label4;
    }
}


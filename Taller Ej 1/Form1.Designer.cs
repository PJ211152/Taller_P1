namespace Taller_Ej_1
{
    partial class Cuadratica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuadratica));
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Indicacion = new System.Windows.Forms.Label();
            this.txb_a = new System.Windows.Forms.TextBox();
            this.txb_x1 = new System.Windows.Forms.TextBox();
            this.txb_x2 = new System.Windows.Forms.TextBox();
            this.txb_c = new System.Windows.Forms.TextBox();
            this.txb_b = new System.Windows.Forms.TextBox();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.lbl_x2 = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(236, 294);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Indicacion
            // 
            this.lbl_Indicacion.AutoSize = true;
            this.lbl_Indicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Indicacion.Location = new System.Drawing.Point(12, 9);
            this.lbl_Indicacion.Name = "lbl_Indicacion";
            this.lbl_Indicacion.Size = new System.Drawing.Size(530, 24);
            this.lbl_Indicacion.TabIndex = 1;
            this.lbl_Indicacion.Text = "Ingrese los valores de a, b y c para calcular sus puntos criticos";
            // 
            // txb_a
            // 
            this.txb_a.Location = new System.Drawing.Point(128, 109);
            this.txb_a.Name = "txb_a";
            this.txb_a.Size = new System.Drawing.Size(100, 20);
            this.txb_a.TabIndex = 2;
            // 
            // txb_x1
            // 
            this.txb_x1.Location = new System.Drawing.Point(386, 140);
            this.txb_x1.Name = "txb_x1";
            this.txb_x1.ReadOnly = true;
            this.txb_x1.Size = new System.Drawing.Size(100, 20);
            this.txb_x1.TabIndex = 3;
            // 
            // txb_x2
            // 
            this.txb_x2.Location = new System.Drawing.Point(386, 166);
            this.txb_x2.Name = "txb_x2";
            this.txb_x2.ReadOnly = true;
            this.txb_x2.Size = new System.Drawing.Size(100, 20);
            this.txb_x2.TabIndex = 4;
            // 
            // txb_c
            // 
            this.txb_c.Location = new System.Drawing.Point(128, 184);
            this.txb_c.Name = "txb_c";
            this.txb_c.Size = new System.Drawing.Size(100, 20);
            this.txb_c.TabIndex = 5;
            // 
            // txb_b
            // 
            this.txb_b.Location = new System.Drawing.Point(128, 145);
            this.txb_b.Name = "txb_b";
            this.txb_b.Size = new System.Drawing.Size(100, 20);
            this.txb_b.TabIndex = 6;
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Location = new System.Drawing.Point(337, 143);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(26, 13);
            this.lbl_x1.TabIndex = 7;
            this.lbl_x1.Text = "X1=";
            // 
            // lbl_x2
            // 
            this.lbl_x2.AutoSize = true;
            this.lbl_x2.Location = new System.Drawing.Point(337, 169);
            this.lbl_x2.Name = "lbl_x2";
            this.lbl_x2.Size = new System.Drawing.Size(26, 13);
            this.lbl_x2.TabIndex = 8;
            this.lbl_x2.Text = "X2=";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(77, 109);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(20, 24);
            this.lbl_a.TabIndex = 9;
            this.lbl_a.Text = "a";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b.Location = new System.Drawing.Point(77, 145);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(21, 24);
            this.lbl_b.TabIndex = 10;
            this.lbl_b.Text = "b";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c.Location = new System.Drawing.Point(77, 180);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(20, 24);
            this.lbl_c.TabIndex = 11;
            this.lbl_c.Text = "c";
            // 
            // Cuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(555, 329);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_x2);
            this.Controls.Add(this.lbl_x1);
            this.Controls.Add(this.txb_b);
            this.Controls.Add(this.txb_c);
            this.Controls.Add(this.txb_x2);
            this.Controls.Add(this.txb_x1);
            this.Controls.Add(this.txb_a);
            this.Controls.Add(this.lbl_Indicacion);
            this.Controls.Add(this.btn_Calcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cuadratica";
            this.Text = "Ecuación Cuadratica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Indicacion;
        private System.Windows.Forms.TextBox txb_a;
        private System.Windows.Forms.TextBox txb_x1;
        private System.Windows.Forms.TextBox txb_x2;
        private System.Windows.Forms.TextBox txb_c;
        private System.Windows.Forms.TextBox txb_b;
        private System.Windows.Forms.Label lbl_x1;
        private System.Windows.Forms.Label lbl_x2;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_c;
    }
}


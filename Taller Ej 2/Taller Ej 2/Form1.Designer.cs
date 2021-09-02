namespace Taller_Ej_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btb_limpiar_lista = new System.Windows.Forms.Button();
            this.lsb_Votos = new System.Windows.Forms.ListBox();
            this.txb_votos = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lsb_Recuento = new System.Windows.Forms.ListBox();
            this.lbl_recuento = new System.Windows.Forms.Label();
            this.lbl_voto = new System.Windows.Forms.Label();
            this.btn_contar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btb_limpiar_lista
            // 
            this.btb_limpiar_lista.Location = new System.Drawing.Point(35, 279);
            this.btb_limpiar_lista.Name = "btb_limpiar_lista";
            this.btb_limpiar_lista.Size = new System.Drawing.Size(75, 23);
            this.btb_limpiar_lista.TabIndex = 0;
            this.btb_limpiar_lista.Text = "Limpiar";
            this.btb_limpiar_lista.UseVisualStyleBackColor = true;
            this.btb_limpiar_lista.Click += new System.EventHandler(this.btb_limpiar_lista_Click);
            // 
            // lsb_Votos
            // 
            this.lsb_Votos.FormattingEnabled = true;
            this.lsb_Votos.Location = new System.Drawing.Point(12, 48);
            this.lsb_Votos.Name = "lsb_Votos";
            this.lsb_Votos.Size = new System.Drawing.Size(120, 225);
            this.lsb_Votos.TabIndex = 1;
            this.lsb_Votos.SelectedIndexChanged += new System.EventHandler(this.lsb_Votos_SelectedIndexChanged);
            // 
            // txb_votos
            // 
            this.txb_votos.Location = new System.Drawing.Point(342, 19);
            this.txb_votos.Name = "txb_votos";
            this.txb_votos.Size = new System.Drawing.Size(100, 20);
            this.txb_votos.TabIndex = 2;
            this.txb_votos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txb_votos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(448, 19);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 20);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lsb_Recuento
            // 
            this.lsb_Recuento.FormattingEnabled = true;
            this.lsb_Recuento.Location = new System.Drawing.Point(222, 87);
            this.lsb_Recuento.Name = "lsb_Recuento";
            this.lsb_Recuento.Size = new System.Drawing.Size(295, 186);
            this.lsb_Recuento.TabIndex = 4;
            this.lsb_Recuento.SelectedIndexChanged += new System.EventHandler(this.lsb_Recuento_SelectedIndexChanged);
            // 
            // lbl_recuento
            // 
            this.lbl_recuento.AutoSize = true;
            this.lbl_recuento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_recuento.Location = new System.Drawing.Point(222, 68);
            this.lbl_recuento.Name = "lbl_recuento";
            this.lbl_recuento.Size = new System.Drawing.Size(81, 13);
            this.lbl_recuento.TabIndex = 5;
            this.lbl_recuento.Text = "Recuento Total";
            this.lbl_recuento.Click += new System.EventHandler(this.lbl_recuento_Click);
            // 
            // lbl_voto
            // 
            this.lbl_voto.AutoSize = true;
            this.lbl_voto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_voto.Location = new System.Drawing.Point(219, 22);
            this.lbl_voto.Name = "lbl_voto";
            this.lbl_voto.Size = new System.Drawing.Size(117, 13);
            this.lbl_voto.TabIndex = 6;
            this.lbl_voto.Text = "Voto para el candidato:";
            // 
            // btn_contar
            // 
            this.btn_contar.Location = new System.Drawing.Point(331, 279);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(75, 23);
            this.btn_contar.TabIndex = 7;
            this.btn_contar.Text = "Contar votos";
            this.btn_contar.UseVisualStyleBackColor = true;
            this.btn_contar.Click += new System.EventHandler(this.btn_contar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(591, 333);
            this.Controls.Add(this.btn_contar);
            this.Controls.Add(this.lbl_voto);
            this.Controls.Add(this.lbl_recuento);
            this.Controls.Add(this.lsb_Recuento);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txb_votos);
            this.Controls.Add(this.lsb_Votos);
            this.Controls.Add(this.btb_limpiar_lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conteo de Votos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btb_limpiar_lista;
        private System.Windows.Forms.ListBox lsb_Votos;
        private System.Windows.Forms.TextBox txb_votos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ListBox lsb_Recuento;
        private System.Windows.Forms.Label lbl_recuento;
        private System.Windows.Forms.Label lbl_voto;
        private System.Windows.Forms.Button btn_contar;
    }
}


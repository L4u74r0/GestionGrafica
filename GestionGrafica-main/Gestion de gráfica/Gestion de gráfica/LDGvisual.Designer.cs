namespace Gestion_de_gráfica
{
    partial class LDGvisual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDGvisual));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pnlCajaSubmenu = new System.Windows.Forms.Panel();
            this.btnPrecios = new System.Windows.Forms.Button();
            this.btnPendiente = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.pnlGrafSubmenu = new System.Windows.Forms.Panel();
            this.btnProceso = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnTrabajos = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.pnlCajaSubmenu.SuspendLayout();
            this.pnlGrafSubmenu.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSideMenu.Controls.Add(this.pnlCajaSubmenu);
            this.panelSideMenu.Controls.Add(this.btnAdm);
            this.panelSideMenu.Controls.Add(this.pnlGrafSubmenu);
            this.panelSideMenu.Controls.Add(this.btnTrabajos);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(157, 550);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // pnlCajaSubmenu
            // 
            this.pnlCajaSubmenu.Controls.Add(this.btnPrecios);
            this.pnlCajaSubmenu.Controls.Add(this.btnPendiente);
            this.pnlCajaSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCajaSubmenu.Location = new System.Drawing.Point(0, 140);
            this.pnlCajaSubmenu.Name = "pnlCajaSubmenu";
            this.pnlCajaSubmenu.Size = new System.Drawing.Size(157, 70);
            this.pnlCajaSubmenu.TabIndex = 6;
            // 
            // btnPrecios
            // 
            this.btnPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPrecios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrecios.FlatAppearance.BorderSize = 0;
            this.btnPrecios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPrecios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecios.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecios.ForeColor = System.Drawing.Color.MintCream;
            this.btnPrecios.Location = new System.Drawing.Point(0, 35);
            this.btnPrecios.Name = "btnPrecios";
            this.btnPrecios.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPrecios.Size = new System.Drawing.Size(157, 35);
            this.btnPrecios.TabIndex = 8;
            this.btnPrecios.Text = "Precios";
            this.btnPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecios.UseVisualStyleBackColor = false;
            this.btnPrecios.Click += new System.EventHandler(this.btnPrecios_Click);
            // 
            // btnPendiente
            // 
            this.btnPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPendiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendiente.FlatAppearance.BorderSize = 0;
            this.btnPendiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPendiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendiente.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendiente.ForeColor = System.Drawing.Color.MintCream;
            this.btnPendiente.Location = new System.Drawing.Point(0, 0);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPendiente.Size = new System.Drawing.Size(157, 35);
            this.btnPendiente.TabIndex = 7;
            this.btnPendiente.Text = "Pago pendiente";
            this.btnPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendiente.UseVisualStyleBackColor = false;
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.Crimson;
            this.btnAdm.Location = new System.Drawing.Point(0, 105);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAdm.Size = new System.Drawing.Size(157, 35);
            this.btnAdm.TabIndex = 5;
            this.btnAdm.Text = "ADMINISTRACION";
            this.btnAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // pnlGrafSubmenu
            // 
            this.pnlGrafSubmenu.Controls.Add(this.btnProceso);
            this.pnlGrafSubmenu.Controls.Add(this.btnRegistro);
            this.pnlGrafSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGrafSubmenu.Location = new System.Drawing.Point(0, 35);
            this.pnlGrafSubmenu.Name = "pnlGrafSubmenu";
            this.pnlGrafSubmenu.Size = new System.Drawing.Size(157, 70);
            this.pnlGrafSubmenu.TabIndex = 4;
            // 
            // btnProceso
            // 
            this.btnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProceso.FlatAppearance.BorderSize = 0;
            this.btnProceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceso.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceso.ForeColor = System.Drawing.Color.MintCream;
            this.btnProceso.Location = new System.Drawing.Point(0, 35);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProceso.Size = new System.Drawing.Size(157, 35);
            this.btnProceso.TabIndex = 4;
            this.btnProceso.Text = "En proceso";
            this.btnProceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceso.UseVisualStyleBackColor = false;
            this.btnProceso.Click += new System.EventHandler(this.btnProceso_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.MintCream;
            this.btnRegistro.Location = new System.Drawing.Point(0, 0);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRegistro.Size = new System.Drawing.Size(157, 35);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnConfirmado_Click);
            // 
            // btnTrabajos
            // 
            this.btnTrabajos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajos.FlatAppearance.BorderSize = 0;
            this.btnTrabajos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajos.ForeColor = System.Drawing.Color.Crimson;
            this.btnTrabajos.Location = new System.Drawing.Point(0, 0);
            this.btnTrabajos.Name = "btnTrabajos";
            this.btnTrabajos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTrabajos.Size = new System.Drawing.Size(157, 35);
            this.btnTrabajos.TabIndex = 3;
            this.btnTrabajos.Text = "TRABAJOS";
            this.btnTrabajos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajos.UseVisualStyleBackColor = true;
            this.btnTrabajos.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(157, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(693, 550);
            this.pnlContenedor.TabIndex = 1;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::Gestion_de_gráfica.Properties.Resources.LDGVisual_Negro;
            this.pictureBox1.Location = new System.Drawing.Point(149, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LDGvisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "LDGvisual";
            this.Text = "LDGvisual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.pnlCajaSubmenu.ResumeLayout(false);
            this.pnlGrafSubmenu.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnTrabajos;
        private System.Windows.Forms.Panel pnlGrafSubmenu;
        private System.Windows.Forms.Button btnProceso;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel pnlCajaSubmenu;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrecios;
        private System.Windows.Forms.Button btnPendiente;
    }
}


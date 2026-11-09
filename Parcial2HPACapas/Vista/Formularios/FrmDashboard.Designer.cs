namespace Parcial2HPACapas.Vista.Formularios
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codigo generado por el Disenador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblSesionTitulo = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlReloj = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.pnlLateral.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlReloj.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlLateral
            //
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.pnlLateral.Controls.Add(this.btnPedidos);
            this.pnlLateral.Controls.Add(this.btnInicio);
            this.pnlLateral.Controls.Add(this.lblLogo);
            this.pnlLateral.Controls.Add(this.btnCerrarSesion);
            this.pnlLateral.Controls.Add(this.pnlUsuario);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(230, 620);
            this.pnlLateral.TabIndex = 0;
            //
            // pnlUsuario
            //
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.pnlUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlUsuario.Controls.Add(this.lblSesionTitulo);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 530);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Padding = new System.Windows.Forms.Padding(14, 8, 10, 8);
            this.pnlUsuario.Size = new System.Drawing.Size(230, 90);
            this.pnlUsuario.TabIndex = 0;
            //
            // lblRolUsuario
            //
            this.lblRolUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRolUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRolUsuario.Location = new System.Drawing.Point(14, 52);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(206, 18);
            this.lblRolUsuario.TabIndex = 2;
            this.lblRolUsuario.Text = "Rol";
            //
            // lblNombreUsuario
            //
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(14, 28);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(206, 24);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            //
            // lblSesionTitulo
            //
            this.lblSesionTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSesionTitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSesionTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.lblSesionTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblSesionTitulo.Name = "lblSesionTitulo";
            this.lblSesionTitulo.Size = new System.Drawing.Size(206, 20);
            this.lblSesionTitulo.TabIndex = 0;
            this.lblSesionTitulo.Text = "SESION INICIADA:";
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 485);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(230, 45);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "   Cerrar sesion";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // btnPedidos
            //
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Location = new System.Drawing.Point(0, 128);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(230, 48);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "   Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            //
            // btnInicio
            //
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(0, 80);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(230, 48);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            //
            // lblLogo
            //
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(230, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "PARCIAL II\r\nHPA III (.NET)";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlSuperior
            //
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.lblTituloModulo);
            this.pnlSuperior.Controls.Add(this.pnlReloj);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(230, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(770, 64);
            this.pnlSuperior.TabIndex = 1;
            //
            // pnlReloj
            //
            this.pnlReloj.Controls.Add(this.lblFecha);
            this.pnlReloj.Controls.Add(this.lblReloj);
            this.pnlReloj.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReloj.Location = new System.Drawing.Point(480, 0);
            this.pnlReloj.Name = "pnlReloj";
            this.pnlReloj.Padding = new System.Windows.Forms.Padding(0, 6, 16, 6);
            this.pnlReloj.Size = new System.Drawing.Size(290, 64);
            this.pnlReloj.TabIndex = 1;
            //
            // lblReloj
            //
            this.lblReloj.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReloj.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblReloj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.lblReloj.Location = new System.Drawing.Point(0, 6);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(274, 36);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "00:00:00";
            this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblFecha
            //
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFecha.Location = new System.Drawing.Point(0, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(274, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblTituloModulo
            //
            this.lblTituloModulo.AutoSize = true;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.lblTituloModulo.Location = new System.Drawing.Point(18, 16);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(70, 28);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Text = "Inicio";
            //
            // timerReloj
            //
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            //
            // FrmDashboard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlLateral);
            this.IsMdiContainer = true;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal - Parcial II HPA III (.NET)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlReloj.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblSesionTitulo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Panel pnlReloj;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timerReloj;
    }
}

namespace Parcial2HPACapas.Vista.Formularios
{
    partial class FrmLogin
    {
        /// <summary>Componentes del disenador.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Libera los recursos del formulario.</summary>
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
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.lblMarcaSub = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.pnlMarca.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMarca
            //
            this.pnlMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.pnlMarca.Controls.Add(this.lblMarcaSub);
            this.pnlMarca.Controls.Add(this.lblMarca);
            this.pnlMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(300, 500);
            this.pnlMarca.TabIndex = 0;
            //
            // lblMarca
            //
            this.lblMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(0, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(300, 460);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "PARCIAL II\r\nHPA III (.NET)";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblMarcaSub
            //
            this.lblMarcaSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMarcaSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMarcaSub.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMarcaSub.Location = new System.Drawing.Point(0, 460);
            this.lblMarcaSub.Name = "lblMarcaSub";
            this.lblMarcaSub.Size = new System.Drawing.Size(300, 40);
            this.lblMarcaSub.TabIndex = 0;
            this.lblMarcaSub.Text = "Sistema de acceso";
            this.lblMarcaSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblEncabezado
            //
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.lblEncabezado.Location = new System.Drawing.Point(340, 45);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(165, 30);
            this.lblEncabezado.TabIndex = 1;
            this.lblEncabezado.Text = "Iniciar Sesion";
            //
            // lblCorreo
            //
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCorreo.Location = new System.Drawing.Point(342, 110);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(130, 19);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo electronico:";
            //
            // txtCorreo
            //
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCorreo.Location = new System.Drawing.Point(345, 133);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(410, 27);
            this.txtCorreo.TabIndex = 0;
            //
            // lblContrasena
            //
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblContrasena.Location = new System.Drawing.Point(342, 180);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(86, 19);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contrasena:";
            //
            // txtContrasena
            //
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContrasena.Location = new System.Drawing.Point(345, 203);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(410, 27);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.UseSystemPasswordChar = true;
            //
            // chkMostrar
            //
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMostrar.Location = new System.Drawing.Point(345, 238);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(160, 19);
            this.chkMostrar.TabIndex = 2;
            this.chkMostrar.Text = "Mostrar contrasena";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMensaje.Location = new System.Drawing.Point(342, 268);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(413, 40);
            this.lblMensaje.TabIndex = 7;
            //
            // btnIngresar
            //
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(345, 315);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(410, 42);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // lblAyuda
            //
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblAyuda.ForeColor = System.Drawing.Color.Gray;
            this.lblAyuda.Location = new System.Drawing.Point(342, 375);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(413, 60);
            this.lblAyuda.TabIndex = 9;
            this.lblAyuda.Text = "Usuario de prueba: admin@utp.ac.pa  /  Admin123*";
            //
            // FrmLogin
            //
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.pnlMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion - Parcial II HPA III (.NET)";
            this.pnlMarca.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaSub;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblAyuda;
    }
}

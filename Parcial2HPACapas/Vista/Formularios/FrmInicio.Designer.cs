namespace Parcial2HPACapas.Vista.Formularios
{
    partial class FrmInicio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flpTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlContenidoGrid = new System.Windows.Forms.Panel();
            this.dgvUltimosPedidos = new System.Windows.Forms.DataGridView();
            this.pnlContenidoGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimosPedidos)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(900, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Resumen del sistema";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // flpTarjetas
            //
            this.flpTarjetas.AutoScroll = true;
            this.flpTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpTarjetas.Location = new System.Drawing.Point(0, 40);
            this.flpTarjetas.Name = "flpTarjetas";
            this.flpTarjetas.Padding = new System.Windows.Forms.Padding(8);
            this.flpTarjetas.Size = new System.Drawing.Size(900, 220);
            this.flpTarjetas.TabIndex = 1;
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 260);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblSubtitulo.Size = new System.Drawing.Size(900, 30);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Ultimos pedidos";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlContenidoGrid
            //
            this.pnlContenidoGrid.Controls.Add(this.dgvUltimosPedidos);
            this.pnlContenidoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenidoGrid.Location = new System.Drawing.Point(0, 290);
            this.pnlContenidoGrid.Name = "pnlContenidoGrid";
            this.pnlContenidoGrid.Padding = new System.Windows.Forms.Padding(14, 0, 14, 14);
            this.pnlContenidoGrid.Size = new System.Drawing.Size(900, 310);
            this.pnlContenidoGrid.TabIndex = 3;
            //
            // dgvUltimosPedidos
            //
            this.dgvUltimosPedidos.AllowUserToAddRows = false;
            this.dgvUltimosPedidos.AllowUserToDeleteRows = false;
            this.dgvUltimosPedidos.AllowUserToResizeRows = false;
            this.dgvUltimosPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUltimosPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvUltimosPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvUltimosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimosPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUltimosPedidos.Location = new System.Drawing.Point(14, 0);
            this.dgvUltimosPedidos.Name = "dgvUltimosPedidos";
            this.dgvUltimosPedidos.ReadOnly = true;
            this.dgvUltimosPedidos.RowHeadersVisible = false;
            this.dgvUltimosPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUltimosPedidos.Size = new System.Drawing.Size(872, 296);
            this.dgvUltimosPedidos.TabIndex = 0;
            //
            // FrmInicio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlContenidoGrid);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.flpTarjetas);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.pnlContenidoGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimosPedidos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpTarjetas;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlContenidoGrid;
        private System.Windows.Forms.DataGridView dgvUltimosPedidos;
    }
}

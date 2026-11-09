namespace Parcial2HPACapas.Vista.Formularios
{
    partial class FrmPedidos
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
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenidoGrid = new System.Windows.Forms.Panel();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlCabecera.SuspendLayout();
            this.pnlContenidoGrid.SuspendLayout();
            this.pnlPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            //
            // pnlCabecera
            //
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.pnlCabecera.Controls.Add(this.btnActualizar);
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.pnlCabecera.Size = new System.Drawing.Size(900, 50);
            this.pnlCabecera.TabIndex = 0;
            //
            // btnActualizar
            //
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(756, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 34);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.lblTitulo.Location = new System.Drawing.Point(14, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 34);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Listado de Pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlContenidoGrid
            //
            this.pnlContenidoGrid.BackColor = System.Drawing.Color.White;
            this.pnlContenidoGrid.Controls.Add(this.dgvPedidos);
            this.pnlContenidoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenidoGrid.Location = new System.Drawing.Point(0, 50);
            this.pnlContenidoGrid.Name = "pnlContenidoGrid";
            this.pnlContenidoGrid.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.pnlContenidoGrid.Size = new System.Drawing.Size(900, 500);
            this.pnlContenidoGrid.TabIndex = 1;
            //
            // dgvPedidos
            //
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.Location = new System.Drawing.Point(14, 8);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(872, 484);
            this.dgvPedidos.TabIndex = 0;
            //
            // pnlPie
            //
            this.pnlPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.pnlPie.Controls.Add(this.lblTotal);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 550);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Padding = new System.Windows.Forms.Padding(14, 4, 14, 4);
            this.pnlPie.Size = new System.Drawing.Size(900, 30);
            this.pnlPie.TabIndex = 2;
            //
            // lblTotal
            //
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotal.Location = new System.Drawing.Point(14, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(300, 22);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total de pedidos: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // FrmPedidos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.pnlContenidoGrid);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlContenidoGrid.ResumeLayout(false);
            this.pnlPie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlContenidoGrid;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblTotal;
    }
}

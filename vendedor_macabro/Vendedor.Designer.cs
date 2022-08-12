namespace vendedor_macabro
{
    partial class Vendedor
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblVenta = new System.Windows.Forms.Label();
            this.llbArt = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCantVen = new System.Windows.Forms.Label();
            this.lblResVen = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblResMonto = new System.Windows.Forms.Label();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblResProm = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblResPor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblResMenor = new System.Windows.Forms.Label();
            this.txtVent = new System.Windows.Forms.TextBox();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblMon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(65, 205);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Registrar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.Location = new System.Drawing.Point(12, 9);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(78, 15);
            this.lblVenta.TabIndex = 1;
            this.lblVenta.Text = "Nro. Venta:";
            // 
            // llbArt
            // 
            this.llbArt.AutoSize = true;
            this.llbArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbArt.Location = new System.Drawing.Point(12, 41);
            this.llbArt.Name = "llbArt";
            this.llbArt.Size = new System.Drawing.Size(59, 15);
            this.llbArt.TabIndex = 2;
            this.llbArt.Text = "Artículo:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(107, 15);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Precio Unitario:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(12, 114);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(68, 15);
            this.lblCant.TabIndex = 4;
            this.lblCant.Text = "Cantidad:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(12, 147);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(51, 15);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto:";
            // 
            // lblCantVen
            // 
            this.lblCantVen.AutoSize = true;
            this.lblCantVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVen.Location = new System.Drawing.Point(336, 9);
            this.lblCantVen.Name = "lblCantVen";
            this.lblCantVen.Size = new System.Drawing.Size(135, 15);
            this.lblCantVen.TabIndex = 6;
            this.lblCantVen.Text = "Cantidad de Ventas:";
            // 
            // lblResVen
            // 
            this.lblResVen.AutoSize = true;
            this.lblResVen.Location = new System.Drawing.Point(692, 13);
            this.lblResVen.Name = "lblResVen";
            this.lblResVen.Size = new System.Drawing.Size(0, 13);
            this.lblResVen.TabIndex = 7;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(336, 43);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(87, 15);
            this.lblMontoTotal.TabIndex = 8;
            this.lblMontoTotal.Text = "Monto Total:";
            // 
            // lblResMonto
            // 
            this.lblResMonto.AutoSize = true;
            this.lblResMonto.Location = new System.Drawing.Point(692, 45);
            this.lblResMonto.Name = "lblResMonto";
            this.lblResMonto.Size = new System.Drawing.Size(0, 13);
            this.lblResMonto.TabIndex = 9;
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProm.Location = new System.Drawing.Point(336, 81);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(113, 15);
            this.lblProm.TabIndex = 10;
            this.lblProm.Text = "Venta Promedio:";
            // 
            // lblResProm
            // 
            this.lblResProm.AutoSize = true;
            this.lblResProm.Location = new System.Drawing.Point(686, 83);
            this.lblResProm.Name = "lblResProm";
            this.lblResProm.Size = new System.Drawing.Size(0, 13);
            this.lblResProm.TabIndex = 11;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(336, 116);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(313, 15);
            this.lblPorcentaje.TabIndex = 12;
            this.lblPorcentaje.Text = "Porcentaje de Artículos con precio mayor a 100:";
            // 
            // lblResPor
            // 
            this.lblResPor.AutoSize = true;
            this.lblResPor.Location = new System.Drawing.Point(686, 118);
            this.lblResPor.Name = "lblResPor";
            this.lblResPor.Size = new System.Drawing.Size(0, 13);
            this.lblResPor.TabIndex = 13;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(336, 149);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(163, 15);
            this.lblMenor.TabIndex = 14;
            this.lblMenor.Text = "Venta con menor Monto:";
            // 
            // lblResMenor
            // 
            this.lblResMenor.AutoSize = true;
            this.lblResMenor.Location = new System.Drawing.Point(686, 151);
            this.lblResMenor.Name = "lblResMenor";
            this.lblResMenor.Size = new System.Drawing.Size(0, 13);
            this.lblResMenor.TabIndex = 15;
            // 
            // txtVent
            // 
            this.txtVent.Location = new System.Drawing.Point(137, 4);
            this.txtVent.Name = "txtVent";
            this.txtVent.Size = new System.Drawing.Size(87, 20);
            this.txtVent.TabIndex = 16;
            // 
            // txtArt
            // 
            this.txtArt.Location = new System.Drawing.Point(137, 36);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(87, 20);
            this.txtArt.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 74);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(87, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(137, 109);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(87, 20);
            this.txtCant.TabIndex = 19;
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(134, 149);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(0, 13);
            this.lblMon.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtVent);
            this.Controls.Add(this.lblResMenor);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblResPor);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblResProm);
            this.Controls.Add(this.lblProm);
            this.Controls.Add(this.lblResMonto);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblResVen);
            this.Controls.Add(this.lblCantVen);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.llbArt);
            this.Controls.Add(this.lblVenta);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label llbArt;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCantVen;
        private System.Windows.Forms.Label lblResVen;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblResMonto;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblResProm;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblResPor;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblResMenor;
        private System.Windows.Forms.TextBox txtVent;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblMon;
    }
}


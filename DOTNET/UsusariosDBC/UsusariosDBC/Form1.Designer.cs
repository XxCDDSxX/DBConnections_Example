namespace UsusariosDBC
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
            this.txtResultadoConexion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnFormCSharp = new System.Windows.Forms.Button();
            this.btnFormVB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultadoConexion
            // 
            this.txtResultadoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoConexion.Location = new System.Drawing.Point(11, 130);
            this.txtResultadoConexion.Multiline = true;
            this.txtResultadoConexion.Name = "txtResultadoConexion";
            this.txtResultadoConexion.ReadOnly = true;
            this.txtResultadoConexion.Size = new System.Drawing.Size(362, 174);
            this.txtResultadoConexion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(206, 33);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(167, 36);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(11, 33);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(167, 36);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnFormCSharp
            // 
            this.btnFormCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormCSharp.Location = new System.Drawing.Point(11, 310);
            this.btnFormCSharp.Name = "btnFormCSharp";
            this.btnFormCSharp.Size = new System.Drawing.Size(167, 39);
            this.btnFormCSharp.TabIndex = 8;
            this.btnFormCSharp.Text = "Agregar C#";
            this.btnFormCSharp.UseVisualStyleBackColor = true;
            this.btnFormCSharp.Click += new System.EventHandler(this.btnFormCShapr_Click);
            // 
            // btnFormVB
            // 
            this.btnFormVB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormVB.Location = new System.Drawing.Point(206, 310);
            this.btnFormVB.Name = "btnFormVB";
            this.btnFormVB.Size = new System.Drawing.Size(166, 39);
            this.btnFormVB.TabIndex = 9;
            this.btnFormVB.Text = "Agregar VB";
            this.btnFormVB.UseVisualStyleBackColor = true;
            this.btnFormVB.Click += new System.EventHandler(this.btnFormVB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 366);
            this.Controls.Add(this.btnFormVB);
            this.Controls.Add(this.btnFormCSharp);
            this.Controls.Add(this.txtResultadoConexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultadoConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnFormCSharp;
        private System.Windows.Forms.Button btnFormVB;
    }
}


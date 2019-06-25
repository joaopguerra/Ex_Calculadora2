namespace Ex_Calculadora2
{
    partial class CalculoAreas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoAreas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECIONE A ÁREA QUE DESEJA CALCULAR:";
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCirculo.BackgroundImage")));
            this.btnCirculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCirculo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCirculo.Location = new System.Drawing.Point(20, 44);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(66, 65);
            this.btnCirculo.TabIndex = 1;
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuadrado.BackgroundImage")));
            this.btnQuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuadrado.Location = new System.Drawing.Point(112, 44);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(66, 65);
            this.btnQuadrado.TabIndex = 2;
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetangulo.BackgroundImage")));
            this.btnRetangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetangulo.Location = new System.Drawing.Point(301, 44);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(66, 65);
            this.btnRetangulo.TabIndex = 4;
            this.btnRetangulo.UseVisualStyleBackColor = true;
            this.btnRetangulo.Click += new System.EventHandler(this.btnRetangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTriangulo.BackgroundImage")));
            this.btnTriangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTriangulo.Location = new System.Drawing.Point(209, 44);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(66, 65);
            this.btnTriangulo.TabIndex = 3;
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(150, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CalculoAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRetangulo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "CalculoAreas";
            this.Text = "CÁLCULO DE ÁREA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button button1;
    }
}


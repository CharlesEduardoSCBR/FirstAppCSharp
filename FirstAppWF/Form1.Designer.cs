namespace FirstAppWF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickMe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbOpenSource = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.Location = new System.Drawing.Point(84, 49);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(75, 23);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "Click-me";
            this.clickMe.UseVisualStyleBackColor = true;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbOpenSource
            // 
            this.pbOpenSource.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenSource.Image")));
            this.pbOpenSource.Location = new System.Drawing.Point(111, 78);
            this.pbOpenSource.Name = "pbOpenSource";
            this.pbOpenSource.Size = new System.Drawing.Size(33, 34);
            this.pbOpenSource.TabIndex = 1;
            this.pbOpenSource.TabStop = false;
            this.pbOpenSource.Click += new System.EventHandler(this.pbOpenSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 134);
            this.Controls.Add(this.pbOpenSource);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clickMe);
            this.Name = "Form1";
            this.Text = "FirstAppWF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbOpenSource;
    }
}


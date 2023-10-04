namespace richhTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btCitaj = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(224, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 156);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btCitaj
            // 
            this.btCitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btCitaj.Location = new System.Drawing.Point(206, 63);
            this.btCitaj.Name = "btCitaj";
            this.btCitaj.Size = new System.Drawing.Size(87, 34);
            this.btCitaj.TabIndex = 1;
            this.btCitaj.Text = "Citaj";
            this.btCitaj.UseVisualStyleBackColor = true;
            this.btCitaj.Click += new System.EventHandler(this.btCitaj_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBrisi.Location = new System.Drawing.Point(384, 62);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(87, 34);
            this.btBrisi.TabIndex = 2;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btSpremi
            // 
            this.btSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSpremi.Location = new System.Drawing.Point(206, 291);
            this.btSpremi.Name = "btSpremi";
            this.btSpremi.Size = new System.Drawing.Size(87, 38);
            this.btSpremi.TabIndex = 3;
            this.btSpremi.Text = "Spremi";
            this.btSpremi.UseVisualStyleBackColor = true;
            this.btSpremi.Click += new System.EventHandler(this.btSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSpremi);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btCitaj);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btCitaj;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btSpremi;
    }
}


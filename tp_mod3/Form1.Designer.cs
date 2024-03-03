namespace tp_mod3
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
          
            this.textBoxNama.BackColor = System.Drawing.Color.LightPink;
            this.textBoxNama.Location = new System.Drawing.Point(36, 55);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(217, 20);
            this.textBoxNama.TabIndex = 0;
          
            this.buttonKirim.BackColor = System.Drawing.Color.LightPink;
            this.buttonKirim.Location = new System.Drawing.Point(269, 55);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(91, 20);
            this.buttonKirim.TabIndex = 1;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = false;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
           
            this.labelHasil.BackColor = System.Drawing.Color.LightPink;
            this.labelHasil.Location = new System.Drawing.Point(36, 93);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(324, 20);
            this.labelHasil.TabIndex = 2;
         
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 173);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textBoxNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.Label labelHasil;
    }
}

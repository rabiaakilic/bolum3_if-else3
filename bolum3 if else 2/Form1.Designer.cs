namespace bolum3_if_else_2
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
            this.cbKirmizi = new System.Windows.Forms.CheckBox();
            this.cbPembe = new System.Windows.Forms.CheckBox();
            this.cbMavi = new System.Windows.Forms.CheckBox();
            this.cbSiyah = new System.Windows.Forms.CheckBox();
            this.cbSari = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbKirmizi
            // 
            this.cbKirmizi.AutoSize = true;
            this.cbKirmizi.Location = new System.Drawing.Point(44, 41);
            this.cbKirmizi.Name = "cbKirmizi";
            this.cbKirmizi.Size = new System.Drawing.Size(116, 17);
            this.cbKirmizi.TabIndex = 0;
            this.cbKirmizi.Text = "_______________";
            this.cbKirmizi.UseVisualStyleBackColor = true;
            this.cbKirmizi.Click += new System.EventHandler(this.cbKirmizi_Click);
            // 
            // cbPembe
            // 
            this.cbPembe.AutoSize = true;
            this.cbPembe.Location = new System.Drawing.Point(44, 198);
            this.cbPembe.Name = "cbPembe";
            this.cbPembe.Size = new System.Drawing.Size(116, 17);
            this.cbPembe.TabIndex = 1;
            this.cbPembe.Text = "_______________";
            this.cbPembe.UseVisualStyleBackColor = true;
            this.cbPembe.Click += new System.EventHandler(this.cbPembe_Click);
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Location = new System.Drawing.Point(44, 153);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(116, 17);
            this.cbMavi.TabIndex = 2;
            this.cbMavi.Text = "_______________";
            this.cbMavi.UseVisualStyleBackColor = true;
            this.cbMavi.Click += new System.EventHandler(this.cbMavi_Click);
            // 
            // cbSiyah
            // 
            this.cbSiyah.AutoSize = true;
            this.cbSiyah.Location = new System.Drawing.Point(44, 113);
            this.cbSiyah.Name = "cbSiyah";
            this.cbSiyah.Size = new System.Drawing.Size(116, 17);
            this.cbSiyah.TabIndex = 3;
            this.cbSiyah.Text = "_______________";
            this.cbSiyah.UseVisualStyleBackColor = true;
            this.cbSiyah.Click += new System.EventHandler(this.cbSiyah_Click);
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Location = new System.Drawing.Point(44, 79);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(116, 17);
            this.cbSari.TabIndex = 4;
            this.cbSari.Text = "_______________";
            this.cbSari.UseVisualStyleBackColor = true;
            this.cbSari.CheckedChanged += new System.EventHandler(this.cbSari_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.cbSiyah);
            this.Controls.Add(this.cbMavi);
            this.Controls.Add(this.cbPembe);
            this.Controls.Add(this.cbKirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbKirmizi;
        private System.Windows.Forms.CheckBox cbPembe;
        private System.Windows.Forms.CheckBox cbMavi;
        private System.Windows.Forms.CheckBox cbSiyah;
        private System.Windows.Forms.CheckBox cbSari;
    }
}


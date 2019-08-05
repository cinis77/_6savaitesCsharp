namespace _20190805_pavyzdys
{
    partial class PagrindinisLangas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagrindinisLangas));
            this.GroupFirst = new System.Windows.Forms.GroupBox();
            this.MygtukasSpausti = new System.Windows.Forms.Button();
            this.TekstoLaukas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupFirst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupFirst
            // 
            this.GroupFirst.BackColor = System.Drawing.Color.Yellow;
            this.GroupFirst.Controls.Add(this.TekstoLaukas);
            this.GroupFirst.Controls.Add(this.MygtukasSpausti);
            this.GroupFirst.Location = new System.Drawing.Point(12, 12);
            this.GroupFirst.Name = "GroupFirst";
            this.GroupFirst.Size = new System.Drawing.Size(226, 204);
            this.GroupFirst.TabIndex = 0;
            this.GroupFirst.TabStop = false;
            this.GroupFirst.Text = "PirmaGrupe";
            // 
            // MygtukasSpausti
            // 
            this.MygtukasSpausti.Location = new System.Drawing.Point(43, 127);
            this.MygtukasSpausti.Name = "MygtukasSpausti";
            this.MygtukasSpausti.Size = new System.Drawing.Size(75, 23);
            this.MygtukasSpausti.TabIndex = 0;
            this.MygtukasSpausti.Text = "Spausti";
            this.MygtukasSpausti.UseVisualStyleBackColor = true;
            this.MygtukasSpausti.Click += new System.EventHandler(this.MygtukasSpausti_Click);
            // 
            // TekstoLaukas
            // 
            this.TekstoLaukas.Location = new System.Drawing.Point(43, 46);
            this.TekstoLaukas.Name = "TekstoLaukas";
            this.TekstoLaukas.Size = new System.Drawing.Size(139, 20);
            this.TekstoLaukas.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(388, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 333);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PagrindinisLangas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GroupFirst);
            this.Name = "PagrindinisLangas";
            this.Text = "Programa";
            this.GroupFirst.ResumeLayout(false);
            this.GroupFirst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupFirst;
        private System.Windows.Forms.Button MygtukasSpausti;
        private System.Windows.Forms.TextBox TekstoLaukas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


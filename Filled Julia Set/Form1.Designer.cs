
namespace Filled_Julia_Set
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
            this.pbNumberline = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberline)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNumberline
            // 
            this.pbNumberline.Location = new System.Drawing.Point(21, 12);
            this.pbNumberline.Name = "pbNumberline";
            this.pbNumberline.Size = new System.Drawing.Size(800, 600);
            this.pbNumberline.TabIndex = 0;
            this.pbNumberline.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 631);
            this.Controls.Add(this.pbNumberline);
            this.Name = "Form1";
            this.Text = "Filled Julia Set";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNumberline;
    }
}


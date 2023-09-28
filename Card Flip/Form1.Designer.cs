
namespace Card_Flip
{
    partial class Flip_Card
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCardBack = new System.Windows.Forms.PictureBox();
            this.picCardShow = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFront = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCardBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardShow)).BeginInit();
            this.SuspendLayout();
            // 
            // picCardBack
            // 
            this.picCardBack.Image = global::Card_Flip.Properties.Resources.bak;
            this.picCardBack.Location = new System.Drawing.Point(59, 56);
            this.picCardBack.Name = "picCardBack";
            this.picCardBack.Size = new System.Drawing.Size(424, 689);
            this.picCardBack.TabIndex = 0;
            this.picCardBack.TabStop = false;
            // 
            // picCardShow
            // 
            this.picCardShow.Image = global::Card_Flip.Properties.Resources.king;
            this.picCardShow.Location = new System.Drawing.Point(542, 56);
            this.picCardShow.Name = "picCardShow";
            this.picCardShow.Size = new System.Drawing.Size(518, 689);
            this.picCardShow.TabIndex = 1;
            this.picCardShow.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(240, 751);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Show Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFront
            // 
            this.btnFront.Location = new System.Drawing.Point(724, 751);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(75, 23);
            this.btnFront.TabIndex = 3;
            this.btnFront.Text = "Show Front";
            this.btnFront.UseVisualStyleBackColor = true;
            this.btnFront.Click += new System.EventHandler(this.btnFront_Click);
            // 
            // Flip_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 808);
            this.Controls.Add(this.btnFront);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picCardShow);
            this.Controls.Add(this.picCardBack);
            this.Name = "Flip_Card";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Flip_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCardBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCardBack;
        private System.Windows.Forms.PictureBox picCardShow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFront;
    }
}



namespace WinFormsCurso
{
    partial class Frm_ArqImg_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_ArqImg = new System.Windows.Forms.Label();
            this.Pic_ArqImg = new System.Windows.Forms.PictureBox();
            this.Btn_Cor = new System.Windows.Forms.Button();
            this.Btn_Fonte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArqImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ArqImg
            // 
            this.Lbl_ArqImg.AutoSize = true;
            this.Lbl_ArqImg.Location = new System.Drawing.Point(17, 45);
            this.Lbl_ArqImg.Name = "Lbl_ArqImg";
            this.Lbl_ArqImg.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ArqImg.TabIndex = 0;
            this.Lbl_ArqImg.Text = "label1";
            // 
            // Pic_ArqImg
            // 
            this.Pic_ArqImg.Location = new System.Drawing.Point(20, 95);
            this.Pic_ArqImg.Name = "Pic_ArqImg";
            this.Pic_ArqImg.Size = new System.Drawing.Size(209, 156);
            this.Pic_ArqImg.TabIndex = 1;
            this.Pic_ArqImg.TabStop = false;
            // 
            // Btn_Cor
            // 
            this.Btn_Cor.Location = new System.Drawing.Point(24, 4);
            this.Btn_Cor.Name = "Btn_Cor";
            this.Btn_Cor.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cor.TabIndex = 2;
            this.Btn_Cor.Text = "Cor";
            this.Btn_Cor.UseVisualStyleBackColor = true;
            this.Btn_Cor.Click += new System.EventHandler(this.Btn_Cor_Click);
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.Location = new System.Drawing.Point(105, 4);
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fonte.TabIndex = 3;
            this.Btn_Fonte.Text = "Fonte";
            this.Btn_Fonte.UseVisualStyleBackColor = true;
            this.Btn_Fonte.Click += new System.EventHandler(this.Btn_Fonte_Click);
            // 
            // Frm_ArqImg_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Fonte);
            this.Controls.Add(this.Btn_Cor);
            this.Controls.Add(this.Pic_ArqImg);
            this.Controls.Add(this.Lbl_ArqImg);
            this.Name = "Frm_ArqImg_UC";
            this.Size = new System.Drawing.Size(629, 301);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ArqImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ArqImg;
        private System.Windows.Forms.PictureBox Pic_ArqImg;
        private System.Windows.Forms.Button Btn_Cor;
        private System.Windows.Forms.Button Btn_Fonte;
    }
}

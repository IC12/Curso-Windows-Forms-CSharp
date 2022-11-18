
namespace WinFormsCurso
{
    partial class Frm_Questao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            this.Lbl_Questao = new System.Windows.Forms.Label();
            this.Btm_OK = new System.Windows.Forms.Button();
            this.Btm_Cancel = new System.Windows.Forms.Button();
            this.Pic_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Questao
            // 
            this.Lbl_Questao.AutoSize = true;
            this.Lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Questao.Location = new System.Drawing.Point(18, 9);
            this.Lbl_Questao.Name = "Lbl_Questao";
            this.Lbl_Questao.Size = new System.Drawing.Size(244, 20);
            this.Lbl_Questao.TabIndex = 0;
            this.Lbl_Questao.Text = "Você deseja validar a senha?";
            // 
            // Btm_OK
            // 
            this.Btm_OK.Location = new System.Drawing.Point(147, 60);
            this.Btm_OK.Name = "Btm_OK";
            this.Btm_OK.Size = new System.Drawing.Size(115, 23);
            this.Btm_OK.TabIndex = 1;
            this.Btm_OK.Text = "Sim. Continue";
            this.Btm_OK.UseVisualStyleBackColor = true;
            this.Btm_OK.Click += new System.EventHandler(this.Btm_OK_Click);
            // 
            // Btm_Cancel
            // 
            this.Btm_Cancel.Location = new System.Drawing.Point(147, 89);
            this.Btm_Cancel.Name = "Btm_Cancel";
            this.Btm_Cancel.Size = new System.Drawing.Size(115, 23);
            this.Btm_Cancel.TabIndex = 2;
            this.Btm_Cancel.Text = "Não. Pare";
            this.Btm_Cancel.UseVisualStyleBackColor = true;
            this.Btm_Cancel.Click += new System.EventHandler(this.Btm_Cancel_Click);
            // 
            // Pic_img
            // 
            this.Pic_img.Image = global::WinFormsCurso.Properties.Resources.icons8_query_801;
            this.Pic_img.Location = new System.Drawing.Point(22, 43);
            this.Pic_img.Name = "Pic_img";
            this.Pic_img.Size = new System.Drawing.Size(100, 96);
            this.Pic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_img.TabIndex = 3;
            this.Pic_img.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.Pic_img);
            this.Controls.Add(this.Btm_Cancel);
            this.Controls.Add(this.Btm_OK);
            this.Controls.Add(this.Lbl_Questao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Questao;
        private System.Windows.Forms.Button Btm_OK;
        private System.Windows.Forms.Button Btm_Cancel;
        private System.Windows.Forms.PictureBox Pic_img;
    }
}
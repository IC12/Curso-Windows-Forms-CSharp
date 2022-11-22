using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCurso
{
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;

                //MessageBox.Show("Cliquei com o botão da direita do mouse. A posição relativa foi " + PosicaoX.ToString() + "," + PosicaoY.ToString() + ".");

                var ContextMenu = new ContextMenuStrip();

                var vToolTip01 = DesenhaItemMenu("Item do menu 1", "icons8_query_801");
                var vToolTip02 = DesenhaItemMenu("Item do menu 2", "key");
                var vToolTip03 = DesenhaItemMenu("Item do menu 3", "Frm_ValidaSenha");

                vToolTip01.DropDownItems.Add(DesenhaItemMenu("Item do menu 1.1", "icons8_query_801"));
                vToolTip01.DropDownItems.Add(DesenhaItemMenu("Item do menu 1.2", "icons8_query_801"));

                ContextMenu.Items.Add(vToolTip01);
                ContextMenu.Items.Add(vToolTip02);
                ContextMenu.Items.Add(vToolTip03);

                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip02.Click += new EventHandler(VToolTip02_Click);
                vToolTip03.Click += new EventHandler(VToolTip03_Click);
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImg)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;

                Image MyImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImg);//ou pegar uma imagem específica: Image.FromFile("C:\Documentos\Imagens\key")
                vToolTip.Image = MyImage;

                return vToolTip;
            }
        }

        private void VToolTip02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionei a opção do menu 2");
        }

        private void VToolTip03_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecionei a opção do menu 3");
        }
    }
}

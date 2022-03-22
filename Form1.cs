using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;

namespace contextMenuStrip_uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Dosyası |*.txt| Tüm Dosyalar |*.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları |*.txt";
            DialogResult cevap= ofd.ShowDialog();
            if(cevap==DialogResult.OK)
            {
               txtEditor.LoadFile(ofd.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                e.Graphics.DrawString(txtEditor.Text, txtEditor.Font,
                Brushes.Black, new Point(100, 100));
            }
        }

        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fd.Font;
            }
        }

        private void menuRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.SelectionColor = cd.Color;
            }
        }
    }
}

    
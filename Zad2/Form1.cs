using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2
{
    public partial class Form1 : Form
    {
        Image image;
        double zoom;
        List<String> Ścieszka = new List<String>();
        ImageList Obraz = new ImageList();



        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Obrazy", 200);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            Obraz.ImageSize = new Size(100, 100);
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = " Images (*.PNG,*.BMP,*.JPG,*.GIF)|*.png;*.BMP;*.JPG;*.GIF|All files(*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                try {
                    foreach(String file in openFileDialog.FileNames)
                    {
                        try
                        {
                                Ścieszka.Add(file);
                        }
                        catch (Exception ex) { MessageBox.Show("ERROR", ex.ToString()); }
                    }
                    listView1.SmallImageList = Obraz;
                    for (j = 0; j < Ścieszka.Count; i++)
                    {
                        Obraz.Images.Add(Image.FromFile(Ścieszka[j]));
                    }
                    for(i = 0; i < Ścieszka.Count; i++)
                    {
                        
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show("ERROR",ex.ToString());
                }
    
            }
        }
    }
}

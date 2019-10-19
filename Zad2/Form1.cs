using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using System.Windows;
namespace Zad2
{
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;
        Image image;
        double zoom;
        List<String> Ścieszka = new List<String>();
        ImageList Obraz = new ImageList();
       




        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Obrazy", -2);
            Obraz.ImageSize = new Size(100, 100);
            listView1.SmallImageList = Obraz;
            listView1.MultiSelect = false;
            
            
            
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Obraz.Images.Clear();
                Ścieszka.Clear();
                OpenFileDialog openFileDialog = new OpenFileDialog{
                InitialDirectory = "C:\\Users\\Modzel\\Documents\\My Games\\Fallout 76\\Photos\\6f24a1582fa547048f7bdcd7a5adf5b1",
                Filter = " Images (*.PNG,*.BMP,*.JPG,*.GIF)|*.png;*.BMP;*.JPG;*.GIF|All files(*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = true,
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK){
                    foreach (String file in openFileDialog.FileNames)
                    {
                        try
                        {
                            Ścieszka.Add(file);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(),"ERROR"); 
                        }
                    }
                    
                    for (j = 0; j < Ścieszka.Count; j++)
                    {
                        Obraz.Images.Add(Image.FromFile(Ścieszka[j]));
                    }
                    for (i = 0; i < Ścieszka.Count; i++)
                    {
                        listView1.Items.Add(Ścieszka[i], i);
                    }
                    
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void Wczytaj_Click(object sender, EventArgs e)
        {
            String text = listView1.SelectedItems[0].Text;
            pictureBox1.ImageLocation = text.ToString();
            
        }
        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta != 0)
            {
                if (e.Delta > 0)
                {
                    
                }
                else if(e.Delta < 0)
                {
                
                }
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }
    }
}

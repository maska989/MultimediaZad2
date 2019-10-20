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
        double zoom = 1;
        Bitmap bitmap;
        bool rot = false;
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
            pictureBox1.MouseWheel += new MouseEventHandler(pictureBox_MouseWheel);
            hScrollBar1.Width = pictureBox1.Width;
            hScrollBar1.Left = pictureBox1.Left;
            hScrollBar1.Top = pictureBox1.Bottom;
            vScrollBar1.Height = pictureBox1.Height;
            vScrollBar1.Left = pictureBox1.Left + pictureBox1.Width;
            vScrollBar1.Top = pictureBox1.Top;
        }


        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Obraz.Images.Clear();
                Ścieszka.Clear();
                OpenFileDialog openFileDialog = new OpenFileDialog {
                    InitialDirectory = "C:\\Users\\Modzel\\Documents\\My Games\\Fallout 76\\Photos\\6f24a1582fa547048f7bdcd7a5adf5b1",
                    Filter = " Images (*.PNG,*.BMP,*.JPG,*.GIF)|*.png;*.BMP;*.JPG;*.GIF|All files(*.*)|*.*",
                    RestoreDirectory = true,
                    Multiselect = true,
                    ValidateNames = false,
                    CheckFileExists = false,
                    CheckPathExists = true
                    
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
            try
            {
                String text = listView1.SelectedItems[0].Text;
                pictureBox1.ImageLocation = text.ToString();
                bitmap = new Bitmap(Image.FromFile(listView1.SelectedItems[0].Text));
                image = Image.FromFile(listView1.SelectedItems[0].Text);
            }
            catch
            {
                MessageBox.Show("Wybierz obraz", "Error");
            }

            
        }
        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta != 0)
            {
                if (e.Delta > 0)
                {
                    Plus_Click(sender,e);
                }
                else if(e.Delta < 0)
                {
                    Minus_Click(sender,e);
                }
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            try
            {

                if (zoom < 5) zoom = zoom + 0.1;
                Bitmap bmp = new Bitmap(image, Convert.ToInt32(image.Width * zoom), Convert.ToInt32(image.Height * zoom));
                Graphics g = Graphics.FromImage(bmp);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                pictureBox1.Focus();
                bitmap = bmp;
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();
                
            }
            catch { }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            try
            {
                if (zoom > 0.5) zoom = zoom - 0.1;
                Bitmap bmp = new Bitmap(image, Convert.ToInt32(image.Width * zoom), Convert.ToInt32(image.Height* zoom));
                Graphics g = Graphics.FromImage(bmp);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                pictureBox1.Focus();
                bitmap = bmp;
                pictureBox1.Image = bmp;
                pictureBox1.Refresh();
               
                
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
            pictureBox1.Refresh();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }


        private void RotPraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (rot == true)
                {
                    
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                    pictureBox1.Image = bitmap;
                    image = bitmap;
                    rot = false;
                    pictureBox1.Refresh();
                }
                else
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipY);
                    pictureBox1.Image = bitmap;
                    image = bitmap;
                    rot = true;
                    pictureBox1.Refresh();
                }

            }
            catch { }

        }

        private void RotLew_Click(object sender, EventArgs e)
        {
            try
            {
                if (rot == false)
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                    pictureBox1.Image = bitmap;
                    image = bitmap;
                    rot = true;
                    pictureBox1.Refresh();

                }
                else
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate90FlipY);
                    pictureBox1.Image = bitmap;
                    image = bitmap;
                    rot = false;
                    pictureBox1.Refresh();
                }
            }
            catch { }
        }

        private void ususnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            catch
            {
                MessageBox.Show("Wybierz Plik", "ERROR");
            }
        }
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }




        int x = 0;
        int y = 0;
        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            x = (sender as HScrollBar).Value *10;
            pictureBox1.Refresh();
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            y = (sender as VScrollBar).Value *10;
            pictureBox1.Refresh();
        }
        private void Prawo_Click_1(object sender, EventArgs e)
        {
            y++;
        }
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            try {
                
                pictureBox1 = sender as PictureBox;
                e.Graphics.DrawImage(pictureBox1.Image, e.ClipRectangle, x, y, e.ClipRectangle.Width, e.ClipRectangle.Height, GraphicsUnit.Pixel);
            }
            catch
            {

            }
        }


 
    }
}

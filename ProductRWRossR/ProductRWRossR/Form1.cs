using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRWRossR
{
    public partial class Form1 : Form
    {
        Product p;
        ProductList pl ;
        int idx = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void drawSet(bool bool1,bool bool2, bool bool3, bool bool4, bool bool5, bool bool6, bool bool7, bool bool8)
        {
            lblVar1.Visible = bool1;
            txtVar1.Visible = bool1;
            lblVar2.Visible = bool2;
            txtVar2.Visible = bool2;
            lblVar3.Visible = bool3;
            txtVar3.Visible = bool3;
            lblVar4.Visible = bool4;
            txtVar4.Visible = bool4;
            lblVar5.Visible = bool5;
            txtVar5.Visible = bool5;
            lblVar6.Visible = bool6;
            txtVar6.Visible = bool6;
            lblVar7.Visible = bool7;
            txtVar7.Visible = bool7;
            lblVar8.Visible = bool8;
            txtVar8.Visible = bool8;

        }

        public void drawBook()
        {
            Book b = (Book)p;
            drawSet(true, true, true, true, false, false, false, false);
            drawMedia();
            lblVar2.Text = "Author";
            txtVar2.Text = b.Author;
            lblVar3.Text = "Pages";
            txtVar3.Text = b.NumPages.ToString();
            lblVar4.Text = "Publisher";
            txtVar4.Text = b.Publisher;
        }
        public void drawMedia()
        {
            Media m = (Media)p;
            lblVar1.Text = "Release Date";
            txtVar1.Text = m.ReleaseDate;
        }

        public void drawDisk()
        {
            Disk d = (Disk)p;
            drawMedia();
            lblVar2.Text = "Number of Disks";
            txtVar2.Text = d.NumDisks.ToString();
            lblVar3.Text = "Data Size";
            txtVar3.Text = d.Size.ToString();
            lblVar4.Text = "Type Disk";
            txtVar4.Text = d.TypeDisk;
        }
        public void drawSoftware()
        {
            Software s = (Software)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawDisk();
            lblVar5.Text = "Type Software";
            txtVar5.Text = s.TypeSoft;
        }

        public void drawEntertainment()
        {
            Entertainment e = (Entertainment)p;
            drawDisk();
            lblVar5.Text = "Run Time";
            txtVar5.Text = e.RunTime;
        }

        public void drawMovie()
        {
            Movie m = (Movie)p;
            drawSet(true, true, true, true, true, true, true, false);
            drawEntertainment();
            lblVar6.Text = "Director";
            txtVar6.Text = m.Director;
            lblVar7.Text = "Producer";
            txtVar7.Text = m.Producer;
        }

        public void drawMusic()
        {
            Music m = (Music)p;
            drawSet(true, true, true, true, true, true, true, true);
            drawEntertainment();
            lblVar6.Text = "Artist";
            txtVar6.Text = m.Artist;
            lblVar7.Text = "Genre";
            txtVar7.Text = m.Genre;
            lblVar8.Text = "Label";
            txtVar8.Text = m.Label;
        }
        public void drawApparel()
        {
            Apparel a = (Apparel)p;
            lblVar1.Text = "Color";
            txtVar1.Text = a.Color;
            lblVar2.Text = "Manufacturer";
            txtVar2.Text = a.Manufacturer;
            lblVar3.Text = "Material";
            txtVar3.Text = a.Material;
        }

        public void drawDressShirt()
        {
            DressShirt dressS = (DressShirt)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            lblVar4.Text = "Neck";
            txtVar4.Text = dressS.Neck.ToString();
            lblVar5.Text = "Sleeve";
            txtVar5.Text = dressS.Sleeve.ToString();
        }

        public void drawPants()
        {
            Pants pants = (Pants)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            lblVar4.Text = "Inseam";
            txtVar4.Text = pants.Inseam.ToString();
            lblVar5.Text = "Waist";
            txtVar5.Text = pants.Waist.ToString();
        }

        public void drawTShirt()
        {
            TShirt t = (TShirt)p;
            drawSet(true, true, true, true, false, false, false, false);
            drawApparel();
            lblVar4.Text = "Size";
            txtVar4.Text = t.Size;
        }
        public void drawProduct()
        {
            if (idx >= 0 && idx < pl.Count)
            {
                p = pl.ElementAt(idx);
                txtType.Text = p.Type;
                txtID.Text = p.ID;
                txtDesc.Text = p.Desc;
                txtPrice.Text = p.Price.ToString("C");
                txtQuantity.Text = p.Qty.ToString();
                if (p.Type == "Book")
                    drawBook();
                else if (p.Type == "Software")
                    drawSoftware();
                else if (p.Type == "Music")
                    drawMusic();
                else if (p.Type == "Movie")
                    drawMovie();
                else if (p.Type == "Pants")
                    drawPants();
                else if (p.Type == "TShirt")
                    drawTShirt();
                else if (p.Type == "DressShirt")
                    drawDressShirt();
                else
                    MessageBox.Show("Not found.");
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawSet(false, false, false, false, false, false, false, false);
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnWrite.Enabled = false;
            btnWriteBin.Enabled = false;
            btnRead.Focus();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            pl = new ProductList();
            pl.readFromFile();
            if (pl.Count != 1)
            {
                btnNext.Enabled = true;
            }
            btnWrite.Enabled = true;
            btnWriteBin.Enabled = true;
            foreach(Product prod in pl)
            {
               drawProduct();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            idx++;
            drawProduct();
            btnPrev.Enabled = true;
            if(idx == pl.Count-1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            idx--;
            drawProduct();
            btnNext.Enabled = true;
            if(idx == 0)
            {
                btnPrev.Enabled = false;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if(pl!=null)
                pl.writeToFile();
        }

        private void btnWriteBin_Click(object sender, EventArgs e)
        {
            pl.writeToBinary();
        }

        private void btnReadBin_Click(object sender, EventArgs e)
        {
            pl = new ProductList();
            pl.readFromBinary();
            if (pl.Count != 1)
            {
                btnNext.Enabled = true;
            }
            btnWrite.Enabled = true;
            btnWriteBin.Enabled = true;
            foreach (Product prod in pl)
            {
                drawProduct();
            }
        }
    }
}

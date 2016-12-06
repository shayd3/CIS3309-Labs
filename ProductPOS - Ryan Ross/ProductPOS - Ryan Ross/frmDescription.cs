using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPOS___Ryan_Ross
{
    public partial class frmDescription : Form
    {
        public frmDescription()
        {
            InitializeComponent();
        }

        private void frmDescription_Load(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                return;
            }
            this.drawProduct((Product)this.Tag);

        }

        public void drawSet(bool bool1, bool bool2, bool bool3, bool bool4, bool bool5, bool bool6, bool bool7, bool bool8)
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

        public void showClear()
        {
            drawSet(false, false, false, false, false, false, false, false);
            txtType.Text = "";
            txtID.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            lblVar1.Text = "";
            lblVar2.Text = "";
            lblVar3.Text = "";
            lblVar4.Text = "";
            lblVar5.Text = "";
            lblVar6.Text = "";
            lblVar7.Text = "";
            lblVar8.Text = "";
        }

        public void drawProduct(Product p)
        {
            txtType.Text = p.Type;
            txtID.Text = p.ID;
            txtDesc.Text = p.Desc;
            txtPrice.Text = p.Price.ToString("C");
            txtQuantity.Text = p.Qty.ToString();
            if (p.Type == "Book")
                drawBook(p);
            else if (p.Type == "Software")
                drawSoftware(p);
            else if (p.Type == "Music")
                drawMusic(p);
            else if (p.Type == "Movie")
                drawMovie(p);
            else if (p.Type == "Pants")
                drawPants(p);
            else if (p.Type == "TShirt")
                drawTShirt(p);
            else if (p.Type == "DressShirt")
                drawDressShirt(p);
            else
                MessageBox.Show("Not found.");
        }

        public void drawBook(Product p)
        {
            Book b = (Book)p;
            drawSet(true, true, true, true, false, false, false, false);
            drawMedia(p);
            lblVar2.Text = "Pages";
            txtVar2.Text = b.NumPages.ToString();
            lblVar3.Text = "Author";
            txtVar3.Text = b.Author;
            lblVar4.Text = "Publisher";
            txtVar4.Text = b.Publisher;
        }
        public void drawMedia(Product p)
        {
            Media m = (Media)p;
            lblVar1.Text = "Release Date";
            txtVar1.Text = m.ReleaseDate;
        }

        public void drawDisk(Product p)
        {
            Disk d = (Disk)p;
            drawMedia(p);
            lblVar2.Text = "Number of Disks";
            txtVar2.Text = d.NumDisks.ToString();
            lblVar3.Text = "Data Size";
            txtVar3.Text = d.Size.ToString();
            lblVar4.Text = "Type Disk";
            txtVar4.Text = d.TypeDisk;
        }
        public void drawSoftware(Product p)
        {
            Software s = (Software)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawDisk(p);
            lblVar5.Text = "Type Software";
            txtVar5.Text = s.TypeSoft;
        }

        public void drawEntertainment(Product p)
        {
            Entertainment e = (Entertainment)p;
            drawDisk(p);
            lblVar5.Text = "Run Time";
            txtVar5.Text = e.RunTime;
        }

        public void drawMovie(Product p)
        {
            Movie m = (Movie)p;
            drawSet(true, true, true, true, true, true, true, false);
            drawEntertainment(p);
            lblVar6.Text = "Director";
            txtVar6.Text = m.Director;
            lblVar7.Text = "Producer";
            txtVar7.Text = m.Producer;
        }

        public void drawMusic(Product p)
        {
            Music m = (Music)p;
            drawSet(true, true, true, true, true, true, true, true);
            drawEntertainment(p);
            lblVar6.Text = "Artist";
            txtVar6.Text = m.Artist;
            lblVar7.Text = "Label";
            txtVar7.Text = m.Label;
            lblVar8.Text = "Genre";
            txtVar8.Text = m.Genre;
        }
        public void drawApparel(Product p)
        {
            Apparel a = (Apparel)p;
            lblVar1.Text = "Color";
            txtVar1.Text = a.Color;
            lblVar2.Text = "Manufacturer";
            txtVar2.Text = a.Manufacturer;
            lblVar3.Text = "Material";
            txtVar3.Text = a.Material;
        }

        public void drawDressShirt(Product p)
        {
            DressShirt dressS = (DressShirt)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel(p);
            lblVar4.Text = "Neck";
            txtVar4.Text = dressS.Neck.ToString();
            lblVar5.Text = "Sleeve";
            txtVar5.Text = dressS.Sleeve.ToString();
        }

        public void drawPants(Product p)
        {
            Pants pants = (Pants)p;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel(p);
            lblVar4.Text = "Waist";
            txtVar4.Text = pants.Waist.ToString();
            lblVar5.Text = "Inseam";
            txtVar5.Text = pants.Inseam.ToString();
        }

        public void drawTShirt(Product p)
        {
            TShirt t = (TShirt)p;
            drawSet(true, true, true, true, false, false, false, false);
            drawApparel(p);
            lblVar4.Text = "Size";
            txtVar4.Text = t.Size;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

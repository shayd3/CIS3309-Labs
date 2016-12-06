using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPOS___Ryan_Ross
{
    class ProductList:List<Product>
    {

        public void readFromFile()
        {
            string dir = @"Outputs";
            string path = dir + "/Products.csv";
            StreamReader reader;
            string[] splitEntry;
            string curLine;
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Directory not found '" + dir + "'");
            }
            else if (!File.Exists(path))
            {
                MessageBox.Show("File not found '" + path + "'");
                return;
            }
            else
            {
                reader = new StreamReader(path);
                while ((curLine = reader.ReadLine()) != null)
                {
                    splitEntry = curLine.Split(',');
                    this.Add(splitEntry);
                }
                reader.Close();
            }
        }

        public void readFromBinary()
        {
            string dir = @"Outputs";
            string path = dir + "/Output.bin";

            BinaryReader binaryIn = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            while(binaryIn.PeekChar() != -1)
            {
                this.Add(binaryIn.ReadString().Split(','));
            }
            binaryIn.Close();
        }

        public void writeToFile()
        {
            string dir = @"Outputs";
            string path = dir + "/Output.csv";

            StreamWriter textOut = new StreamWriter(new FileStream(path,
                FileMode.Create, FileAccess.Write));

            foreach (Product p in this)
            {
                textOut.WriteLine(p.ToCSV());
            }

            // Close StreamWriter
            textOut.Close();

        }

        public void writeToBinary()
        {
            string dir = @"Outputs";
            string path = dir + "/Output.bin";

            BinaryWriter binaryOut = new BinaryWriter(new FileStream(path,
                FileMode.Create, FileAccess.Write));

            foreach (Product p in this)
            {
                binaryOut.Write(p.ToCSV());
            }
            binaryOut.Close();
        }

        


        public void Add(string[] splitEntry)
        {
            if(splitEntry[0] == "DressShirt")
            {
                this.Add(new DressShirt(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse(splitEntry[3]), int.Parse(splitEntry[4]),
                    splitEntry[6], splitEntry[7], splitEntry[5], int.Parse(splitEntry[8]), int.Parse(splitEntry[9])));
            } else if(splitEntry[0] == "Pants")
            {
                this.Add(new Pants(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse(splitEntry[3]), int.Parse(splitEntry[4]),
                    splitEntry[6], splitEntry[7], splitEntry[5], int.Parse(splitEntry[8]), int.Parse(splitEntry[9])));

            }
            else if (splitEntry[0] == "TShirt")
            {
                this.Add(new TShirt(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse(splitEntry[3]), int.Parse(splitEntry[4]), 
                    splitEntry[6], splitEntry[7], splitEntry[5], splitEntry[8]));
            }
            else if (splitEntry[0] == "Book")
            {
                this.Add(new Book(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])), 
                    splitEntry[5], splitEntry[6], int.Parse(splitEntry[7]), splitEntry[8]));
            }
            else if (splitEntry[0] == "Software")
            {
                this.Add(new Software(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])),
                  splitEntry[5], int.Parse(splitEntry[6]), int.Parse(splitEntry[7]), splitEntry[8], splitEntry[9]));
            }
            else if (splitEntry[0] == "Movie")
            {
                this.Add(new Movie(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])),
                      splitEntry[5], int.Parse(splitEntry[6]), int.Parse(splitEntry[7]), splitEntry[8], TimeSpan.Parse(splitEntry[9]), splitEntry[10], splitEntry[11]));

            }
            else if (splitEntry[0] == "Music")
            {
                this.Add(new Music(splitEntry[0], splitEntry[1], splitEntry[2], double.Parse((splitEntry[3])), int.Parse((splitEntry[4])),
                       splitEntry[5], int.Parse(splitEntry[6]), int.Parse(splitEntry[7]), splitEntry[8], TimeSpan.Parse(splitEntry[9]), splitEntry[10], splitEntry[12], splitEntry[11]));
            }
        }

        public virtual string ToCSV()
        {
            string CSVString = "";
            foreach (Product product in this)
                CSVString = CSVString + product.ToCSV() + "\r\n";
            return CSVString;
        }

        public override string ToString()
        {
           string ToStringString = String.Join(" ", this.Select(x => x.ToString().ToArray()));
            
            return ToStringString;
        }



    }
}

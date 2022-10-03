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

namespace verona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
        }

        const string filename = @"./veneto_verona.csv";
        string line = "";
        int recordLenght = 528;
        int numerorecord = 2592;
        char semicolon = ';';

        public void letturafile(string nome)
        {
            var sr = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            byte[] br = new byte[recordLenght];
            BinaryReader reader = new BinaryReader(sr);
            
            sr.Seek(0, SeekOrigin.Begin);
            byte[] bt = Encoding.ASCII.GetBytes(nome);

            int i = 0;
            int j = numerorecord;
            int m = 0;
            int pos = -1;
            int chg = 0;

            do
            {
                m = (i + j) / 2;
                chg = m * recordLenght;
                sr.Seek(chg, SeekOrigin.Begin);
                byte[] line = reader.ReadBytes(recordLenght);
                string linestr = Encoding.ASCII.GetString(line);
                int index = linestr.IndexOf(semicolon);

                byte[] bnt = reader.ReadBytes(index);
                if (bt == bnt)
                    pos = m;
                else if (bt[0] < bnt[0])
                    i = m + 1;
                else
                    j = m - 1;
            } while (i <= j && pos == -1);

            MessageBox.Show(sr.Seek(pos, SeekOrigin.Begin).ToString());
        }

        private void cerca_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            bool check = string.IsNullOrEmpty(nome);
            if (check)
            {
                MessageBox.Show("inserisci il comune da cercare!");
            }
            else
            letturafile(nome);
        }         
    }
}

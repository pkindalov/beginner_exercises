using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaToCyr
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            rctLatin.Text = Properties.Settings.Default.Latin;

        }

        private void btnToBul_Click(object sender, EventArgs e)
        {
            if (rctLatin.Text == string.Empty)
            {
                MessageBox.Show("Не сте въвели текст");
                
            }

            //тук са тежките случаи от времето на мирката четворки и шестици за ч и ш
            string convert = rctLatin.Text.ToLower();
            convert = convert.Replace("6", "ш");
            convert = convert.Replace("4", "ч");
            convert = convert.Replace("3", "е");
            convert = convert.Replace("7", "т");
            convert = convert.Replace("ch", "ч");
            convert = convert.Replace("ia", "я");
            convert = convert.Replace("iu", "ю");
            convert = convert.Replace("sht", "щ");
            convert = convert.Replace("zh", "ж");


           convert = convert.Replace("a", "а");
           convert = convert.Replace("b", "б");
           convert = convert.Replace("v", "ж");
           convert = convert.Replace("g", "г");
           convert = convert.Replace("d", "д");
           convert = convert.Replace("e", "е");
           convert = convert.Replace("w", "в");
           convert = convert.Replace("z", "з");
           convert = convert.Replace("i", "и");
           convert = convert.Replace("j", "й");
           convert = convert.Replace("k", "к");
           convert = convert.Replace("a", "а");
           convert = convert.Replace("l", "л");
           convert = convert.Replace("m", "м");
           convert = convert.Replace("n", "н");
           convert = convert.Replace("o", "о");
           convert = convert.Replace("p", "п");
           convert = convert.Replace("r", "р");
           convert = convert.Replace("s", "с");
           convert = convert.Replace("t", "т");
           convert = convert.Replace("u", "у");
           convert = convert.Replace("f", "ф");
           convert = convert.Replace("h", "х");
           convert = convert.Replace("c", "ц");
           convert = convert.Replace("`", "ч");
           convert = convert.Replace("[", "ш");
           convert = convert.Replace("]", "щ");
           convert = convert.Replace("y", "ъ");
           convert = convert.Replace("x", "ь");
           convert = convert.Replace("\\", "ю");
           convert = convert.Replace("q", "я");

            rctCyr.Text = convert;

        }

        private void btnPhonTrad_Click(object sender, EventArgs e)
        {
            if (rctLatin.Text == string.Empty)
            {
                MessageBox.Show("Не сте въвели текст");

            }

            string convert = rctLatin.Text.ToLower();

            convert = convert.Replace("6", "ш");
            convert = convert.Replace("4", "ч");
            convert = convert.Replace("3", "е");
            convert = convert.Replace("7", "т");
            convert = convert.Replace("ch", "ч");
            convert = convert.Replace("ia", "я");
            convert = convert.Replace("iu", "ю");
            convert = convert.Replace("sh", "ш");
            convert = convert.Replace("sht", "щ");
            convert = convert.Replace("tc", "ц");
            convert = convert.Replace("zh", "ж");

            convert = convert.Replace("d", "а");
            convert = convert.Replace("/", "б");
            convert = convert.Replace(";", "в");
            convert = convert.Replace("j", "г");
            convert = convert.Replace("o", "д");
            convert = convert.Replace("e", "е");
            convert = convert.Replace("g", "ж");
            convert = convert.Replace("p", "з");
            convert = convert.Replace("r", "и");
            convert = convert.Replace("x", "й");
            convert = convert.Replace("u", "к");
            convert = convert.Replace(".", "л");
            convert = convert.Replace("'", "м");
            convert = convert.Replace("l", "н");
            convert = convert.Replace("f", "о");
            convert = convert.Replace("m", "п");
            convert = convert.Replace(",", "р");
            convert = convert.Replace("i", "с");
            convert = convert.Replace("k", "т");
            convert = convert.Replace("w", "у");
            convert = convert.Replace("b", "ф");
            convert = convert.Replace("n", "х");
            convert = convert.Replace("[", "ц");
            convert = convert.Replace("\\", "ч");
            convert = convert.Replace("t", "ш");
            convert = convert.Replace("y", "щ");
            convert = convert.Replace("c", "ъ");
            convert = convert.Replace("a", "ь");
            convert = convert.Replace("z", "ю");
            convert = convert.Replace("s", "я");

            rctCyr.Text = convert;
        }

        private void btnPhonetic_Click(object sender, EventArgs e)
        {
            if (rctLatin.Text == string.Empty)
            {
                MessageBox.Show("Не сте въвели текст");

            }

            string convert = rctLatin.Text.ToLower();

            convert = convert.Replace("6", "ш");
            convert = convert.Replace("4", "ч");
            convert = convert.Replace("3", "е");
            convert = convert.Replace("7", "т");
            convert = convert.Replace("ch", "ч");
            convert = convert.Replace("ia", "я");
            convert = convert.Replace("iu", "ю");
            convert = convert.Replace("sh", "ш");
            convert = convert.Replace("sht", "щ");
            convert = convert.Replace("tc", "ц");
            convert = convert.Replace("zh", "ж");


            convert = convert.Replace("a", "а");
            convert = convert.Replace("b", "б");
            convert = convert.Replace("v", "в");
            convert = convert.Replace("g", "г");
            convert = convert.Replace("d", "д");
            convert = convert.Replace("e", "е");
            convert = convert.Replace("x", "ж");
            convert = convert.Replace("z", "з");
            convert = convert.Replace("i", "и");
            convert = convert.Replace("j", "й");
            convert = convert.Replace("k", "к");
            convert = convert.Replace("l", "л");
            convert = convert.Replace("m", "м");
            convert = convert.Replace("n", "н");
            convert = convert.Replace("o", "о");
            convert = convert.Replace("p", "п");
            convert = convert.Replace("r", "р");
            convert = convert.Replace("s", "с");
            convert = convert.Replace("t", "т");
            convert = convert.Replace("u", "у");
            convert = convert.Replace("f", "ф");
            convert = convert.Replace("h", "х");
            convert = convert.Replace("c", "ц");
            convert = convert.Replace("q", "ч");
            convert = convert.Replace("w", "ш");
            convert = convert.Replace("]", "щ");
            convert = convert.Replace("y", "ъ");
            convert = convert.Replace("\\", "ь");
            convert = convert.Replace("`", "ю");
            convert = convert.Replace("[", "я");
            //convert = convert.Replace("a", Properties.Settings.Default.A);
            //convert = convert.Replace("b", Properties.Settings.Default.B);
            //convert = convert.Replace("v", Properties.Settings.Default.C);
            //convert = convert.Replace("g", Properties.Settings.Default.D);
            //convert = convert.Replace("d", Properties.Settings.Default.D);
            //convert = convert.Replace("e", Properties.Settings.Default.E);
            //convert = convert.Replace("x", Properties.Settings.Default.F);
            //convert = convert.Replace("z", Properties.Settings.Default.G);
            //convert = convert.Replace("i", Properties.Settings.Default.H);
            //convert = convert.Replace("j", Properties.Settings.Default.I);
            //convert = convert.Replace("k", Properties.Settings.Default.J);
            //convert = convert.Replace("l", Properties.Settings.Default.K);
            //convert = convert.Replace("m", Properties.Settings.Default.L);
            //convert = convert.Replace("n", Properties.Settings.Default.M);
            //convert = convert.Replace("o", Properties.Settings.Default.N);
            //convert = convert.Replace("p", Properties.Settings.Default.O);
            //convert = convert.Replace("r", Properties.Settings.Default.P);
            //convert = convert.Replace("s", Properties.Settings.Default.Q);
            //convert = convert.Replace("t", Properties.Settings.Default.R);
            //convert = convert.Replace("u", Properties.Settings.Default.S);
            //convert = convert.Replace("f", Properties.Settings.Default.F);
            //convert = convert.Replace("h", Properties.Settings.Default.H);
            //convert = convert.Replace("c", Properties.Settings.Default.C);
            //convert = convert.Replace("q", Properties.Settings.Default.T);
            //convert = convert.Replace("w", Properties.Settings.Default.U);
            //convert = convert.Replace("]", Properties.Settings.Default.V);
            //convert = convert.Replace("y", Properties.Settings.Default.W);
            //convert = convert.Replace("\\", "ь");
            //convert = convert.Replace("`", "ю");
            //convert = convert.Replace("[", "я");

            rctCyr.Text = convert;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().TrimStart().StartsWith("{\rtf1", StringComparison.Ordinal))
            {
                rctLatin.Text = Clipboard.GetText(TextDataFormat.Rtf);
                //rctLatin.Text = Clipboard.GetText(TextDataFormat.Rtf);
                //rctLatin.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
            else
            {
                rctLatin.Text = Clipboard.GetText();
            }
                
               
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (rctCyr.Font.Bold || rctCyr.Font.Italic || rctCyr.Font.Underline)
            {
                Clipboard.SetText(rctCyr.Rtf, TextDataFormat.Rtf);
            }
            else
            {
                Clipboard.SetText(rctCyr.Text);
            }
            
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            rctLatin.Text = string.Empty;

            if (rctLatin.Text == string.Empty)
            {
                rctCyr.Text = string.Empty;
            }
        }

        private void btnBulTypewritter_Click(object sender, EventArgs e)
        {
            if (rctLatin.Text == string.Empty)
            {
                MessageBox.Show("Не сте въвели текст");

            }

            string convert = rctLatin.Text.ToLower();

            convert = convert.Replace("6", "ш");
            convert = convert.Replace("4", "ч");
            convert = convert.Replace("3", "е");
            convert = convert.Replace("7", "т");
            convert = convert.Replace("ch", "ч");
            convert = convert.Replace("ia", "я");
            convert = convert.Replace("iu", "ю");
            convert = convert.Replace("sh", "ш");
            convert = convert.Replace("sht", "щ");
            convert = convert.Replace("tc", "ц");
            convert = convert.Replace("zh", "ж");

            convert = convert.Replace("d", "а");
            convert = convert.Replace("/", "б");
            convert = convert.Replace(";", "в");
            convert = convert.Replace("h", "г");
            convert = convert.Replace("o", "д");
            convert = convert.Replace("e", "е");
            convert = convert.Replace("g", "ж");
            convert = convert.Replace("p", "з");
            convert = convert.Replace("r", "и");
            convert = convert.Replace("x", "й");
            convert = convert.Replace("u", "к");
            convert = convert.Replace(".", "л");
            convert = convert.Replace(";", "м");
            convert = convert.Replace("k", "н");
            convert = convert.Replace("f", "о");
            convert = convert.Replace("m", "п");
            convert = convert.Replace(",", "р");
            convert = convert.Replace("i", "с");
            convert = convert.Replace("j", "т");
            convert = convert.Replace("w", "у");
            convert = convert.Replace("b", "ф");
            convert = convert.Replace("n", "х");
            convert = convert.Replace("[", "ц");
            convert = convert.Replace("'", "ч");
            convert = convert.Replace("t", "ш");
            convert = convert.Replace("y", "щ");
            convert = convert.Replace("c", "ъ");
            convert = convert.Replace("a", "ь");
            convert = convert.Replace("z", "ю");
            convert = convert.Replace("s", "я");

            rctCyr.Text = convert;
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            rctCyr.Text = rctCyr.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            rctCyr.Text = rctCyr.Text.ToLower();
        }

        private void nmrFontSize_ValueChanged(object sender, EventArgs e)
        {
            //rctCyr.Size = nmrFontSize.Size;
            rctCyr.SelectionFont = new Font("Microsoft San Serif", (int)nmrFontSize.Value);
            rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value);
        }






        private void btnBold_Click(object sender, EventArgs e)
        {
            if (rctCyr.Font.Italic && rctCyr.Font.Underline)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            else if (rctCyr.Font.Italic)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Italic);
            }
            else if (rctCyr.Font.Underline)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Underline);
            }
            else
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold);
            }


            //rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold);

           

            //if (!rctCyr.Font.Italic && !rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold);
            //}


            //if (rctCyr.Font.Italic && rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            //}


            //if (rctCyr.Font.Italic)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Italic);
            //}

            //if (rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold |  FontStyle.Underline);
            //}

            

            
            
            //if (rctCyr.Font.Italic)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Italic);
            //}

            //else if (rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Underline);
            //}

            //else if (rctCyr.Font.Italic || rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            //}
            //else
            //{
            //    rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Bold);
            //}

        }





        private void btnItallic_Click(object sender, EventArgs e)
        {

            if (rctCyr.Font.Bold && rctCyr.Font.Underline)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
            }
            else if (rctCyr.Font.Bold)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Bold);
            }
            else if (rctCyr.Font.Underline)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Underline);
            }
            else
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Italic);
            }



            //if (rctCyr.Font.Bold)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Bold);
            //}

            //if (rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
            //}



            //if (!rctCyr.Font.Bold && !rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Italic);
            //}


            //if (rctCyr.Font.Bold)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Bold);
            //}
            //else if (rctCyr.Font.Bold || rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
            //}
            //else if (rctCyr.Font.Underline)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Underline);
            //}
            //else
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Italic);
            //}


            //rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Italic);

        }








        private void btnUnderline_Click(object sender, EventArgs e)
        {

            if (rctCyr.Font.Bold && rctCyr.Font.Italic)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
            }
            else if (rctCyr.Font.Bold)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Underline | FontStyle.Bold);
            }
            else if (rctCyr.Font.Italic)
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Underline | FontStyle.Italic);
            }
            else
            {
                rctCyr.Font = new Font("Microsoft San Serif", (int)nmrFontSize.Value, FontStyle.Underline);
            }
            //if (rctCyr.Font.Bold)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Underline | FontStyle.Bold);
            //}

            //else if (rctCyr.Font.Italic)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Underline | FontStyle.Italic);
            //}

            //else if (rctCyr.Font.Bold || rctCyr.Font.Italic)
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
            //}

            //else
            //{
            //    rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Underline);
            //}

            //rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Underline);

        }






        private void btnRegular_Click(object sender, EventArgs e)
        {
            rctCyr.Font = new Font("Microsoft Sans Serif", (int)nmrFontSize.Value, FontStyle.Regular);
        }



        private void btnLatin_Click(object sender, EventArgs e)
        {
            string convert = rctLatin.Text.ToLower();
            //convert = convert.Replace("6", "ш");
            //convert = convert.Replace("4", "ч");
            //convert = convert.Replace("3", "е");
            //convert = convert.Replace("7", "т");
            //convert = convert.Replace("ch", "ч");
            //convert = convert.Replace("ia", "я");
            //convert = convert.Replace("iu", "ю");
            //convert = convert.Replace("sht", "щ");
            //convert = convert.Replace("zh", "ж");


            convert = convert.Replace("а", "a");
            convert = convert.Replace("б", "b");
            convert = convert.Replace("в", "v");
            convert = convert.Replace("г", "g");
            convert = convert.Replace("д", "d");
            convert = convert.Replace("е", "e");
            convert = convert.Replace("ж", "zh");
            convert = convert.Replace("з", "z");
            convert = convert.Replace("и", "i");
            convert = convert.Replace("й", "i");
            convert = convert.Replace("к", "k");
            convert = convert.Replace("л", "l");
            convert = convert.Replace("м", "m");
            convert = convert.Replace("н", "n");
            convert = convert.Replace("о", "o");
            convert = convert.Replace("п", "p");
            convert = convert.Replace("р", "r");
            convert = convert.Replace("с", "s");
            convert = convert.Replace("т", "t");
            convert = convert.Replace("у", "y");
            convert = convert.Replace("ф", "f");
            convert = convert.Replace("х", "h");
            convert = convert.Replace("ц", "c");
            convert = convert.Replace("ч", "ch");
            convert = convert.Replace("ш", "sh");
            convert = convert.Replace("щ", "sht");
            convert = convert.Replace("ъ", "u");
            convert = convert.Replace("ь", "u");
            convert = convert.Replace("ю", "iu");
            convert = convert.Replace("я", "ia");

            rctCyr.Text = convert;
        }

        private void menuTopHorizontal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void превеждаПрограматаНаБългарскиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void преведиМенютоНаБългарскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnToBul.Text = "Български";
            btnPhonTrad.Text = "Традиционна фон.";
            btnPhonetic.Text = "Фонетика";
            btnBulTypewritter.Text = "Машинопис";
            btnPaste.Text = "Постави";
            btnErase.Text = "Изчисти";
            btnCopy.Text = "Копирай";
            btnToUpper.Text = "ГОЛЕМИ БУКВИ";
            btnLower.Text = "малки букви";
            btnBold.Text = "Б";
            btnItallic.Text = "Н";
            btnUnderline.Text = "П";
            btnRegular.Text = "О";
            btnLatin.Text = "Маймуница";

        }

        private void translateProgramToEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnToBul.Text = "Bulgarian";
            btnPhonTrad.Text = "Phonetic Trad";
            btnPhonetic.Text = "Phonetic";
            btnBulTypewritter.Text = "Typewritter";
            btnPaste.Text = "Paste";
            btnErase.Text = "Erase";
            btnCopy.Text = "Copy";
            btnToUpper.Text = "UPPER";
            btnLower.Text = "lower";
            btnBold.Text = "B";
            btnItallic.Text = "I";
            btnUnderline.Text = "U";
            btnRegular.Text = "R";
            btnLatin.Text = "Latin";
        }

        private void doYouWantReallyToExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void rctLatin_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Latin = rctLatin.Text;
            Properties.Settings.Default.Save();
        }

        private void makeYourOwnPhoneticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        byte clickCount = 1;
        private void btnCode_Click(object sender, EventArgs e)
        {
            clickCount++;
            //if (rctLatin.Text == string.Empty)
            //{
            //    MessageBox.Show("Не сте въвели текст");

            //}

            string convert = rctCyr.Text.ToLower();
            string codeword = string.Empty;
            int key = 0;

            try
            {
                 key = int.Parse(txtKey.Text);

                for (int i = 0; i < convert.Length; i++)
                {
                    int conv = convert[i] + key;
                    codeword += conv + " ";
                }
                if (clickCount > 4)
                {
                    MessageBox.Show("You can`t code more.");

                }

                rctCyr.Text = codeword;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong data type. I expect to enter integer");
                clickCount = 1;
                
            }

            

            

            //btnCode.Click += btnCode_Click;
            


            //convert = convert.Replace("а", Properties.Settings.Default.a.ToString());
            //convert = convert.Replace("б", Properties.Settings.Default.b.ToString());
            //convert = convert.Replace("в", Properties.Settings.Default.v.ToString());
            //convert = convert.Replace("г", Properties.Settings.Default.g.ToString());
            //convert = convert.Replace("д", Properties.Settings.Default.d.ToString());
            //convert = convert.Replace("е", Properties.Settings.Default.e.ToString());
            //convert = convert.Replace("ж", Properties.Settings.Default.zh.ToString());
            //convert = convert.Replace("з", Properties.Settings.Default.z.ToString());
            //convert = convert.Replace("и", Properties.Settings.Default.i.ToString());
            //convert = convert.Replace("й", Properties.Settings.Default.j.ToString());
            //convert = convert.Replace("к", Properties.Settings.Default.k.ToString());
            //convert = convert.Replace("л", Properties.Settings.Default.l.ToString());
            //convert = convert.Replace("м", Properties.Settings.Default.m.ToString());
            //convert = convert.Replace("н", Properties.Settings.Default.n.ToString());
            //convert = convert.Replace("о", Properties.Settings.Default.o.ToString());
            //convert = convert.Replace("п", Properties.Settings.Default.p.ToString());
            //convert = convert.Replace("р", Properties.Settings.Default.r.ToString());
            //convert = convert.Replace("с", Properties.Settings.Default.s.ToString());
            //convert = convert.Replace("т", Properties.Settings.Default.t.ToString());
            //convert = convert.Replace("у", Properties.Settings.Default.u.ToString());
            //convert = convert.Replace("ф", Properties.Settings.Default.f.ToString());
            //convert = convert.Replace("х", Properties.Settings.Default.h.ToString());
            //convert = convert.Replace("ц", Properties.Settings.Default.c.ToString());
            //convert = convert.Replace("ч", Properties.Settings.Default.ch.ToString());
            //convert = convert.Replace("ш", Properties.Settings.Default.sh).ToString();
            //convert = convert.Replace("щ", Properties.Settings.Default.sht.ToString());
            //convert = convert.Replace("ъ", Properties.Settings.Default.y.ToString());
            //convert = convert.Replace("ь", Properties.Settings.Default.erMaluk.ToString());
            //convert = convert.Replace("ю", Properties.Settings.Default.iu.ToString());
            //convert = convert.Replace("я", Properties.Settings.Default.ia.ToString());


            //if (convert.Contains("a"))
            //{
            //    convert = convert.Replace("а", Properties.Settings.Default.a.ToString());
            //}

            //if (convert.Contains("б"))
            //{
            //    convert = convert.Replace("б", Properties.Settings.Default.b.ToString());
            //}

            //if (convert.Contains("в"))
            //{
            //    convert = convert.Replace("в", Properties.Settings.Default.v.ToString());
            //}

            //if (convert.Contains("г"))
            //{
            //    convert = convert.Replace("г", Properties.Settings.Default.g.ToString());
            //}

            //if (convert.Contains("д"))
            //{
            //    convert = convert.Replace("д", Properties.Settings.Default.d.ToString());
            //}

            //if (convert.Contains("е"))
            //{
            //    convert = convert.Replace("е", Properties.Settings.Default.e.ToString());
            //}

            //if (convert.Contains("ж"))
            //{
            //    convert = convert.Replace("ж", Properties.Settings.Default.zh.ToString());
            //}

            //if (convert.Contains("з"))
            //{
            //    convert = convert.Replace("з", Properties.Settings.Default.z.ToString());
            //}

            //if (convert.Contains("и"))
            //{
            //    convert = convert.Replace("и", Properties.Settings.Default.i.ToString());
            //}

            //if (convert.Contains("й"))
            //{
            //    convert = convert.Replace("й", Properties.Settings.Default.j.ToString());
            //}

            //if (convert.Contains("к"))
            //{
            //    convert = convert.Replace("к", Properties.Settings.Default.k.ToString());
            //}

            //if (convert.Contains("л"))
            //{
            //    convert = convert.Replace("л", Properties.Settings.Default.l.ToString());
            //}

            //if (convert.Contains("м"))
            //{
            //    convert = convert.Replace("м", Properties.Settings.Default.m.ToString());
            //}

            //if (convert.Contains("н"))
            //{
            //    convert = convert.Replace("н", Properties.Settings.Default.n.ToString());
            //}

            //if (convert.Contains("о"))
            //{
            //    convert = convert.Replace("о", Properties.Settings.Default.o.ToString());
            //}

            //if (convert.Contains("п"))
            //{
            //    convert = convert.Replace("п", Properties.Settings.Default.p.ToString());
            //}

            //if (convert.Contains("р"))
            //{
            //    convert = convert.Replace("р", Properties.Settings.Default.r.ToString());
            //}

            //if (convert.Contains("с"))
            //{
            //    convert = convert.Replace("с", Properties.Settings.Default.s.ToString());
            //}

            //if (convert.Contains("т"))
            //{
            //    convert = convert.Replace("т", Properties.Settings.Default.t.ToString());
            //}

            //if (convert.Contains("у"))
            //{
            //    convert = convert.Replace("у", Properties.Settings.Default.u.ToString());
            //}

            //if (convert.Contains("ф"))
            //{
            //    convert = convert.Replace("ф", Properties.Settings.Default.f.ToString());
            //}

            //if (convert.Contains("х"))
            //{
            //    convert = convert.Replace("х", Properties.Settings.Default.h.ToString());
            //}

            //if (convert.Contains("ц"))
            //{
            //    convert = convert.Replace("ц", Properties.Settings.Default.c.ToString());
            //}

            //if (convert.Contains("ч"))
            //{
            //    convert = convert.Replace("ч", Properties.Settings.Default.ch.ToString());
            //}

            //if (convert.Contains("ш"))
            //{
            //    convert = convert.Replace("ш", Properties.Settings.Default.sh).ToString();
            //}

            //if (convert.Contains("щ"))
            //{
            //    convert = convert.Replace("щ", Properties.Settings.Default.sht.ToString());
            //}

            //if (convert.Contains("ъ"))
            //{
            //    convert = convert.Replace("ъ", Properties.Settings.Default.y.ToString());
            //}

            //if (convert.Contains("ь"))
            //{
            //    convert = convert.Replace("ь", Properties.Settings.Default.erMaluk.ToString());
            //}

            //if (convert.Contains("ю"))
            //{
            //    convert = convert.Replace("ю", Properties.Settings.Default.iu.ToString());
            //}

            //if (convert.Contains("я"))
            //{
            //    convert = convert.Replace("я", Properties.Settings.Default.ia.ToString());
            //}





























            //rctCyr.Text = convert;

            //convert = convert.Replace("6", Properties.Settings.Default.sh);
            //convert = convert.Replace("4", Properties.Settings.Default.ch);
            //convert = convert.Replace("3", Properties.Settings.Default.e);
            //convert = convert.Replace("7", Properties.Settings.Default.t);
            //convert = convert.Replace("ch", Properties.Settings.Default.ch);
            //convert = convert.Replace("ia", Properties.Settings.Default.ia);
            //convert = convert.Replace("iu", Properties.Settings.Default.iu);
            //convert = convert.Replace("sh", Properties.Settings.Default.sh);
            //convert = convert.Replace("sht", Properties.Settings.Default.sht);
            //convert = convert.Replace("tc", Properties.Settings.Default.c);
            //convert = convert.Replace("zh", Properties.Settings.Default.zh);

            //convert = convert.Replace("a", Properties.Settings.Default.a);
            //convert = convert.Replace("b", Properties.Settings.Default.b);
            //convert = convert.Replace("v", Properties.Settings.Default.v);
            //convert = convert.Replace("g", Properties.Settings.Default.g);
            //convert = convert.Replace("d", Properties.Settings.Default.d);
            //convert = convert.Replace("e", Properties.Settings.Default.e);
            //convert = convert.Replace("x", Properties.Settings.Default.h);
            //convert = convert.Replace("z", Properties.Settings.Default.z);
            //convert = convert.Replace("i", Properties.Settings.Default.i);
            //convert = convert.Replace("j", Properties.Settings.Default.j);
            //convert = convert.Replace("k", Properties.Settings.Default.k);
            //convert = convert.Replace("l", Properties.Settings.Default.l);
            //convert = convert.Replace("m", Properties.Settings.Default.m);
            //convert = convert.Replace("n", Properties.Settings.Default.n);
            //convert = convert.Replace("o", Properties.Settings.Default.o);
            //convert = convert.Replace("p", Properties.Settings.Default.p);
            //convert = convert.Replace("r", Properties.Settings.Default.r);
            //convert = convert.Replace("s", Properties.Settings.Default.s);
            //convert = convert.Replace("t", Properties.Settings.Default.t);
            //convert = convert.Replace("u", Properties.Settings.Default.u);
            //convert = convert.Replace("f", Properties.Settings.Default.f);
            //convert = convert.Replace("h", Properties.Settings.Default.h);
            //convert = convert.Replace("c", Properties.Settings.Default.c);
            //convert = convert.Replace("q", Properties.Settings.Default.ch);
            //convert = convert.Replace("w", Properties.Settings.Default.sh);
            //convert = convert.Replace("]", Properties.Settings.Default.sht);
            //convert = convert.Replace("y", Properties.Settings.Default.y);
            //convert = convert.Replace("\\", Properties.Settings.Default.erMaluk);
            //convert = convert.Replace("`", Properties.Settings.Default.iu);
            //convert = convert.Replace("[", Properties.Settings.Default.ia);

            //rctCyr.Text = convert;

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string[] convert = rctCyr.Text.ToLower().Split(' ');
            string decodeword = string.Empty;
            clickCount = 1;

            int key = 0;

            try
            {
                key = int.Parse(txtKey.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong data type. I expect to enter integer");

            }


            try
            {
                for (int i = 0; i < convert.Length; i++)
                {
                    if (convert[i] == string.Empty)
                    {
                        break;
                    }


                    int conv = int.Parse(convert[i]);
                    conv -= key;
                    decodeword += (char)conv;

                    rctCyr.Text = decodeword;
                }
            }
                catch (Exception)
                {
                    MessageBox.Show("Nothing to decode!");
                    
                }
                
                
                
            
            

            
            //for (int i = 0; i < convert.Length - 1; i++)
            //{
            //    int conv = convert[i] - 11;
            //    decodeword += (char)conv;
            //}


            
            //convert = convert.Replace(Properties.Settings.Default.a.ToString(), "а");
            //convert = convert.Replace(Properties.Settings.Default.b.ToString(), "б");
            //convert = convert.Replace(Properties.Settings.Default.v.ToString(), "в");
            //convert = convert.Replace(Properties.Settings.Default.g.ToString(), "г");
            //convert = convert.Replace(Properties.Settings.Default.d.ToString(), "д");
            //convert = convert.Replace(Properties.Settings.Default.e.ToString(), "е");
            //convert = convert.Replace(Properties.Settings.Default.zh.ToString(), "ж");
            //convert = convert.Replace(Properties.Settings.Default.z.ToString(), "з");
            //convert = convert.Replace(Properties.Settings.Default.i.ToString(), "и");
            //convert = convert.Replace(Properties.Settings.Default.j.ToString(), "й");
            //convert = convert.Replace(Properties.Settings.Default.k.ToString(), "к");
            //convert = convert.Replace(Properties.Settings.Default.l.ToString(), "л");
            //convert = convert.Replace(Properties.Settings.Default.m.ToString(), "м");
            //convert = convert.Replace(Properties.Settings.Default.n.ToString(), "н");
            //convert = convert.Replace(Properties.Settings.Default.o.ToString(), "о");
            //convert = convert.Replace(Properties.Settings.Default.p.ToString(), "п");
            //convert = convert.Replace(Properties.Settings.Default.r.ToString(), "р");
            //convert = convert.Replace(Properties.Settings.Default.s.ToString(), "с");
            //convert = convert.Replace(Properties.Settings.Default.t.ToString(), "т");
            //convert = convert.Replace(Properties.Settings.Default.u.ToString(), "у");
            //convert = convert.Replace(Properties.Settings.Default.f.ToString(), "ф");
            //convert = convert.Replace(Properties.Settings.Default.h.ToString(), "х");
            //convert = convert.Replace(Properties.Settings.Default.c.ToString(), "ц");
            //convert = convert.Replace(Properties.Settings.Default.ch.ToString(), "ч");
            //convert = convert.Replace(Properties.Settings.Default.sh.ToString(), "ш");
            //convert = convert.Replace(Properties.Settings.Default.sht.ToString(), "щ");
            //convert = convert.Replace(Properties.Settings.Default.y.ToString(), "ъ");
            //convert = convert.Replace(Properties.Settings.Default.erMaluk.ToString(), "ь");
            //convert = convert.Replace(Properties.Settings.Default.iu.ToString(), "ю");
            //convert = convert.Replace(Properties.Settings.Default.ia.ToString(), "я");


            //if (convert.Contains(Properties.Settings.Default.a))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.a.ToString(), "а");
            //}

            //if (convert.Contains(Properties.Settings.Default.b))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.b.ToString(), "б");
            //}

            //if (convert.Contains(Properties.Settings.Default.v))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.v.ToString(), "в");
            //}

            //if (convert.Contains(Properties.Settings.Default.g))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.g.ToString(), "г");
            //}

            //if (convert.Contains(Properties.Settings.Default.d))
            //{
            //    convert = convert.Replace("д", Properties.Settings.Default.d.ToString());
            //}

            //if (convert.Contains(Properties.Settings.Default.e))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.e.ToString(), "е");
            //}

            //if (convert.Contains(Properties.Settings.Default.zh))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.zh.ToString(), "ж");
            //}

            //if (convert.Contains(Properties.Settings.Default.z))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.z.ToString(), "з");
            //}

            //if (convert.Contains(Properties.Settings.Default.i))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.i.ToString(), "и");
            //}

            //if (convert.Contains(Properties.Settings.Default.j))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.j.ToString(), "й");
            //}

            //if (convert.Contains(Properties.Settings.Default.k))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.k.ToString(), "к");
            //}

            //if (convert.Contains(Properties.Settings.Default.l))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.l.ToString(), "л");
            //}

            //if (convert.Contains(Properties.Settings.Default.m))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.m.ToString(), "м");
            //}

            //if (convert.Contains(Properties.Settings.Default.n))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.n.ToString(), "н");
            //}

            //if (convert.Contains(Properties.Settings.Default.o))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.o.ToString(), "о");
            //}

            //if (convert.Contains(Properties.Settings.Default.p))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.p.ToString(), "п");
            //}

            //if (convert.Contains(Properties.Settings.Default.r))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.r.ToString(), "р");
            //}

            //if (convert.Contains(Properties.Settings.Default.s))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.s.ToString(), "с");
            //}

            //if (convert.Contains(Properties.Settings.Default.t))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.t.ToString(), "т");
            //}

            //if (convert.Contains(Properties.Settings.Default.u))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.u.ToString(), "у");
            //}

            //if (convert.Contains(Properties.Settings.Default.f))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.f.ToString(), "ф");
            //}

            //if (convert.Contains(Properties.Settings.Default.h))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.h.ToString(), "х");
            //}

            //if (convert.Contains(Properties.Settings.Default.c))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.c.ToString(), "ц");
            //}

            //if (convert.Contains(Properties.Settings.Default.ch))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.ch.ToString(), "ч");
            //}

            //if (convert.Contains(Properties.Settings.Default.sh))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.sh.ToString(), "ш");
            //}

            //if (convert.Contains(Properties.Settings.Default.sht))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.sht.ToString(), "щ");
            //}

            //if (convert.Contains(Properties.Settings.Default.y))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.y.ToString(), "ъ");
            //}

            //if (convert.Contains(Properties.Settings.Default.erMaluk))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.erMaluk.ToString(), "ь");
            //}

            //if (convert.Contains(Properties.Settings.Default.iu))
            //{
            //    convert = convert.Replace("ю", Properties.Settings.Default.iu.ToString());
            //}

            //if (convert.Contains(Properties.Settings.Default.ia))
            //{
            //    convert = convert.Replace(Properties.Settings.Default.ia.ToString(), "я");
            //}

            //rctCyr.Text = convert;
        }

        private void lnkGenKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rand = new Random();

            int randNumber = rand.Next(1, 2001);
            txtKey.Text = Convert.ToString(randNumber);

        }

        private void btnYourPhonetic_Click(object sender, EventArgs e)
        {
             if (rctLatin.Text == string.Empty)
            {
                MessageBox.Show("Не сте въвели текст");

            }

            string convert = rctLatin.Text.ToLower();

            convert = convert.Replace("6", "ш");
            convert = convert.Replace("4", "ч");
            convert = convert.Replace("3", "е");
            convert = convert.Replace("7", "т");
            convert = convert.Replace("ch", "ч");
            convert = convert.Replace("ia", "я");
            convert = convert.Replace("iu", "ю");
            convert = convert.Replace("sh", "ш");
            convert = convert.Replace("sht", "щ");
            convert = convert.Replace("tc", "ц");
            convert = convert.Replace("zh", "ж");



            convert = convert.Replace("a", Properties.Settings.Default.A);
            convert = convert.Replace("b", Properties.Settings.Default.B);
            convert = convert.Replace("c", Properties.Settings.Default.C);
            convert = convert.Replace("d", Properties.Settings.Default.D);
            convert = convert.Replace("e", Properties.Settings.Default.E);
            convert = convert.Replace("f", Properties.Settings.Default.F);
            convert = convert.Replace("g", Properties.Settings.Default.G);
            convert = convert.Replace("h", Properties.Settings.Default.H);
            convert = convert.Replace("i", Properties.Settings.Default.I);
            convert = convert.Replace("j", Properties.Settings.Default.J);
            convert = convert.Replace("k", Properties.Settings.Default.K);
            convert = convert.Replace("l", Properties.Settings.Default.L);
            convert = convert.Replace("m", Properties.Settings.Default.M);
            convert = convert.Replace("n", Properties.Settings.Default.N);
            convert = convert.Replace("o", Properties.Settings.Default.O);
            convert = convert.Replace("p", Properties.Settings.Default.P);
            convert = convert.Replace("q", Properties.Settings.Default.Q);
            convert = convert.Replace("r", Properties.Settings.Default.R);
            convert = convert.Replace("s", Properties.Settings.Default.S);
            convert = convert.Replace("t", Properties.Settings.Default.T);
            convert = convert.Replace("u", Properties.Settings.Default.U);
            convert = convert.Replace("v", Properties.Settings.Default.V);
            convert = convert.Replace("w", Properties.Settings.Default.W);
            convert = convert.Replace("x", Properties.Settings.Default.X);
            convert = convert.Replace("y", Properties.Settings.Default.Y);
            convert = convert.Replace("z", Properties.Settings.Default.Z);
            convert = convert.Replace("[", Properties.Settings.Default.leftBracket);
            convert = convert.Replace("]", Properties.Settings.Default.rightBracket);
            convert = convert.Replace("`", Properties.Settings.Default.firstButtonUnderEsc);
            convert = convert.Replace(";", Properties.Settings.Default.semicolon);
            convert = convert.Replace(".", Properties.Settings.Default.dot);
            convert = convert.Replace("'", Properties.Settings.Default.singleQuote);
            convert = convert.Replace("\\", Properties.Settings.Default.rightSlash);
            convert = convert.Replace("/", Properties.Settings.Default.leftSlash);
            convert = convert.Replace(",", Properties.Settings.Default.comma);


            //convert = convert.Replace("d", "а");
            //convert = convert.Replace("/", "б");
            //convert = convert.Replace(";", "в");
            //convert = convert.Replace("j", "г");
            //convert = convert.Replace("o", "д");
            //convert = convert.Replace("e", "е");
            //convert = convert.Replace("g", "ж");
            //convert = convert.Replace("p", "з");
            //convert = convert.Replace("r", "и");
            //convert = convert.Replace("x", "й");
            //convert = convert.Replace("u", "к");
            //convert = convert.Replace(".", "л");
            //convert = convert.Replace("'", "м");
            //convert = convert.Replace("l", "н");
            //convert = convert.Replace("f", "о");
            //convert = convert.Replace("m", "п");
            //convert = convert.Replace(",", "р");
            //convert = convert.Replace("i", "с");
            //convert = convert.Replace("k", "т");
            //convert = convert.Replace("w", "у");
            //convert = convert.Replace("b", "ф");
            //convert = convert.Replace("n", "х");
            //convert = convert.Replace("[", "ц");
            //convert = convert.Replace("\\", "ч");
            //convert = convert.Replace("t", "ш");
            //convert = convert.Replace("y", "щ");
            //convert = convert.Replace("c", "ъ");
            //convert = convert.Replace("a", "ь");
            //convert = convert.Replace("z", "ю");
            //convert = convert.Replace("s", "я");

            rctCyr.Text = convert;
        }
    }
}

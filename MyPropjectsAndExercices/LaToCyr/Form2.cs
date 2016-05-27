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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtA.Text = Properties.Settings.Default.A;
            txtB.Text = Properties.Settings.Default.B;
            txtC.Text = Properties.Settings.Default.C;
            txtD.Text = Properties.Settings.Default.D;
            txtE.Text = Properties.Settings.Default.E;
            txtF.Text = Properties.Settings.Default.F;
            txtG.Text = Properties.Settings.Default.G;
            txtH.Text = Properties.Settings.Default.H;
            txtI.Text = Properties.Settings.Default.I;
            txtJ.Text = Properties.Settings.Default.J;
            txtK.Text = Properties.Settings.Default.K;
            txtL.Text = Properties.Settings.Default.L;
            txtM.Text = Properties.Settings.Default.M;
            txtN.Text = Properties.Settings.Default.N;
            txtO.Text = Properties.Settings.Default.O;
            txtP.Text = Properties.Settings.Default.P;
            txtQ.Text = Properties.Settings.Default.Q;
            txtR.Text = Properties.Settings.Default.R;
            txtS.Text = Properties.Settings.Default.S;
            txtT.Text = Properties.Settings.Default.T;
            txtU.Text = Properties.Settings.Default.U;
            txtV.Text = Properties.Settings.Default.V;
            txtW.Text = Properties.Settings.Default.W;
            txtX.Text = Properties.Settings.Default.X;
            txtY.Text = Properties.Settings.Default.Y;
            txtZ.Text = Properties.Settings.Default.Z;
            txtY.Text = Properties.Settings.Default.Y;
            txtRightBracket.Text = Properties.Settings.Default.rightBracket;
            txtLeftBracket.Text = Properties.Settings.Default.leftBracket;
            txtFirstButtonUnderEsc.Text = Properties.Settings.Default.firstButtonUnderEsc;
            txtSemicolon.Text = Properties.Settings.Default.semicolon;
            txtDot.Text = Properties.Settings.Default.dot;
            txtSingleQuote.Text = Properties.Settings.Default.singleQuote;
            txtRightSlash.Text = Properties.Settings.Default.rightSlash;
            txtLeftSlash.Text = Properties.Settings.Default.leftSlash;
            txtComma.Text = Properties.Settings.Default.comma;


        }






        static int checkForEmptyField(TextBox txtIsItEmpty)
        {
            string txtName = txtIsItEmpty.Name;
            txtName = txtName.Substring(3);
            int count = 0;

            if (txtIsItEmpty.Text == string.Empty)
            {
                if (txtIsItEmpty.Name == "txtLeftBracket" || txtIsItEmpty.Name == "txtRightBracket" || txtIsItEmpty.Name == "txtFirstButtonUnderEsc" || txtIsItEmpty.Name == "txtSemicolon" || txtIsItEmpty.Name == "txtDot" || txtIsItEmpty.Name == "txtSingleQuote" || txtIsItEmpty.Name == "txtRightSlash" || txtIsItEmpty.Name == "txtLeftSlash" || txtIsItEmpty.Name == "txtComma")
                {
                    return count;
                }
                MessageBox.Show($"{txtName} cannot be empty");
                count++;
            }

            return count;
            
        }







        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] alphabetFields = new TextBox[]
            {
                txtA, txtB, txtC, txtD, txtE, txtF, txtG, txtH,
                txtI, txtJ, txtK, txtL, txtM, txtN, txtO, txtP,
                txtQ, txtR, txtS, txtT, txtU, txtV, txtW, txtX,
                txtY, txtZ, txtLeftBracket, txtRightBracket, txtFirstButtonUnderEsc,
                txtSemicolon, txtDot, txtSingleQuote, txtRightSlash, txtLeftSlash,
                txtComma
            };

            //checkForEmptyField(txtA);
            int emptyFieldsCount = 0;

            for (int i = 0; i < alphabetFields.Length; i++)
            {
                emptyFieldsCount += checkForEmptyField(alphabetFields[i]);
                if (emptyFieldsCount > 3)
                {
                    MessageBox.Show("Many fields are empty. Please fill it. ONLY OTHER KEYBORD KEYS CAN BE EMPTY");
                    break;
                }



            }


            if (emptyFieldsCount == 0)
            {
                Properties.Settings.Default.Save();
                MessageBox.Show("Saved successfully.");
            }
            

        }







        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.A = string.Empty;
            txtA.Text = string.Empty;
            Properties.Settings.Default.B = string.Empty;
            txtB.Text = string.Empty;
            Properties.Settings.Default.C = string.Empty;
            txtC.Text = string.Empty;
            Properties.Settings.Default.D = string.Empty;
            txtD.Text = string.Empty;
            Properties.Settings.Default.E = string.Empty;
            txtE.Text = string.Empty;
            Properties.Settings.Default.F = string.Empty;
            txtF.Text = string.Empty;
            Properties.Settings.Default.G = string.Empty;
            txtG.Text = string.Empty;
            Properties.Settings.Default.H = string.Empty;
            txtH.Text = string.Empty;
            Properties.Settings.Default.I = string.Empty;
            txtI.Text = string.Empty;
            Properties.Settings.Default.J = string.Empty;
            txtJ.Text = string.Empty;
            Properties.Settings.Default.K = string.Empty;
            txtK.Text = string.Empty;
            Properties.Settings.Default.L = string.Empty;
            txtL.Text = string.Empty;
            Properties.Settings.Default.M = string.Empty;
            txtM.Text = string.Empty;
            Properties.Settings.Default.N = string.Empty;
            txtN.Text = string.Empty;
            Properties.Settings.Default.O = string.Empty;
            txtO.Text = string.Empty;
            Properties.Settings.Default.P = string.Empty;
            txtP.Text = string.Empty;
            Properties.Settings.Default.Q = string.Empty;
            txtQ.Text = string.Empty;
            Properties.Settings.Default.R = string.Empty;
            txtR.Text = string.Empty;
            Properties.Settings.Default.S = string.Empty;
            txtS.Text = string.Empty;
            Properties.Settings.Default.T = string.Empty;
            txtT.Text = string.Empty;
            Properties.Settings.Default.U = string.Empty;
            txtU.Text = string.Empty;
            Properties.Settings.Default.V = string.Empty;
            txtV.Text = string.Empty;
            Properties.Settings.Default.W = string.Empty;
            txtW.Text = string.Empty;
            Properties.Settings.Default.X = string.Empty;
            txtX.Text = string.Empty;
            Properties.Settings.Default.Y = string.Empty;
            txtY.Text = string.Empty;
            Properties.Settings.Default.Z = string.Empty;
            txtZ.Text = string.Empty;



            Properties.Settings.Default.leftBracket = string.Empty;
            txtLeftBracket.Text = string.Empty;

            Properties.Settings.Default.rightBracket = string.Empty;
            txtRightBracket.Text = string.Empty;

            Properties.Settings.Default.firstButtonUnderEsc = string.Empty;
            txtFirstButtonUnderEsc.Text = string.Empty;

            Properties.Settings.Default.semicolon = string.Empty;
            txtSemicolon.Text = string.Empty;

            Properties.Settings.Default.dot = string.Empty;
            txtDot.Text = string.Empty;

            Properties.Settings.Default.singleQuote = string.Empty;
            txtSingleQuote.Text = string.Empty;

            Properties.Settings.Default.rightSlash = string.Empty;
            txtRightSlash.Text = string.Empty;

            Properties.Settings.Default.leftSlash = string.Empty;
            txtLeftSlash.Text = string.Empty;

            Properties.Settings.Default.comma = string.Empty;
            txtComma.Text = string.Empty;

            Properties.Settings.Default.Save();

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.A = txtA.Text;
            Properties.Settings.Default.Save();

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.B = txtB.Text;
            Properties.Settings.Default.Save();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.C = txtC.Text;
            Properties.Settings.Default.Save();
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.D = txtD.Text;
            Properties.Settings.Default.Save();
        }

        private void txtE_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.E = txtE.Text;
            Properties.Settings.Default.Save();
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.F = txtF.Text;
            Properties.Settings.Default.Save();
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.G = txtG.Text;
            Properties.Settings.Default.Save();
        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.H = txtH.Text;
            Properties.Settings.Default.Save();
        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.I = txtI.Text;
            Properties.Settings.Default.Save();
        }

        private void txtJ_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.J = txtJ.Text;
            Properties.Settings.Default.Save();
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.K = txtK.Text;
            Properties.Settings.Default.Save();
        }

        private void txtL_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.L = txtL.Text;
            Properties.Settings.Default.Save();
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.M = txtM.Text;
            Properties.Settings.Default.Save();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.N = txtN.Text;
            Properties.Settings.Default.Save();
        }

        private void txtO_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.O = txtO.Text;
            Properties.Settings.Default.Save();
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.P = txtP.Text;
            Properties.Settings.Default.Save();
        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Q = txtQ.Text;
            Properties.Settings.Default.Save();
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.R = txtR.Text;
            Properties.Settings.Default.Save();
        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.S = txtS.Text;
            Properties.Settings.Default.Save();
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.T = txtT.Text;
            Properties.Settings.Default.Save();
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.U = txtU.Text;
            Properties.Settings.Default.Save();
        }

        private void txtV_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.V = txtV.Text;
            Properties.Settings.Default.Save();
        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.W = txtW.Text;
            Properties.Settings.Default.Save();
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.X = txtX.Text;
            Properties.Settings.Default.Save();
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Y = txtY.Text;
            Properties.Settings.Default.Save();
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Z = txtZ.Text;
            Properties.Settings.Default.Save();
        }

        private void txtLeftBracket_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.leftBracket = txtLeftBracket.Text;
            Properties.Settings.Default.Save();
        }

        private void txtRightBracket_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rightBracket = txtRightBracket.Text;
            Properties.Settings.Default.Save();
        }

        private void txtFirstButtonUnderEsc_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.firstButtonUnderEsc = txtFirstButtonUnderEsc.Text;
            Properties.Settings.Default.Save();
        }

        private void txtSemicolon_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.semicolon = txtSemicolon.Text;
            Properties.Settings.Default.Save();
        }

        private void txtDot_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dot = txtDot.Text;
            Properties.Settings.Default.Save();
        }

        private void txtSingleQuote_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.singleQuote = txtSingleQuote.Text;
            Properties.Settings.Default.Save();
        }

        private void txtRightSlash_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rightSlash = txtRightSlash.Text;
            Properties.Settings.Default.Save();
        }

        private void txtLeftSlash_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.leftSlash = txtLeftSlash.Text;
            Properties.Settings.Default.Save();
        }

        private void txtComma_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.comma = txtComma.Text;
            Properties.Settings.Default.Save();
        }
    }       
}           
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
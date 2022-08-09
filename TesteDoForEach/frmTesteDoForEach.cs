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

namespace TesteDoForEach
{
    public partial class frmTesteDoForEach : Form
    {
        StreamReader objLeitorTxt;
        string strLinhaLida;

        public frmTesteDoForEach()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void btnDesvConv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha ok ou cancelar!", "Desvio Condicional!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Você escolheu ok!");
            }
            else
            {
                MessageBox.Show("Você escolheu cancelar!");
            }
        }

        private void btnDesvConvEnc_Click(object sender, EventArgs e)
        {
            DialogResult ResultadoDoClique = MessageBox.Show("Escolha sim,não ou cancelar!", "Desvio Condicional encadeado!", MessageBoxButtons.YesNoCancel);
            if (ResultadoDoClique == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("você escolheu sim!");
            }
            else if (ResultadoDoClique == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("você escolheu não!");
            }
            else
            {
                MessageBox.Show("Você escolheu cancelar!");
            }
        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Escolha sim,não ou cancelar!", "Desvio Condicional encadeado!", MessageBoxButtons.YesNoCancel))
            { 
                case System.Windows.Forms.DialogResult.Yes:
                    MessageBox.Show("Você escolheu sim!");
                    break;
                case System.Windows.Forms.DialogResult.No:
                    MessageBox.Show("Você escolheu não!");
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    MessageBox.Show("Você escolheu cancelar!");
                    break;
                default:
                    MessageBox.Show("Você escolheu errado!,Escolha sim,não ou cancelar");
                    break;
            }
        }

        private void btnImpTxtWhile_Click(object sender, EventArgs e)
        {
            lstbxPreferencias.Items.Clear();
            ImpTxtWhile();
        }
        public void ImpTxtWhile()
        {
            objLeitorTxt = new StreamReader(@"C:\Curso Programar\Preferencias.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            while (strLinhaLida != null)
            {
                lstbxPreferencias.Items.Add(strLinhaLida);
                strLinhaLida = objLeitorTxt.ReadLine();
            }
            objLeitorTxt.Close();
        }

        private void btnImpTxtDoWhile_Click(object sender, EventArgs e)
        {
            ImpTxtDoWhile();
        }
        public void ImpTxtDoWhile()
        {
            objLeitorTxt = new StreamReader(@"C:\Curso Programar\Preferencias.txt");
            strLinhaLida = objLeitorTxt.ReadLine();

            do
            {
                lstbxPreferencias.Items.Add(strLinhaLida);
                strLinhaLida = objLeitorTxt.ReadLine();
            } while (strLinhaLida != null);
            objLeitorTxt.Close();
        }

        private void btnImpTxtFor_Click(object sender, EventArgs e)
        {
            ImpTxtFor();
        }
        public void ImpTxtFor()
        {
            objLeitorTxt = new StreamReader(@"C:\Curso Programar\Preferencias.txt");
            

            for(strLinhaLida = objLeitorTxt.ReadLine();strLinhaLida != null;strLinhaLida = objLeitorTxt.ReadLine())

            {
                lstbxPreferencias.Items.Add(strLinhaLida);
            }
            objLeitorTxt.Close();
        }

        private void btnImpTxtForEach_Click(object sender, EventArgs e)
        {
            ImpTxtForEach();
        }
        public void ImpTxtForEach()
        {
            objLeitorTxt = new StreamReader(@"C:\Curso Programar\Preferencias.txt");
            string[] arrListaCompleta = objLeitorTxt.ReadToEnd().Split('\n');

            foreach(string itemLido in arrListaCompleta)

            {
                lstbxPreferencias.Items.Add(itemLido);
                
            }
            objLeitorTxt.Close();
        }
    }
}

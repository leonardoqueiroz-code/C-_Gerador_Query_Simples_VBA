using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtRng.Text = "\"" + txtRng1.Text + ":" + txtRng2.Text + "\"" ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtRng.Text = "\"" + txtRng1.Text + ":" + txtRng2.Text + "\"" + " & intLinha";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {

            txtOutput.Text += ( "\r\n Sub " + txtSUB2.Text + "  \r\n" + " ' " + txtComentario.Text + " \r\n" + " Sheets(\"" + txtPlanilha.Text + "\")." + "Range(" + txtRng.Text + " )" + ".FormulaLocal = \" = " + txtFormula.Text + "\"" + " \r\n End Sub");
            txtMain.Text += (" \r\n Call " + txtSUB2.Text);

        }

        private void txtSUB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroSetRadioButton1_CheckedChanged(object sender)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            txtOutput.Text += ("\r\n  Dim intLinha As Integer \r\n  Sub INT_LINHA() \r\n     intLinha = Cells(Rows.Count, 1).End(xlUp).Row  \r\n  End Sub");
            txtMain.Text += txtSUB2.Text;
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            txtMain.Text += ("\r\n End sub");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtOutput.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtOutput.Enabled = false;
        }
    }

    public static class WinFormsExtensions
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}

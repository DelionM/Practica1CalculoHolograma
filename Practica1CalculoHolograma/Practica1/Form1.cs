using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Restart();
        }
        //Variables
        int TotalNeg = 0, TotalPos = 0, MayNeg = 0, MayPos = 0, CantNums, Num, Cont = 1;
        bool AddWasClicked = false;
        String CantNums2, Num2, TextNeg = "", TextPos = "";

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '-')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult seleccion = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (seleccion != DialogResult.Yes)
            {
                e.Cancel = true;
                Focus();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
    {
        e.Handled = true;
        e.SuppressKeyPress = true;
    }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            try
            {
                Restart();
            }
            catch
            {
                MessageBox.Show("Lo sentimos, pero ha habido un error inesperado mientras se intentaba reiniciar, por favor cierre la aplicacion e intente nuevamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Restart()
        {
            TotalNeg = 0;
            TotalPos = 0;
            MayNeg = 0;
            CantNums = 0;
            Num = 0;
            Cont = 1;
            AddWasClicked = false;
            CantNums2 = "";
            Num2 = "";
            TextNeg = "";
            TextPos = "";
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnRestart.Enabled = false;
            txtCantidad.Clear();
            txtCantidad.Enabled = true;
            txtNum.Enabled = false;
            txtNum.Clear();
            txtSumNeg.Enabled = false;
            txtSumNeg.Clear();
            txtSumPos.Enabled = false;
            txtSumPos.Clear();
            txtMayNeg.Enabled = false;
            txtMayNeg.Clear();
            txtMayPos.Enabled = false;
            txtMayPos.Clear();
            txtNeg.Enabled = false;
            txtNeg.Clear();
            txtPos.Enabled = false;
            txtPos.Clear();
            lblNo.Text = "No. " + Cont.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                BasicClear();
            }
            catch
            {
                MessageBox.Show("Ha habido un error a la hora de intentar una limpieza, por favor intente mas tarde", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void BasicClear()
        {
            txtNum.Clear();
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CantNums = Convert.ToInt32(txtCantidad.Text);
                btnClear.Enabled = false;
                AddWasClicked = true;
                if (Cont < CantNums)
                {
                    Cont++;
                    lblNo.Text = "No. " + Cont.ToString();
                    AddSomeNumbers();
                }
                else
                {
                    AddSomeNumbers();
                    btnAdd.Enabled = false;
                    btnClear.Enabled = false;
                    btnRestart.Enabled = true;
                    txtNum.Enabled = false;
                }
                BasicClear();                
            }
            catch
            {
                MessageBox.Show("Ha surgido un error al ejecutar el boton de añadir, por favor, clickee en 'Reinciar' para volver a iniciar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void AddSomeNumbers()
        {
            try
            {
                Num = Convert.ToInt32(txtNum.Text);
                if (Num < 0)
                {
                    TextNeg = TextNeg + "   " + Num.ToString() + "\\n";
                    txtNeg.Text = TextNeg;
                    TotalNeg += Num;
                    txtSumNeg.Text = TotalNeg.ToString();
                    if (Cont == 1)
                    {
                        MayNeg = Num;
                    }
                    else
                    {
                        if (Math.Abs(MayNeg) > Math.Abs(Num))
                        {
                            //El mayor sigue siendo el mayor
                        }
                        else
                        {
                            //Num es el nuevo mayor
                            MayNeg = Num;
                        }
                    }
                    txtMayNeg.Text = MayNeg.ToString();
                }
                else
                {
                    TextPos = TextPos + " -> \n" + Num.ToString()  ;
                    txtPos.Text = TextPos;
                    TotalPos += Num;
                    txtSumPos.Text = TotalPos.ToString();
                    if (Cont == 1)
                    {
                        MayPos = Num;
                    }
                    else
                    {
                        if (MayPos > Num)
                        {
                            //El mayor sigue siendo el mayor
                        }
                        else
                        {
                            //Num es el nuevo mayor
                            MayPos = Num;
                        }
                    }
                    txtMayPos.Text = MayPos.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ha habido un error inesperado durante la captura de datos, por favor, intente mas tarde", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AddWasClicked == false)
                {
                    Num2 = txtNum.Text;
                    if (Num2 == "")
                    {
                        txtCantidad.Enabled = true;
                        btnAdd.Enabled = false;
                        btnRestart.Enabled = false;
                        btnClear.Enabled = false;
                    }
                    else
                    {
                        txtCantidad.Enabled = false;
                        btnAdd.Enabled = true;
                        btnRestart.Enabled = true;
                        btnClear.Enabled = true;
                    }
                }
                else
                {
                    //Add fue clickeado, Solo cambia "Limpiar"
                    if (Num2 == "")
                    {
                        btnClear.Enabled = false;
                    }
                    else
                    {
                        btnClear.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado, intente reiniciar la aplicacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AddWasClicked == false)
                {
                    CantNums2 = txtCantidad.Text;
                    if (CantNums2 == "")
                    {
                        txtNum.Enabled = false;
                    }
                    else
                    {
                        txtNum.Enabled = true;
                    }
                }
                else
                {
                    //add fue clickeado, no hagas nada
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado, intente reiniciar la aplicacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

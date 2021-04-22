using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int X = 0;
        int Y = 0;

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        int igual = 0;
        int ponto = 0;
        string sinal = "";
        double resul = 0;
        double aux = 0;
        double mesave = 0;
        int quant = 0;

        public void botoes() 
        {
            if (textBox1.Text == "0" || igual > 0)
                textBox1.Clear();
            igual = 0;
            if (sinal != "" && quant == 0) 
            {
                textBox1.Clear();
                quant++;
            }
        }

        public void disablebtn()
        {
            btn0.Enabled = false; btn0.BackColor = Color.FromArgb(64,0,0);
            btn1.Enabled = false; btn1.BackColor = Color.FromArgb(64, 0, 0);
            btn2.Enabled = false; btn2.BackColor = Color.FromArgb(64, 0, 0);
            btn3.Enabled = false; btn3.BackColor = Color.FromArgb(64, 0, 0);
            btn4.Enabled = false; btn4.BackColor = Color.FromArgb(64, 0, 0);
            btn5.Enabled = false; btn5.BackColor = Color.FromArgb(64, 0, 0);
            btn6.Enabled = false; btn6.BackColor = Color.FromArgb(64, 0, 0);
            btn7.Enabled = false; btn7.BackColor = Color.FromArgb(64, 0, 0);
            btn8.Enabled = false; btn8.BackColor = Color.FromArgb(64, 0, 0);
            btn9.Enabled = false; btn9.BackColor = Color.FromArgb(64, 0, 0);
            btnvirgula.Enabled = false; btnvirgula.BackColor = Color.FromArgb(64, 0, 0);
            btnmais.Enabled = false; btnmais.BackColor = Color.FromArgb(64, 0, 0);
            btnmenos.Enabled = false; btnmenos.BackColor = Color.FromArgb(64, 0, 0);
            btnmult.Enabled = false; btnmult.BackColor = Color.FromArgb(64, 0, 0);
            btndiv.Enabled = false; btndiv.BackColor = Color.FromArgb(64, 0, 0);
            btnmaismenos.Enabled = false; btnmaismenos.BackColor = Color.FromArgb(64, 0, 0);
            btnraiz.Enabled = false; btnraiz.BackColor = Color.FromArgb(64, 0, 0);
            btnporcento.Enabled = false; btnporcento.BackColor = Color.FromArgb(64, 0, 0);
            btnnudiv1.Enabled = false; btnnudiv1.BackColor = Color.FromArgb(64, 0, 0);
            btnigual.Enabled = false; btnigual.BackColor = Color.FromArgb(64, 0, 0);
            btnbackspace.Enabled = false; btnbackspace.BackColor = Color.FromArgb(64, 0, 0);
            btnclear.Enabled = false; btnclear.BackColor = Color.FromArgb(64, 0, 0);
            btnMclear.Enabled = false; btnMclear.BackColor = Color.FromArgb(64, 0, 0);
            btnMread.Enabled = false; btnMread.BackColor = Color.FromArgb(64, 0, 0);
            btnMsave.Enabled = false; btnMsave.BackColor = Color.FromArgb(64, 0, 0);
            btnMmais.Enabled = false; btnMmais.BackColor = Color.FromArgb(64, 0, 0);
            btnMmenos.Enabled = false; btnMmenos.BackColor = Color.FromArgb(64, 0, 0);
        }

        public void enablebtn()
        {
            btn0.Enabled = true; btn0.BackColor = Color.Maroon;
            btn1.Enabled = true; btn1.BackColor = Color.Maroon;
            btn2.Enabled = true; btn2.BackColor = Color.Maroon;
            btn3.Enabled = true; btn3.BackColor = Color.Maroon;
            btn4.Enabled = true; btn4.BackColor = Color.Maroon;
            btn5.Enabled = true; btn5.BackColor = Color.Maroon;
            btn6.Enabled = true; btn6.BackColor = Color.Maroon;
            btn7.Enabled = true; btn7.BackColor = Color.Maroon;
            btn8.Enabled = true; btn8.BackColor = Color.Maroon;
            btn9.Enabled = true; btn9.BackColor = Color.Maroon;
            btnvirgula.Enabled = true; btnvirgula.BackColor = Color.Maroon;
            btnmais.Enabled = true; btnmais.BackColor = Color.Maroon;
            btnmenos.Enabled = true; btnmenos.BackColor = Color.Maroon;
            btnmult.Enabled = true; btnmult.BackColor = Color.Maroon;
            btndiv.Enabled = true; btndiv.BackColor = Color.Maroon;
            btnmaismenos.Enabled = true; btnmaismenos.BackColor = Color.Maroon;
            btnraiz.Enabled = true; btnraiz.BackColor = Color.Maroon;
            btnporcento.Enabled = true; btnporcento.BackColor = Color.Maroon;
            btnnudiv1.Enabled = true; btnnudiv1.BackColor = Color.Maroon;
            btnigual.Enabled = true; btnigual.BackColor = Color.Maroon;
            btnbackspace.Enabled = true; btnbackspace.BackColor = Color.Maroon;
            btnclear.Enabled = true; btnclear.BackColor = Color.Maroon;
            btnMclear.Enabled = true; btnMclear.BackColor = Color.Maroon;
            btnMread.Enabled = true; btnMread.BackColor = Color.Maroon;
            btnMsave.Enabled = true; btnMsave.BackColor = Color.Maroon;
            btnMmais.Enabled = true; btnMmais.BackColor = Color.Maroon;
            btnMmenos.Enabled = true; btnMmenos.BackColor = Color.Maroon;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            botoes();
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            ponto++;
            if(ponto < 2)
               textBox1.Text = textBox1.Text + ",";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ponto = 0;
            textBox1.Text = "0";
        }

        private void btnmaismenos_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * -1);
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            quant = 0;
            aux = Convert.ToDouble(textBox1.Text);
            label1.Text = label1.Text + textBox1.Text + " + ";
            if (sinal == "-")
            {
                sinal = "+";
                resul = resul - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
            else if (sinal == "*")
            {
                sinal = "+";
                resul = resul * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
            else if (sinal == "/")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "Impossível dividir por zero";
                    disablebtn();
                }
                if (textBox1.Text != "Impossível dividir por zero")
                {
                    sinal = "+";
                    resul = resul / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(resul);
                }
            }
            else
            {
                sinal = "+";
                resul = resul + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (sinal == "+")
                resul = resul + Convert.ToDouble(textBox1.Text);
            else if (sinal == "-")
                resul = resul - Convert.ToDouble(textBox1.Text);
            else if (sinal == "/")
                resul = resul / Convert.ToDouble(textBox1.Text);
            else
                resul = resul * Convert.ToDouble(textBox1.Text);
            
            textBox1.Text = Convert.ToString(resul);
            label1.Text = "";
            ponto = 0;
            sinal = "";
            resul = 0;
            igual = 1;
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            quant = 0;
            aux = Convert.ToDouble(textBox1.Text);
            label1.Text = label1.Text + textBox1.Text + " - ";
            if (sinal == "+")
            {
                resul = resul + Convert.ToDouble(textBox1.Text);
                sinal = "-";
                textBox1.Text = Convert.ToString(resul);
            }
            else if(sinal == "*"){
                sinal = "-";
                resul = resul * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
            else if (sinal == "/")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "Impossível dividir por zero";
                    disablebtn();
                }
                if (textBox1.Text != "Impossível dividir por zero")
                {
                    sinal = "-";
                    resul = resul / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(resul);
                }
            }
            else
            {
                if (resul == 0)
                    resul = Convert.ToDouble(textBox1.Text);
                else
                    resul = resul - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
                sinal = "-";
            }
        }

        private void btnclearall_Click(object sender, EventArgs e)
        {
            enablebtn();
            ponto = 0;
            sinal = "";
            resul = 0;
            label1.Text = "";
            textBox1.Text = "0";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            quant = 0;
            aux = Convert.ToDouble(textBox1.Text);
            label1.Text = label1.Text + textBox1.Text + " / ";
            if (sinal == "+")
            {
                resul = resul + Convert.ToDouble(textBox1.Text);
                sinal = "/";
                textBox1.Text = Convert.ToString(resul);
            }
            else if (sinal == "-")
            {
                sinal = "/";
                resul = resul - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
            else if (sinal == "*")
            {
                sinal = "/";
                resul = resul * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
            else
            {
                sinal = "/";
                if (resul == 0)
                    resul = Convert.ToDouble(textBox1.Text);

                textBox1.Text = Convert.ToString(resul);
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            quant = 0;
            aux = Convert.ToDouble(textBox1.Text);
            label1.Text = label1.Text + textBox1.Text + " * ";
            if (sinal == "+")
            {
                resul = resul + Convert.ToDouble(textBox1.Text);
                sinal = "*";
                textBox1.Text = Convert.ToString(resul);
                aux = Convert.ToDouble(textBox1.Text);
            }
            else if (sinal == "-")
            {
                sinal = "*";
                resul = resul - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
            else if (sinal == "/")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "Impossível dividir por zero";
                    disablebtn();
                }
                if (textBox1.Text != "Impossível dividir por zero")
                {
                    sinal = "*";
                    resul = resul / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(resul);
                }
            }
            else
            {
                sinal = "*";
                if (resul == 0)
                    resul = 1;
                resul = resul * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(resul);
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Sair_MouseLeave(object sender, EventArgs e)
        {
            Sair.BackColor = Color.IndianRed;
        }

        private void Sair_MouseMove(object sender, MouseEventArgs e)
        {
            Sair.BackColor = Color.Red;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button25_MouseMove(object sender, MouseEventArgs e)
        {
            button25.BackColor = Color.Blue;
        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            button25.BackColor = Color.SlateGray;
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) >= 0)
            {
                double raiz = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(raiz);
            }
            else
                textBox1.Text = "Entrada Inválida";
        }

        private void btnnudiv1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(1 / Convert.ToDouble(textBox1.Text));
        }

        private void btnporcento_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString((aux / 100) * Convert.ToDouble(textBox1.Text));
        }

        private void btnMsave_Click(object sender, EventArgs e)
        {
            mesave = Convert.ToDouble(textBox1.Text);
            memoria.Text = "M";
        }

        private void btnMread_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(mesave);
        }

        private void btnMclear_Click(object sender, EventArgs e)
        {
            mesave = 0;
            memoria.Text = "";
        }

        private void btnMmais_Click(object sender, EventArgs e)
        {
            mesave = mesave + Convert.ToDouble(textBox1.Text);
        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {
            mesave = mesave - Convert.ToDouble(textBox1.Text);
        }
    }
}

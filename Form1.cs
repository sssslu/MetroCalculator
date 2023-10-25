using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MetroCalculator
{
    public partial class f1 : MetroForm
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }
        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        double first = 0;
        double second = 0;


        public f1()
        {
            InitializeComponent();
        }

        private void metroButton17_Click(object sender, EventArgs e)//= 
        {
            second = Convert.ToDouble(label1.Text);

            switch (currentOperator)
            {
                case Operators.Add:
                    first += second;
                    break;
                case Operators.Subtract:
                    first -= second;
                    break;
                case Operators.Multiply:
                    first *= second;
                    break;
                case Operators.Divide:
                    if (second != 0)
                    {
                        first /= second;
                    }
                    else
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.", "계산 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            label1.Text = first.ToString("0.####"); // 결과를 문자열로 변환, 소수점 이하 4자리까지 표시
        }

        private void metroButton14_Click(object sender, EventArgs e)//0
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "0";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }


        private void metroButton1_Click(object sender, EventArgs e)//1
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "1";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }
        private void metroButton2_Click(object sender, EventArgs e)//2
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "2";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)//3
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "3";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton5_Click(object sender, EventArgs e)//4
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "4";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton6_Click(object sender, EventArgs e)//5
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "5";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton7_Click(object sender, EventArgs e)//6
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "6";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton9_Click(object sender, EventArgs e)//7
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "7";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton10_Click(object sender, EventArgs e)//8
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "8";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton11_Click(object sender, EventArgs e)//9
        {
            if (operatorChangeFlag == true)
            {
                label1.Text = "";
                operatorChangeFlag = false;
            }
            string strNum = label1.Text += "9";
            int intNum = Int32.Parse(strNum);
            label1.Text = intNum.ToString();
        }

        private void metroButton4_Click(object sender, EventArgs e)//+
        {
            first = Convert.ToDouble(label1.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void metroButton8_Click(object sender, EventArgs e)//-
        {
            first = Convert.ToDouble(label1.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void metroButton12_Click(object sender, EventArgs e)//x
        {
            first = Convert.ToDouble(label1.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void metroButton16_Click(object sender, EventArgs e)///
        {
            first = Convert.ToDouble(label1.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }


        private void metroButton13_Click(object sender, EventArgs e)//ac
        {
            first = 0;
            second = 0;
            operatorChangeFlag=false;
            label1.Text= "0";
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            first = 0;
            second = 0;
            operatorChangeFlag = false;
            label1.Text = "SLUCOMPANY NEVER GIVES UP";
        }
    }
}

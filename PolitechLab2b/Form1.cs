using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PolitechLab2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDownX1.DecimalPlaces = 2;
            numericUpDownY1.DecimalPlaces = 2;
            numericUpDownX2.DecimalPlaces = 2;
            numericUpDownY2.DecimalPlaces = 2;
            numericUpDownX3.DecimalPlaces = 2;
            numericUpDownY3.DecimalPlaces = 2;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            double textBox1 = Double.Parse(numericUpDownX1.Text);
            double textBox2 = Double.Parse(numericUpDownY1.Text);
            double textBox3 = Double.Parse(numericUpDownX2.Text);
            double textBox4 = Double.Parse(numericUpDownY2.Text);
            double textBox5 = Double.Parse(numericUpDownX3.Text);
            double textBox6 = Double.Parse(numericUpDownY3.Text);
            
            EqualSideTriangle triangle = new EqualSideTriangle(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);
            
            printResult(triangle);
        }

        private void printResult(EqualSideTriangle triangle)
        {
            if (triangle.isTriangle())
            {
                LabelIsTriangle.Text = "Is triangle!";
                labelSides.Text = "Side A: " + formatNumber(triangle.getSideA()) + 
                                "  Side B: " + formatNumber(triangle.getSideB()) + 
                                "  Side C: " + formatNumber(triangle.getSideC());

                LabelSquarePerimeter.Text = "Perimeter: " + triangle.getPerimetr().ToString("0.00") + 
                    "  Square: " + triangle.getSquare().ToString("0.00");
                labelCos.Text = "Cos(AB,BC): " + formatNumber(triangle.getCosABBC()) + 
                    "  Cos(BC,AC): " + formatNumber(triangle.getCosBCAC()) + 
                    "  Cos(AC,AB): " + formatNumber(triangle.getCosACAB());
                labelEqualTriangle.Text = triangle.isTriangle() ? "Is equal side triangle" : "Is not equal side triangle";
            }
            else
            {
                LabelIsTriangle.Text = "";
                labelSides.Text = "";
                LabelSquarePerimeter.Text = "";
                labelCos.Text = "";
                labelEqualTriangle.Text = "";
                LabelIsTriangle.Text = "Is not triangle!";
            }
        }

        private static string formatNumber(double value)
        {
            return value.ToString("0.00");
        }

     

        /*private bool validateNumberField(object field, ErrorProvider errorProvider)
        {
            MaskedTextBox maskedTextBox = field as MaskedTextBox;
            if (maskedTextBox.TextLength == 0)
            {
                errorProvider.SetError(maskedTextBox, "Field is empty!");
                return false;
            }
            else
            {
           
                return true;
            }
        }

        private bool validateAllNumberFields()
        {
            bool result = true;
            
            result = result & validateNumberField(numericUpDownX1, errorProvider1);
            result = result & validateNumberField(numericUpDownY1, errorProvider2);
            result = result & validateNumberField(numericUpDownX2, errorProvider3);
            result = result & validateNumberField(numericUpDownY2, errorProvider4);
            result = result & validateNumberField(numericUpDownX3, errorProvider5);
            result = result & validateNumberField(numericUpDownY3, errorProvider6);

            return result;
        }*/
       
    }







}

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
            loadData();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            printResult(getTriangle());
        }


        private EqualSideTriangle getTriangle()
        {
            double textBox1 = Double.Parse(numericUpDownX1.Text);
            double textBox2 = Double.Parse(numericUpDownY1.Text);
            double textBox3 = Double.Parse(numericUpDownX2.Text);
            double textBox4 = Double.Parse(numericUpDownY2.Text);
            double textBox5 = Double.Parse(numericUpDownX3.Text);
            double textBox6 = Double.Parse(numericUpDownY3.Text);

            EqualSideTriangle triangle = new EqualSideTriangle(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);
            return triangle; 
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

        private void saveData(String filename,EqualSideTriangle triangle)
        {

            using (System.IO.BinaryWriter binaryWriter = new System.IO.BinaryWriter(new System.IO.FileStream(filename, System.IO.FileMode.OpenOrCreate)))
            {
                binaryWriter.Write(Double.Parse(numericUpDownX1.Text));
                binaryWriter.Write(Double.Parse(numericUpDownY1.Text));
                binaryWriter.Write(Double.Parse(numericUpDownX2.Text));
                binaryWriter.Write(Double.Parse(numericUpDownY2.Text));
                binaryWriter.Write(Double.Parse(numericUpDownX3.Text));
                binaryWriter.Write(Double.Parse(numericUpDownY3.Text));
            }
           
        }

        private void loadData()
        {
            var result = MessageBox.Show("Upload lastest data?","", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                if (!openFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    return;
                }
                string filename = openFileDialog.FileName;
                using (System.IO.BinaryReader binaryReader = new System.IO.BinaryReader
                    (new System.IO.FileStream(filename, System.IO.FileMode.Open)))
                    {
                        numericUpDownX1.Text = binaryReader.ReadDouble().ToString();
                        numericUpDownY1.Text = binaryReader.ReadDouble().ToString();
                        numericUpDownX2.Text = binaryReader.ReadDouble().ToString();
                        numericUpDownY2.Text = binaryReader.ReadDouble().ToString();
                        numericUpDownX3.Text = binaryReader.ReadDouble().ToString();
                        numericUpDownY3.Text = binaryReader.ReadDouble().ToString();
                    }
            }
           
            
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            if (!saveFileDialog.ShowDialog().Equals(DialogResult.OK)) { 
                return; 
            }
            string filename = saveFileDialog.FileName;
            saveData(filename, getTriangle());
        }
    }







}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        
            public int count_8;
            public int count_7;
            public int count_6;
            public int count_5;
            public int count_4;
            public int count_3;
            public int count_2;

           
            public double V_8 { get; set; }
            public double V_7 { get; set; }
            public double V_6 { get; set; }
            public double V_5 { get; set; }
            public double V_4 { get; set; }
            public double V_3 { get; set; }
            public double V_2 { get; set; }
           
        
        class Part
        {
           
            public int count;
            public double V;
            public int L;
            public int D;
        }

        public double Загальна_куб { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        List<Part> parts = new List<Part>();
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {

            double[,] value = {{0.044,0.05,0.056,0.062,0.069,0.076,0.084,0.094,0.103,0.113,0.123,0.131,0.144,0.155,0.165,0.178,0.19,0.2,0.21,0.22,0.23,0.245,0.26,0.27,0.28,0.295,0.31,0.325,0.34,0.355,0.37,0.39,0.41,0.425,0.44,0.46,0.48,0.515,0.53,0.55,0.57,0.59,0.61,0.635,0.66,0.685,0.71,0.73,0.75,0.775,0.8,0.825,0.85,0.87,0.89},
            {0.069,0.077,0.086,0.097,0.107,0.119,0.13,0.144,0.157,0.171,0.185,0.203,0.22,0.235,0.25,0.265,0.28,0.3,0.32,0.34,0.36,0.375,0.39,0.41,0.43,0.45,0.47,0.495,0.515,0.543,0.57,0.595,0.62,0.645,0.67,0.7,0.73,0.765,0.8,0.83,0.86,0.89,0.92,0.955,0.99,1.025,1.06,1.1,1.13,1.17,1.2,1.24,1.27,1.31,1.34},
            {0.095,0.107,0.12,0.134,0.147,0.163,0.178,0.194,0.21,0.23,0.25,0.27,0.29,0.31,0.33,0.355,0.38,0.405,0.43,0.455,0.48,0.505,0.53,0.555,0.58,0.61,0.64,0.67,0.7,0.735,0.77,0.805,0.84,0.875,0.91,0.95,0.99,1.03,1.07,1.115,1.16,1.205,1.25,1.29,1.33,1.38,1.43,1.475,1.52,1.565,1.61,1.655,1.70,1.75,1.8},
            {0.124,0.14,0.156,0.173,0.19,0.21,0.23,0.25,0.27,0.295,0.32,0.345,0.37,0.395,0.42,0.45,0.48,0.51,0.54,0.57,0.6,0.635,0.67,0.705,0.74,0.775,0.81,0.85,0.89,0.935,0.98,1.02,1.06,1.105,1.15,1.2,1.25,1.3,1.35,1.405,1.46,1.515,1.57,1.625,1.68,1.74,1.8,1.855,1.91,1.965,2.02,2.085,2.13,2.19,2.25},
            {0.155,0.174,0.194,0.212,0.23,0.255,0.28,0.305,0.33,0.36,0.39,0.42,0.45,0.485,0.52,0.555,0.59,0.625,0.66,0.7,0.74,0.78,0.82,0.86,0.9,0.95,1,1.045,1.09,1.14,1.19,1.245,1.3,1.355,1.41,1.47,1.53,1.59,1.65,1.715,1.78,1.845,1.91,1.98,2.05,2.115,2.18,2.25,2.32,2.38,2.44,2.505,2.57,2.645,2.72},
            {0.189,0.196,0.23,0.255,0.28,0.32,0.34,0.37,0.4,0.43,0.46,0.495,0.53,0.57,0.61,0.655,0.7,0.74,0.78,0.83,0.88,0.925,0.97,1.02,1.07,1.125,1.18,1.24,1.3,1.355,1.41,1.475,1.54,1.605,1.67,1.74,1.81,1.885,1.96,2.035,2.11,2.19,2.27,2.345,2.42,2.495,2.57,2.65,2.73,2.805,2.88,2.965,3.05,3.14,3.23},
            {0.22,0.25,0.28,0.305,0.33,0.365,0.4,0.435,0.47,0.505,0.54,0.585,0.63,0.675,0.72,0.77,0.82,0.87,0.92,0.97,1.02,1.085,1.13,1.19,1.25,1.315,1.38,1.445,1.51,1.58,1.65,1.725,1.8,1.875,1.95,2.035,2.12,2.205,2.29,2.375,2.46,2.545,2.63,2.72,2.81,2.9,2.99,3.08,3.17,3.265,3.38,3.485,3.59,3.705,3.8 } };


            if(comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                return;
            }
            int b = Convert.ToInt32(comboBox2.Text) - 2;
            
            int c = Convert.ToInt32(comboBox3.Text) - 16;
            
            int a = Convert.ToInt32(comboBox1.Text);
           
            parts.Add(new Part() {L = b + 2, V = Math.Round(value[b, c] * a, 3), count = a, D = c});
            
            listBox2.Items.Add((listBox2.Items.Count+1)+")  Кубатура   L - " + comboBox2.Text + " м.  "+(char)0216+comboBox3.Text+
                " см.  ("+comboBox1.Text+"шт.) =  " + Math.Round(value[b, c] * a, 3)+" m"+(char)0179);
           
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                return;
            }
            parts.RemoveAt(listBox2.SelectedIndex);
            
            listBox2.Items.Clear();
            foreach (var item in parts)
            {
                listBox2.Items.Add((listBox2.Items.Count + 1) + ")  Кубатура   L - " + item.L + " м.  " + (char)0216 + item.D +
                " см.  (" + item.count + "шт.) =  " + item.V + " m" + (char)0179);
            }

            Підсумок();


        }


        private void Підсумок()
        {
            if (textBox2.TextLength == 0)
            {
                return;
            }

            ОбнуленняЗначень();
            
            foreach (var item in parts)
            {
                switch (item.L)
                {
                    case 2:
                        V_2 += item.V;
                        count_2 += item.count;
                        break;
                    case 3:
                        V_3 += item.V;
                        count_3 += item.count;
                        break;
                    case 4:
                        V_4 += item.V;
                        count_4 += item.count;
                        break;
                    case 5:
                        V_5 += item.V;
                        count_5 += item.count;
                        break;
                    case 6:
                        V_6 += item.V;
                        count_6 += item.count;
                        break;
                    case 7:
                        V_7 += item.V;
                        count_7 += item.count;
                        break;
                    case 8:
                        V_8 += item.V;
                        count_8 += item.count;
                        break;
                }
            }
            Загальна_куб = V_2 + V_3 + V_4 + V_5 + V_6 + V_7 + V_8;

            listBox1.Items.Add("Загальна кубатура становить - " + Math.Round(Загальна_куб, 3) + " m" + (char)0179);
            
            if (count_2 != 0)
            {
                listBox1.Items.Add("L-2.0 m. : " + count_2 + " шт. - " + V_2 + " m" + (char)0179);
            }
            if (count_3 != 0)
            {
                listBox1.Items.Add("L-3.0 m. : " + count_3 + " шт. - " + V_3 + " m" + (char)0179);
            }
            if (count_4 != 0)
            {
                listBox1.Items.Add("L-4.0 m. : " + count_4 + " шт. - " + V_4 + " m" + (char)0179);
            }
            if (count_5 != 0)
            {
                listBox1.Items.Add("L-5.0 m. : " + count_5 + " шт. - " + V_5 + " m" + (char)0179);
            }
            if (count_6 != 0)
            {
                listBox1.Items.Add("L-6.0 m. : " + count_6 + " шт. - " + V_6 + " m" + (char)0179);
            }
            if (count_7 != 0)
            {
                listBox1.Items.Add("L-7.0 m. : " + count_7 + " шт. - " + V_7 + " m" + (char)0179);
            }
            if (count_8 != 0)
            {
                listBox1.Items.Add("L-8.0 m. : " + count_8 + " шт. - " + V_8 + " m" + (char)0179);
            }
                    
            listBox1.Items.Add(new string('-', 60));
            listBox1.Items.Add("Вартість лісу становить : " + Math.Round(Загальна_куб, 3) * Convert.ToDouble(textBox2.Text) + " грн.");

        }

        private void ОбнуленняЗначень()
        {
            listBox1.Items.Clear();
            count_8 = 0;
            count_7 = 0;
            count_6 = 0;
            count_5 = 0;
            count_4 = 0;
            count_3 = 0;
            count_2 = 0;
            V_2 = 0;
            V_3 = 0;
            V_4 = 0;
            V_5 = 0;
            V_6 = 0;
            V_7 = 0;
            V_8 = 0;
            Загальна_куб = 0;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Підсумок();
        }


        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            ОбнуленняЗначень();
            listBox2.Items.Clear();
           
            textBox2.Text = null;
            parts.Clear();
            
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;

            

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point LastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        
        private int Lines = 0;
        private string[] result;
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == null)
            {
                return;
            }
            int countLines = listBox1.Items.Count + listBox2.Items.Count + 2;
            result = new string[countLines];
            // задаємо текст для друку
            foreach (var item in listBox1.Items)
            {  
                result[Lines] = item.ToString();
                Lines++;
            }
           
            result[Lines]= (new string('-', 70));
            Lines++;

            result[Lines] = (new string('-', 70));          
            Lines++;

            foreach (var item in listBox2.Items)
            {         
                result[Lines]= item.ToString();
                Lines++;
            }

            //объект для печати
           PrintDocument printDocument = new PrintDocument();

            //обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем



        }
        
        int counter = 0;//лічильник строк друку
        int curPage = 1;// поточна сторінка
        // обробник події друку
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
           
            int h = Convert.ToInt32(comboBox4.Text);
            float leftMargin = e.MarginBounds.Left; // відступ зліва у документі
            float topMargin = e.MarginBounds.Top; // відступ зверху в документі
            float yPos = 0; // поточна позиція Y для виведення рядка
           
            int i = 0;// лічильник рядків на сторінці
           
            Font myFont = new Font("Arial", h , FontStyle.Regular, GraphicsUnit.Pixel);

            int nLines = (int)(e.MarginBounds.Height / myFont.GetHeight(e.Graphics));
            int nPages = ((listBox1.Items.Count + listBox2.Items.Count + 2) - 1) / nLines + 1;


            while ((i < nLines ) && (counter < Lines))
            {
               
                yPos = topMargin + i* myFont.GetHeight(e.Graphics);
                // друк рядка result
                e.Graphics.DrawString(result[counter], myFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                i++;
                counter++;
                
            }
            // визначення чи потрібна ще одна сторінка
            e.HasMorePages = false;

            if (curPage < nPages)
            {
                // надання ще однієї сторінки
                e.HasMorePages = true;
                curPage++;

            }
        }

       
    }
    
}

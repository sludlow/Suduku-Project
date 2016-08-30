using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suduku
{
    public partial class Form1 : Form
    {
        private Array grid;
        private Array rows;
        private Array boxes;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = Array.CreateInstance(typeof(string), 9, 9);
            rows = Array.CreateInstance(typeof(int), 9, 9);
            generateGrid();
            generateRows();
            generateBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateGrid();
            if (isLegal())
            {
                messageBox.Text = "Legal";
                messageBox.ForeColor = Color.Green;
            }
            else
            {
                messageBox.Text = "NOT Legal";
                messageBox.ForeColor = Color.Red;
            }
        }
        private bool isLegal()
        {
            List<int> rowNums;
            List<int> colNums;
            List<int> boxNums;
            int value;
            for (int i = 0; i < 9; i++)
            {
                rowNums = new List<int>();
                colNums = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    //Row validation
                    if (!grid.GetValue(i, j).Equals(""))
                    {
                        value = Convert.ToInt16(grid.GetValue(i, j));
                        if (rowNums.Contains(value))
                        {
                            return false;
                        }
                        else
                        {
                            rowNums.Add(value);
                        }
                    }


                    //Column Valudation
                    if (!grid.GetValue(j, i).Equals(""))
                    {
                        value = Convert.ToInt16(grid.GetValue(j, i));
                        if (colNums.Contains(value))
                        {
                            return false;
                        }
                        else
                        {
                            colNums.Add(value);
                        }
                    }
                }
            }
            //Box Validation
            for(int i = 0; i < 7; i += 3)
            {
                for(int j = 0; j < 7; j+=3)
                {
                    boxNums = new List<int>();
                    for(int x = i; x < i+3; x++)
                    {
                        for(int y = j; y < j+3; y++)
                        {
                            if(!grid.GetValue(x,y).Equals(""))
                            {
                                value = Convert.ToInt16(grid.GetValue(x, y));
                                if(boxNums.Contains(value))
                                {
                                    return false;
                                }
                                else
                                {
                                    boxNums.Add(value);
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        private void generateGrid()
        {
            //Column 1
            grid.SetValue(A1.Text, 0, 0);
            grid.SetValue(B1.Text, 1, 0);
            grid.SetValue(C1.Text, 2, 0);
            grid.SetValue(D1.Text, 3, 0);
            grid.SetValue(E1.Text, 4, 0);
            grid.SetValue(F1.Text, 5, 0);
            grid.SetValue(G1.Text, 6, 0);
            grid.SetValue(H1.Text, 7, 0);
            grid.SetValue(I1.Text, 8, 0);
            //Column 2
            grid.SetValue(A2.Text, 0, 1);
            grid.SetValue(B2.Text, 1, 1);
            grid.SetValue(C2.Text, 2, 1);
            grid.SetValue(D2.Text, 3, 1);
            grid.SetValue(E2.Text, 4, 1);
            grid.SetValue(F2.Text, 5, 1);
            grid.SetValue(G2.Text, 6, 1);
            grid.SetValue(H2.Text, 7, 1);
            grid.SetValue(I2.Text, 8, 1);
            //Column 3
            grid.SetValue(A3.Text, 0, 2);
            grid.SetValue(B3.Text, 1, 2);
            grid.SetValue(C3.Text, 2, 2);
            grid.SetValue(D3.Text, 3, 2);
            grid.SetValue(E3.Text, 4, 2);
            grid.SetValue(F3.Text, 5, 2);
            grid.SetValue(G3.Text, 6, 2);
            grid.SetValue(H3.Text, 7, 2);
            grid.SetValue(I3.Text, 8, 2);
            //Column 4
            grid.SetValue(A4.Text, 0, 3);
            grid.SetValue(B4.Text, 1, 3);
            grid.SetValue(C4.Text, 2, 3);
            grid.SetValue(D4.Text, 3, 3);
            grid.SetValue(E4.Text, 4, 3);
            grid.SetValue(F4.Text, 5, 3);
            grid.SetValue(G4.Text, 6, 3);
            grid.SetValue(H4.Text, 7, 3);
            grid.SetValue(I4.Text, 8, 3);
            //Column 5
            grid.SetValue(A5.Text, 0, 4);
            grid.SetValue(B5.Text, 1, 4);
            grid.SetValue(C5.Text, 2, 4);
            grid.SetValue(D5.Text, 3, 4);
            grid.SetValue(E5.Text, 4, 4);
            grid.SetValue(F5.Text, 5, 4);
            grid.SetValue(G5.Text, 6, 4);
            grid.SetValue(H5.Text, 7, 4);
            grid.SetValue(I5.Text, 8, 4);
            //Column 6
            grid.SetValue(A6.Text, 0, 5);
            grid.SetValue(B6.Text, 1, 5);
            grid.SetValue(C6.Text, 2, 5);
            grid.SetValue(D6.Text, 3, 5);
            grid.SetValue(E6.Text, 4, 5);
            grid.SetValue(F6.Text, 5, 5);
            grid.SetValue(G6.Text, 6, 5);
            grid.SetValue(H6.Text, 7, 5);
            grid.SetValue(I6.Text, 8, 5);
            //Column 7
            grid.SetValue(A7.Text, 0, 6);
            grid.SetValue(B7.Text, 1, 6);
            grid.SetValue(C7.Text, 2, 6);
            grid.SetValue(D7.Text, 3, 6);
            grid.SetValue(E7.Text, 4, 6);
            grid.SetValue(F7.Text, 5, 6);
            grid.SetValue(G7.Text, 6, 6);
            grid.SetValue(H7.Text, 7, 6);
            grid.SetValue(I7.Text, 8, 6);
            //Column 8
            grid.SetValue(A8.Text, 0, 7);
            grid.SetValue(B8.Text, 1, 7);
            grid.SetValue(C8.Text, 2, 7);
            grid.SetValue(D8.Text, 3, 7);
            grid.SetValue(E8.Text, 4, 7);
            grid.SetValue(F8.Text, 5, 7);
            grid.SetValue(G8.Text, 6, 7);
            grid.SetValue(H8.Text, 7, 7);
            grid.SetValue(I8.Text, 8, 7);
            //Column 9
            grid.SetValue(A9.Text, 0, 8);
            grid.SetValue(B9.Text, 1, 8);
            grid.SetValue(C9.Text, 2, 8);
            grid.SetValue(D9.Text, 3, 8);
            grid.SetValue(E9.Text, 4, 8);
            grid.SetValue(F9.Text, 5, 8);
            grid.SetValue(G9.Text, 6, 8);
            grid.SetValue(H9.Text, 7, 8);
            grid.SetValue(I9.Text, 8, 8);
        }
        public void generateRows()
        {
            //Row 1
            rows.SetValue(Convert.ToInt16(A1.Text), 0, 0);
            rows.SetValue(Convert.ToInt16(A2.Text), 1, 0);
            rows.SetValue(Convert.ToInt16(A3.Text), 2, 0);
            rows.SetValue(Convert.ToInt16(A4.Text), 3, 0);
            rows.SetValue(Convert.ToInt16(A5.Text), 4, 0);
            rows.SetValue(Convert.ToInt16(A6.Text), 5, 0);
            rows.SetValue(Convert.ToInt16(A7.Text), 6, 0);
            rows.SetValue(Convert.ToInt16(A8.Text), 7, 0);
            rows.SetValue(Convert.ToInt16(A9.Text), 8, 0);
            //Row 2
            rows.SetValue(Convert.ToInt16(B1.Text), 0, 1);
            rows.SetValue(Convert.ToInt16(B2.Text), 1, 1);
            rows.SetValue(Convert.ToInt16(B3.Text), 2, 1);
            rows.SetValue(Convert.ToInt16(B4.Text), 3, 1);
            rows.SetValue(Convert.ToInt16(B5.Text), 4, 1);
            rows.SetValue(Convert.ToInt16(B6.Text), 5, 1);
            rows.SetValue(Convert.ToInt16(B7.Text), 6, 1);
            rows.SetValue(Convert.ToInt16(B8.Text), 7, 1);
            rows.SetValue(Convert.ToInt16(B9.Text), 8, 1);
            //Row 3
            rows.SetValue(Convert.ToInt16(C1.Text), 0, 2);
            rows.SetValue(Convert.ToInt16(C2.Text), 1, 2);
            rows.SetValue(Convert.ToInt16(C3.Text), 2, 2);
            rows.SetValue(Convert.ToInt16(C4.Text), 3, 2);
            rows.SetValue(Convert.ToInt16(C5.Text), 4, 2);
            rows.SetValue(Convert.ToInt16(C6.Text), 5, 2);
            rows.SetValue(Convert.ToInt16(C7.Text), 6, 2);
            rows.SetValue(Convert.ToInt16(C8.Text), 7, 2);
            rows.SetValue(Convert.ToInt16(C9.Text), 8, 2);
            //Row 4
            rows.SetValue(Convert.ToInt16(D1.Text), 0, 3);
            rows.SetValue(Convert.ToInt16(D2.Text), 1, 3);
            rows.SetValue(Convert.ToInt16(D3.Text), 2, 3);
            rows.SetValue(Convert.ToInt16(D4.Text), 3, 3);
            rows.SetValue(Convert.ToInt16(D5.Text), 4, 3);
            rows.SetValue(Convert.ToInt16(D6.Text), 5, 3);
            rows.SetValue(Convert.ToInt16(D7.Text), 6, 3);
            rows.SetValue(Convert.ToInt16(D8.Text), 7, 3);
            rows.SetValue(Convert.ToInt16(D9.Text), 8, 3);
            //Row 5
            rows.SetValue(Convert.ToInt16(E1.Text), 0, 4);
            rows.SetValue(Convert.ToInt16(E2.Text), 1, 4);
            rows.SetValue(Convert.ToInt16(E3.Text), 2, 4);
            rows.SetValue(Convert.ToInt16(E4.Text), 3, 4);
            rows.SetValue(Convert.ToInt16(E5.Text), 4, 4);
            rows.SetValue(Convert.ToInt16(E6.Text), 5, 4);
            rows.SetValue(Convert.ToInt16(E7.Text), 6, 4);
            rows.SetValue(Convert.ToInt16(E8.Text), 7, 4);
            rows.SetValue(Convert.ToInt16(E9.Text), 8, 4);
            //Row 6
            rows.SetValue(Convert.ToInt16(F1.Text), 0, 5);
            rows.SetValue(Convert.ToInt16(F2.Text), 1, 5);
            rows.SetValue(Convert.ToInt16(F3.Text), 2, 5);
            rows.SetValue(Convert.ToInt16(F4.Text), 3, 5);
            rows.SetValue(Convert.ToInt16(F5.Text), 4, 5);
            rows.SetValue(Convert.ToInt16(F6.Text), 5, 5);
            rows.SetValue(Convert.ToInt16(F7.Text), 6, 5);
            rows.SetValue(Convert.ToInt16(F8.Text), 7, 5);
            rows.SetValue(Convert.ToInt16(F9.Text), 8, 5);
            //Row 7
            rows.SetValue(Convert.ToInt16(G1.Text), 0, 6);
            rows.SetValue(Convert.ToInt16(G2.Text), 1, 6);
            rows.SetValue(Convert.ToInt16(G3.Text), 2, 6);
            rows.SetValue(Convert.ToInt16(G4.Text), 3, 6);
            rows.SetValue(Convert.ToInt16(G5.Text), 4, 6);
            rows.SetValue(Convert.ToInt16(G6.Text), 5, 6);
            rows.SetValue(Convert.ToInt16(G7.Text), 6, 6);
            rows.SetValue(Convert.ToInt16(G8.Text), 7, 6);
            rows.SetValue(Convert.ToInt16(G9.Text), 8, 6);
            //Row 8
            rows.SetValue(Convert.ToInt16(H1.Text), 0, 7);
            rows.SetValue(Convert.ToInt16(H2.Text), 1, 7);
            rows.SetValue(Convert.ToInt16(H3.Text), 2, 7);
            rows.SetValue(Convert.ToInt16(H4.Text), 3, 7);
            rows.SetValue(Convert.ToInt16(H5.Text), 4, 7);
            rows.SetValue(Convert.ToInt16(H6.Text), 5, 7);
            rows.SetValue(Convert.ToInt16(H7.Text), 6, 7);
            rows.SetValue(Convert.ToInt16(H8.Text), 7, 7);
            rows.SetValue(Convert.ToInt16(H9.Text), 8, 7);
            //Row 9
            rows.SetValue(Convert.ToInt16(I1.Text), 0, 8);
            rows.SetValue(Convert.ToInt16(I2.Text), 1, 8);
            rows.SetValue(Convert.ToInt16(I3.Text), 2, 8);
            rows.SetValue(Convert.ToInt16(I4.Text), 3, 8);
            rows.SetValue(Convert.ToInt16(I5.Text), 4, 8);
            rows.SetValue(Convert.ToInt16(I6.Text), 5, 8);
            rows.SetValue(Convert.ToInt16(I7.Text), 6, 8);
            rows.SetValue(Convert.ToInt16(I8.Text), 7, 8);
            rows.SetValue(Convert.ToInt16(I9.Text), 8, 8);
        }
        private void generateBoxes()
        {
            //box 1
            boxes.SetValue(Convert.ToInt16(A1.Text), 0, 0);
            boxes.SetValue(Convert.ToInt16(A2.Text), 1, 0);
            boxes.SetValue(Convert.ToInt16(A3.Text), 2, 0);
            boxes.SetValue(Convert.ToInt16(B1.Text), 3, 0);
            boxes.SetValue(Convert.ToInt16(B2.Text), 4, 0);
            boxes.SetValue(Convert.ToInt16(B3.Text), 5, 0);
            boxes.SetValue(Convert.ToInt16(C1.Text), 6, 0);
            boxes.SetValue(Convert.ToInt16(C2.Text), 7, 0);
            boxes.SetValue(Convert.ToInt16(C3.Text), 8, 0);
            //box 2
            boxes.SetValue(Convert.ToInt16(A4.Text), 0, 1);
            boxes.SetValue(Convert.ToInt16(A5.Text), 1, 1);
            boxes.SetValue(Convert.ToInt16(A6.Text), 2, 1);
            boxes.SetValue(Convert.ToInt16(B4.Text), 3, 1);
            boxes.SetValue(Convert.ToInt16(B5.Text), 4, 1);
            boxes.SetValue(Convert.ToInt16(B6.Text), 5, 1);
            boxes.SetValue(Convert.ToInt16(C4.Text), 6, 1);
            boxes.SetValue(Convert.ToInt16(C5.Text), 7, 1);
            boxes.SetValue(Convert.ToInt16(C6.Text), 8, 1);
            //box 3
            boxes.SetValue(Convert.ToInt16(A7.Text), 0, 2);
            boxes.SetValue(Convert.ToInt16(A8.Text), 1, 2);
            boxes.SetValue(Convert.ToInt16(A9.Text), 2, 2);
            boxes.SetValue(Convert.ToInt16(B7.Text), 3, 2);
            boxes.SetValue(Convert.ToInt16(B8.Text), 4, 2);
            boxes.SetValue(Convert.ToInt16(B9.Text), 5, 2);
            boxes.SetValue(Convert.ToInt16(C7.Text), 6, 2);
            boxes.SetValue(Convert.ToInt16(C8.Text), 7, 2);
            boxes.SetValue(Convert.ToInt16(C9.Text), 8, 2);
            //box 4
            boxes.SetValue(Convert.ToInt16(D1.Text), 0, 3);
            boxes.SetValue(Convert.ToInt16(D2.Text), 1, 3);
            boxes.SetValue(Convert.ToInt16(D3.Text), 2, 3);
            boxes.SetValue(Convert.ToInt16(E1.Text), 3, 3);
            boxes.SetValue(Convert.ToInt16(E2.Text), 4, 3);
            boxes.SetValue(Convert.ToInt16(E3.Text), 5, 3);
            boxes.SetValue(Convert.ToInt16(F1.Text), 6, 3);
            boxes.SetValue(Convert.ToInt16(F2.Text), 7, 3);
            boxes.SetValue(Convert.ToInt16(F3.Text), 8, 3);
            //box 5
            boxes.SetValue(Convert.ToInt16(D4.Text), 0, 4);
            boxes.SetValue(Convert.ToInt16(D5.Text), 1, 4);
            boxes.SetValue(Convert.ToInt16(D6.Text), 2, 4);
            boxes.SetValue(Convert.ToInt16(E4.Text), 3, 4);
            boxes.SetValue(Convert.ToInt16(E5.Text), 4, 4);
            boxes.SetValue(Convert.ToInt16(E6.Text), 5, 4);
            boxes.SetValue(Convert.ToInt16(F4.Text), 6, 4);
            boxes.SetValue(Convert.ToInt16(F5.Text), 7, 4);
            boxes.SetValue(Convert.ToInt16(F6.Text), 8, 4);
            //box 6
            boxes.SetValue(Convert.ToInt16(D7.Text), 0, 5);
            boxes.SetValue(Convert.ToInt16(D8.Text), 1, 5);
            boxes.SetValue(Convert.ToInt16(D9.Text), 2, 5);
            boxes.SetValue(Convert.ToInt16(E7.Text), 3, 5);
            boxes.SetValue(Convert.ToInt16(E8.Text), 4, 5);
            boxes.SetValue(Convert.ToInt16(E9.Text), 5, 5);
            boxes.SetValue(Convert.ToInt16(F7.Text), 6, 5);
            boxes.SetValue(Convert.ToInt16(F8.Text), 7, 5);
            boxes.SetValue(Convert.ToInt16(F9.Text), 8, 5);
            //box 7
            boxes.SetValue(Convert.ToInt16(G1.Text), 0, 6);
            boxes.SetValue(Convert.ToInt16(G2.Text), 1, 6);
            boxes.SetValue(Convert.ToInt16(G3.Text), 2, 6);
            boxes.SetValue(Convert.ToInt16(H1.Text), 3, 6);
            boxes.SetValue(Convert.ToInt16(H2.Text), 4, 6);
            boxes.SetValue(Convert.ToInt16(H3.Text), 5, 6);
            boxes.SetValue(Convert.ToInt16(I1.Text), 6, 6);
            boxes.SetValue(Convert.ToInt16(I2.Text), 7, 6);
            boxes.SetValue(Convert.ToInt16(I3.Text), 8, 6);
            //box 8
            boxes.SetValue(Convert.ToInt16(G4.Text), 0, 7);
            boxes.SetValue(Convert.ToInt16(G5.Text), 1, 7);
            boxes.SetValue(Convert.ToInt16(G6.Text), 2, 7);
            boxes.SetValue(Convert.ToInt16(H4.Text), 3, 7);
            boxes.SetValue(Convert.ToInt16(H5.Text), 4, 7);
            boxes.SetValue(Convert.ToInt16(H6.Text), 5, 7);
            boxes.SetValue(Convert.ToInt16(I4.Text), 6, 7);
            boxes.SetValue(Convert.ToInt16(I5.Text), 7, 7);
            boxes.SetValue(Convert.ToInt16(I6.Text), 8, 7);
            //box 9
            boxes.SetValue(Convert.ToInt16(G7.Text), 0, 8);
            boxes.SetValue(Convert.ToInt16(G8.Text), 1, 8);
            boxes.SetValue(Convert.ToInt16(G9.Text), 2, 8);
            boxes.SetValue(Convert.ToInt16(H7.Text), 3, 8);
            boxes.SetValue(Convert.ToInt16(H8.Text), 4, 8);
            boxes.SetValue(Convert.ToInt16(H9.Text), 5, 8);
            boxes.SetValue(Convert.ToInt16(I7.Text), 6, 8);
            boxes.SetValue(Convert.ToInt16(I8.Text), 7, 8);
            boxes.SetValue(Convert.ToInt16(I9.Text), 8, 8);
        }
    }
}

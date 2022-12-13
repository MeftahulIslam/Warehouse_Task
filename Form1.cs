using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdoBtnType1_CheckedChanged(object sender, EventArgs e)
        {

        }
        Warehouse objWare = new Warehouse(100, 50, 12);   //Global scope
        double totalFreeSpace = Warehouse.UsableSpace();
        List<Box> boxCustomList = new List<Box>();
        private Box CreateBox()
        {
            if (rdoBtnType1.Checked)
            {
                Box box = new Box(1, 1, 1);
                return box;
            }
            else if (rdoBtnType2.Checked)
            {
                Box box = new Box(2, 2, 1);
                return box;
            }
            else if (rdoBtnType3.Checked)
            {
                Box box = new Box(2, 2, 2);
                return box;
            }
            else if (rdoBtnCustom.Checked)
            {
                int length, breadth, height;
                length = int.Parse(numUpDwnLength.Value.ToString());
                breadth = int.Parse(numUpDwnBreadth.Value.ToString());
                height = int.Parse(numUpDwnHeight.Value.ToString());
                Box box = new Box(length, breadth, height);
                return box;
            }
            else
            {
                MessageBox.Show("Please select a type!");
            }
            Box empty = new Box(0, 0, 0);
            return empty;
        }
        private Box RemoveBox(int countOfBox)
        {
            if (rdoBtnType1.Checked)
            {
                if(countOfBox <= objWare.GetType1Count())
                {
                    Box box = new Box(1, 1, 1);
                    objWare.SetType1Count((-countOfBox));
                    return box;
                }
                else
                {
                    MessageBox.Show("The number of Type-1 containers left is: " + objWare.GetType1Count().ToString()
                                    + "\nYou're trying to remove: " + countOfBox.ToString());
                }

            }
            else if (rdoBtnType2.Checked)
            {
                if(countOfBox <= objWare.GetType2Count())
                {
                    Box box = new Box(2, 2, 1);
                    objWare.SetType2Count((-countOfBox));
                    return box;
                }
                else
                {
                    MessageBox.Show("The number of Type-2 containers left is: " + objWare.GetType2Count().ToString()
                                    + "\nYou're trying to remove: " + countOfBox.ToString());
                }
            }
            else if (rdoBtnType3.Checked)
            {
                if(countOfBox <= objWare.GetType3Count())
                {
                    Box box = new Box(2, 2, 2);
                    objWare.SetType3Count((-countOfBox));
                    return box;
                }
                else
                {
                    MessageBox.Show("The number of Type-3 containers left is: " + objWare.GetType3Count().ToString()
                                    + "\nYou're trying to remove: " + countOfBox.ToString());
                }
            }
            else if (rdoBtnCustom.Checked)
            {
                int length, breadth, height;
                length = int.Parse(numUpDwnLength.Value.ToString());
                breadth = int.Parse(numUpDwnBreadth.Value.ToString());
                height = int.Parse(numUpDwnHeight.Value.ToString());
                Box box = new Box(length, breadth, height);
                List<Box> matchedBoxes = boxCustomList.FindAll(container => container.GetLength == box.GetLength &&
                                               container.GetBreadth == box.GetBreadth && container.GetHeight ==
                                               box.GetHeight);
                int countOfCustom = matchedBoxes.Count();
                if(countOfCustom == 0)
                {
                    MessageBox.Show("Container of this type doesn't exist in the warehouse!");
                }
                else
                {
                    if (countOfBox <= countOfCustom)
                    {
                        for(int i = 0; i < countOfBox; i++)
                        {
                            boxCustomList.Remove(boxCustomList.Find(container => container.GetLength == box.GetLength &&
                                               container.GetBreadth == box.GetBreadth && container.GetHeight ==
                                               box.GetHeight));
                        }
                        return box;
                    }
                    else
                    {
                        MessageBox.Show("The number of this custom type containers left is: " + countOfCustom.ToString()
                                        + "\nYou're trying to remove: " + countOfBox.ToString());
                    }

                }

            }
            else
            {
                MessageBox.Show("Please select a type!");
            }
            Box empty = new Box(0, 0, 0);
            return empty;

        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            int numberOfContainer = 0;
            bool correctInput =  int.TryParse(txtNumCont.Text, out numberOfContainer);
            if (!correctInput)
            {
                MessageBox.Show("Please Enter a proper value in the box for number of containers!");
                objWare.SetFreeSpace(totalFreeSpace);
            }
            else
            {
                Box box = CreateBox();
                int contTotalSpace = box * numberOfContainer;   //overloaded operator used
                if (totalFreeSpace < contTotalSpace)
                {
                    MessageBox.Show("Above safety measures! Not enough Space!");
                    objWare.SetFreeSpace(totalFreeSpace);
                }
                else
                {
                    totalFreeSpace -= contTotalSpace;
                    if (rdoBtnType1.Checked)
                    {
                        objWare.SetType1Count(numberOfContainer);
                    }
                    else if (rdoBtnType2.Checked)
                    {
                        objWare.SetType2Count(numberOfContainer);
                    }
                    else if (rdoBtnType3.Checked)
                    {
                        objWare.SetType3Count(numberOfContainer);

                    }
                    else if (rdoBtnCustom.Checked)
                    {
                        objWare.setTypeCustomCount(numberOfContainer);
                        for(int i = 0; i < numberOfContainer; i++)
                        {
                            boxCustomList.Add(box);
                        }

                    }
                    objWare.SetFreeSpace(totalFreeSpace);
                }
            }
            txtFreeSpace.Text = objWare.GetFreeSpace().ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfContainer;
            bool correctInput = int.TryParse(txtNumCont.Text, out numberOfContainer);
            if (!correctInput)
            {
                MessageBox.Show("Please enter a proper value in the box for number of containers!");
            }
            else
            {
                Box box = RemoveBox(numberOfContainer);
                int contTotalSpaceRemoved = box * numberOfContainer;   //overloaded operator used
                if (totalFreeSpace == Warehouse.UsableSpace())
                {
                    MessageBox.Show("The warehouse is empty!");
                }
                else
                {
                    totalFreeSpace += contTotalSpaceRemoved;
                }
            }
            objWare.SetFreeSpace(totalFreeSpace);
            txtFreeSpace.Text = objWare.GetFreeSpace().ToString();
        }

        private void rdoBtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            numUpDwnLength.Visible = true;
            numUpDwnBreadth.Visible = true;
            numUpDwnHeight.Visible = true;
            lblCustomLenght.Visible = true;
            lblCustomBreadth.Visible = true;
            lblCustomHeight.Visible = true;
            numUpDwnBreadth.Maximum = 6; //For the ease of calculation maximum breadth of the customizable
                                         //container is set to 6.
            numUpDwnBreadth.Minimum = 1;
            numUpDwnLength.Maximum = 10;
            numUpDwnLength.Minimum = 1;
            numUpDwnHeight.Maximum = 6;
            numUpDwnHeight.Minimum = 1;
        }
    }
}

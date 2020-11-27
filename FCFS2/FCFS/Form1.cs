using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS
{
    public partial class fcfsForm : Form
    {
        public static int at, bt,nRow = 0;
        public fcfsForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.Rows.Count;

            if (inProcess.TextLength == 0 || inBT.TextLength == 0)
            {
                MessageBox.Show("No input", "Error Message");
            }
            else
            {
                //add label and data
                if (rows == 1)
                {
                    this.dataGridView1.Rows.Add(inProcess.Text, inAT.Text, inBT.Text);
                    this.label5.Text = inAT.Text;
                    this.label6.Text = inBT.Text;

                    this.Process1.Text = inProcess.Text;
                    this.label22.Text = inBT.Text;
                }
                else if (rows == 2)
                {
                    this.dataGridView1.Rows.Add(inProcess.Text, inAT.Text, inBT.Text);
                    this.label7.Text = label5.Text;
                    this.label8.Text = inBT.Text;

                    this.Process2.Text = inProcess.Text;
                    this.label23.Text = inBT.Text;

                }
                else if (rows == 3)
                {
                    this.dataGridView1.Rows.Add(inProcess.Text, inAT.Text, inBT.Text);
                    this.label9.Text = label5.Text;
                    this.label10.Text = inBT.Text;

                    this.Process3.Text = inProcess.Text;
                    this.label24.Text = inBT.Text;
                }
                else if (rows == 4)
                {
                    this.dataGridView1.Rows.Add(inProcess.Text, inAT.Text, inBT.Text);
                    this.label11.Text = label5.Text;
                    this.label12.Text = inBT.Text;

                    this.Process4.Text = inProcess.Text;
                    this.label25.Text = inBT.Text;
                }
                else if (rows == 5)
                {
                    this.dataGridView1.Rows.Add(inProcess.Text, inAT.Text, inBT.Text);
                    this.label13.Text = label5.Text;
                    this.label14.Text = inBT.Text;

                    this.Process5.Text = inProcess.Text;
                    this.label26.Text = inBT.Text;
                }

                inProcess.Clear();
                inAT.Clear();
                inBT.Clear();
            }
        }

        private void clearTxts()
        {
            inProcess.Text = "";
            inAT.Text = "";
            inBT.Text = "";
            
        }
        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            inProcess.Clear();
            inAT.Clear();
            inBT.Clear();
            
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            int rows = dataGridView1.Rows.Count;

            if (rows > 1)
            {
                inAT.ReadOnly = true; 
            }

        }

        private void btnCOMPUTE_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.Rows.Count;

            // single q
            if (rbSingle.Checked)
            {
                if (rows == 4) // 3 rows
                {
                    // ROW 1
                    int a1 = Convert.ToInt32(label5.Text);
                    int b1 = Convert.ToInt32(label6.Text);
                    // ROW 2
                    int a2 = Convert.ToInt32(label7.Text);
                    int b2 = Convert.ToInt32(label8.Text);
                    // ROW 3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);

                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float sum = a1 + add1 + add2;

                    float div = sum / 3;
                    float ans = div - a1;

                    AWT.Text = ans.ToString() + " ms";

                    //ATAT Computation
                    float add3 = add2 + b3;
                    float sum1 = add1 + add2 + add3;

                    float div1 = sum1 / 3;
                    float ans1 = div1 - a1;

                    ATAT.Text = ans1.ToString() + " ms";

                    panel10.BackColor = Color.FromArgb(46, 47, 51);
                    panel11.BackColor = Color.FromArgb(46, 47, 51);
                    panel5.BackColor = Color.FromArgb(58, 192, 197);
                    panel6.BackColor = Color.FromArgb(40, 166, 200);
                    panel7.BackColor = Color.FromArgb(58, 192, 197);

                    label16.Text = a1.ToString();
                    label17.Text = add1.ToString();
                    label18.Text = add2.ToString();
                    label19.Text = sum.ToString();

                    label16.ForeColor = Color.Black;
                    label17.ForeColor = Color.Black;
                    label18.ForeColor = Color.Black;
                    label19.ForeColor = Color.Black;
                }

                else if (rows == 5) // row 4
                {
                    //AWT computation
                    int a1 = Convert.ToInt32(label5.Text);
                    int b1 = Convert.ToInt32(label6.Text);
                    int a2 = Convert.ToInt32(label7.Text);
                    int b2 = Convert.ToInt32(label8.Text);
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    int a4 = Convert.ToInt32(label11.Text);
                    int b4 = Convert.ToInt32(label12.Text);

                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float add3 = add2 + b3;
                    float sum = a1 + add1 + add2 + add3;

                    float div = sum / 4;
                    float ans = div - a1;

                    AWT.Text = ans.ToString() + " ms";

                    //ATAT Computation
                    float add4 = add3 + b4;
                    float sum1 = add1 + add2 + add3 + add4;

                    float div1 = sum1 / 4;
                    float ans1 = div1 - a1;

                    ATAT.Text = ans1.ToString() + " ms";

                    panel10.BackColor = Color.FromArgb(46, 47, 51);
                    panel11.BackColor = Color.FromArgb(46, 47, 51);
                    panel5.BackColor = Color.FromArgb(58, 192, 197);
                    panel6.BackColor = Color.FromArgb(40, 166, 200);
                    panel7.BackColor = Color.FromArgb(58, 192, 197);
                    panel8.BackColor = Color.FromArgb(40, 166, 200);

                    label16.Text = a1.ToString();
                    label17.Text = add1.ToString();
                    label18.Text = add2.ToString();
                    label19.Text = add3.ToString();
                    label20.Text = sum.ToString();

                    label16.ForeColor = Color.Black;
                    label17.ForeColor = Color.Black;
                    label18.ForeColor = Color.Black;
                    label19.ForeColor = Color.Black;
                    label20.ForeColor = Color.Black;

                }

                else if (rows == 6) // row 5
                {
                    //AWT computation  
                    int a1 = Convert.ToInt32(label5.Text);
                    int b1 = Convert.ToInt32(label6.Text);
                    int a2 = Convert.ToInt32(label7.Text);
                    int b2 = Convert.ToInt32(label8.Text);
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    int a4 = Convert.ToInt32(label11.Text);
                    int b4 = Convert.ToInt32(label12.Text);
                    int a5 = Convert.ToInt32(label13.Text);
                    int b5 = Convert.ToInt32(label14.Text);

                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float add3 = add2 + b3;
                    float add4 = add3 + b4;
                 
                    float sum = a1 + add1 + add2 + add3 + add4;

                    float div = sum / 5;
                    float ans = div - a1;

                    AWT.Text = ans.ToString() + " ms";

                    //ATAT Computation
                    float add5 = add4 + b5;
                    float sum1 = add1 + add2 + add3 + add4 + add5;

                    float div1 = sum1 / 5;
                    float ans1 = div1 - a1;

                    ATAT.Text = ans1.ToString() + " ms";

                    panel10.BackColor = Color.FromArgb(46, 47, 51);
                    panel11.BackColor = Color.FromArgb(46, 47, 51);
                    panel5.BackColor = Color.FromArgb(58, 192, 197);
                    panel6.BackColor = Color.FromArgb(40, 166, 200);
                    panel7.BackColor = Color.FromArgb(58, 192, 197);
                    panel8.BackColor = Color.FromArgb(40, 166, 200);
                    panel9.BackColor = Color.FromArgb(58, 192, 197);

                    label16.Text = a1.ToString();
                    label17.Text = add1.ToString();
                    label18.Text = add2.ToString();
                    label19.Text = add3.ToString();
                    label20.Text = add4.ToString();
                    label21.Text = add5.ToString();

                    label16.ForeColor = Color.Black;
                    label17.ForeColor = Color.Black;
                    label18.ForeColor = Color.Black;
                    label19.ForeColor = Color.Black;
                    label20.ForeColor = Color.Black;
                    label21.ForeColor = Color.Black;
                }
            }

            else if (rbMultiple.Checked)
            {
                if (rows == 4) //row 3
                {
                    // ROW 1
                    int a1 = Convert.ToInt32(label5.Text);
                    int b1 = Convert.ToInt32(label6.Text);
                    // ROW 2
                    int a2 = Convert.ToInt32(label7.Text);
                    int b2 = Convert.ToInt32(label8.Text);
                    // ROW 3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);

                    // WT = starting TIME - ARRIVAL TIME

                    float add1 = a1 + b1;
                    float wt1 = 0;
                    float add2 = add1 + b2;
                    float wt2 = add1 - a2;
                    float wt3 = add2 - a3;
                    float sum = wt1 + wt2 + wt3;

                    float div = sum / 3;
                    float ans = div - a1;

                    AWT.Text = ans.ToString() + " ms";

                }
                if (rows == 5) //row 4
                {
                    // ROW 1
                    int a1 = Convert.ToInt32(label5.Text);
                    int b1 = Convert.ToInt32(label6.Text);
                    // ROW 2
                    int a2 = Convert.ToInt32(label7.Text);
                    int b2 = Convert.ToInt32(label8.Text);
                    // ROW 3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    // ROW 4
                    int a4 = Convert.ToInt32(label9.Text);
                    int b4 = Convert.ToInt32(label10.Text);

                    // WT = starting TIME - ARRIVAL TIME
                    //add = finish time

                    float add1 = a1 + b1; 
                    float add2 = add1 + b2; 
                    float add3 = add2 + b3; 
                    float add4 = add3 + b4; 

                    float wt1 = 0;
                    float wt2 = add1 - a2; 
                    float wt3 = add2 - a3; 
                    float wt4 = add3 - a4; 
        
                    float sum = wt1 + wt2 + wt3 + wt4;

                    float div = sum / 4;
                 

                    AWT.Text = div.ToString() + " ms";
                }
            }
        }

        private void AWT_TextChanged(object sender, EventArgs e)
        {

        }

        private void inBT_TextChanged(object sender, EventArgs e)
        {

        }

        private void inAT_TextChanged(object sender, EventArgs e)
        {
            int rows = dataGridView1.Rows.Count;
            
            if(rbSingle.Checked && rows >= 2)
            {
                inAT.ReadOnly = true;
            }
        }

        private void inProcess_TextChanged(object sender, EventArgs e)
        {

        }

        private void Process1_Click(object sender, EventArgs e)
        {

        }

        private void rbMultiple_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void delete()
        {
            if(MessageBox.Show("Are you sure you want to delete this row?", "DELETE",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(index);
                if (dataGridView1.Rows.Count == 1)
                {
                    grpQueue.Enabled = true;
                    rbSingle.Checked = false;
                    rbMultiple.Checked = false;
                    nRow = 0;
                }
            } 
        }
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            inAT.ReadOnly = false;
        }
    }
}

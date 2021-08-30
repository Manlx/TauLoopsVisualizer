using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Loops
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private delegate bool ComparisonOperatorPointer(int x, int y);
        private delegate void IncOp(ref int x);
        private delegate void SayThing();
        //private delegate bool CompletePartB(ComparisonOperatorPointer x, SayThing y);

        private int iLimit = 0, iLimitChange = 0, iStart = 0,iStartChange = 0, iIterChange = 0;
        static int LoopExecution = 0, ComparisonExecution = 0;

        private bool Help(ComparisonOperatorPointer x, int a, int b, SayThing y)
        {
            
            y();
            return x(a,b);
        }
        private void AlertExecution()
        {
            redForMapOut.Text += $"Executing Comparison operartion\n";
            ComparisonExecution++;
        }
        

        private void btnMapForLoop_Click(object sender, EventArgs e)
        {
            LoopExecution = 0;
            ComparisonExecution = 0;
            redForMapOut.Clear();
            ComparisonOperatorPointer myFunc = null;
            switch (cbbOperator.SelectedIndex)
            {
                case 0: myFunc = Smaller; break;
                case 1: myFunc = Larger; break;
                case 2: myFunc = SmallerEqual; break;
                case 3: myFunc = LargerEqual; break;
                default: MessageBox.Show("lols"); break;
            }
            IncOp myOp = null;
            if (cbbInc.SelectedIndex == 0)
                myOp = Inc;
            else
                myOp = Dec;
            for (int x = iStart+iStartChange; Help(myFunc,(x + iIterChange),(iLimit+iLimitChange), AlertExecution); myOp(ref x))
            {
                redForMapOut.Text += $"{LoopExecution}: For loop executes\n";
                LoopExecution++;
            }
            redForMapOut.Text += $"\nThe loop executed: {LoopExecution} times\nWhere the comparsion executed: {ComparisonExecution} times\n\n";
            redForMapOut.Text += $"The comparison is (N{WhatToReturn(ComparisonExecution - iLimit) }) times\n" +
                $"The Loop is executed (N{WhatToReturn(ComparisonExecution - iLimit -1)}) times\n";
        }
        private bool Smaller(int x, int y)
        {
            return x < y;
        }
        private bool SmallerEqual(int x, int y)
        {
            return x <= y;
        }
        private bool Larger(int x, int y)
        {
            return x > y;
        }
        private bool LargerEqual(int x, int y)
        {
            return x >= y;
        }
        private void Inc(ref int x)
        {
            x++;
        }
        private void Dec(ref int x)
        {
            x--;
        }
        private void edtStart_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edtStart.Text, out iStart) && edtStart.Text != "" && edtStart.Text != "-")
                MessageBox.Show("Please enter a number");
            SimulateLable();
        }
        private void edtChange_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edtChange.Text, out iIterChange) && edtChange.Text != "" && edtChange.Text != "-")
                MessageBox.Show("Please enter a number");
            SimulateLable();
        }

        private void edtStartChange_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edtStartChange.Text, out iStartChange) && edtStartChange.Text != "" && edtStartChange.Text != "-")
                MessageBox.Show("Please enter a number");
            SimulateLable();
        }

        private void edtLimitChange_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edtLimitChange.Text, out iLimitChange) && edtLimitChange.Text != "" && edtLimitChange.Text != "-")
                MessageBox.Show("Please enter a number");
            SimulateLable();
        }

        private void edtLimit_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edtLimit.Text, out iLimit) && edtLimit.Text != "")
                MessageBox.Show("Please enter a number");
            SimulateLable();
        }
        private void cbbOperator_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SimulateLable();
        }
        private void frmForLoop_Load(object sender, EventArgs e)
        {
            cbbOperator.SelectedIndex = 0;
            cbbInc.SelectedIndex = 0;
            redForMapOut.ReadOnly = true;
            SimulateLable();
        }
        private static string WhatToReturn(int x)
        {
            if (x == 0)
                return "";
            if (x > 0)
                return " + " + x;
            return x.ToString();
        }
        private void SimulateLable()
        {
            lblVisual.Text = $"for (int X = {iStart}{WhatToReturn(iStartChange)};" +
                $"(X{WhatToReturn(iIterChange)})" +
                $" {cbbOperator.Text} " +
                $"({iLimit}{WhatToReturn(iLimitChange)}); {cbbInc.Text})";
        }
    }
}

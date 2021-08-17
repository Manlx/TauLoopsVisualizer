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

        private int Limit = 0, Start = 0, Change = 0;

        private bool Help(ComparisonOperatorPointer x, int a, int b, SayThing y)
        {
            
            y();
            return x(a,b);
        }
        private void CallMeDaddy()
        {
            redForMapOut.Text += $"Executing Comparison operartion\n";
            ComparisonExecution++;
        }
        static int LoopExecution = 0, ComparisonExecution= 0;

        private void btnMapForLoop_Click(object sender, EventArgs e)
        {
            redForMapOut.Clear();
            /*Func<int, int> myFunc = x => { return x * x * x; };
MessageBox.Show(myFunc(10).ToString());*/
            /*
            <
            >
            <=
            >=
             */
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
            for (int x = Start; Help(myFunc,(x+Change),Limit, CallMeDaddy); myOp(ref x))
            {
                redForMapOut.Text += $"{x + Change}: For loop executes\n";
                LoopExecution++;
            }
            redForMapOut.Text += $"The loop executed: {LoopExecution} times\nWhere the comparsion executed: {ComparisonExecution} times";
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
            if (!Int32.TryParse(edtStart.Text, out Start) && edtStart.Text != "")
                MessageBox.Show("Please enter a number");
            SimulateLable();
        }

        private void edtChange_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edtChange.Text, out Change) && edtChange.Text != "" && edtChange.Text != "-")
                MessageBox.Show("Please enter a number");
            SimulateLable();
        }

        private void edtLimit_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(edtLimit.Text, out Limit) && edtLimit.Text != "")
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
            SimulateLable();

            
        }
        private void SimulateLable()
        {
            lblVisual.Text = $"for (int x = {Start}; x {((Change== 0)? "" : ((Change > 0) ? "+"+Change.ToString():Change.ToString()))} {cbbOperator.Text} {Limit}; {cbbInc.Text})";
        }
    }
}

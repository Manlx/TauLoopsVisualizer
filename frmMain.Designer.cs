
namespace For_Loops
{
    partial class frmForLoop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redForMapOut = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMapForLoop = new System.Windows.Forms.Button();
            this.lblVisual = new System.Windows.Forms.Label();
            this.edtStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtChange = new System.Windows.Forms.TextBox();
            this.cbbOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbInc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtLimit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtStartChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtLimitChange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redForMapOut
            // 
            this.redForMapOut.BackColor = System.Drawing.SystemColors.InfoText;
            this.redForMapOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.redForMapOut.Location = new System.Drawing.Point(-2, -3);
            this.redForMapOut.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.redForMapOut.Name = "redForMapOut";
            this.redForMapOut.Size = new System.Drawing.Size(456, 416);
            this.redForMapOut.TabIndex = 0;
            this.redForMapOut.TabStop = false;
            this.redForMapOut.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnMapForLoop
            // 
            this.btnMapForLoop.Location = new System.Drawing.Point(456, 354);
            this.btnMapForLoop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMapForLoop.Name = "btnMapForLoop";
            this.btnMapForLoop.Size = new System.Drawing.Size(625, 53);
            this.btnMapForLoop.TabIndex = 7;
            this.btnMapForLoop.Text = "Map For Loop";
            this.btnMapForLoop.UseVisualStyleBackColor = true;
            this.btnMapForLoop.Click += new System.EventHandler(this.btnMapForLoop_Click);
            // 
            // lblVisual
            // 
            this.lblVisual.AutoSize = true;
            this.lblVisual.Location = new System.Drawing.Point(460, 290);
            this.lblVisual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisual.Name = "lblVisual";
            this.lblVisual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVisual.Size = new System.Drawing.Size(163, 19);
            this.lblVisual.TabIndex = 9;
            this.lblVisual.Text = "Visual Display";
            // 
            // edtStart
            // 
            this.edtStart.Location = new System.Drawing.Point(606, 219);
            this.edtStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edtStart.Name = "edtStart";
            this.edtStart.Size = new System.Drawing.Size(26, 26);
            this.edtStart.TabIndex = 0;
            this.edtStart.Text = "0";
            this.edtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtStart.TextChanged += new System.EventHandler(this.edtStart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "for (int X =";
            // 
            // edtChange
            // 
            this.edtChange.Location = new System.Drawing.Point(751, 219);
            this.edtChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edtChange.Name = "edtChange";
            this.edtChange.Size = new System.Drawing.Size(26, 26);
            this.edtChange.TabIndex = 2;
            this.edtChange.Text = "0";
            this.edtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtChange.TextChanged += new System.EventHandler(this.edtChange_TextChanged);
            // 
            // cbbOperator
            // 
            this.cbbOperator.FormattingEnabled = true;
            this.cbbOperator.Items.AddRange(new object[] {
            "<",
            ">",
            "<=",
            ">="});
            this.cbbOperator.Location = new System.Drawing.Point(799, 218);
            this.cbbOperator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbOperator.Name = "cbbOperator";
            this.cbbOperator.Size = new System.Drawing.Size(47, 27);
            this.cbbOperator.TabIndex = 3;
            this.cbbOperator.SelectedValueChanged += new System.EventHandler(this.cbbOperator_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(947, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = ");";
            // 
            // cbbInc
            // 
            this.cbbInc.FormattingEnabled = true;
            this.cbbInc.Items.AddRange(new object[] {
            "x++",
            "x--"});
            this.cbbInc.Location = new System.Drawing.Point(978, 219);
            this.cbbInc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbInc.Name = "cbbInc";
            this.cbbInc.Size = new System.Drawing.Size(61, 27);
            this.cbbInc.TabIndex = 6;
            this.cbbInc.SelectionChangeCommitted += new System.EventHandler(this.cbbOperator_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1039, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = ")";
            // 
            // edtLimit
            // 
            this.edtLimit.Location = new System.Drawing.Point(869, 219);
            this.edtLimit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edtLimit.Name = "edtLimit";
            this.edtLimit.Size = new System.Drawing.Size(26, 26);
            this.edtLimit.TabIndex = 4;
            this.edtLimit.Text = "0";
            this.edtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtLimit.TextChanged += new System.EventHandler(this.edtLimit_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "+";
            // 
            // edtStartChange
            // 
            this.edtStartChange.Location = new System.Drawing.Point(653, 219);
            this.edtStartChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edtStartChange.Name = "edtStartChange";
            this.edtStartChange.Size = new System.Drawing.Size(26, 26);
            this.edtStartChange.TabIndex = 1;
            this.edtStartChange.Text = "0";
            this.edtStartChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtStartChange.TextChanged += new System.EventHandler(this.edtStartChange_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(899, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "+";
            // 
            // edtLimitChange
            // 
            this.edtLimitChange.Location = new System.Drawing.Point(920, 219);
            this.edtLimitChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edtLimitChange.Name = "edtLimitChange";
            this.edtLimitChange.Size = new System.Drawing.Size(26, 26);
            this.edtLimitChange.TabIndex = 5;
            this.edtLimitChange.Text = "0";
            this.edtLimitChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edtLimitChange.TextChanged += new System.EventHandler(this.edtLimitChange_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = ")";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(849, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "(";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = ";( X +";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 27;
            // 
            // frmForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1082, 406);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtLimitChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edtStartChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbInc);
            this.Controls.Add(this.edtChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbOperator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtStart);
            this.Controls.Add(this.lblVisual);
            this.Controls.Add(this.btnMapForLoop);
            this.Controls.Add(this.redForMapOut);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmForLoop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For Loops";
            this.Load += new System.EventHandler(this.frmForLoop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox redForMapOut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnMapForLoop;
        private System.Windows.Forms.Label lblVisual;
        private System.Windows.Forms.TextBox edtStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtChange;
        private System.Windows.Forms.ComboBox cbbOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbInc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtStartChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtLimitChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


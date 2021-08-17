
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
            this.label2 = new System.Windows.Forms.Label();
            this.edtChange = new System.Windows.Forms.TextBox();
            this.cbbOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbInc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // redForMapOut
            // 
            this.redForMapOut.BackColor = System.Drawing.SystemColors.InfoText;
            this.redForMapOut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.redForMapOut.Location = new System.Drawing.Point(-2, -3);
            this.redForMapOut.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.redForMapOut.Name = "redForMapOut";
            this.redForMapOut.Size = new System.Drawing.Size(456, 408);
            this.redForMapOut.TabIndex = 0;
            this.redForMapOut.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnMapForLoop
            // 
            this.btnMapForLoop.Location = new System.Drawing.Point(455, 352);
            this.btnMapForLoop.Name = "btnMapForLoop";
            this.btnMapForLoop.Size = new System.Drawing.Size(487, 53);
            this.btnMapForLoop.TabIndex = 3;
            this.btnMapForLoop.Text = "Map For Loop";
            this.btnMapForLoop.UseVisualStyleBackColor = true;
            this.btnMapForLoop.Click += new System.EventHandler(this.btnMapForLoop_Click);
            // 
            // lblVisual
            // 
            this.lblVisual.AutoSize = true;
            this.lblVisual.Location = new System.Drawing.Point(459, 290);
            this.lblVisual.Name = "lblVisual";
            this.lblVisual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVisual.Size = new System.Drawing.Size(163, 19);
            this.lblVisual.TabIndex = 9;
            this.lblVisual.Text = "Visual Display";
            // 
            // edtStart
            // 
            this.edtStart.Location = new System.Drawing.Point(606, 219);
            this.edtStart.Name = "edtStart";
            this.edtStart.Size = new System.Drawing.Size(26, 26);
            this.edtStart.TabIndex = 10;
            this.edtStart.TextChanged += new System.EventHandler(this.edtStart_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "for (int x =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "; x +";
            // 
            // edtChange
            // 
            this.edtChange.Location = new System.Drawing.Point(708, 219);
            this.edtChange.Name = "edtChange";
            this.edtChange.Size = new System.Drawing.Size(26, 26);
            this.edtChange.TabIndex = 13;
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
            this.cbbOperator.Location = new System.Drawing.Point(740, 219);
            this.cbbOperator.Name = "cbbOperator";
            this.cbbOperator.Size = new System.Drawing.Size(47, 27);
            this.cbbOperator.TabIndex = 14;
            this.cbbOperator.SelectionChangeCommitted += new System.EventHandler(this.cbbOperator_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = ";";
            // 
            // cbbInc
            // 
            this.cbbInc.FormattingEnabled = true;
            this.cbbInc.Items.AddRange(new object[] {
            "x++",
            "x--"});
            this.cbbInc.Location = new System.Drawing.Point(837, 219);
            this.cbbInc.Name = "cbbInc";
            this.cbbInc.Size = new System.Drawing.Size(61, 27);
            this.cbbInc.TabIndex = 16;
            this.cbbInc.SelectionChangeCommitted += new System.EventHandler(this.cbbOperator_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(903, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = ")";
            // 
            // edtLimit
            // 
            this.edtLimit.Location = new System.Drawing.Point(795, 220);
            this.edtLimit.Name = "edtLimit";
            this.edtLimit.Size = new System.Drawing.Size(26, 26);
            this.edtLimit.TabIndex = 18;
            this.edtLimit.TextChanged += new System.EventHandler(this.edtLimit_TextChanged);
            // 
            // frmForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(942, 406);
            this.Controls.Add(this.edtLimit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbInc);
            this.Controls.Add(this.edtChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtStart);
            this.Controls.Add(this.lblVisual);
            this.Controls.Add(this.btnMapForLoop);
            this.Controls.Add(this.redForMapOut);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtChange;
        private System.Windows.Forms.ComboBox cbbOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbInc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtLimit;
    }
}


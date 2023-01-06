namespace MiniPaint
{
    partial class UserControlPen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudPenWidth = new System.Windows.Forms.NumericUpDown();
            this.bPenColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lbStyle = new System.Windows.Forms.ListBox();
            this.bBrushColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFill = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudPenWidth
            // 
            this.nudPenWidth.Location = new System.Drawing.Point(73, 19);
            this.nudPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPenWidth.Name = "nudPenWidth";
            this.nudPenWidth.Size = new System.Drawing.Size(78, 20);
            this.nudPenWidth.TabIndex = 0;
            this.nudPenWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPenWidth.ValueChanged += new System.EventHandler(this.nudPenWidth_ValueChanged);
            // 
            // bPenColor
            // 
            this.bPenColor.BackColor = System.Drawing.Color.Black;
            this.bPenColor.Location = new System.Drawing.Point(73, 45);
            this.bPenColor.Name = "bPenColor";
            this.bPenColor.Size = new System.Drawing.Size(78, 23);
            this.bPenColor.TabIndex = 1;
            this.bPenColor.UseVisualStyleBackColor = false;
            this.bPenColor.Click += new System.EventHandler(this.bPenColor_Click);
            // 
            // lbStyle
            // 
            this.lbStyle.FormattingEnabled = true;
            this.lbStyle.Items.AddRange(new object[] {
            "Ciągła",
            "Kropka",
            "Kreska",
            "Kropka-Kreska"});
            this.lbStyle.Location = new System.Drawing.Point(73, 74);
            this.lbStyle.Name = "lbStyle";
            this.lbStyle.Size = new System.Drawing.Size(78, 56);
            this.lbStyle.TabIndex = 2;
            this.lbStyle.SelectedIndexChanged += new System.EventHandler(this.lbStyle_SelectedIndexChanged);
            // 
            // bBrushColor
            // 
            this.bBrushColor.BackColor = System.Drawing.Color.Red;
            this.bBrushColor.Location = new System.Drawing.Point(73, 19);
            this.bBrushColor.Name = "bBrushColor";
            this.bBrushColor.Size = new System.Drawing.Size(78, 23);
            this.bBrushColor.TabIndex = 3;
            this.bBrushColor.UseVisualStyleBackColor = false;
            this.bBrushColor.Click += new System.EventHandler(this.bBrushColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudPenWidth);
            this.groupBox1.Controls.Add(this.bPenColor);
            this.groupBox1.Controls.Add(this.lbStyle);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia pióra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Linia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grubość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFill);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bBrushColor);
            this.groupBox2.Location = new System.Drawing.Point(3, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia pędzla";
            // 
            // cbFill
            // 
            this.cbFill.AutoSize = true;
            this.cbFill.Checked = true;
            this.cbFill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFill.Location = new System.Drawing.Point(9, 47);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(103, 17);
            this.cbFill.TabIndex = 5;
            this.cbFill.Text = "Czy wypełnienie";
            this.cbFill.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kolor";
            // 
            // UserControlPen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlPen";
            this.Size = new System.Drawing.Size(165, 230);
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPenWidth;
        private System.Windows.Forms.Button bPenColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ListBox lbStyle;
        private System.Windows.Forms.Button bBrushColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbFill;
    }
}

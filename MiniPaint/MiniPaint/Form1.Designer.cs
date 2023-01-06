namespace MiniPaint
{
    partial class Form1
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
            this.pbFrame = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFill = new System.Windows.Forms.RadioButton();
            this.rbCurve = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.ucPenBrush = new MiniPaint.UserControlPen();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFrame
            // 
            this.pbFrame.Location = new System.Drawing.Point(13, 27);
            this.pbFrame.Name = "pbFrame";
            this.pbFrame.Size = new System.Drawing.Size(580, 377);
            this.pbFrame.TabIndex = 1;
            this.pbFrame.TabStop = false;
            this.pbFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFrame_MouseDown);
            this.pbFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFrame_MouseMove);
            this.pbFrame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbFrame_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFill);
            this.groupBox1.Controls.Add(this.rbCurve);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbEllipse);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Location = new System.Drawing.Point(599, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narzędzia";
            // 
            // rbFill
            // 
            this.rbFill.AutoSize = true;
            this.rbFill.Location = new System.Drawing.Point(7, 112);
            this.rbFill.Name = "rbFill";
            this.rbFill.Size = new System.Drawing.Size(85, 17);
            this.rbFill.TabIndex = 4;
            this.rbFill.Text = "Wypełnienie";
            this.rbFill.UseVisualStyleBackColor = true;
            // 
            // rbCurve
            // 
            this.rbCurve.AutoSize = true;
            this.rbCurve.Location = new System.Drawing.Point(7, 89);
            this.rbCurve.Name = "rbCurve";
            this.rbCurve.Size = new System.Drawing.Size(59, 17);
            this.rbCurve.TabIndex = 3;
            this.rbCurve.Text = "Krzywa";
            this.rbCurve.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(7, 66);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(70, 17);
            this.rbRectangle.TabIndex = 2;
            this.rbRectangle.Text = "Prostokąt";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(7, 43);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(53, 17);
            this.rbEllipse.TabIndex = 1;
            this.rbEllipse.Text = "Elipsa";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(7, 20);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(55, 17);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Prosta";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // ucPenBrush
            // 
            this.ucPenBrush.Location = new System.Drawing.Point(599, 27);
            this.ucPenBrush.Name = "ucPenBrush";
            this.ucPenBrush.Size = new System.Drawing.Size(171, 232);
            this.ucPenBrush.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Bitmapy|*.bmp|Jotpegi|*.jpg";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Bitmapy|*.bmp|Jotpegi|*.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbFrame);
            this.Controls.Add(this.ucPenBrush);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MiniPaint v0.8";
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlPen ucPenBrush;
        private System.Windows.Forms.PictureBox pbFrame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCurve;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RadioButton rbFill;
    }
}


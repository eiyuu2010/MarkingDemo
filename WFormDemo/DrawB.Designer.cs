namespace WFormDemo
{
    partial class DrawB
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdShowColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panelColor = new System.Windows.Forms.Panel();
            this.cmdSaveImage = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPen = new System.Windows.Forms.Button();
            this.mainCanvas = new WFormDemo.Canvas();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cmdShowColor
            // 
            this.cmdShowColor.Location = new System.Drawing.Point(440, 312);
            this.cmdShowColor.Name = "cmdShowColor";
            this.cmdShowColor.Size = new System.Drawing.Size(75, 23);
            this.cmdShowColor.TabIndex = 2;
            this.cmdShowColor.Text = "Color";
            this.cmdShowColor.UseVisualStyleBackColor = true;
            this.cmdShowColor.Click += new System.EventHandler(this.cmdShowColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(400, 312);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(32, 24);
            this.panelColor.TabIndex = 4;
            // 
            // cmdSaveImage
            // 
            this.cmdSaveImage.Location = new System.Drawing.Point(8, 312);
            this.cmdSaveImage.Name = "cmdSaveImage";
            this.cmdSaveImage.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveImage.TabIndex = 5;
            this.cmdSaveImage.Text = "Save";
            this.cmdSaveImage.UseVisualStyleBackColor = true;
            this.cmdSaveImage.Click += new System.EventHandler(this.cmdSaveImage_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(88, 312);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 6;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // domainUpDown
            // 
            this.domainUpDown.Items.Add("1");
            this.domainUpDown.Items.Add("2");
            this.domainUpDown.Items.Add("3");
            this.domainUpDown.Items.Add("4");
            this.domainUpDown.Items.Add("5");
            this.domainUpDown.Items.Add("6");
            this.domainUpDown.Items.Add("7");
            this.domainUpDown.Items.Add("8");
            this.domainUpDown.Items.Add("9");
            this.domainUpDown.Items.Add("10");
            this.domainUpDown.Location = new System.Drawing.Point(344, 312);
            this.domainUpDown.Name = "domainUpDown";
            this.domainUpDown.Size = new System.Drawing.Size(48, 19);
            this.domainUpDown.TabIndex = 7;
            this.domainUpDown.Text = "1";
            this.domainUpDown.SelectedItemChanged += new System.EventHandler(this.domainUpDown_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Line Size";
            // 
            // cmdPen
            // 
            this.cmdPen.Location = new System.Drawing.Point(176, 312);
            this.cmdPen.Name = "cmdPen";
            this.cmdPen.Size = new System.Drawing.Size(75, 23);
            this.cmdPen.TabIndex = 9;
            this.cmdPen.Text = "Pen";
            this.cmdPen.UseVisualStyleBackColor = true;
            this.cmdPen.Click += new System.EventHandler(this.cmdPen_Click);
            // 
            // mainCanvas
            // 
            this.mainCanvas.Location = new System.Drawing.Point(0, 40);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(520, 264);
            this.mainCanvas.TabIndex = 3;
            this.mainCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseDown);
            this.mainCanvas.MouseLeave += new System.EventHandler(this.mainCanvas_MouseLeave);
            this.mainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseMove);
            this.mainCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdPen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdSaveImage);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.mainCanvas);
            this.Controls.Add(this.cmdShowColor);
            this.Controls.Add(this.statusStrip1);
            this.Name = "DrawB";
            this.Text = "DrawB";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button cmdShowColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Canvas mainCanvas;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button cmdSaveImage;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.DomainUpDown domainUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdPen;
        private System.Windows.Forms.Button button1;

    }
}
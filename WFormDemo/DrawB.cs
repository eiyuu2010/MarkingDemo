using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormDemo
{
    public partial class DrawB : Form
    {
        private bool isPenMode;

        private bool isDelete = false;
        // Variable used for determining if the user is currently drawing on the canvas
        private Boolean mouseDown;

        /// <summary>
        /// Getter/Setter used for changing the pen colour
        /// </summary>
        private Color colour
        {
            // Simply return the colour panel's background colour
            get { return this.panelColor.BackColor; }

            // Set the pen colour, then set the colour panel's background colour
            set
            {
                // Set the pen colour
                this.mainCanvas.Colour = value;

                // Set the colour panel's background colour
                this.panelColor.BackColor = value;
            }
        }
        public DrawB()
        {
            InitializeComponent();
            // Set the default pen colour to black. This will trigger the setter above!
            this.colour = Color.Black;
            this.mouseDown = false;    // The user is not currently drawing
            this.isPenMode = true;
        }

        
        private void cmdShowColor_Click(object sender, EventArgs e)
        {
            // Open the dialog, where the user can choose a colour. Store the 
            // result to be checked later
            DialogResult result = this.colorDialog.ShowDialog();

            // Check to see if the result is valid
            if (result == DialogResult.OK)
            {
                // Set the pen colour, and colour panel's background colour. This
                // fires the Setter at the top of the file
                if (this.isPenMode)
                {
                    this.colour = this.colorDialog.Color;
                }
                else
                {
                    this.colour = Color.FromArgb(50, this.colorDialog.Color);
                }
            }
        }

        private void mainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Set the variable that watches if the user is currently drawing
                this.mouseDown = true;

                // Add a new shape to the canvas, at the point where the user clicked.
                // By default, your mouse coordinates are measured from the upper left 
                // hand corner OF THE WINDOW, not the canvas. So PointToClient converts
                // Those coordinates so that it is relative to the upper left hand corner
                // of the canvas
                if(!isDelete)
                {
                    this.mainCanvas.AddNewShape(this.mainCanvas.PointToClient(Cursor.Position));
                }
            }
        }

        private void mainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Only handle the event if the user is currently drawing (clicking down 
            // on the canvas)
            if (this.mouseDown)
            {
                // Update the current shape with the current coordinates of the mouse.
                // By default, your mouse coordinates are measured from the upper left 
                // hand corner OF THE WINDOW, not the canvas. So PointToClient converts
                // Those coordinates so that it is relative to the upper left hand corner
                // of the canvas
                this.mainCanvas.UpdateCurrentShape(this.mainCanvas.PointToClient(Cursor.Position));
                if (this.isDelete)
                {
                    this.mainCanvas.DeleteCurrentShape(this.mainCanvas.PointToClient(Cursor.Position), 10);
                }
            }
          
        }

        private void mainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // Turn off the variable that watches whethere or not the user is 
            // currently drawing
            this.mouseDown = false;
        }

        private void mainCanvas_MouseLeave(object sender, EventArgs e)
        {
            // Turn off the variable that watches whethere or not the user is 
            // currently drawing
            this.mouseDown = false;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            this.mainCanvas.Clear();
        }

        private void cmdSaveImage_Click(object sender, EventArgs e)
        {
            try
            {
                int width = this.mainCanvas.Size.Width;
                int height = this.mainCanvas.Size.Height;
                Bitmap bt = new Bitmap(width, height);
                this.mainCanvas.DrawToBitmap(bt, new Rectangle(0, 0, width, height));
                bt.Save(@"C:\testsave.bmp", ImageFormat.Bmp);
                MessageBox.Show("Save success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void domainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            this.mainCanvas.Thickness = float.Parse(this.domainUpDown.Text);
        }

        private void cmdPen_Click(object sender, EventArgs e)
        {
            if(this.isPenMode)
            {
                this.isPenMode = false;
                this.cmdPen.Text = "HighLight";
                this.colour = Color.FromArgb(50, this.panelColor.BackColor);
            }
            else
            {
                this.isPenMode = true;
                this.cmdPen.Text = "Pen";
                this.colour = this.colorDialog.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.isDelete = true;
        }
    }
}

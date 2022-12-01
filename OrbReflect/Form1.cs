using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbReflect
{
    public partial class OrbReflect : Form
    {
        //Moving works differently here, you turn and can then move forward and back
        //This was chosen to simplify spell casting
        //General Move Controls, W and UP for forward, S and DOWN for back, A and LEFT for turn left, D and RIGHT for turn right
        bool wDown = false;
        bool aDown = false;
        bool sDown = false;
        bool dDown = false;
        bool capsDown = false;
        bool iDown = false;
        bool jDown = false;
        bool kDown = false;
        bool lDown = false;
        bool hDown = false;

        //Spell Casting Controls
        //Cast Spell
        bool fDown = false;
        bool semiColonDown = false;
        //Switch Spell
        bool qDown = false;
        bool eDown = false;
        bool uDown = false;
        bool oDown = false;

        //Track the facing direction
        bool p1IsRight = false;
        bool p2IsRight = false;

        //Track the hitboxes of p1 and p2
        Rectangle p1 = new Rectangle(390, 595, 55, 65);
        Rectangle p2 = new Rectangle(390, 35, 55, 65);

        //Set up Goals
        int goalWidth = 300;
        int goalHeight = 100;
        Rectangle goalUp = new Rectangle();
        Rectangle goalDown = new Rectangle();

        //Set up Walls
        Rectangle wallLeft = new Rectangle(143, 160, 5, 365);
        Rectangle wallRight = new Rectangle(678, 160, 5, 365);
        Rectangle wallTopLeft = new Rectangle(270, 38, 55, 5);
        Rectangle wallTopRight = new Rectangle(500, 38, 55, 5);
        Rectangle wallBottomLeft = new Rectangle(270, 643, 55, 5);
        Rectangle wallBottomRight = new Rectangle(500, 643, 55, 5);
        Rectangle arcTopLeft = new Rectangle(145, 395, 270, 520);
        Rectangle arcTopRight = new Rectangle(500, 38, 55, 5);
        Rectangle arcBottomLeft = new Rectangle(270, 643, 55, 5);
        Rectangle arcBottomRight = new Rectangle(500, 643, 55, 5);


        public OrbReflect()
        {
            InitializeComponent();
            Refresh();
        }

        private void OrbReflect_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.CapsLock:
                    capsDown = true;
                    break;
                case Keys.I:
                    iDown = true;
                    break;
                case Keys.J:
                    jDown = true;
                    break;
                case Keys.K:
                    kDown = true;
                    break;
                case Keys.L:
                    lDown = true;
                    break;
                case Keys.H:
                    hDown = true;
                    break;
                //Spell Cast Check
                case Keys.F:
                    fDown = true;
                    break;
                case Keys.OemSemicolon:
                    semiColonDown = true;
                    break;
                case Keys.Q:
                    qDown = true;
                    break;
                case Keys.E:
                    eDown = true;
                    break;
                case Keys.U:
                    uDown = true;
                    break;
                case Keys.O:
                    oDown = true;
                    break;
            }
        }

        private void OrbReflect_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Movement Check
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.CapsLock:
                    capsDown = false;
                    break;
                case Keys.I:
                    iDown = false;
                    break;
                case Keys.J:
                    jDown = false;
                    break;
                case Keys.K:
                    kDown = false;
                    break;
                case Keys.L:
                    lDown = false;
                    break;
                case Keys.H:
                    hDown = false;
                    break;
                //Spell Cast Check
                case Keys.F:
                    fDown = false;
                    break;
                case Keys.OemSemicolon:
                    semiColonDown = false;
                    break;
                case Keys.Q:
                    qDown = false;
                    break;
                case Keys.E:
                    eDown = false;
                    break;
                case Keys.U:
                    uDown = false;
                    break;
                case Keys.O:
                    oDown = false;
                    break;
            }
        }

        private void OrbReflect_Paint(object sender, PaintEventArgs e)
        {
            Pen outlinePen = new Pen(Color.DarkGray, 5);
            SolidBrush outlineBrush = new SolidBrush(Color.DarkGray);

            e.Graphics.FillRectangle(outlineBrush, wallLeft);
            e.Graphics.FillRectangle(outlineBrush, wallRight);
            e.Graphics.FillRectangle(outlineBrush, wallTopLeft);
            e.Graphics.FillRectangle(outlineBrush, wallTopRight);
            e.Graphics.FillRectangle(outlineBrush, wallBottomLeft);
            e.Graphics.FillRectangle(outlineBrush, wallBottomRight);

            //Arc Drawn For arcTopRight, arcTopLeft, arcBottomRight, arcBottomLeft
            e.Graphics.DrawArc(outlinePen, 145, 395, 250, 250, 180, -90);
            e.Graphics.DrawArc(outlinePen, 430, 395, 250, 250, 90, -90);
            e.Graphics.DrawArc(outlinePen, 145, 40, 250, 250, 180, 90);
            e.Graphics.DrawArc(outlinePen, 430, 40, 250, 250, 270, 90);
            e.Graphics.FillRectangle(outlineBrush, arcTopLeft);

            p1Display.Location = p1.Location;
            p2Display.Location = p2.Location;
        }

        private void gameFrameTimer(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Grady Rueffer
 * 152446035
 * Air Hockey
 * 01/12/22
*/

/* Controlls 
 * w,s  i,k for forward and back
 * a,d  j,l for turning
 * caps  h for running
 * enter to restart at end
 * Soon to be added:
 * q,e  u,o for spell scrolling
 * f  semicolon to fire spell
*/


/* List of Incomplete and thus cut for the original hand-in
 * (If Acceptable, I will resubmit with finished fun components later)
 * (This may be because they still need to be coded, Such as a cpu, Or because they need tweaking (I.E Spellcasting))
 * Arc Collision (Sample Code Still Included)
 * Spellcasting [:(]
 * HP Bar
 * Cross Line Interactions
 * + Cross Line Mirroring/Teleportation
 * Concurrent Audio
 * CPU
 */

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

        //Score Tracking
        int p1Score = 0;
        int p2Score = 0;
        int winScore = 3;

        //Spell Casting Controls
        //Cast Spell
        bool fDown = false;
        bool semiColonDown = false;
        //Switch Spell
        bool qDown = false;
        bool eDown = false;
        bool uDown = false;
        bool oDown = false;

        //Restart Check
        bool enterDown = false;

        //Ball Speed Decay Controlls
        int ballDecay = 0;
        int ballDecayRate = 10;

        //Track player speed
        int p1Speed = 0;
        int p2Speed = 0;
        int p1StoredSpeed = 0;
        int p2StoredSpeed = 0;

        int[] playerXSpeeds = { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5, -4, -3, -2, -1 };
        int[] playerYSpeeds = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0, -1, -2, -3, -4 };

        //Track Wizard Knockback
        int p1IsKnockback = 5;
        int p2IsKnockback = 5;

        //Track the facing direction
        bool p1IsRight = false;
        bool p2IsRight = false;

        //Track the hitboxes of p1 and p2
        Rectangle p1 = new Rectangle(400, 595, 55, 65);
        Rectangle p2 = new Rectangle(400, 35, 55, 65);
        Rectangle p1StartPosition = new Rectangle(400, 595, 55, 65);
        Rectangle p2StartPosition = new Rectangle(400, 35, 55, 65);

        Image p1LeftLoad = Properties.Resources.Player1Left;
        Image p1RightLoad = Properties.Resources.Player1Right;
        Image p2LeftLoad = Properties.Resources.Player2Left;
        Image p2RightLoad = Properties.Resources.Player2Right;

        //Track The Ball
        Rectangle Ball = new Rectangle(395, 320, 55, 55);
        Rectangle ballStartPosition = new Rectangle(395, 320, 55, 55);

        Image ballLoad = Properties.Resources.ShadowBallIcon;

        //Track Ball Speeds
        int ballSpeedX = 0;
        int ballSpeedY = 0;

        //Set up Goals
        int goalWidth = 300;
        int goalHeight = 100;
        Rectangle goalUp = new Rectangle();
        Rectangle goalDown = new Rectangle();

        //Set up Walls
        Rectangle wallLeft = new Rectangle(143, 38, 5, 605);
        Rectangle wallRight = new Rectangle(678, 38, 5, 605);
        Rectangle wallTopLeft = new Rectangle(143, 38, 180, 5);
        Rectangle wallTopRight = new Rectangle(500, 38, 180, 5);
        Rectangle wallBottomLeft = new Rectangle(143, 643, 180, 5);
        Rectangle wallBottomRight = new Rectangle(500, 643, 180, 5);
        Rectangle arcTopLeft = new Rectangle(143, 38, 125, 125);
        Rectangle arcTopRight = new Rectangle(558, 38, 125, 125);
        Rectangle arcBottomLeft = new Rectangle(143, 523, 125, 125);
        Rectangle arcBottomRight = new Rectangle(558, 523, 125, 125);

        //Middle of the Map
        Rectangle middleLine = new Rectangle(143, 342, 535, 5);

        //Drawing Tools
        Pen outlinePen = new Pen(Color.DarkGray, 5);
        Pen middlePen = new Pen(Color.Purple, 5);
        SolidBrush middleBrush = new SolidBrush(Color.Purple);
        SolidBrush outlineBrush = new SolidBrush(Color.DarkGray);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush accentBlueBrush = new SolidBrush(Color.Navy);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush accentRedBrush = new SolidBrush(Color.IndianRed);

        //Setup Sounds
        SoundPlayer playerBounce = new SoundPlayer(Properties.Resources.MageBallBounce);
        SoundPlayer wallBounce1 = new SoundPlayer(Properties.Resources.WallBounce1);
        SoundPlayer wallBounce2 = new SoundPlayer(Properties.Resources.WallBounce2);
        SoundPlayer wallBounce3 = new SoundPlayer(Properties.Resources.WallBounce3);
        SoundPlayer wallBounce4 = new SoundPlayer(Properties.Resources.WallBounce4);
        SoundPlayer fanfare = new SoundPlayer(Properties.Resources.victoryFanfare);
        public OrbReflect()
        {
            InitializeComponent();
            Refresh();
            FrameTimer.Enabled = true;
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
                case Keys.Enter:
                    enterDown = true;
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
                case Keys.Enter:
                    enterDown = false;
                    break;
            }
        }

        private void OrbReflect_Paint(object sender, PaintEventArgs e)
        {
                //Draw Arena Paintings
                //Carpet Walkway
                Rectangle RedCarpet = new Rectangle(325, 3, 175, 340);
                e.Graphics.FillRectangle(accentRedBrush, RedCarpet);
                Rectangle BlueCarpet = new Rectangle(325, 344, 175, 340);
                e.Graphics.FillRectangle(accentBlueBrush, BlueCarpet);

                //Circles
                Rectangle redCircleLeft = new Rectangle(170, 135, 120, 120);
                e.Graphics.FillPie(redBrush, redCircleLeft, 0, 360);
                Rectangle redCircleRight = new Rectangle(535, 135, 120, 120);
                e.Graphics.FillPie(redBrush, redCircleRight, 0, 360);
                Rectangle blueCircleLeft = new Rectangle(170, 465, 120, 120);
                e.Graphics.FillPie(blueBrush, blueCircleLeft, 0, 360);
                Rectangle blueCircleRight = new Rectangle(535, 465, 120, 120);
                e.Graphics.FillPie(blueBrush, blueCircleRight, 0, 360);
                Rectangle smallRedCircleLeft = new Rectangle(203, 168, 55, 55);
                e.Graphics.FillPie(accentRedBrush, smallRedCircleLeft, 0, 360);
                Rectangle smallRedCircleRight = new Rectangle(568, 168, 55, 55);
                e.Graphics.FillPie(accentRedBrush, smallRedCircleRight, 0, 360);
                Rectangle smallBlueCircleLeft = new Rectangle(203, 498, 55, 55);
                e.Graphics.FillPie(accentBlueBrush, smallBlueCircleLeft, 0, 360);
                Rectangle smallBlueCircleRight = new Rectangle(568, 498, 55, 55);
                e.Graphics.FillPie(accentBlueBrush, smallBlueCircleRight, 0, 360);

                //Halfway Line
                e.Graphics.FillRectangle(middleBrush, middleLine);
                e.Graphics.DrawArc(middlePen, 335, 265, 155, 155, 0, 360);


                //Draw Walls
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

                //Arc drawn for goals
                e.Graphics.DrawArc(outlinePen, 325, 603, 175, 80, 0, 180);
                e.Graphics.DrawArc(outlinePen, 325, 3, 175, 80, 180, 180);

            //Set Wizard Positions
            p1Display.Location = new Point(p1.X - 10, p1.Y - 5);
            p2Display.Location = new Point(p2.X - 10, p2.Y - 5);

            //Set The Orb
            ShadowBallDisplay.Location = new Point(Ball.X - 5, Ball.Y);
        }

        private void gameFrameTimer(object sender, EventArgs e)
        {
            if (p1IsKnockback >= 5)
            {
                //Determine Move Speed P1
                if (aDown == true)
                {
                    p1Speed--;
                    if (p1Speed < 0)
                    {
                        p1Speed = 19;
                    }
                }
                if (dDown == true)
                {
                    p1Speed++;
                    if (p1Speed > 19)
                    {
                        p1Speed = 0;
                    }
                }

                //Move p1
                if (wDown == true)
                {
                    p1.X += playerXSpeeds[p1Speed];
                    p1.Y += playerYSpeeds[p1Speed];
                }
                if (sDown == true)
                {
                    p1.X -= playerXSpeeds[p1Speed];
                    p1.Y -= playerYSpeeds[p1Speed];
                }

                //Check for p1 Sprint
                if (capsDown == true)
                {
                    if (wDown == true)
                    {
                        if (playerXSpeeds[p1Speed] > 0)
                        {
                            p1.X += 5;
                        }
                        else if (playerXSpeeds[p1Speed] < 0)
                        {
                            p1.X -= 5;
                        }

                        if (playerYSpeeds[p1Speed] > 0)
                        {
                            p1.Y += 5;
                        }
                        else if (playerYSpeeds[p1Speed] < 0)
                        {
                            p1.Y -= 5;
                        }
                    }

                    if (sDown == true)
                    {
                        if (playerXSpeeds[p1Speed] * -1 > 0)
                        {
                            p1.X += 5;
                        }
                        else if (playerXSpeeds[p1Speed] * -1 < 0)
                        {
                            p1.X -= 5;
                        }

                        if (playerYSpeeds[p1Speed] * -1 > 0)
                        {
                            p1.Y += 5;
                        }
                        else if (playerYSpeeds[p1Speed] * -1 < 0)
                        {
                            p1.Y -= 5;
                        }
                    }
                }

                //Check Walls
                if (p1.IntersectsWith(wallLeft))
                {
                    p1.X = wallLeft.X + wallLeft.Width + 1;
                }
                if (p1.IntersectsWith(wallRight))
                {
                    p1.X = wallRight.X - p1.Width;
                }
                if (p1.IntersectsWith(wallBottomLeft))
                {
                    p1.Y = wallBottomLeft.Y - p1.Height;
                }
                if (p1.IntersectsWith(wallBottomRight))
                {
                    p1.Y = wallBottomRight.Y - p1.Height;
                }
                if (p1.IntersectsWith(middleLine))
                {
                    p1.Y = middleLine.Y + middleLine.Height + 1;
                }
                if (p1.Y + p1.Height > 700)
                {
                    p1.Y = 700 - p1.Height;
                }
                //DetermineArcIntersect("Bottom Left", "p1");
                //DetermineArcIntersect("Bottom Right", "p1");

                //Set Wizard Orientation p1
                if (p1Speed > 9)
                {
                    p1Display.BackgroundImage = p1LeftLoad;
                }
                else
                {
                    p1Display.BackgroundImage = p1RightLoad;
                }
            }
            else
            {
                p1.X += ballSpeedX * -1;
                p1.Y += ballSpeedY * -1;
                p1IsKnockback++;
            }

            if (p2IsKnockback >= 5)
            {
                //Determine Move Speed P2
                if (jDown == true)
                {
                    p2Speed--;
                    if (p2Speed < 0)
                    {
                        p2Speed = 19;
                    }
                }
                if (lDown == true)
                {
                    p2Speed++;
                    if (p2Speed > 19)
                    {
                        p2Speed = 0;
                    }
                }

                //Move p2
                if (iDown == true)
                {
                    p2.X += playerXSpeeds[p2Speed];
                    p2.Y += playerYSpeeds[p2Speed];
                }
                if (kDown == true)
                {
                    p2.X -= playerXSpeeds[p2Speed];
                    p2.Y -= playerYSpeeds[p2Speed];
                }

                //Check for p2 Sprint
                if (hDown == true)
                {
                    if (iDown == true)
                    {
                        if (playerXSpeeds[p2Speed] > 0)
                        {
                            p2.X += 5;
                        }
                        else if (playerXSpeeds[p2Speed] < 0)
                        {
                            p2.X -= 5;
                        }

                        if (playerYSpeeds[p2Speed] > 0)
                        {
                            p2.Y += 5;
                        }
                        else if (playerYSpeeds[p2Speed] < 0)
                        {
                            p2.Y -= 5;
                        }
                    }

                    if (kDown == true)
                    {
                        if (playerXSpeeds[p2Speed] * -1 > 0)
                        {
                            p2.X += 5;
                        }
                        else if (playerXSpeeds[p2Speed] * -1 < 0)
                        {
                            p2.X -= 5;
                        }

                        if (playerYSpeeds[p2Speed] * -1 > 0)
                        {
                            p2.Y += 5;
                        }
                        else if (playerYSpeeds[p2Speed] * -1 < 0)
                        {
                            p2.Y -= 5;
                        }
                    }
                }

                //Check For Collisions p2
                if (p2.IntersectsWith(wallLeft))
                {
                    p2.X = wallLeft.X + wallLeft.Width + 1;
                }
                if (p2.IntersectsWith(wallRight))
                {
                    p2.X = wallRight.X - p2.Width;
                }
                if (p2.IntersectsWith(wallTopLeft))
                {
                    p2.Y = wallTopLeft.Y + +wallTopLeft.Height + 1;
                }
                if (p2.IntersectsWith(wallTopRight))
                {
                    p2.Y = wallTopRight.Y + wallTopRight.Height + 1;
                }
                if (p2.IntersectsWith(middleLine))
                {
                    p2.Y = middleLine.Y - p2.Height;
                }
                if (p2.Y < 3)
                {
                    p2.Y = 3;
                }
                //DetermineArcIntersect("Top Left", "p2");
                //DetermineArcIntersect("Top Right", "p2");


                //Set Wizard Orientation p2
                if (p2Speed > 9)
                {
                    p2Display.BackgroundImage = p2LeftLoad;
                }
                else
                {
                    p2Display.BackgroundImage = p2RightLoad;
                }
            }
            else
            {
                p2.X += ballSpeedX * -1;
                p2.Y += ballSpeedY * -1;
                p2IsKnockback++;
            }

            //Slow The Ball
            if (ballSpeedX > 0 || ballSpeedX < 0 || ballSpeedY > 0 || ballSpeedY < 0)
            {
                if (ballDecay >= ballDecayRate)
                {
                    if (ballSpeedX > 0)
                    {
                        ballSpeedX--;
                    }
                    else if (ballSpeedX < 0)
                    {
                        ballSpeedX++;
                    }
                    if (ballSpeedY > 0)
                    {
                        ballSpeedY--;
                    }
                    else if (ballSpeedY < 0)
                    {
                        ballSpeedY++;
                    }
                    ballDecay = 0;
                }
                else
                {
                    ballDecay++;
                }
            }

            //Check Ball Collisions
            if (Ball.IntersectsWith(wallLeft))
            {
                Ball.X = wallLeft.X + wallLeft.Width + 1;
                ballSpeedX = ballSpeedX * -1;
                wallBounce1.Play();
            }
            if (Ball.IntersectsWith(wallRight))
            {
                Ball.X = wallRight.X - wallRight.Width - Ball.Width;
                ballSpeedX = ballSpeedX * -1;
                wallBounce2.Play();
            }
            if (Ball.IntersectsWith(wallTopLeft))
            {
                Ball.Y = wallTopLeft.Y + wallTopLeft.Height + 1;
                ballSpeedY = ballSpeedY * -1;
                wallBounce3.Play();
            }
            if (Ball.IntersectsWith(wallTopRight))
            {
                Ball.Y = wallTopRight.Y + wallTopRight.Height + 1;
                ballSpeedY = ballSpeedY * -1;
                wallBounce3.Play();
            }
            if (Ball.IntersectsWith(wallBottomLeft))
            {
                Ball.Y = wallBottomLeft.Y - Ball.Height - 1;
                ballSpeedY = ballSpeedY * -1;
                wallBounce4.Play();
            }
            if (Ball.IntersectsWith(wallBottomRight))
            {
                Ball.Y = wallBottomRight.Y - Ball.Height - 1;
                ballSpeedY = ballSpeedY * -1;
                wallBounce4.Play();
            }
            //DetermineArcIntersect("Bottom Left", "p1");
            //DetermineArcIntersect("Bottom Right", "p1");
            //DetermineArcIntersect("Top Left", "p2");
            //DetermineArcIntersect("Top Right", "p2");

            //Check Ball Hits p1
            if (p1.IntersectsWith(Ball))
            {
                ballSpeedX += playerXSpeeds[p1Speed] * 3;
                ballSpeedY += playerYSpeeds[p1Speed] * 3;
                if (capsDown == true)
                {
                    ballSpeedX = Convert.ToInt16(ballSpeedX * 1.5);
                    ballSpeedY = Convert.ToInt16(ballSpeedY * 1.5);
                }
                p1IsKnockback = 0;
                playerBounce.Play();
            }

            //Check Ball Hits p2
            if (p2.IntersectsWith(Ball))
            {
                ballSpeedX += playerXSpeeds[p2Speed] * -3;
                ballSpeedY += playerYSpeeds[p2Speed] * -3;
                if (hDown == true)
                {
                    ballSpeedX = Convert.ToInt16(ballSpeedX * 1.5);
                    ballSpeedY = Convert.ToInt16(ballSpeedY * 1.5);
                }
                p2IsKnockback = 0;
                playerBounce.Play();
            }

            //Move Ball
            Ball.X += ballSpeedX;
            Ball.Y += ballSpeedY;

            //Check For Score
            if (Ball.Y < 3)
            {
                p1Score++;
                p1ScoreDisplay.Text = Convert.ToString(p1Score);
                ballSpeedX = 0;
                ballSpeedY = 0;
                Ball.Location = ballStartPosition.Location;
                p1Speed = 0;
                p2Speed = 0;
                p1.Location = p1StartPosition.Location;
                p2.Location = p2StartPosition.Location;
            }

            if (Ball.Y + Ball.Height > 700)
            {
                p2Score++;
                p2ScoreDisplay.Text = Convert.ToString(p2Score);
                ballSpeedX = 0;
                ballSpeedY = 0;
                Ball.Location = ballStartPosition.Location;
                p1Speed = 0;
                p2Speed = 0;
                p1.Location = p1StartPosition.Location;
                p2.Location = p2StartPosition.Location;
            }

            if (p1Score >= 3 && p1Score - p2Score >= 2)
            {
                FrameTimer.Stop();
                winLabel.Visible = true;
                winLabel.BackColor = Color.DarkBlue;
                winLabel.Text = "The Blue Mage Wins The Duel! \nRestart? (Enter)";
                RestartTimer.Enabled = true;
                fanfare.Play();
            }

            else if (p2Score >= 3 && p2Score - p1Score >= 2)
            {
                FrameTimer.Stop();
                winLabel.Visible = true;
                winLabel.BackColor = Color.Maroon;
                winLabel.Text = "The Red Mage Wins The Duel! \nRestart? (Enter)";
                RestartTimer.Enabled = true;
                fanfare.Play();
            }

            //Check The Mages Are Still In the Playing Field
            //Boundaries can be broken "magically", due to high speed knockback
            //Will Be Patched
            if (p2.X < 125 || p2.X > 700 || p2.Y < 0 || p2.Y > 355)
            {
                p2.Location = p2StartPosition.Location;
            }
            if (p1.X < 125 || p1.X > 700 || p1.Y < 330 || p1.Y > 725)
            {
                p1.Location = p1StartPosition.Location;
            }

            Refresh();
        }

        void DetermineArcIntersect(String arcIntercept, String objectIntercept)
        {
            Point position = new Point();

            if (arcIntercept == "Top Left")
            {
                double aValue = -0.008;

                if (objectIntercept == "p1")
                {
                    position = new Point(p1.X, p1.Y);
                }

                else if (objectIntercept == "p2")
                {
                    position = new Point(p2.X, p2.Y);
                }

                else if (objectIntercept == "Orb")
                {
                    position = new Point(Ball.X, Ball.Y);
                }

                int yPoint = Convert.ToInt32(aValue * Math.Pow(position.X - (arcTopLeft.X + arcTopLeft.Width), 2) + arcTopLeft.Y);
                int xPoint = Convert.ToInt32(Math.Sqrt((position.Y - arcTopLeft.Y) / aValue) + (arcTopLeft.X + arcTopLeft.Width));

                if (position.X < xPoint && position.Y < yPoint)
                {
                    if (objectIntercept == "p1")
                    {
                        p1.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "p2")
                    {
                        p2.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "Ball")
                    {
                        Ball.Location = new Point(xPoint, yPoint);
                    }
                }
            }
            else if (arcIntercept == "Top Right")
            {
                double aValue = -0.008;

                if (objectIntercept == "p1")
                {
                    position = new Point(p1.X + p1.Width, p1.Y);
                }

                else if (objectIntercept == "p2")
                {
                    position = new Point(p2.X + p2.Width, p2.Y);
                }

                else if (objectIntercept == "Orb")
                {
                    position = new Point(Ball.X + Ball.Width, Ball.Y);
                }

                int yPoint = Convert.ToInt32(aValue * Math.Pow(position.X - arcTopRight.X, 2) + arcTopRight.Y);
                int xPoint = Convert.ToInt32(Math.Sqrt((position.Y - arcTopRight.Y) / aValue) + arcTopRight.X);

                if (position.X > xPoint && position.Y < yPoint)
                {
                    if (objectIntercept == "p1")
                    {
                        p1.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "p2")
                    {
                        p2.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "Ball")
                    {
                        Ball.Location = new Point(xPoint, yPoint);
                    }
                }
            }
            if (arcIntercept == "Bottom Left")
            {
                double aValue = 0.008;

                if (objectIntercept == "p1")
                {
                    position = new Point(p1.X, p1.Y + p1.Height);
                }

                else if (objectIntercept == "p2")
                {
                    position = new Point(p2.X, p2.Y + p2.Height);
                }

                else if (objectIntercept == "Orb")
                {
                    position = new Point(Ball.X, Ball.Y + Ball.Height);
                }
                int yPoint = Convert.ToInt32(aValue * Math.Pow(position.X - (arcBottomLeft.X + arcBottomLeft.Width), 2) + (arcBottomLeft.Y + arcBottomLeft.Height));
                int xPoint = Convert.ToInt32(Math.Sqrt((position.Y - (arcBottomLeft.Y + arcBottomLeft.Height)) / aValue) + (arcBottomLeft.X + arcBottomLeft.Width));

                if (position.X < xPoint && position.Y > yPoint)
                {
                    if (objectIntercept == "p1")
                    {
                        p1.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "p2")
                    {
                        p2.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "Ball")
                    {
                        Ball.Location = new Point(xPoint, yPoint);
                    }
                }
            }
            else if (arcIntercept == "Bottom Right")
            {
                double aValue = 0.008;

                if (objectIntercept == "p1")
                {
                    position = new Point(p1.X + p1.Width, p1.Y + p1.Height);
                }

                else if (objectIntercept == "p2")
                {
                    position = new Point(p2.X + p2.Width, p2.Y + p2.Height);
                }

                else if (objectIntercept == "Orb")
                {
                    position = new Point(Ball.X + Ball.Width, Ball.Y + Ball.Height);
                }
                int yPoint = Convert.ToInt32(aValue * Math.Pow(position.X - arcBottomRight.X, 2) + (arcBottomRight.Y + arcBottomRight.Height));
                int xPoint = Convert.ToInt32(Math.Sqrt((position.Y - (arcBottomRight.Y + arcBottomRight.Height)) / aValue) + arcBottomRight.X);

                if (position.X > xPoint && position.Y > yPoint)
                {
                    if (objectIntercept == "p1")
                    {
                        p1.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "p2")
                    {
                        p2.Location = new Point(xPoint, yPoint);
                    }
                    else if (objectIntercept == "Ball")
                    {
                        Ball.Location = new Point(xPoint, yPoint);
                    }
                }
            }
        }

        private void RestartTimer_Tick(object sender, EventArgs e)
        {
            if (enterDown == true)
            {
                Application.Restart();
                Application.Exit();
            }
        }
    }
}

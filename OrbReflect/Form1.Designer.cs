namespace OrbReflect
{
    partial class OrbReflect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrbReflect));
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.keyUDisplay = new System.Windows.Forms.PictureBox();
            this.p2SpellWindow = new System.Windows.Forms.PictureBox();
            this.p1Display = new System.Windows.Forms.PictureBox();
            this.keyODisplay = new System.Windows.Forms.PictureBox();
            this.p2LeftArrowDisplay = new System.Windows.Forms.PictureBox();
            this.p2RightArrowDisplay = new System.Windows.Forms.PictureBox();
            this.keySemiColonDisplay = new System.Windows.Forms.PictureBox();
            this.keyFDisplay = new System.Windows.Forms.PictureBox();
            this.p1RightArrowDisplay = new System.Windows.Forms.PictureBox();
            this.p1LeftArrowDisplay = new System.Windows.Forms.PictureBox();
            this.keyEDisplay = new System.Windows.Forms.PictureBox();
            this.keyQDisplay = new System.Windows.Forms.PictureBox();
            this.p1SpellWindow = new System.Windows.Forms.PictureBox();
            this.ControlBackdrop = new System.Windows.Forms.Label();
            this.p2Display = new System.Windows.Forms.PictureBox();
            this.ShadowBallDisplay = new System.Windows.Forms.PictureBox();
            this.p2ScoreDisplay = new System.Windows.Forms.Label();
            this.p1ScoreDisplay = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.RestartTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.keyUDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2SpellWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyODisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2LeftArrowDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2RightArrowDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySemiColonDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1RightArrowDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1LeftArrowDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyEDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyQDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1SpellWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowBallDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // FrameTimer
            // 
            this.FrameTimer.Interval = 25;
            this.FrameTimer.Tick += new System.EventHandler(this.gameFrameTimer);
            // 
            // keyUDisplay
            // 
            this.keyUDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.Ukey;
            this.keyUDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyUDisplay.Location = new System.Drawing.Point(12, 45);
            this.keyUDisplay.Name = "keyUDisplay";
            this.keyUDisplay.Size = new System.Drawing.Size(52, 52);
            this.keyUDisplay.TabIndex = 2;
            this.keyUDisplay.TabStop = false;
            // 
            // p2SpellWindow
            // 
            this.p2SpellWindow.BackColor = System.Drawing.SystemColors.Control;
            this.p2SpellWindow.BackgroundImage = global::OrbReflect.Properties.Resources.FireballIcon;
            this.p2SpellWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2SpellWindow.Location = new System.Drawing.Point(12, 103);
            this.p2SpellWindow.Name = "p2SpellWindow";
            this.p2SpellWindow.Size = new System.Drawing.Size(152, 172);
            this.p2SpellWindow.TabIndex = 1;
            this.p2SpellWindow.TabStop = false;
            // 
            // p1Display
            // 
            this.p1Display.BackColor = System.Drawing.Color.Transparent;
            this.p1Display.BackgroundImage = global::OrbReflect.Properties.Resources.Player1Left;
            this.p1Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1Display.Location = new System.Drawing.Point(444, 614);
            this.p1Display.Name = "p1Display";
            this.p1Display.Size = new System.Drawing.Size(75, 75);
            this.p1Display.TabIndex = 0;
            this.p1Display.TabStop = false;
            // 
            // keyODisplay
            // 
            this.keyODisplay.BackgroundImage = global::OrbReflect.Properties.Resources.Okey;
            this.keyODisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyODisplay.Location = new System.Drawing.Point(112, 45);
            this.keyODisplay.Name = "keyODisplay";
            this.keyODisplay.Size = new System.Drawing.Size(52, 52);
            this.keyODisplay.TabIndex = 3;
            this.keyODisplay.TabStop = false;
            // 
            // p2LeftArrowDisplay
            // 
            this.p2LeftArrowDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.LeftArrow;
            this.p2LeftArrowDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2LeftArrowDisplay.Location = new System.Drawing.Point(12, 1);
            this.p2LeftArrowDisplay.Name = "p2LeftArrowDisplay";
            this.p2LeftArrowDisplay.Size = new System.Drawing.Size(52, 38);
            this.p2LeftArrowDisplay.TabIndex = 4;
            this.p2LeftArrowDisplay.TabStop = false;
            // 
            // p2RightArrowDisplay
            // 
            this.p2RightArrowDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.p2RightArrowDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.RightArrow;
            this.p2RightArrowDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2RightArrowDisplay.Location = new System.Drawing.Point(112, 1);
            this.p2RightArrowDisplay.Name = "p2RightArrowDisplay";
            this.p2RightArrowDisplay.Size = new System.Drawing.Size(52, 38);
            this.p2RightArrowDisplay.TabIndex = 5;
            this.p2RightArrowDisplay.TabStop = false;
            // 
            // keySemiColonDisplay
            // 
            this.keySemiColonDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.Semicolonkey;
            this.keySemiColonDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keySemiColonDisplay.Location = new System.Drawing.Point(38, 281);
            this.keySemiColonDisplay.Name = "keySemiColonDisplay";
            this.keySemiColonDisplay.Size = new System.Drawing.Size(95, 82);
            this.keySemiColonDisplay.TabIndex = 6;
            this.keySemiColonDisplay.TabStop = false;
            // 
            // keyFDisplay
            // 
            this.keyFDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.Fkey;
            this.keyFDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyFDisplay.Location = new System.Drawing.Point(38, 735);
            this.keyFDisplay.Name = "keyFDisplay";
            this.keyFDisplay.Size = new System.Drawing.Size(80, 82);
            this.keyFDisplay.TabIndex = 12;
            this.keyFDisplay.TabStop = false;
            // 
            // p1RightArrowDisplay
            // 
            this.p1RightArrowDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.p1RightArrowDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.RightArrow;
            this.p1RightArrowDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1RightArrowDisplay.Location = new System.Drawing.Point(112, 455);
            this.p1RightArrowDisplay.Name = "p1RightArrowDisplay";
            this.p1RightArrowDisplay.Size = new System.Drawing.Size(52, 38);
            this.p1RightArrowDisplay.TabIndex = 11;
            this.p1RightArrowDisplay.TabStop = false;
            // 
            // p1LeftArrowDisplay
            // 
            this.p1LeftArrowDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.LeftArrow;
            this.p1LeftArrowDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1LeftArrowDisplay.Location = new System.Drawing.Point(12, 455);
            this.p1LeftArrowDisplay.Name = "p1LeftArrowDisplay";
            this.p1LeftArrowDisplay.Size = new System.Drawing.Size(52, 38);
            this.p1LeftArrowDisplay.TabIndex = 10;
            this.p1LeftArrowDisplay.TabStop = false;
            // 
            // keyEDisplay
            // 
            this.keyEDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.Ekey;
            this.keyEDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyEDisplay.Location = new System.Drawing.Point(112, 499);
            this.keyEDisplay.Name = "keyEDisplay";
            this.keyEDisplay.Size = new System.Drawing.Size(52, 52);
            this.keyEDisplay.TabIndex = 9;
            this.keyEDisplay.TabStop = false;
            // 
            // keyQDisplay
            // 
            this.keyQDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.Qkey;
            this.keyQDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyQDisplay.Location = new System.Drawing.Point(12, 499);
            this.keyQDisplay.Name = "keyQDisplay";
            this.keyQDisplay.Size = new System.Drawing.Size(52, 52);
            this.keyQDisplay.TabIndex = 8;
            this.keyQDisplay.TabStop = false;
            // 
            // p1SpellWindow
            // 
            this.p1SpellWindow.BackColor = System.Drawing.SystemColors.Control;
            this.p1SpellWindow.BackgroundImage = global::OrbReflect.Properties.Resources.FireballIcon;
            this.p1SpellWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1SpellWindow.Location = new System.Drawing.Point(12, 557);
            this.p1SpellWindow.Name = "p1SpellWindow";
            this.p1SpellWindow.Size = new System.Drawing.Size(152, 172);
            this.p1SpellWindow.TabIndex = 7;
            this.p1SpellWindow.TabStop = false;
            // 
            // ControlBackdrop
            // 
            this.ControlBackdrop.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBackdrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ControlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.ControlBackdrop.Name = "ControlBackdrop";
            this.ControlBackdrop.Size = new System.Drawing.Size(190, 858);
            this.ControlBackdrop.TabIndex = 13;
            // 
            // p2Display
            // 
            this.p2Display.BackColor = System.Drawing.Color.Transparent;
            this.p2Display.BackgroundImage = global::OrbReflect.Properties.Resources.Player2Left;
            this.p2Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2Display.Location = new System.Drawing.Point(429, 389);
            this.p2Display.Name = "p2Display";
            this.p2Display.Size = new System.Drawing.Size(75, 75);
            this.p2Display.TabIndex = 14;
            this.p2Display.TabStop = false;
            // 
            // ShadowBallDisplay
            // 
            this.ShadowBallDisplay.BackColor = System.Drawing.Color.Transparent;
            this.ShadowBallDisplay.BackgroundImage = global::OrbReflect.Properties.Resources.ShadowBallIcon;
            this.ShadowBallDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShadowBallDisplay.Location = new System.Drawing.Point(544, 297);
            this.ShadowBallDisplay.Name = "ShadowBallDisplay";
            this.ShadowBallDisplay.Size = new System.Drawing.Size(65, 55);
            this.ShadowBallDisplay.TabIndex = 15;
            this.ShadowBallDisplay.TabStop = false;
            // 
            // p2ScoreDisplay
            // 
            this.p2ScoreDisplay.BackColor = System.Drawing.Color.Maroon;
            this.p2ScoreDisplay.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p2ScoreDisplay.Location = new System.Drawing.Point(667, 0);
            this.p2ScoreDisplay.Name = "p2ScoreDisplay";
            this.p2ScoreDisplay.Size = new System.Drawing.Size(267, 48);
            this.p2ScoreDisplay.TabIndex = 16;
            this.p2ScoreDisplay.Text = "0";
            this.p2ScoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1ScoreDisplay
            // 
            this.p1ScoreDisplay.BackColor = System.Drawing.Color.DarkBlue;
            this.p1ScoreDisplay.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p1ScoreDisplay.Location = new System.Drawing.Point(667, 810);
            this.p1ScoreDisplay.Name = "p1ScoreDisplay";
            this.p1ScoreDisplay.Size = new System.Drawing.Size(267, 48);
            this.p1ScoreDisplay.TabIndex = 17;
            this.p1ScoreDisplay.Text = "0";
            this.p1ScoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Maroon;
            this.winLabel.Font = new System.Drawing.Font("Magneto", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winLabel.Location = new System.Drawing.Point(196, 399);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(738, 94);
            this.winLabel.TabIndex = 18;
            this.winLabel.Text = "Enigma";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // RestartTimer
            // 
            this.RestartTimer.Tick += new System.EventHandler(this.RestartTimer_Tick);
            // 
            // OrbReflect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::OrbReflect.Properties.Resources.BattleTexture;
            this.ClientSize = new System.Drawing.Size(932, 853);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p1ScoreDisplay);
            this.Controls.Add(this.p2ScoreDisplay);
            this.Controls.Add(this.p2Display);
            this.Controls.Add(this.keyFDisplay);
            this.Controls.Add(this.p1RightArrowDisplay);
            this.Controls.Add(this.p1LeftArrowDisplay);
            this.Controls.Add(this.keyEDisplay);
            this.Controls.Add(this.keyQDisplay);
            this.Controls.Add(this.p1SpellWindow);
            this.Controls.Add(this.keySemiColonDisplay);
            this.Controls.Add(this.p2RightArrowDisplay);
            this.Controls.Add(this.p2LeftArrowDisplay);
            this.Controls.Add(this.keyODisplay);
            this.Controls.Add(this.keyUDisplay);
            this.Controls.Add(this.p2SpellWindow);
            this.Controls.Add(this.p1Display);
            this.Controls.Add(this.ControlBackdrop);
            this.Controls.Add(this.ShadowBallDisplay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrbReflect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrbReflect";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OrbReflect_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrbReflect_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OrbReflect_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.keyUDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2SpellWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyODisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2LeftArrowDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2RightArrowDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySemiColonDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyFDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1RightArrowDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1LeftArrowDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyEDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyQDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1SpellWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowBallDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.PictureBox p1Display;
        private System.Windows.Forms.PictureBox p2SpellWindow;
        private System.Windows.Forms.PictureBox keyUDisplay;
        private System.Windows.Forms.PictureBox keyODisplay;
        private System.Windows.Forms.PictureBox p2LeftArrowDisplay;
        private System.Windows.Forms.PictureBox p2RightArrowDisplay;
        private System.Windows.Forms.PictureBox keySemiColonDisplay;
        private System.Windows.Forms.PictureBox keyFDisplay;
        private System.Windows.Forms.PictureBox p1RightArrowDisplay;
        private System.Windows.Forms.PictureBox p1LeftArrowDisplay;
        private System.Windows.Forms.PictureBox keyEDisplay;
        private System.Windows.Forms.PictureBox keyQDisplay;
        private System.Windows.Forms.PictureBox p1SpellWindow;
        private System.Windows.Forms.Label ControlBackdrop;
        private System.Windows.Forms.PictureBox p2Display;
        private System.Windows.Forms.PictureBox ShadowBallDisplay;
        private System.Windows.Forms.Label p2ScoreDisplay;
        private System.Windows.Forms.Label p1ScoreDisplay;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Timer RestartTimer;
    }
}


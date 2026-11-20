namespace snake_and_apple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picBomb = new PictureBox();
            picSnake = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            picApple = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBomb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSnake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picApple).BeginInit();
            SuspendLayout();
            // 
            // picBomb
            // 
            picBomb.Image = (Image)resources.GetObject("picBomb.Image");
            picBomb.Location = new Point(219, 115);
            picBomb.Name = "picBomb";
            picBomb.Size = new Size(77, 68);
            picBomb.SizeMode = PictureBoxSizeMode.Zoom;
            picBomb.TabIndex = 1;
            picBomb.TabStop = false;
            // 
            // picSnake
            // 
            picSnake.Image = (Image)resources.GetObject("picSnake.Image");
            picSnake.Location = new Point(248, 414);
            picSnake.Name = "picSnake";
            picSnake.Size = new Size(97, 97);
            picSnake.SizeMode = PictureBoxSizeMode.Zoom;
            picSnake.TabIndex = 0;
            picSnake.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // picApple
            // 
            picApple.Image = (Image)resources.GetObject("picApple.Image");
            picApple.Location = new Point(518, 205);
            picApple.Name = "picApple";
            picApple.Size = new Size(77, 68);
            picApple.SizeMode = PictureBoxSizeMode.Zoom;
            picApple.TabIndex = 2;
            picApple.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 547);
            Controls.Add(picApple);
            Controls.Add(picBomb);
            Controls.Add(picSnake);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake and apple";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBomb).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSnake).EndInit();
            ((System.ComponentModel.ISupportInitialize)picApple).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picSnake;
        private PictureBox picBomb;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picApple;
    }
}

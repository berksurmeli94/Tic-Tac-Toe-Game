namespace NoughtsandCrosses
{
    partial class tictactoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tictactoe));
            this.Me = new System.Windows.Forms.Label();
            this.XWin = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.DumbCPU = new System.Windows.Forms.RadioButton();
            this.AverageCPU = new System.Windows.Forms.RadioButton();
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_komut_istemi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Me
            // 
            this.Me.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Me.ForeColor = System.Drawing.Color.White;
            this.Me.Location = new System.Drawing.Point(495, 270);
            this.Me.Name = "Me";
            this.Me.Size = new System.Drawing.Size(210, 32);
            this.Me.TabIndex = 2;
            this.Me.Text = "Ben";
            // 
            // XWin
            // 
            this.XWin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.XWin.ForeColor = System.Drawing.Color.White;
            this.XWin.Location = new System.Drawing.Point(495, 376);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(233, 32);
            this.XWin.TabIndex = 2;
            this.XWin.Text = "Bilgisayar";
            // 
            // Draws
            // 
            this.Draws.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Draws.ForeColor = System.Drawing.Color.White;
            this.Draws.Location = new System.Drawing.Point(495, 482);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(221, 33);
            this.Draws.TabIndex = 2;
            this.Draws.Text = "Beraberlik";
            // 
            // DumbCPU
            // 
            this.DumbCPU.AutoSize = true;
            this.DumbCPU.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DumbCPU.ForeColor = System.Drawing.Color.White;
            this.DumbCPU.Location = new System.Drawing.Point(85, 578);
            this.DumbCPU.Name = "DumbCPU";
            this.DumbCPU.Size = new System.Drawing.Size(78, 26);
            this.DumbCPU.TabIndex = 3;
            this.DumbCPU.TabStop = true;
            this.DumbCPU.Text = "Kolay";
            this.DumbCPU.UseVisualStyleBackColor = true;
            // 
            // AverageCPU
            // 
            this.AverageCPU.AutoSize = true;
            this.AverageCPU.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AverageCPU.ForeColor = System.Drawing.Color.White;
            this.AverageCPU.Location = new System.Drawing.Point(288, 578);
            this.AverageCPU.Name = "AverageCPU";
            this.AverageCPU.Size = new System.Drawing.Size(58, 26);
            this.AverageCPU.TabIndex = 4;
            this.AverageCPU.TabStop = true;
            this.AverageCPU.Text = "Zor";
            this.AverageCPU.UseVisualStyleBackColor = true;
            // 
            // A00
            // 
            this.A00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A00.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A00.ForeColor = System.Drawing.Color.White;
            this.A00.Location = new System.Drawing.Point(76, 203);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(100, 100);
            this.A00.TabIndex = 6;
            this.A00.UseVisualStyleBackColor = false;
            this.A00.Click += new System.EventHandler(this.buttonClick);
            // 
            // A01
            // 
            this.A01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A01.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A01.ForeColor = System.Drawing.Color.White;
            this.A01.Location = new System.Drawing.Point(182, 203);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(100, 100);
            this.A01.TabIndex = 6;
            this.A01.UseVisualStyleBackColor = false;
            this.A01.Click += new System.EventHandler(this.buttonClick);
            // 
            // A02
            // 
            this.A02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A02.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A02.ForeColor = System.Drawing.Color.White;
            this.A02.Location = new System.Drawing.Point(288, 203);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(100, 100);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = false;
            this.A02.Click += new System.EventHandler(this.buttonClick);
            // 
            // A10
            // 
            this.A10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A10.ForeColor = System.Drawing.Color.White;
            this.A10.Location = new System.Drawing.Point(76, 309);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(100, 100);
            this.A10.TabIndex = 6;
            this.A10.UseVisualStyleBackColor = false;
            this.A10.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A11.ForeColor = System.Drawing.Color.White;
            this.A11.Location = new System.Drawing.Point(182, 309);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(100, 100);
            this.A11.TabIndex = 6;
            this.A11.UseVisualStyleBackColor = false;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A12.ForeColor = System.Drawing.Color.White;
            this.A12.Location = new System.Drawing.Point(288, 309);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(100, 100);
            this.A12.TabIndex = 6;
            this.A12.UseVisualStyleBackColor = false;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A20.ForeColor = System.Drawing.Color.White;
            this.A20.Location = new System.Drawing.Point(76, 415);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(100, 100);
            this.A20.TabIndex = 6;
            this.A20.UseVisualStyleBackColor = false;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A21.ForeColor = System.Drawing.Color.White;
            this.A21.Location = new System.Drawing.Point(182, 415);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(100, 100);
            this.A21.TabIndex = 6;
            this.A21.UseVisualStyleBackColor = false;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.A22.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A22.ForeColor = System.Drawing.Color.White;
            this.A22.Location = new System.Drawing.Point(288, 415);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(100, 100);
            this.A22.TabIndex = 6;
            this.A22.UseVisualStyleBackColor = false;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(591, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skorlar";
            // 
            // lbl_close
            // 
            this.lbl_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_close.BackColor = System.Drawing.Color.Black;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(884, 0);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(66, 39);
            this.lbl_close.TabIndex = 2;
            this.lbl_close.Text = "X";
            this.lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            this.lbl_close.MouseLeave += new System.EventHandler(this.lbl_close_MouseLeave);
            this.lbl_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_close_MouseMove);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbl_close);
            this.bunifuGradientPanel1.Controls.Add(this.lbl_komut_istemi);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(950, 39);
            this.bunifuGradientPanel1.TabIndex = 7;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseMove);
            this.bunifuGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseUp);
            // 
            // lbl_komut_istemi
            // 
            this.lbl_komut_istemi.BackColor = System.Drawing.Color.Black;
            this.lbl_komut_istemi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_komut_istemi.ForeColor = System.Drawing.Color.White;
            this.lbl_komut_istemi.Location = new System.Drawing.Point(12, 9);
            this.lbl_komut_istemi.Name = "lbl_komut_istemi";
            this.lbl_komut_istemi.Size = new System.Drawing.Size(152, 30);
            this.lbl_komut_istemi.TabIndex = 2;
            this.lbl_komut_istemi.Text = "Komut İstemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 76);
            this.label2.TabIndex = 8;
            this.label2.Text = "Microsoft Windows [Version 10.0.18363.815]\r\n(c) 2020 Microsoft Corporation. Tüm h" +
    "akları saklıdır.\r\n\r\nC:\\Users\\admin\\";
            // 
            // tictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(950, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Controls.Add(this.AverageCPU);
            this.Controls.Add(this.DumbCPU);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Me);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tictactoe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Me;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.RadioButton DumbCPU;
        private System.Windows.Forms.RadioButton AverageCPU;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_close;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_komut_istemi;
    }
}


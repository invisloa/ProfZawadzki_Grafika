namespace ProfZawadzki
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.BtnRed = new System.Windows.Forms.Button();
			this.BtnYellow = new System.Windows.Forms.Button();
			this.BtnGreen = new System.Windows.Forms.Button();
			this.BtnBlack = new System.Windows.Forms.Button();
			this.BtnWhite = new System.Windows.Forms.Button();
			this.BtnBlue = new System.Windows.Forms.Button();
			this.btnEllipse = new System.Windows.Forms.Button();
			this.btnCircle = new System.Windows.Forms.Button();
			this.btnNone = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "None";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(713, 27);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// BtnRed
			// 
			this.BtnRed.BackColor = System.Drawing.Color.Red;
			this.BtnRed.Location = new System.Drawing.Point(459, 8);
			this.BtnRed.Name = "BtnRed";
			this.BtnRed.Size = new System.Drawing.Size(75, 23);
			this.BtnRed.TabIndex = 6;
			this.BtnRed.UseVisualStyleBackColor = false;
			this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
			// 
			// BtnYellow
			// 
			this.BtnYellow.BackColor = System.Drawing.Color.Yellow;
			this.BtnYellow.Location = new System.Drawing.Point(459, 37);
			this.BtnYellow.Name = "BtnYellow";
			this.BtnYellow.Size = new System.Drawing.Size(75, 23);
			this.BtnYellow.TabIndex = 7;
			this.BtnYellow.UseVisualStyleBackColor = false;
			this.BtnYellow.Click += new System.EventHandler(this.BtnYellow_Click);
			// 
			// BtnGreen
			// 
			this.BtnGreen.BackColor = System.Drawing.Color.Lime;
			this.BtnGreen.Location = new System.Drawing.Point(540, 8);
			this.BtnGreen.Name = "BtnGreen";
			this.BtnGreen.Size = new System.Drawing.Size(75, 23);
			this.BtnGreen.TabIndex = 8;
			this.BtnGreen.UseVisualStyleBackColor = false;
			this.BtnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
			// 
			// BtnBlack
			// 
			this.BtnBlack.BackColor = System.Drawing.Color.Black;
			this.BtnBlack.Location = new System.Drawing.Point(540, 37);
			this.BtnBlack.Name = "BtnBlack";
			this.BtnBlack.Size = new System.Drawing.Size(75, 23);
			this.BtnBlack.TabIndex = 9;
			this.BtnBlack.UseVisualStyleBackColor = false;
			this.BtnBlack.Click += new System.EventHandler(this.BtnBlack_Click);
			// 
			// BtnWhite
			// 
			this.BtnWhite.Location = new System.Drawing.Point(621, 37);
			this.BtnWhite.Name = "BtnWhite";
			this.BtnWhite.Size = new System.Drawing.Size(75, 23);
			this.BtnWhite.TabIndex = 10;
			this.BtnWhite.UseVisualStyleBackColor = true;
			this.BtnWhite.Click += new System.EventHandler(this.BtnWhite_Click);
			// 
			// BtnBlue
			// 
			this.BtnBlue.BackColor = System.Drawing.Color.Blue;
			this.BtnBlue.Location = new System.Drawing.Point(621, 8);
			this.BtnBlue.Name = "BtnBlue";
			this.BtnBlue.Size = new System.Drawing.Size(75, 23);
			this.BtnBlue.TabIndex = 11;
			this.BtnBlue.UseVisualStyleBackColor = false;
			this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
			// 
			// btnEllipse
			// 
			this.btnEllipse.BackgroundImage = global::ProfZawadzki.Properties.Resources.ellipse;
			this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEllipse.Location = new System.Drawing.Point(93, 37);
			this.btnEllipse.Name = "btnEllipse";
			this.btnEllipse.Size = new System.Drawing.Size(75, 23);
			this.btnEllipse.TabIndex = 5;
			this.btnEllipse.UseVisualStyleBackColor = true;
			this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
			// 
			// btnCircle
			// 
			this.btnCircle.BackgroundImage = global::ProfZawadzki.Properties.Resources.circle_FILL0_wght400_GRAD0_opsz24;
			this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCircle.Location = new System.Drawing.Point(93, 12);
			this.btnCircle.Name = "btnCircle";
			this.btnCircle.Size = new System.Drawing.Size(75, 23);
			this.btnCircle.TabIndex = 3;
			this.btnCircle.UseVisualStyleBackColor = true;
			this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
			// 
			// btnNone
			// 
			this.btnNone.BackgroundImage = global::ProfZawadzki.Properties.Resources.remove_FILL0_wght400_GRAD0_opsz24;
			this.btnNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnNone.Location = new System.Drawing.Point(12, 37);
			this.btnNone.Name = "btnNone";
			this.btnNone.Size = new System.Drawing.Size(75, 23);
			this.btnNone.TabIndex = 2;
			this.btnNone.UseVisualStyleBackColor = true;
			this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(12, 66);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(776, 372);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(226, 27);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Animacja";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.BtnBlue);
			this.Controls.Add(this.BtnWhite);
			this.Controls.Add(this.BtnBlack);
			this.Controls.Add(this.BtnGreen);
			this.Controls.Add(this.BtnYellow);
			this.Controls.Add(this.BtnRed);
			this.Controls.Add(this.btnEllipse);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCircle);
			this.Controls.Add(this.btnNone);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnNone;
		private System.Windows.Forms.Button btnCircle;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnEllipse;
		private System.Windows.Forms.Button BtnRed;
		private System.Windows.Forms.Button BtnYellow;
		private System.Windows.Forms.Button BtnGreen;
		private System.Windows.Forms.Button BtnBlack;
		private System.Windows.Forms.Button BtnWhite;
		private System.Windows.Forms.Button BtnBlue;
		private System.Windows.Forms.Button button3;
	}
}


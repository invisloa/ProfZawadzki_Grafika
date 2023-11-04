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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnNone = new System.Windows.Forms.Button();
			this.btnCircle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 66);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(776, 372);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(93, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Line";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnNone
			// 
			this.btnNone.Location = new System.Drawing.Point(12, 27);
			this.btnNone.Name = "btnNone";
			this.btnNone.Size = new System.Drawing.Size(75, 23);
			this.btnNone.TabIndex = 2;
			this.btnNone.Text = "None";
			this.btnNone.UseVisualStyleBackColor = true;
			this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
			// 
			// btnCircle
			// 
			this.btnCircle.Location = new System.Drawing.Point(175, 27);
			this.btnCircle.Name = "btnCircle";
			this.btnCircle.Size = new System.Drawing.Size(75, 23);
			this.btnCircle.TabIndex = 3;
			this.btnCircle.Text = "Circle";
			this.btnCircle.UseVisualStyleBackColor = true;
			this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}


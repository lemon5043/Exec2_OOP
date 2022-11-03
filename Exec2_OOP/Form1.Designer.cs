namespace Exec2_OOP
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
			this.btnGo = new System.Windows.Forms.Button();
			this.lblIntro = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.txtHint = new System.Windows.Forms.TextBox();
			this.lblanswer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(282, 71);
			this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(96, 29);
			this.btnGo.TabIndex = 0;
			this.btnGo.Text = "Go!";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// lblIntro
			// 
			this.lblIntro.AutoSize = true;
			this.lblIntro.Location = new System.Drawing.Point(15, 23);
			this.lblIntro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new System.Drawing.Size(247, 19);
			this.lblIntro.TabIndex = 1;
			this.lblIntro.Text = "請猜一個4 位數字，每個數字不重複\r\n";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(15, 73);
			this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(230, 27);
			this.txtAnswer.TabIndex = 2;
			// 
			// btnNewGame
			// 
			this.btnNewGame.Location = new System.Drawing.Point(273, 358);
			this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(113, 29);
			this.btnNewGame.TabIndex = 4;
			this.btnNewGame.Text = "New game";
			this.btnNewGame.UseVisualStyleBackColor = true;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// txtHint
			// 
			this.txtHint.Location = new System.Drawing.Point(15, 166);
			this.txtHint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtHint.Multiline = true;
			this.txtHint.Name = "txtHint";
			this.txtHint.Size = new System.Drawing.Size(230, 222);
			this.txtHint.TabIndex = 5;
			// 
			// lblanswer
			// 
			this.lblanswer.AutoSize = true;
			this.lblanswer.Location = new System.Drawing.Point(300, 220);
			this.lblanswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblanswer.Name = "lblanswer";
			this.lblanswer.Size = new System.Drawing.Size(51, 19);
			this.lblanswer.TabIndex = 6;
			this.lblanswer.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 436);
			this.Controls.Add(this.lblanswer);
			this.Controls.Add(this.txtHint);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.lblIntro);
			this.Controls.Add(this.btnGo);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnGo;
		private Label lblIntro;
		private TextBox txtAnswer;
		private Button btnNewGame;
		private TextBox txtHint;
		private Label lblanswer;
	}
}
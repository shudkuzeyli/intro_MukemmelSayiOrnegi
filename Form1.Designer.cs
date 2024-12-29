namespace intro_MukemmelSayiOrnegi
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
			this.lblMukemmelSayilar = new System.Windows.Forms.Label();
			this.btnMukemmelSayiListele = new System.Windows.Forms.Button();
			this.txtSayi = new System.Windows.Forms.TextBox();
			this.btnMukemmelSayi = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblMukemmelSayilar
			// 
			this.lblMukemmelSayilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblMukemmelSayilar.Location = new System.Drawing.Point(17, 217);
			this.lblMukemmelSayilar.Name = "lblMukemmelSayilar";
			this.lblMukemmelSayilar.Size = new System.Drawing.Size(171, 146);
			this.lblMukemmelSayilar.TabIndex = 8;
			// 
			// btnMukemmelSayiListele
			// 
			this.btnMukemmelSayiListele.Location = new System.Drawing.Point(20, 173);
			this.btnMukemmelSayiListele.Name = "btnMukemmelSayiListele";
			this.btnMukemmelSayiListele.Size = new System.Drawing.Size(168, 41);
			this.btnMukemmelSayiListele.TabIndex = 7;
			this.btnMukemmelSayiListele.Text = "Mükemmel Sayıları Listele";
			this.btnMukemmelSayiListele.UseVisualStyleBackColor = true;
			this.btnMukemmelSayiListele.Click += new System.EventHandler(this.btnMukemmelSayiListele_Click);
			// 
			// txtSayi
			// 
			this.txtSayi.Location = new System.Drawing.Point(56, 100);
			this.txtSayi.Name = "txtSayi";
			this.txtSayi.Size = new System.Drawing.Size(131, 20);
			this.txtSayi.TabIndex = 6;
			this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
			// 
			// btnMukemmelSayi
			// 
			this.btnMukemmelSayi.Location = new System.Drawing.Point(19, 126);
			this.btnMukemmelSayi.Name = "btnMukemmelSayi";
			this.btnMukemmelSayi.Size = new System.Drawing.Size(168, 41);
			this.btnMukemmelSayi.TabIndex = 5;
			this.btnMukemmelSayi.Text = "Mükemmel Sayı Kontrolü";
			this.btnMukemmelSayi.UseVisualStyleBackColor = true;
			this.btnMukemmelSayi.Click += new System.EventHandler(this.btnMukemmelSayi_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Mükemmel Sayı: tam bölenlerinin toplamı kendisine eşit olan sayı";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblMukemmelSayilar);
			this.Controls.Add(this.btnMukemmelSayiListele);
			this.Controls.Add(this.txtSayi);
			this.Controls.Add(this.btnMukemmelSayi);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMukemmelSayilar;
		private System.Windows.Forms.Button btnMukemmelSayiListele;
		private System.Windows.Forms.TextBox txtSayi;
		private System.Windows.Forms.Button btnMukemmelSayi;
		private System.Windows.Forms.Label label1;
	}
}


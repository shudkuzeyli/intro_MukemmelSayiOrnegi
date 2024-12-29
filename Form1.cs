using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intro_MukemmelSayiOrnegi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnMukemmelSayi_Click(object sender, EventArgs e)
		{
			try
			{
				int sayi = 0, toplam = 0;
				if (int.TryParse(txtSayi.Text, out sayi) == false)
				{
					MessageBox.Show("Lütfen Sayılsal Değer Giriniz.");
					return;
				}

				for (int i = 1; i < sayi; i++)
				{
					if (sayi % i == 0)
					{
						toplam += i;
					}
				}
				if (toplam == sayi)
				{
					MessageBox.Show("Sayı Mükemmel");
				}
				else
				{
					MessageBox.Show("Sayı Mükemmel Değil");
				}
			}
			catch (Exception hata)
			{
			}
		}

		private void btnMukemmelSayiListele_Click(object sender, EventArgs e)
		{
			try
			{
				lblMukemmelSayilar.Text = "";
				int sayi = 0, toplam = 0;
				if (int.TryParse(txtSayi.Text, out sayi) == false)
				{
					MessageBox.Show("Lütfen Sayılsal Değer Giriniz.");
					return;
				}

				for (int j = 1; j <= sayi; j++)
				{
					toplam = 0;
					for (int i = 1; i < j; i++)
					{
						if (j % i == 0)
						{
							toplam += i;
						}
					}

					if (toplam == j)
					{
						lblMukemmelSayilar.Text += j.ToString() + ", ";
					}
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show(hata.Message);
			}
		}

		private void txtSayi_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

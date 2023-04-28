using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button_sum_Click(object sender, EventArgs e)
		{
			string productName = textBox_productName.Text;
			int quantity = (int)numericUpDown_quantity.Value;

			string[] product = { productName, quantity.ToString() };


			int index = GetIndex(productName);

			if (index!=-1)
			{
				int initialQuantity = int.Parse(listView1.Items[index].SubItems[1].Text);
				int sumQuantity= initialQuantity+quantity;
				listView1.Items[index].SubItems[1].Text= sumQuantity.ToString();
			}
			else
			{
				listView1.Items.Add(new ListViewItem(product));
			}

		}

		private int GetIndex(string productName)
		{
			foreach(ListViewItem item in listView1.Items)
			{
				if (item.SubItems[0].Text == productName)
				{
					return item.Index;
				}
			}
			return -1;
		}

		private void button_delete_Click(object sender, EventArgs e)
		{
			listView1.SelectedItems[0].Remove();
		}
	}
}

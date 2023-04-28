using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Load_Listview();
			comboBox1.Items.Add("蘋果");
			comboBox1.Items.Add("奇異果");
			comboBox1.Items.Add("香蕉");
			comboBox1.Items.Add("芒果");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// 從combox抓取值
			var productName=comboBox1.SelectedItem.ToString();
			// 從numericUpDown1抓取值
			var quantity = numericUpDown1.Value;

			string[] rowA = { productName,  quantity.ToString()};
			listView1.Items.Add(new ListViewItem(rowA));			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listView3.Items.Clear();

			// Items: rows, subItems: cells
			string product = "";
			int quantity = 0;
			var totalProduct = new Dictionary<string, int>();

			for (int index=0 ; index< listView1.Items.Count; index++)
            {
				product = listView1.Items[index].SubItems[0].Text;
				quantity = int.Parse(listView1.Items[index].SubItems[1].Text);
				
				if (totalProduct.ContainsKey(product))
                {
					totalProduct[product] += quantity;
                }
                else
                {
					totalProduct.Add(product, quantity);
				}
			}

			foreach (var item in totalProduct)
            {				
				string[] rowB = { item.Key, item.Value.ToString() };
				listView3.Items.Add(new ListViewItem(rowB));
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
			listView1.SelectedItems[0].Remove();
		}
    }


}

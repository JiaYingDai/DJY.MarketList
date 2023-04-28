namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.button_sum = new System.Windows.Forms.Button();
			this.label_productName = new System.Windows.Forms.Label();
			this.textBox_productName = new System.Windows.Forms.TextBox();
			this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
			this.label_quantity = new System.Windows.Forms.Label();
			this.button_delete = new System.Windows.Forms.Button();
			this.columnHeader_productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_productName,
            this.columnHeader_quantity});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(140, 124);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(481, 179);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// button_sum
			// 
			this.button_sum.Location = new System.Drawing.Point(249, 319);
			this.button_sum.Name = "button_sum";
			this.button_sum.Size = new System.Drawing.Size(75, 23);
			this.button_sum.TabIndex = 1;
			this.button_sum.Text = "Sum";
			this.button_sum.UseVisualStyleBackColor = true;
			this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
			// 
			// label_productName
			// 
			this.label_productName.AutoSize = true;
			this.label_productName.Location = new System.Drawing.Point(216, 58);
			this.label_productName.Name = "label_productName";
			this.label_productName.Size = new System.Drawing.Size(71, 12);
			this.label_productName.TabIndex = 2;
			this.label_productName.Text = "Product Name";
			// 
			// textBox_productName
			// 
			this.textBox_productName.Location = new System.Drawing.Point(218, 73);
			this.textBox_productName.Name = "textBox_productName";
			this.textBox_productName.Size = new System.Drawing.Size(100, 22);
			this.textBox_productName.TabIndex = 3;
			// 
			// numericUpDown_quantity
			// 
			this.numericUpDown_quantity.Location = new System.Drawing.Point(395, 73);
			this.numericUpDown_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_quantity.Name = "numericUpDown_quantity";
			this.numericUpDown_quantity.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown_quantity.TabIndex = 4;
			this.numericUpDown_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label_quantity
			// 
			this.label_quantity.AutoSize = true;
			this.label_quantity.Location = new System.Drawing.Point(395, 55);
			this.label_quantity.Name = "label_quantity";
			this.label_quantity.Size = new System.Drawing.Size(45, 12);
			this.label_quantity.TabIndex = 5;
			this.label_quantity.Text = "Quantity";
			// 
			// button_delete
			// 
			this.button_delete.Location = new System.Drawing.Point(395, 319);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(75, 23);
			this.button_delete.TabIndex = 6;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = true;
			this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
			// 
			// columnHeader_productName
			// 
			this.columnHeader_productName.Text = "Product Name";
			this.columnHeader_productName.Width = 200;
			// 
			// columnHeader_quantity
			// 
			this.columnHeader_quantity.Text = "Quantity";
			this.columnHeader_quantity.Width = 200;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_delete);
			this.Controls.Add(this.label_quantity);
			this.Controls.Add(this.numericUpDown_quantity);
			this.Controls.Add(this.textBox_productName);
			this.Controls.Add(this.label_productName);
			this.Controls.Add(this.button_sum);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button_sum;
		private System.Windows.Forms.Label label_productName;
		private System.Windows.Forms.TextBox textBox_productName;
		private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
		private System.Windows.Forms.Label label_quantity;
		private System.Windows.Forms.Button button_delete;
		private System.Windows.Forms.ColumnHeader columnHeader_productName;
		private System.Windows.Forms.ColumnHeader columnHeader_quantity;
	}
}


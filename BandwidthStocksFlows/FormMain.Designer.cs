namespace BandwidthStocksFlows
{
	partial class FormMain
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
			gbFlow = new GroupBox();
			btnUpdateFlow = new Button();
			label2 = new Label();
			label1 = new Label();
			nudFlowPx = new NumericUpDown();
			cbFlowUnit = new ComboBox();
			nudFlow = new NumericUpDown();
			gbStocks = new GroupBox();
			cbStocksType = new ComboBox();
			btnUpdateStocks = new Button();
			label3 = new Label();
			cbStockUnit = new ComboBox();
			nudStockPx = new NumericUpDown();
			lblStock = new Label();
			nudStock = new NumericUpDown();
			lblNote = new Label();
			gbFlow.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudFlowPx).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudFlow).BeginInit();
			gbStocks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudStockPx).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
			SuspendLayout();
			// 
			// gbFlow
			// 
			gbFlow.Controls.Add(btnUpdateFlow);
			gbFlow.Controls.Add(label2);
			gbFlow.Controls.Add(label1);
			gbFlow.Controls.Add(nudFlowPx);
			gbFlow.Controls.Add(cbFlowUnit);
			gbFlow.Controls.Add(nudFlow);
			gbFlow.Location = new Point(10, 12);
			gbFlow.Name = "gbFlow";
			gbFlow.Size = new Size(271, 150);
			gbFlow.TabIndex = 0;
			gbFlow.TabStop = false;
			gbFlow.Text = "Flow";
			// 
			// btnUpdateFlow
			// 
			btnUpdateFlow.Location = new Point(90, 106);
			btnUpdateFlow.Name = "btnUpdateFlow";
			btnUpdateFlow.Size = new Size(87, 27);
			btnUpdateFlow.TabIndex = 3;
			btnUpdateFlow.Tag = "Flow";
			btnUpdateFlow.Text = "Update";
			btnUpdateFlow.UseVisualStyleBackColor = true;
			btnUpdateFlow.Click += btnUpdate;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 42);
			label2.Name = "label2";
			label2.Size = new Size(40, 20);
			label2.TabIndex = 4;
			label2.Text = "Flow";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 75);
			label1.Name = "label1";
			label1.Size = new Size(41, 20);
			label1.TabIndex = 3;
			label1.Text = "Price";
			// 
			// nudFlowPx
			// 
			nudFlowPx.DecimalPlaces = 5;
			nudFlowPx.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			nudFlowPx.Location = new Point(65, 73);
			nudFlowPx.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
			nudFlowPx.Name = "nudFlowPx";
			nudFlowPx.Size = new Size(196, 27);
			nudFlowPx.TabIndex = 2;
			// 
			// cbFlowUnit
			// 
			cbFlowUnit.DropDownStyle = ComboBoxStyle.DropDownList;
			cbFlowUnit.FormattingEnabled = true;
			cbFlowUnit.Items.AddRange(new object[] { "Bps", "Kbps", "Mbps", "Gbps", "Tbps" });
			cbFlowUnit.Location = new Point(200, 39);
			cbFlowUnit.Name = "cbFlowUnit";
			cbFlowUnit.Size = new Size(61, 28);
			cbFlowUnit.TabIndex = 1;
			// 
			// nudFlow
			// 
			nudFlow.DecimalPlaces = 5;
			nudFlow.Location = new Point(65, 40);
			nudFlow.Maximum = new decimal(new int[] { 0, 268435456, 0, 0 });
			nudFlow.Name = "nudFlow";
			nudFlow.Size = new Size(128, 27);
			nudFlow.TabIndex = 0;
			// 
			// gbStocks
			// 
			gbStocks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			gbStocks.Controls.Add(cbStocksType);
			gbStocks.Controls.Add(btnUpdateStocks);
			gbStocks.Controls.Add(label3);
			gbStocks.Controls.Add(cbStockUnit);
			gbStocks.Controls.Add(nudStockPx);
			gbStocks.Controls.Add(lblStock);
			gbStocks.Controls.Add(nudStock);
			gbStocks.Location = new Point(287, 12);
			gbStocks.Name = "gbStocks";
			gbStocks.Size = new Size(267, 150);
			gbStocks.TabIndex = 1;
			gbStocks.TabStop = false;
			gbStocks.Text = "Stocks";
			// 
			// cbStocksType
			// 
			cbStocksType.DropDownStyle = ComboBoxStyle.DropDownList;
			cbStocksType.FormattingEnabled = true;
			cbStocksType.Items.AddRange(new object[] { "Monthly", "Daily", "Hourly", "Minutes" });
			cbStocksType.Location = new Point(16, 109);
			cbStocksType.Name = "cbStocksType";
			cbStocksType.Size = new Size(152, 28);
			cbStocksType.TabIndex = 8;
			// 
			// btnUpdateStocks
			// 
			btnUpdateStocks.Location = new Point(174, 109);
			btnUpdateStocks.Name = "btnUpdateStocks";
			btnUpdateStocks.Size = new Size(87, 27);
			btnUpdateStocks.TabIndex = 7;
			btnUpdateStocks.Tag = "Stock";
			btnUpdateStocks.Text = "Update";
			btnUpdateStocks.UseVisualStyleBackColor = true;
			btnUpdateStocks.Click += btnUpdate;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(4, 80);
			label3.Name = "label3";
			label3.Size = new Size(41, 20);
			label3.TabIndex = 6;
			label3.Text = "Price";
			// 
			// cbStockUnit
			// 
			cbStockUnit.DropDownStyle = ComboBoxStyle.DropDownList;
			cbStockUnit.FormattingEnabled = true;
			cbStockUnit.Items.AddRange(new object[] { "B", "KB", "MB", "GB", "TB", "PB", "EB" });
			cbStockUnit.Location = new Point(198, 40);
			cbStockUnit.Name = "cbStockUnit";
			cbStockUnit.Size = new Size(63, 28);
			cbStockUnit.TabIndex = 5;
			// 
			// nudStockPx
			// 
			nudStockPx.DecimalPlaces = 5;
			nudStockPx.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			nudStockPx.Location = new Point(50, 75);
			nudStockPx.Margin = new Padding(3, 4, 3, 4);
			nudStockPx.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
			nudStockPx.Name = "nudStockPx";
			nudStockPx.Size = new Size(211, 27);
			nudStockPx.TabIndex = 6;
			// 
			// lblStock
			// 
			lblStock.AutoSize = true;
			lblStock.Location = new Point(4, 42);
			lblStock.Name = "lblStock";
			lblStock.Size = new Size(45, 20);
			lblStock.TabIndex = 5;
			lblStock.Text = "Stock";
			// 
			// nudStock
			// 
			nudStock.DecimalPlaces = 5;
			nudStock.Location = new Point(50, 40);
			nudStock.Margin = new Padding(3, 4, 3, 4);
			nudStock.Maximum = new decimal(new int[] { 0, 268435456, 0, 0 });
			nudStock.Name = "nudStock";
			nudStock.Size = new Size(142, 27);
			nudStock.TabIndex = 4;
			// 
			// lblNote
			// 
			lblNote.AutoSize = true;
			lblNote.Location = new Point(16, 166);
			lblNote.Name = "lblNote";
			lblNote.Size = new Size(257, 20);
			lblNote.TabIndex = 7;
			lblNote.Text = "Displayed prices are per unit selected";
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(566, 195);
			Controls.Add(lblNote);
			Controls.Add(gbStocks);
			Controls.Add(gbFlow);
			Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			Name = "FormMain";
			Text = "Bandwidth Stocks and Flows Converter";
			gbFlow.ResumeLayout(false);
			gbFlow.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudFlowPx).EndInit();
			((System.ComponentModel.ISupportInitialize)nudFlow).EndInit();
			gbStocks.ResumeLayout(false);
			gbStocks.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudStockPx).EndInit();
			((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox gbFlow;
		private GroupBox gbStocks;
		private Label label1;
		private NumericUpDown nudFlowPx;
		private ComboBox cbFlowUnit;
		private NumericUpDown nudFlow;
		private NumericUpDown nudStock;
		private Label label2;
		private Label label3;
		private ComboBox cbStockUnit;
		private NumericUpDown nudStockPx;
		private Label lblStock;
		private Button btnUpdateFlow;
		private Button btnUpdateStocks;
		private Label lblNote;
		private ComboBox cbStocksType;
	}
}
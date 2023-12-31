namespace BandwidthStocksFlows
{
	public partial class FormMain : Form
	{
		private static readonly Dictionary<String, Int64> flowToBps = new Dictionary<String, Int64>()
		{
			{ "Bps", 1L },
			{ "Kbps", 1000L },
			{ "Mbps", 1000L * 1000 },
			{ "Gbps", 1000L * 1000 * 1000 },
			{ "Tbps", 1000L * 1000 * 1000 * 1000 },
		};

		private static readonly Dictionary<String, Int64> stockToB = new Dictionary<String, Int64>()
		{
			{ "B", 1L },
			{ "KB", 1000L },
			{ "MB", 1000L * 1000 },
			{ "GB", 1000L * 1000 * 1000 },
			{ "TB", 1000L * 1000 * 1000 * 1000 },
			{ "PB", 1000L * 1000 * 1000 * 1000 * 1000 },
			{ "EB", 1000L * 1000 * 1000 * 1000 * 1000 * 1000 },
		};

		private const Int64 minuteSeconds = 60;
		private const Int64 hourSeconds = 60 * minuteSeconds;
		private const Int64 daySeconds = hourSeconds * 24;
		private const Int64 monthSeconds = daySeconds * 30;
		private const Int32 bitsToByte = 8;

		public FormMain()
		{
			InitializeComponent();
			this.MinimumSize = this.Size;
			this.MaximumSize = this.Size;
			cbFlowUnit.SelectedIndex = 0;
			cbStockUnit.SelectedIndex = 0;
			cbStocksType.SelectedIndex = 0;
		}

		public void UpdateUi(Boolean flows)
		{
			this.SuspendLayout();
			Int64 divider = cbStocksType.SelectedIndex switch
			{
				0 => monthSeconds,
				1 => daySeconds,
				2 => hourSeconds,
				3 => minuteSeconds,
				_ => monthSeconds,
			};
			if (flows)
			{
				Decimal flowsBps = nudFlow.Value * flowToBps[(String)cbFlowUnit.SelectedItem];
				Decimal stockB = flowsBps * divider / bitsToByte;
				Int64 unit = stockToB[(String)cbStockUnit.SelectedItem];
				nudStock.Value = stockB / unit;
				nudStockPx.Value = nudFlowPx.Value / nudStock.Value;
			}
			else
			{
				Decimal stockB = nudStock.Value * stockToB[(String)cbStockUnit.SelectedItem];
				Decimal flowBps = stockB / divider * bitsToByte;
				Int64 unit = flowToBps[(String)cbFlowUnit.SelectedItem];
				nudFlow.Value = flowBps / unit;
				nudFlowPx.Value = nudStockPx.Value / nudFlow.Value;
			}
			this.ResumeLayout(true);
		}

		private void btnUpdate(Object sender, EventArgs e)
		{
			UpdateUi(sender is Control control && control.Tag != null && control.Tag.Equals("Flow"));
		}
	}
}
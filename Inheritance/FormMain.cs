namespace Vsite.Oom.ObjectModel
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to exit?", "Customer Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Close();
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{

		}
	}
}

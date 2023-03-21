using CreateZIPFile.Entities;

namespace CreateZIPFile.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string sourceDirectory = textBoxFullPath.Text;
            string zipFilePath = textBoxZipPath.Text;
            
            if (!Directory.Exists(sourceDirectory))
            {
                MessageBox.Show("Invalid directory path.","Error");
                return;
            }
            else
            {
                MainManager.Instance.items.CreateAZipFile(sourceDirectory, zipFilePath);
                textBoxFullPath.Text = "";
                textBoxZipPath.Text = "";
            }         
        }
    }
}
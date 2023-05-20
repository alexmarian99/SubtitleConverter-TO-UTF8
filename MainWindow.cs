using System.Text;

namespace SubtitleFixer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectPath(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = folderPathTextBox.Text;
            DialogResult userResponse = folderBrowserDialog.ShowDialog();
            if (userResponse is DialogResult.OK)
            {
                folderPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void TransformSubtitles(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(folderPathTextBox.Text))
            {
                int filesChanged = 0;
                CheckSubtitles(folderPathTextBox.Text, ref filesChanged);
                MessageBox.Show($"Changed {filesChanged} files to UTF-8. Happy watching :)");
            }
            else
            {
                MessageBox.Show("Please select a folder first!", "INFO");
            }
        }

        private void CheckSubtitles(string path, ref int filesChanged)
        {
            foreach (var directory in Directory.EnumerateDirectories(path))
            {
                CheckSubtitles(directory, ref filesChanged);
            }
            foreach (var file in Directory.EnumerateFiles(path, "*.srt"))
            {
                if (MustBeChanged(file))
                {
                    filesChanged++;
                    File.WriteAllText(file, File.ReadAllText(file, Encoding.GetEncoding(0)), Encoding.UTF8);
                }
            }
        }

        private bool MustBeChanged(string path)
        {
            byte[] buffer = new byte[5];
            FileStream file = new FileStream(path, FileMode.Open);
            file.Read(buffer, 0, 5);
            file.Close();
            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
            {
                return false;
            }
            return true;
        }
    }
}
namespace dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //we created the object 
            ofd.Title = "Open a File";
            ofd.Filter = "Text File| *.txt| RTF file| *.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("OK!");
                //MessageBox.Show(ofd.FileName);
                // show file name 
                //MessageBox.Show(ofd.SafeFileName);
                string filePath = ofd.FileName;
                //read from txt file
                // string fileContent = File.ReadAllText(filePath);
                //MessageBox.Show(fileContent);
                //txtFileContent.Text = fileContent;
                //Read from txt file
                rtxFileContent.LoadFile(filePath);

            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //sfd.ShowDialog();
            sfd.Title = "Save a file";
            sfd.Filter = "Text File| *.txt| RTF file| *.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                // File.WriteAllText(filePath, txtFileContent.Text);

                rtxFileContent.SaveFile(filePath);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            //fd.ShowDialog();
            // set the text font
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtxFileContent.Font = fd.Font;
                rtxFileContent.ForeColor = fd.Color;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.ShowDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Color.BackColor = cd.Color;
            }
        }
    }
}

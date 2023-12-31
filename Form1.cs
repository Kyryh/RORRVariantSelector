#pragma warning disable CS8622
namespace RORRVariantSelector
{
    public partial class Form1 : Form {

        private string? stagesFolder;

        private string? stagesBackup;

        private Size oldSize;
        public Form1() {
            InitializeComponent();
            button4.Click += button1_Click;
            checkedListBox1.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox2.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox3.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox4.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox5.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox6.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox7.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox8.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox9.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
            checkedListBox10.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e) {
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath)! + Path.DirectorySeparatorChar;

            if (Path.Exists(currentPath + "stages")) {
                stagesBackup = currentPath + "stages" + Path.DirectorySeparatorChar;
            }
            oldSize = Size;
            Size = new Size(300, 300);
            CenterToScreen();

        }

        private void checkedListBoxGeneral_SelectedIndexChanged(object sender, EventArgs e) {
            ((CheckedListBox)sender).ClearSelected();
        }

        // Load game files button
        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                //Console.WriteLine(openFileDialog1.FileName);
                string stages = Path.GetDirectoryName(openFileDialog1.FileName) +
                    Path.DirectorySeparatorChar + "data" +
                    Path.DirectorySeparatorChar + "stages" +
                    Path.DirectorySeparatorChar;
                //MessageBox.Show(
                //    stages
                //);

                if (Path.Exists(stages)) {
                    stagesFolder = stages;
                    Size = oldSize;
                    panel1.Hide();
                    panel2.Show();
                    CenterToScreen();
                }
                else {
                    MessageBox.Show("Wrong executable selected");
                }

                //openFileDialog1.FileName
            }
        }

        // Save variants selection button
        private void button2_Click(object sender, EventArgs e) {

        }

        // Restore variants button
        private void button3_Click(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {

        }
    }
}

#pragma warning disable CS8622
using System.Collections;
using System.Windows.Forms;

namespace RORRVariantSelector
{
    public partial class Form1 : Form {

        private string? stagesFolder;

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
            button5_Click(null!, null!);
        }

        private void Form1_Load(object sender, EventArgs e) {
            Directory.CreateDirectory("stages");
            
            oldSize = Size;
            Size = new Size(300, 300);
            CenterToScreen();

        }

        // to remove the annoying blue rectangle when checking a box
        private void checkedListBoxGeneral_SelectedIndexChanged(object sender, EventArgs e) {
            ((CheckedListBox)sender).ClearSelected(); 
        }

        // Load game files button
        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string stages = Path.GetDirectoryName(openFileDialog1.FileName) +
                    Path.DirectorySeparatorChar + "data" +
                    Path.DirectorySeparatorChar + "stages" +
                    Path.DirectorySeparatorChar;

                if (Path.Exists(stages)) {
                    stagesFolder = stages;
                    foreach (string stage in GetAllStageVariantsNames()) {
                        try {
                            File.Copy(stagesFolder + stage, "stages" + Path.DirectorySeparatorChar + stage);
                        } catch (IOException) { }
                        // raises an exception when the files have already
                        // been stored, so we don't need to copy them again
                    }

                    Size = oldSize;
                    panel1.Hide();
                    panel2.Show();
                    CenterToScreen();
                } else {
                    MessageBox.Show("Wrong executable selected");
                }
            }
        }

        // Save variants selection button
        private void button2_Click(object sender, EventArgs e) {
            //checkedListBox1.CheckedIndices
            string[] stageNames = [
                "desolateForest",
                "driedLake",
                "dampCaverns",
                "skyMeadow",
                "ancientValley",
                "sunkenTombs",
                "magmaBarracks",
                "hiveCluster",
                "templeOfTheElders",
                "riskOfRain"
            ];
            for (int i = 0; i < 10; i++) {
                CheckedListBox currentListBox = (CheckedListBox)panel2.Controls.Find($"checkedListBox{i + 1}", false)[0];
                int j = 0;
                for (int k = 0; k < currentListBox.Items.Count; k++) {
                    string localStage = $"stages{Path.DirectorySeparatorChar}{stageNames[i]}_{currentListBox.CheckedIndices[j] + 1}.rorlvl";
                    string gameFilesStage = $"{stagesFolder}{stageNames[i]}_{k + 1}.rorlvl";
                    File.Copy(
                        localStage,
                        gameFilesStage,
                        true
                    );
                    //MessageBox.Show("COPY " + localStage + " TO " + gameFilesStage);
                    j++;
                    if (j >= currentListBox.CheckedIndices.Count)
                        j = 0; // loop back when you reach the last variant
                }
            }
        }

        // Restore variants button
        private void button3_Click(object sender, EventArgs e) {
            foreach (string stage in GetAllStageVariantsNames()) {
                File.Copy("stages" + Path.DirectorySeparatorChar + stage, stagesFolder + stage, true);
            }
            MessageBox.Show("Stage variants restored to default");
        }

        // Select all botton
        private void button5_Click(object sender, EventArgs e) {
            foreach (CheckedListBox checkedListBox in panel2.Controls.OfType<CheckedListBox>()) {
                for (int i = 0; i < checkedListBox.Items.Count; i++) {
                    checkedListBox.SetItemChecked(i, true);
                }
            }
        }

        // Deselect all button
        private void button6_Click(object sender, EventArgs e) {
            foreach (CheckedListBox checkedListBox in panel2.Controls.OfType<CheckedListBox>()) {
                for (int i = 0; i < checkedListBox.Items.Count; i++) {
                    checkedListBox.SetItemChecked(i, false);
                }
            }
        }

        private string[] GetAllStageVariantsNames() {
            List<string> stageVariantsNames = new List<string>();
            for (int i = 1; i <= 6; i++) {
                stageVariantsNames.Add($"desolateForest_{i}.rorlvl");
                stageVariantsNames.Add($"driedLake_{i}.rorlvl");
                stageVariantsNames.Add($"dampCaverns_{i}.rorlvl");
                stageVariantsNames.Add($"skyMeadow_{i}.rorlvl");
                stageVariantsNames.Add($"ancientValley_{i}.rorlvl");
                stageVariantsNames.Add($"sunkenTombs_{i}.rorlvl");
                stageVariantsNames.Add($"magmaBarracks_{i}.rorlvl");
                stageVariantsNames.Add($"hiveCluster_{i}.rorlvl");
                stageVariantsNames.Add($"templeOfTheElders_{i}.rorlvl");
            }
            stageVariantsNames.Add($"riskOfRain_1.rorlvl");
            stageVariantsNames.Add($"riskOfRain_2.rorlvl");
            return stageVariantsNames.ToArray();
        }

    }
}

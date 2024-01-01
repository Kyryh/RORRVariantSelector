using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace RORRVariantSelector
{
    public partial class Form1 : Form {

        private string stagesFolder;

        private Size oldSize;

        private readonly string[] stageNames = new string[] {
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
        };

        private readonly string[][][] stageVariantsSecrets = new string[][][] {
            StageVariantsSecrets.desolateForest,
            StageVariantsSecrets.driedLake,
            StageVariantsSecrets.dampCaverns,
            StageVariantsSecrets.skyMeadow,
            StageVariantsSecrets.ancientValley,
            StageVariantsSecrets.sunkenTombs,
            StageVariantsSecrets.magmaBarracks,
            StageVariantsSecrets.hiveCluster,
            StageVariantsSecrets.templeOfTheElders,
            StageVariantsSecrets.riskOfRain
        };

        private CheckedListBox[] checkedListBoxes;
        public Form1() {
            InitializeComponent();
            checkedListBoxes = new CheckedListBox[] {
                checkedListBox1,
                checkedListBox2,
                checkedListBox3,
                checkedListBox4,
                checkedListBox5,
                checkedListBox6,
                checkedListBox7,
                checkedListBox8,
                checkedListBox9,
                checkedListBox10
            };
        }

        protected override void OnLoad(EventArgs e) {
            Directory.CreateDirectory("stages");
            
            button5_Click(null, null);
            for (int i = 0; i < checkedListBoxes.Length; i++) {
                CheckedListBox clb = checkedListBoxes[i];
                clb.SelectedIndexChanged += checkedListBoxGeneral_SelectedIndexChanged;
                for (int j = 0; j < clb.Items.Count; j++) {
                    if (stageVariantsSecrets[i][j].Length > 0)
                        clb.Items[j] = clb.Items[j] + " (" + string.Join(", ", stageVariantsSecrets[i][j]) + ")";
                }
            }

            button4.Click += button1_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;

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
                
                if (Directory.Exists(stages)) {
                    stagesFolder = stages;
                    try {
                        foreach (string stage in GetAllStageVariantsNames()) {
                            File.Copy(stagesFolder + stage, "stages" + Path.DirectorySeparatorChar + stage);
                        }
                    } catch (IOException) { }
                    // if it raises an exception then the files have
                    // already been copied, no need to copy them again

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
            if (panel2.Controls.OfType<CheckedListBox>().Any(clb => clb.CheckedIndices.Count == 0)) {
                MessageBox.Show("One of the stages has no variants selected, select all of them if you don't want to change that stage");
                return;
            }
            
            for (int i = 0; i < 10; i++) {
                CheckedListBox currentListBox = checkedListBoxes[i];
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
            MessageBox.Show("Variants selection saved!");
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
                foreach (string stageName in stageNames.Take(stageNames.Length-1)) {
                    stageVariantsNames.Add($"{stageName}_{i}.rorlvl");
                }
            }
            stageVariantsNames.Add($"riskOfRain_1.rorlvl");
            stageVariantsNames.Add($"riskOfRain_2.rorlvl");
            return stageVariantsNames.ToArray();
        }

    }
}

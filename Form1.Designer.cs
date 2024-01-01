using System.Drawing;
using System.Windows.Forms;

namespace RORRVariantSelector
{
    partial class Form1
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox6 = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkedListBox7 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox8 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox9 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox10 = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox1.Location = new System.Drawing.Point(9, 79);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(281, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4 ",
            "5",
            "6"});
            this.checkedListBox2.Location = new System.Drawing.Point(295, 79);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(338, 94);
            this.checkedListBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(296, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dried Lake";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desolate Forest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.Location = new System.Drawing.Point(10, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Damp Caverns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(296, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sky Meadow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label5.Location = new System.Drawing.Point(10, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ancient Valley";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label6.Location = new System.Drawing.Point(296, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunken Tombs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label7.Location = new System.Drawing.Point(10, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Magma Barracks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label8.Location = new System.Drawing.Point(293, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hive Cluster";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label9.Location = new System.Drawing.Point(10, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "Temple of the Elders";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.CheckOnClick = true;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox3.Location = new System.Drawing.Point(9, 207);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(284, 94);
            this.checkedListBox3.TabIndex = 11;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.CheckOnClick = true;
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox4.Location = new System.Drawing.Point(298, 207);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(335, 94);
            this.checkedListBox4.TabIndex = 12;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.CheckOnClick = true;
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox5.Location = new System.Drawing.Point(9, 335);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(284, 94);
            this.checkedListBox5.TabIndex = 13;
            // 
            // checkedListBox6
            // 
            this.checkedListBox6.CheckOnClick = true;
            this.checkedListBox6.FormattingEnabled = true;
            this.checkedListBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox6.Location = new System.Drawing.Point(298, 335);
            this.checkedListBox6.Name = "checkedListBox6";
            this.checkedListBox6.Size = new System.Drawing.Size(335, 94);
            this.checkedListBox6.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label10.Location = new System.Drawing.Point(296, 577);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 28);
            this.label10.TabIndex = 15;
            this.label10.Text = "Risk of Rain";
            // 
            // checkedListBox7
            // 
            this.checkedListBox7.CheckOnClick = true;
            this.checkedListBox7.FormattingEnabled = true;
            this.checkedListBox7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox7.Location = new System.Drawing.Point(9, 480);
            this.checkedListBox7.Name = "checkedListBox7";
            this.checkedListBox7.Size = new System.Drawing.Size(284, 94);
            this.checkedListBox7.TabIndex = 16;
            // 
            // checkedListBox8
            // 
            this.checkedListBox8.CheckOnClick = true;
            this.checkedListBox8.FormattingEnabled = true;
            this.checkedListBox8.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox8.Location = new System.Drawing.Point(298, 480);
            this.checkedListBox8.Name = "checkedListBox8";
            this.checkedListBox8.Size = new System.Drawing.Size(335, 94);
            this.checkedListBox8.TabIndex = 17;
            // 
            // checkedListBox9
            // 
            this.checkedListBox9.CheckOnClick = true;
            this.checkedListBox9.FormattingEnabled = true;
            this.checkedListBox9.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.checkedListBox9.Location = new System.Drawing.Point(9, 608);
            this.checkedListBox9.Name = "checkedListBox9";
            this.checkedListBox9.Size = new System.Drawing.Size(284, 94);
            this.checkedListBox9.TabIndex = 18;
            // 
            // checkedListBox10
            // 
            this.checkedListBox10.CheckOnClick = true;
            this.checkedListBox10.FormattingEnabled = true;
            this.checkedListBox10.Items.AddRange(new object[] {
            "1",
            "2"});
            this.checkedListBox10.Location = new System.Drawing.Point(298, 608);
            this.checkedListBox10.Name = "checkedListBox10";
            this.checkedListBox10.Size = new System.Drawing.Size(335, 94);
            this.checkedListBox10.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Risk of Rain Returns.exe";
            this.openFileDialog1.Filter = "RORR executable|*.exe|All files|*.*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Load game files";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Save variants selection";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "Restore variants";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.checkedListBox10);
            this.panel2.Controls.Add(this.checkedListBox9);
            this.panel2.Controls.Add(this.checkedListBox8);
            this.panel2.Controls.Add(this.checkedListBox7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.checkedListBox6);
            this.panel2.Controls.Add(this.checkedListBox5);
            this.panel2.Controls.Add(this.checkedListBox4);
            this.panel2.Controls.Add(this.checkedListBox3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkedListBox2);
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 711);
            this.panel2.TabIndex = 23;
            this.panel2.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(380, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 35);
            this.button6.TabIndex = 24;
            this.button6.Text = "Deselect all";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(260, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 35);
            this.button5.TabIndex = 23;
            this.button5.Text = "Select all";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 711);
            this.panel1.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 100);
            this.button4.MaximumSize = new System.Drawing.Size(100, 40);
            this.button4.MinimumSize = new System.Drawing.Size(100, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Load game files";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RORRVariantSelector";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private CheckedListBox checkedListBox4;
        private CheckedListBox checkedListBox5;
        private CheckedListBox checkedListBox6;
        private CheckedListBox checkedListBox7;
        private CheckedListBox checkedListBox8;
        private CheckedListBox checkedListBox9;
        private CheckedListBox checkedListBox10;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Panel panel1;
        private Button button4;
        private Button button6;
        private Button button5;
    }


}

namespace LearningAndTesting
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.aktivasiComboBox = new System.Windows.Forms.ComboBox();
            this.learnButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tambahBarisButton = new System.Windows.Forms.Button();
            this.tambahKolomButton = new System.Windows.Forms.Button();
            this.targetPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.epochTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thetaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.biasTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alphaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPathTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.browseDataButton = new System.Windows.Forms.Button();
            this.browseTargetButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.thetaTestingTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.biasTestingTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.alphaTestingTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.weightTestingTextBox = new System.Windows.Forms.TextBox();
            this.browseWeightButton = new System.Windows.Forms.Button();
            this.infoPathWeightTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.aktivasiTestingComboBox = new System.Windows.Forms.ComboBox();
            this.testButton = new System.Windows.Forms.Button();
            this.dataTestingTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.browseAlphaBiasThetaButton = new System.Windows.Forms.Button();
            this.viewCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.viewCheckBox);
            this.tabPage1.Controls.Add(this.browseTargetButton);
            this.tabPage1.Controls.Add(this.browseDataButton);
            this.tabPage1.Controls.Add(this.infoPathTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.aktivasiComboBox);
            this.tabPage1.Controls.Add(this.learnButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tambahBarisButton);
            this.tabPage1.Controls.Add(this.tambahKolomButton);
            this.tabPage1.Controls.Add(this.targetPanel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataPanel);
            this.tabPage1.Controls.Add(this.epochTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.thetaTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.biasTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.weightTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.alphaTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Learning";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fungsi aktivasi";
            // 
            // aktivasiComboBox
            // 
            this.aktivasiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aktivasiComboBox.FormattingEnabled = true;
            this.aktivasiComboBox.Items.AddRange(new object[] {
            "Linear",
            "Linear Piecewise",
            "Biner Sigmoid",
            "Bipolar Sigmoid",
            "Biner Treshold",
            "Bipolar Treshold"});
            this.aktivasiComboBox.Location = new System.Drawing.Point(535, 408);
            this.aktivasiComboBox.Name = "aktivasiComboBox";
            this.aktivasiComboBox.Size = new System.Drawing.Size(104, 21);
            this.aktivasiComboBox.TabIndex = 14;
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(535, 458);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(104, 23);
            this.learnButton.TabIndex = 13;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Target";
            // 
            // tambahBarisButton
            // 
            this.tambahBarisButton.Location = new System.Drawing.Point(535, 141);
            this.tambahBarisButton.Name = "tambahBarisButton";
            this.tambahBarisButton.Size = new System.Drawing.Size(104, 23);
            this.tambahBarisButton.TabIndex = 11;
            this.tambahBarisButton.Text = "Tambah baris";
            this.tambahBarisButton.UseVisualStyleBackColor = true;
            this.tambahBarisButton.Click += new System.EventHandler(this.tambahBarisButton_Click);
            // 
            // tambahKolomButton
            // 
            this.tambahKolomButton.Location = new System.Drawing.Point(535, 112);
            this.tambahKolomButton.Name = "tambahKolomButton";
            this.tambahKolomButton.Size = new System.Drawing.Size(104, 23);
            this.tambahKolomButton.TabIndex = 10;
            this.tambahKolomButton.Text = "Tambah kolom";
            this.tambahKolomButton.UseVisualStyleBackColor = true;
            this.tambahKolomButton.Click += new System.EventHandler(this.tambahKolomButton_Click);
            // 
            // targetPanel
            // 
            this.targetPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.targetPanel.ColumnCount = 1;
            this.targetPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.targetPanel.Location = new System.Drawing.Point(429, 112);
            this.targetPanel.Name = "targetPanel";
            this.targetPanel.RowCount = 1;
            this.targetPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.targetPanel.Size = new System.Drawing.Size(100, 369);
            this.targetPanel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data";
            // 
            // dataPanel
            // 
            this.dataPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.dataPanel.ColumnCount = 1;
            this.dataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dataPanel.Location = new System.Drawing.Point(12, 112);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.RowCount = 1;
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dataPanel.Size = new System.Drawing.Size(411, 369);
            this.dataPanel.TabIndex = 8;
            // 
            // epochTextBox
            // 
            this.epochTextBox.Location = new System.Drawing.Point(436, 24);
            this.epochTextBox.Name = "epochTextBox";
            this.epochTextBox.Size = new System.Drawing.Size(100, 20);
            this.epochTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Epoch";
            // 
            // thetaTextBox
            // 
            this.thetaTextBox.Location = new System.Drawing.Point(330, 24);
            this.thetaTextBox.Name = "thetaTextBox";
            this.thetaTextBox.Size = new System.Drawing.Size(100, 20);
            this.thetaTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Theta";
            // 
            // biasTextBox
            // 
            this.biasTextBox.Location = new System.Drawing.Point(224, 24);
            this.biasTextBox.Name = "biasTextBox";
            this.biasTextBox.Size = new System.Drawing.Size(100, 20);
            this.biasTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bias";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(118, 24);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight awal";
            // 
            // alphaTextBox
            // 
            this.alphaTextBox.Location = new System.Drawing.Point(12, 24);
            this.alphaTextBox.Name = "alphaTextBox";
            this.alphaTextBox.Size = new System.Drawing.Size(100, 20);
            this.alphaTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alpha";
            // 
            // infoPathTextBox
            // 
            this.infoPathTextBox.Location = new System.Drawing.Point(12, 69);
            this.infoPathTextBox.Name = "infoPathTextBox";
            this.infoPathTextBox.Size = new System.Drawing.Size(418, 20);
            this.infoPathTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pilih file untuk data atau target";
            // 
            // browseDataButton
            // 
            this.browseDataButton.Location = new System.Drawing.Point(436, 66);
            this.browseDataButton.Name = "browseDataButton";
            this.browseDataButton.Size = new System.Drawing.Size(93, 23);
            this.browseDataButton.TabIndex = 18;
            this.browseDataButton.Text = "Browse data";
            this.browseDataButton.UseVisualStyleBackColor = true;
            this.browseDataButton.Click += new System.EventHandler(this.browseDataButton_Click);
            // 
            // browseTargetButton
            // 
            this.browseTargetButton.Location = new System.Drawing.Point(535, 66);
            this.browseTargetButton.Name = "browseTargetButton";
            this.browseTargetButton.Size = new System.Drawing.Size(93, 23);
            this.browseTargetButton.TabIndex = 19;
            this.browseTargetButton.Text = "Browse target";
            this.browseTargetButton.UseVisualStyleBackColor = true;
            this.browseTargetButton.Click += new System.EventHandler(this.browseTargetButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.browseAlphaBiasThetaButton);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.dataTestingTextBox);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.aktivasiTestingComboBox);
            this.tabPage2.Controls.Add(this.testButton);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.browseWeightButton);
            this.tabPage2.Controls.Add(this.infoPathWeightTextBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.weightTestingTextBox);
            this.tabPage2.Controls.Add(this.thetaTestingTextBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.biasTestingTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.alphaTestingTextBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Testing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // thetaTestingTextBox
            // 
            this.thetaTestingTextBox.Location = new System.Drawing.Point(224, 24);
            this.thetaTestingTextBox.Name = "thetaTestingTextBox";
            this.thetaTestingTextBox.Size = new System.Drawing.Size(100, 20);
            this.thetaTestingTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Theta";
            // 
            // biasTestingTextBox
            // 
            this.biasTestingTextBox.Location = new System.Drawing.Point(118, 24);
            this.biasTestingTextBox.Name = "biasTestingTextBox";
            this.biasTestingTextBox.Size = new System.Drawing.Size(100, 20);
            this.biasTestingTextBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Bias";
            // 
            // alphaTestingTextBox
            // 
            this.alphaTestingTextBox.Location = new System.Drawing.Point(12, 24);
            this.alphaTestingTextBox.Name = "alphaTestingTextBox";
            this.alphaTestingTextBox.Size = new System.Drawing.Size(100, 20);
            this.alphaTestingTextBox.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Alpha";
            // 
            // weightTestingTextBox
            // 
            this.weightTestingTextBox.Location = new System.Drawing.Point(12, 112);
            this.weightTestingTextBox.Multiline = true;
            this.weightTestingTextBox.Name = "weightTestingTextBox";
            this.weightTestingTextBox.Size = new System.Drawing.Size(252, 371);
            this.weightTestingTextBox.TabIndex = 14;
            // 
            // browseWeightButton
            // 
            this.browseWeightButton.Location = new System.Drawing.Point(300, 66);
            this.browseWeightButton.Name = "browseWeightButton";
            this.browseWeightButton.Size = new System.Drawing.Size(84, 23);
            this.browseWeightButton.TabIndex = 21;
            this.browseWeightButton.Text = "Browse weight";
            this.browseWeightButton.UseVisualStyleBackColor = true;
            this.browseWeightButton.Click += new System.EventHandler(this.browseWeightButton_Click);
            // 
            // infoPathWeightTextBox
            // 
            this.infoPathWeightTextBox.Location = new System.Drawing.Point(12, 69);
            this.infoPathWeightTextBox.Name = "infoPathWeightTextBox";
            this.infoPathWeightTextBox.Size = new System.Drawing.Size(282, 20);
            this.infoPathWeightTextBox.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Pilih file";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Weight (pisahkan dengan enter)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(535, 394);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Fungsi aktivasi";
            // 
            // aktivasiTestingComboBox
            // 
            this.aktivasiTestingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aktivasiTestingComboBox.FormattingEnabled = true;
            this.aktivasiTestingComboBox.Items.AddRange(new object[] {
            "Linear",
            "Linear Piecewise",
            "Biner Sigmoid",
            "Bipolar Sigmoid",
            "Biner Treshold",
            "Bipolar Treshold"});
            this.aktivasiTestingComboBox.Location = new System.Drawing.Point(535, 410);
            this.aktivasiTestingComboBox.Name = "aktivasiTestingComboBox";
            this.aktivasiTestingComboBox.Size = new System.Drawing.Size(104, 21);
            this.aktivasiTestingComboBox.TabIndex = 24;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(535, 460);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(104, 23);
            this.testButton.TabIndex = 23;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // dataTestingTextBox
            // 
            this.dataTestingTextBox.Location = new System.Drawing.Point(270, 112);
            this.dataTestingTextBox.Multiline = true;
            this.dataTestingTextBox.Name = "dataTestingTextBox";
            this.dataTestingTextBox.Size = new System.Drawing.Size(259, 371);
            this.dataTestingTextBox.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "data (pisahkan dengan spasi)";
            // 
            // browseAlphaBiasThetaButton
            // 
            this.browseAlphaBiasThetaButton.Location = new System.Drawing.Point(390, 66);
            this.browseAlphaBiasThetaButton.Name = "browseAlphaBiasThetaButton";
            this.browseAlphaBiasThetaButton.Size = new System.Drawing.Size(139, 23);
            this.browseAlphaBiasThetaButton.TabIndex = 28;
            this.browseAlphaBiasThetaButton.Text = "Browse alpha, bias & theta";
            this.browseAlphaBiasThetaButton.UseVisualStyleBackColor = true;
            this.browseAlphaBiasThetaButton.Click += new System.EventHandler(this.browseAlphaBiasThetaButton_Click);
            // 
            // viewCheckBox
            // 
            this.viewCheckBox.AutoSize = true;
            this.viewCheckBox.Location = new System.Drawing.Point(535, 435);
            this.viewCheckBox.Name = "viewCheckBox";
            this.viewCheckBox.Size = new System.Drawing.Size(108, 17);
            this.viewCheckBox.TabIndex = 30;
            this.viewCheckBox.Text = "Lihat perhitungan";
            this.viewCheckBox.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 517);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alphaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tambahBarisButton;
        private System.Windows.Forms.Button tambahKolomButton;
        private System.Windows.Forms.TableLayoutPanel targetPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel dataPanel;
        private System.Windows.Forms.TextBox epochTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox thetaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox biasTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox aktivasiComboBox;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button browseTargetButton;
        private System.Windows.Forms.Button browseDataButton;
        private System.Windows.Forms.TextBox infoPathTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button browseWeightButton;
        private System.Windows.Forms.TextBox infoPathWeightTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox weightTestingTextBox;
        private System.Windows.Forms.TextBox thetaTestingTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox biasTestingTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox alphaTestingTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox aktivasiTestingComboBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox dataTestingTextBox;
        private System.Windows.Forms.Button browseAlphaBiasThetaButton;
        private System.Windows.Forms.CheckBox viewCheckBox;
    }
}


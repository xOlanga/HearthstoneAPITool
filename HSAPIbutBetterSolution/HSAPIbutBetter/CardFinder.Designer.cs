using System.Windows.Forms;
using System;

namespace HSAPIbutBetter
{
    partial class CardFinder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardFinder));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Artist");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Attack");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Class");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Cost");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("DbfID");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Flavor");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Health");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Mechanics");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Name");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Races");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Rarity");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Set");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Spell School");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Type");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Text");
            this.Header = new System.Windows.Forms.Label();
            this.toolTipUpdateData = new System.Windows.Forms.ToolTip(this.components);
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.toolTipGetData = new System.Windows.Forms.ToolTip(this.components);
            this.FindDataButton = new System.Windows.Forms.Button();
            this.toolTipThankYou = new System.Windows.Forms.ToolTip(this.components);
            this.CreatedBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FullDeckTab = new System.Windows.Forms.TabPage();
            this.GenerateRegionsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeckCodeOutputTextbox = new System.Windows.Forms.RichTextBox();
            this.GetDataDeckCodeButton = new System.Windows.Forms.Button();
            this.DeckCodeTextBox = new System.Windows.Forms.TextBox();
            this.DeckCodeLabel = new System.Windows.Forms.Label();
            this.SingleCardTab = new System.Windows.Forms.TabPage();
            this.SelectAllCheckbox = new System.Windows.Forms.CheckBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsOutput = new System.Windows.Forms.RichTextBox();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CardNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectInformationLabel = new System.Windows.Forms.Label();
            this.InformationCheckboxes = new System.Windows.Forms.ListView();
            this.GenerateVariablesButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.FullDeckTab.SuspendLayout();
            this.SingleCardTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.Control;
            this.Header.Location = new System.Drawing.Point(400, -28);
            this.Header.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(425, 31);
            this.Header.TabIndex = 7;
            this.Header.Text = "Hearthstone API Data Extractor";
            // 
            // toolTipUpdateData
            // 
            this.toolTipUpdateData.AutoPopDelay = 60000;
            this.toolTipUpdateData.InitialDelay = 500;
            this.toolTipUpdateData.ReshowDelay = 100;
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataButton.Location = new System.Drawing.Point(433, 231);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(178, 77);
            this.UpdateDataButton.TabIndex = 18;
            this.UpdateDataButton.Text = "Update Data";
            this.toolTipUpdateData.SetToolTip(this.UpdateDataButton, "Download latest card database to your PC.\r\nSource: api.hearthstonejson.com");
            this.UpdateDataButton.UseVisualStyleBackColor = false;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click_1);
            // 
            // toolTipGetData
            // 
            this.toolTipGetData.AutoPopDelay = 60000;
            this.toolTipGetData.InitialDelay = 500;
            this.toolTipGetData.ReshowDelay = 100;
            // 
            // FindDataButton
            // 
            this.FindDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.FindDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindDataButton.Location = new System.Drawing.Point(433, 130);
            this.FindDataButton.Margin = new System.Windows.Forms.Padding(6);
            this.FindDataButton.Name = "FindDataButton";
            this.FindDataButton.Size = new System.Drawing.Size(178, 77);
            this.FindDataButton.TabIndex = 13;
            this.FindDataButton.Text = "Get Data";
            this.toolTipGetData.SetToolTip(this.FindDataButton, "Output requested data to Results");
            this.FindDataButton.UseVisualStyleBackColor = false;
            this.FindDataButton.Click += new System.EventHandler(this.FindDataButton_Click_1);
            // 
            // toolTipThankYou
            // 
            this.toolTipThankYou.ToolTipTitle = "Thanks to:";
            // 
            // CreatedBy
            // 
            this.CreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.CreatedBy.ForeColor = System.Drawing.SystemColors.Control;
            this.CreatedBy.Location = new System.Drawing.Point(13, 881);
            this.CreatedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(164, 25);
            this.CreatedBy.TabIndex = 20;
            this.CreatedBy.Text = "Creator: Olanga";
            this.toolTipThankYou.SetToolTip(this.CreatedBy, "Evil_Eyes");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 881);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Creator: Olanga";
            this.toolTipThankYou.SetToolTip(this.label2, "Evil_Eyes");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FullDeckTab);
            this.tabControl1.Controls.Add(this.SingleCardTab);
            this.tabControl1.Location = new System.Drawing.Point(-10, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1321, 979);
            this.tabControl1.TabIndex = 11;
            // 
            // FullDeckTab
            // 
            this.FullDeckTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullDeckTab.BackgroundImage")));
            this.FullDeckTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullDeckTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FullDeckTab.Controls.Add(this.GenerateVariablesButton);
            this.FullDeckTab.Controls.Add(this.GenerateRegionsButton);
            this.FullDeckTab.Controls.Add(this.label1);
            this.FullDeckTab.Controls.Add(this.label2);
            this.FullDeckTab.Controls.Add(this.DeckCodeOutputTextbox);
            this.FullDeckTab.Controls.Add(this.GetDataDeckCodeButton);
            this.FullDeckTab.Controls.Add(this.DeckCodeTextBox);
            this.FullDeckTab.Controls.Add(this.DeckCodeLabel);
            this.FullDeckTab.Location = new System.Drawing.Point(8, 39);
            this.FullDeckTab.Margin = new System.Windows.Forms.Padding(6);
            this.FullDeckTab.Name = "FullDeckTab";
            this.FullDeckTab.Padding = new System.Windows.Forms.Padding(6);
            this.FullDeckTab.Size = new System.Drawing.Size(1305, 932);
            this.FullDeckTab.TabIndex = 1;
            this.FullDeckTab.Text = "Deck Code";
            this.FullDeckTab.UseVisualStyleBackColor = true;
            // 
            // GenerateRegionsButton
            // 
            this.GenerateRegionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateRegionsButton.Location = new System.Drawing.Point(43, 274);
            this.GenerateRegionsButton.Name = "GenerateRegionsButton";
            this.GenerateRegionsButton.Size = new System.Drawing.Size(218, 66);
            this.GenerateRegionsButton.TabIndex = 23;
            this.GenerateRegionsButton.Text = "Generate Regions";
            this.GenerateRegionsButton.UseVisualStyleBackColor = true;
            this.GenerateRegionsButton.Click += new System.EventHandler(this.GenerateRegionsButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(544, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Results:";
            // 
            // DeckCodeOutputTextbox
            // 
            this.DeckCodeOutputTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.DeckCodeOutputTextbox.Location = new System.Drawing.Point(549, 65);
            this.DeckCodeOutputTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.DeckCodeOutputTextbox.Name = "DeckCodeOutputTextbox";
            this.DeckCodeOutputTextbox.Size = new System.Drawing.Size(692, 826);
            this.DeckCodeOutputTextbox.TabIndex = 3;
            this.DeckCodeOutputTextbox.Text = "";
            this.DeckCodeOutputTextbox.TextChanged += new System.EventHandler(this.DeckCodeOutputTextbox_TextChanged);
            // 
            // GetDataDeckCodeButton
            // 
            this.GetDataDeckCodeButton.BackColor = System.Drawing.SystemColors.Control;
            this.GetDataDeckCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDataDeckCodeButton.Location = new System.Drawing.Point(43, 179);
            this.GetDataDeckCodeButton.Margin = new System.Windows.Forms.Padding(6);
            this.GetDataDeckCodeButton.Name = "GetDataDeckCodeButton";
            this.GetDataDeckCodeButton.Size = new System.Drawing.Size(218, 65);
            this.GetDataDeckCodeButton.TabIndex = 2;
            this.GetDataDeckCodeButton.Text = "Get Data";
            this.GetDataDeckCodeButton.UseVisualStyleBackColor = false;
            this.GetDataDeckCodeButton.Click += new System.EventHandler(this.GetDataDeckCodeButton_Click);
            // 
            // DeckCodeTextBox
            // 
            this.DeckCodeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DeckCodeTextBox.Location = new System.Drawing.Point(43, 65);
            this.DeckCodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.DeckCodeTextBox.Multiline = true;
            this.DeckCodeTextBox.Name = "DeckCodeTextBox";
            this.DeckCodeTextBox.Size = new System.Drawing.Size(401, 92);
            this.DeckCodeTextBox.TabIndex = 1;
            this.DeckCodeTextBox.TextChanged += new System.EventHandler(this.DeckCodeTextBox_TextChanged);
            // 
            // DeckCodeLabel
            // 
            this.DeckCodeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DeckCodeLabel.AutoSize = true;
            this.DeckCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeckCodeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DeckCodeLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DeckCodeLabel.Location = new System.Drawing.Point(38, 23);
            this.DeckCodeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DeckCodeLabel.Name = "DeckCodeLabel";
            this.DeckCodeLabel.Size = new System.Drawing.Size(200, 26);
            this.DeckCodeLabel.TabIndex = 0;
            this.DeckCodeLabel.Text = "Enter Deck Code:";
            // 
            // SingleCardTab
            // 
            this.SingleCardTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SingleCardTab.BackgroundImage")));
            this.SingleCardTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SingleCardTab.Controls.Add(this.Header);
            this.SingleCardTab.Controls.Add(this.CreatedBy);
            this.SingleCardTab.Controls.Add(this.SelectAllCheckbox);
            this.SingleCardTab.Controls.Add(this.UpdateDataButton);
            this.SingleCardTab.Controls.Add(this.ResultsLabel);
            this.SingleCardTab.Controls.Add(this.ResultsOutput);
            this.SingleCardTab.Controls.Add(this.CardNameLabel);
            this.SingleCardTab.Controls.Add(this.CardNameTextBox);
            this.SingleCardTab.Controls.Add(this.FindDataButton);
            this.SingleCardTab.Controls.Add(this.SelectInformationLabel);
            this.SingleCardTab.Controls.Add(this.InformationCheckboxes);
            this.SingleCardTab.Location = new System.Drawing.Point(8, 39);
            this.SingleCardTab.Margin = new System.Windows.Forms.Padding(6);
            this.SingleCardTab.Name = "SingleCardTab";
            this.SingleCardTab.Padding = new System.Windows.Forms.Padding(6);
            this.SingleCardTab.Size = new System.Drawing.Size(1305, 932);
            this.SingleCardTab.TabIndex = 0;
            this.SingleCardTab.Text = "Single Card";
            this.SingleCardTab.UseVisualStyleBackColor = true;
            // 
            // SelectAllCheckbox
            // 
            this.SelectAllCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllCheckbox.AutoSize = true;
            this.SelectAllCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.SelectAllCheckbox.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectAllCheckbox.Location = new System.Drawing.Point(45, 633);
            this.SelectAllCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectAllCheckbox.Name = "SelectAllCheckbox";
            this.SelectAllCheckbox.Size = new System.Drawing.Size(134, 29);
            this.SelectAllCheckbox.TabIndex = 19;
            this.SelectAllCheckbox.Text = "Select All";
            this.SelectAllCheckbox.UseVisualStyleBackColor = false;
            this.SelectAllCheckbox.CheckedChanged += new System.EventHandler(this.SelectAllCheckbox_CheckedChanged_1);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ResultsLabel.Location = new System.Drawing.Point(646, 13);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(98, 25);
            this.ResultsLabel.TabIndex = 17;
            this.ResultsLabel.Text = "Results:";
            // 
            // ResultsOutput
            // 
            this.ResultsOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsOutput.BackColor = System.Drawing.SystemColors.Control;
            this.ResultsOutput.Location = new System.Drawing.Point(651, 71);
            this.ResultsOutput.Margin = new System.Windows.Forms.Padding(6);
            this.ResultsOutput.Name = "ResultsOutput";
            this.ResultsOutput.ReadOnly = true;
            this.ResultsOutput.Size = new System.Drawing.Size(598, 826);
            this.ResultsOutput.TabIndex = 16;
            this.ResultsOutput.Text = "";
            this.ResultsOutput.TextChanged += new System.EventHandler(this.ResultsOutput_TextChanged_1);
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CardNameLabel.Location = new System.Drawing.Point(40, 13);
            this.CardNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(199, 25);
            this.CardNameLabel.TabIndex = 15;
            this.CardNameLabel.Text = "Enter Card Name:";
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.AcceptsReturn = true;
            this.CardNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CardNameTextBox.Location = new System.Drawing.Point(44, 44);
            this.CardNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CardNameTextBox.Multiline = true;
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.Size = new System.Drawing.Size(445, 29);
            this.CardNameTextBox.TabIndex = 14;
            this.CardNameTextBox.TextChanged += new System.EventHandler(this.CardNameTextBox_TextChanged_1);
            // 
            // SelectInformationLabel
            // 
            this.SelectInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectInformationLabel.AutoSize = true;
            this.SelectInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectInformationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectInformationLabel.Location = new System.Drawing.Point(40, 92);
            this.SelectInformationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SelectInformationLabel.Name = "SelectInformationLabel";
            this.SelectInformationLabel.Size = new System.Drawing.Size(323, 25);
            this.SelectInformationLabel.TabIndex = 11;
            this.SelectInformationLabel.Text = "Select information to retrieve:";
            // 
            // InformationCheckboxes
            // 
            this.InformationCheckboxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationCheckboxes.BackColor = System.Drawing.SystemColors.Control;
            this.InformationCheckboxes.CheckBoxes = true;
            this.InformationCheckboxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationCheckboxes.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            this.InformationCheckboxes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.InformationCheckboxes.Location = new System.Drawing.Point(44, 135);
            this.InformationCheckboxes.Margin = new System.Windows.Forms.Padding(6);
            this.InformationCheckboxes.Name = "InformationCheckboxes";
            this.InformationCheckboxes.Size = new System.Drawing.Size(348, 478);
            this.InformationCheckboxes.TabIndex = 12;
            this.InformationCheckboxes.UseCompatibleStateImageBehavior = false;
            this.InformationCheckboxes.View = System.Windows.Forms.View.List;
            this.InformationCheckboxes.SelectedIndexChanged += new System.EventHandler(this.InformationCheckboxes_SelectedIndexChanged_1);
            // 
            // GenerateVariablesButton
            // 
            this.GenerateVariablesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateVariablesButton.Location = new System.Drawing.Point(43, 372);
            this.GenerateVariablesButton.Name = "GenerateVariablesButton";
            this.GenerateVariablesButton.Size = new System.Drawing.Size(218, 66);
            this.GenerateVariablesButton.TabIndex = 24;
            this.GenerateVariablesButton.Text = "Generate Variables";
            this.GenerateVariablesButton.UseVisualStyleBackColor = true;
            this.GenerateVariablesButton.Click += new System.EventHandler(this.GenerateVariablesButton_Click);
            // 
            // CardFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1293, 966);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardFinder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hearthstone API Tool";
            this.Load += new System.EventHandler(this.CardFinder_Load);
            this.tabControl1.ResumeLayout(false);
            this.FullDeckTab.ResumeLayout(false);
            this.FullDeckTab.PerformLayout();
            this.SingleCardTab.ResumeLayout(false);
            this.SingleCardTab.PerformLayout();
            this.ResumeLayout(false);

        }
        private void SelectAllCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = SelectAllCheckbox.Checked;

            foreach (ListViewItem item in InformationCheckboxes.Items)
            {
                item.Checked = isChecked;
            }
        }
        #endregion
        private System.Windows.Forms.Label Header;
        private ToolTip toolTipUpdateData;
        private ToolTip toolTipGetData;
        private ToolTip toolTipThankYou;
        private TabControl tabControl1;
        private TabPage FullDeckTab;
        private TabPage SingleCardTab;
        private Label CreatedBy;
        private CheckBox SelectAllCheckbox;
        private Button UpdateDataButton;
        private Label ResultsLabel;
        private RichTextBox ResultsOutput;
        private Label CardNameLabel;
        private TextBox CardNameTextBox;
        private Button FindDataButton;
        private Label SelectInformationLabel;
        private ListView InformationCheckboxes;
        private Label DeckCodeLabel;
        private RichTextBox DeckCodeOutputTextbox;
        private Button GetDataDeckCodeButton;
        private TextBox DeckCodeTextBox;
        private Label label2;
        private Label label1;
        private Button GenerateRegionsButton;
        private Button GenerateVariablesButton;
    }
}
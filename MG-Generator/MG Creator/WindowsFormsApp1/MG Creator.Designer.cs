namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createGirl = new System.Windows.Forms.Button();
            this.characterRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.affinity1Label = new System.Windows.Forms.Label();
            this.affinity2Label = new System.Windows.Forms.Label();
            this.affinity2TextBox = new System.Windows.Forms.TextBox();
            this.affinity1TextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.titlesTextBox = new System.Windows.Forms.TextBox();
            this.titlesLabel = new System.Windows.Forms.Label();
            this.mgTextBox = new System.Windows.Forms.TextBox();
            this.mgName = new System.Windows.Forms.Label();
            this.characterGroupBox = new System.Windows.Forms.GroupBox();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.baseResilienceTextBox = new System.Windows.Forms.TextBox();
            this.growthSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.growthLabel = new System.Windows.Forms.Label();
            this.magicModifierLabel = new System.Windows.Forms.Label();
            this.baseResilienceLabel = new System.Windows.Forms.Label();
            this.baseDamageLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.magicModifierTextBox = new System.Windows.Forms.TextBox();
            this.baseDamageTextBox = new System.Windows.Forms.TextBox();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.statsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.randomiseButton = new System.Windows.Forms.Button();
            this.weaponGroupBox = new System.Windows.Forms.GroupBox();
            this.weaponRichTextBox = new System.Windows.Forms.RichTextBox();
            this.weaponAbilityTextBox = new System.Windows.Forms.TextBox();
            this.weaponAffinityTextBox = new System.Windows.Forms.TextBox();
            this.aptTextBox = new System.Windows.Forms.TextBox();
            this.weaponLevelTextBox = new System.Windows.Forms.TextBox();
            this.weaponAbilityLabel = new System.Windows.Forms.Label();
            this.weaponAffinityLabel = new System.Windows.Forms.Label();
            this.aptLabel = new System.Windows.Forms.Label();
            this.weaponLevelLabel = new System.Windows.Forms.Label();
            this.weaponNameTextBox = new System.Windows.Forms.TextBox();
            this.weaponNameLabel = new System.Windows.Forms.Label();
            this.spellsGroupBox = new System.Windows.Forms.GroupBox();
            this.spellAbilityTextBox2 = new System.Windows.Forms.TextBox();
            this.spellAffinityTextBox2 = new System.Windows.Forms.TextBox();
            this.spellBaseMagicModifierTextBox2 = new System.Windows.Forms.TextBox();
            this.spellBaseDamageTextBox2 = new System.Windows.Forms.TextBox();
            this.spellLevelTextBox2 = new System.Windows.Forms.TextBox();
            this.spellDescriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.spellNameTextBox2 = new System.Windows.Forms.TextBox();
            this.spellAbilityLabel2 = new System.Windows.Forms.Label();
            this.spellAffinityLabel2 = new System.Windows.Forms.Label();
            this.spellMagicModifierLabel2 = new System.Windows.Forms.Label();
            this.spellBaseDamageLabel2 = new System.Windows.Forms.Label();
            this.spellLevelLabel2 = new System.Windows.Forms.Label();
            this.spellDescriptionLabel2 = new System.Windows.Forms.Label();
            this.spellNameLabel2 = new System.Windows.Forms.Label();
            this.spellRichTextBox = new System.Windows.Forms.RichTextBox();
            this.spellAbilityTextBox = new System.Windows.Forms.TextBox();
            this.spellAffinityTextBox = new System.Windows.Forms.TextBox();
            this.spellBaseMagicModifierTextBox = new System.Windows.Forms.TextBox();
            this.spellBaseDamageTextBox = new System.Windows.Forms.TextBox();
            this.spellLevelTextBox = new System.Windows.Forms.TextBox();
            this.spellDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.spellNameTextBox = new System.Windows.Forms.TextBox();
            this.spellAbilityLabel = new System.Windows.Forms.Label();
            this.spellAffinityLabel = new System.Windows.Forms.Label();
            this.spellMagicModifierLabel = new System.Windows.Forms.Label();
            this.spellBaseDamageLabel = new System.Windows.Forms.Label();
            this.spellLevelLabel = new System.Windows.Forms.Label();
            this.spellDescriptionLabel = new System.Windows.Forms.Label();
            this.spellNameLabel = new System.Windows.Forms.Label();
            this.randomiseChecklist = new System.Windows.Forms.CheckedListBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.abilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.addAbilityButton = new System.Windows.Forms.Button();
            this.abilityRichTextBox = new System.Windows.Forms.RichTextBox();
            this.abilityDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.abilityNameTextBox = new System.Windows.Forms.TextBox();
            this.abilityDescription = new System.Windows.Forms.Label();
            this.abilityNameLabel = new System.Windows.Forms.Label();
            this.characterGroupBox.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.weaponGroupBox.SuspendLayout();
            this.spellsGroupBox.SuspendLayout();
            this.abilitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGirl
            // 
            this.createGirl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createGirl.Location = new System.Drawing.Point(1133, 35);
            this.createGirl.Name = "createGirl";
            this.createGirl.Size = new System.Drawing.Size(81, 23);
            this.createGirl.TabIndex = 5;
            this.createGirl.Text = "Create";
            this.createGirl.UseVisualStyleBackColor = true;
            this.createGirl.Click += new System.EventHandler(this.createGirl_Click);
            // 
            // characterRichTextBox
            // 
            this.characterRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.characterRichTextBox.Location = new System.Drawing.Point(198, 25);
            this.characterRichTextBox.Name = "characterRichTextBox";
            this.characterRichTextBox.Size = new System.Drawing.Size(220, 109);
            this.characterRichTextBox.TabIndex = 9;
            this.characterRichTextBox.TabStop = false;
            this.characterRichTextBox.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(5, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // affinity1Label
            // 
            this.affinity1Label.Location = new System.Drawing.Point(5, 125);
            this.affinity1Label.Name = "affinity1Label";
            this.affinity1Label.Size = new System.Drawing.Size(50, 13);
            this.affinity1Label.TabIndex = 6;
            this.affinity1Label.Text = "Affinity 1:";
            // 
            // affinity2Label
            // 
            this.affinity2Label.Location = new System.Drawing.Point(5, 150);
            this.affinity2Label.Name = "affinity2Label";
            this.affinity2Label.Size = new System.Drawing.Size(50, 13);
            this.affinity2Label.TabIndex = 7;
            this.affinity2Label.Text = "Affinity 2:";
            // 
            // affinity2TextBox
            // 
            this.affinity2TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.affinity2TextBox.Location = new System.Drawing.Point(90, 150);
            this.affinity2TextBox.Name = "affinity2TextBox";
            this.affinity2TextBox.Size = new System.Drawing.Size(102, 20);
            this.affinity2TextBox.TabIndex = 5;
            this.affinity2TextBox.Text = "Affinity";
            // 
            // affinity1TextBox
            // 
            this.affinity1TextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.affinity1TextBox.Location = new System.Drawing.Point(90, 125);
            this.affinity1TextBox.Name = "affinity1TextBox";
            this.affinity1TextBox.Size = new System.Drawing.Size(102, 20);
            this.affinity1TextBox.TabIndex = 4;
            this.affinity1TextBox.Text = "Affinity";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameTextBox.Location = new System.Drawing.Point(90, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(102, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "Real Name";
            // 
            // titlesTextBox
            // 
            this.titlesTextBox.Location = new System.Drawing.Point(90, 75);
            this.titlesTextBox.Name = "titlesTextBox";
            this.titlesTextBox.Size = new System.Drawing.Size(102, 20);
            this.titlesTextBox.TabIndex = 2;
            this.titlesTextBox.Text = "Titles";
            // 
            // titlesLabel
            // 
            this.titlesLabel.Location = new System.Drawing.Point(5, 75);
            this.titlesLabel.Name = "titlesLabel";
            this.titlesLabel.Size = new System.Drawing.Size(41, 13);
            this.titlesLabel.TabIndex = 10;
            this.titlesLabel.Text = "Title(s):";
            // 
            // mgTextBox
            // 
            this.mgTextBox.Location = new System.Drawing.Point(90, 25);
            this.mgTextBox.Name = "mgTextBox";
            this.mgTextBox.Size = new System.Drawing.Size(102, 20);
            this.mgTextBox.TabIndex = 0;
            this.mgTextBox.Text = "MG Name";
            // 
            // mgName
            // 
            this.mgName.Location = new System.Drawing.Point(5, 25);
            this.mgName.Name = "mgName";
            this.mgName.Size = new System.Drawing.Size(58, 13);
            this.mgName.TabIndex = 12;
            this.mgName.Text = "MG Name:";
            // 
            // characterGroupBox
            // 
            this.characterGroupBox.Controls.Add(this.titlesLabel);
            this.characterGroupBox.Controls.Add(this.mgName);
            this.characterGroupBox.Controls.Add(this.nameLabel);
            this.characterGroupBox.Controls.Add(this.characterRichTextBox);
            this.characterGroupBox.Controls.Add(this.mgTextBox);
            this.characterGroupBox.Controls.Add(this.titlesTextBox);
            this.characterGroupBox.Controls.Add(this.nameTextBox);
            this.characterGroupBox.Location = new System.Drawing.Point(10, 20);
            this.characterGroupBox.Name = "characterGroupBox";
            this.characterGroupBox.Size = new System.Drawing.Size(430, 153);
            this.characterGroupBox.TabIndex = 13;
            this.characterGroupBox.TabStop = false;
            this.characterGroupBox.Text = "Character";
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.baseResilienceTextBox);
            this.statsGroupBox.Controls.Add(this.growthSelectionComboBox);
            this.statsGroupBox.Controls.Add(this.growthLabel);
            this.statsGroupBox.Controls.Add(this.magicModifierLabel);
            this.statsGroupBox.Controls.Add(this.baseResilienceLabel);
            this.statsGroupBox.Controls.Add(this.baseDamageLabel);
            this.statsGroupBox.Controls.Add(this.healthLabel);
            this.statsGroupBox.Controls.Add(this.magicModifierTextBox);
            this.statsGroupBox.Controls.Add(this.baseDamageTextBox);
            this.statsGroupBox.Controls.Add(this.healthTextBox);
            this.statsGroupBox.Controls.Add(this.affinity2Label);
            this.statsGroupBox.Controls.Add(this.statsRichTextBox);
            this.statsGroupBox.Controls.Add(this.affinity2TextBox);
            this.statsGroupBox.Controls.Add(this.affinity1Label);
            this.statsGroupBox.Controls.Add(this.affinity1TextBox);
            this.statsGroupBox.Location = new System.Drawing.Point(10, 160);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(430, 215);
            this.statsGroupBox.TabIndex = 14;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // baseResilienceTextBox
            // 
            this.baseResilienceTextBox.Location = new System.Drawing.Point(90, 75);
            this.baseResilienceTextBox.Name = "baseResilienceTextBox";
            this.baseResilienceTextBox.Size = new System.Drawing.Size(102, 20);
            this.baseResilienceTextBox.TabIndex = 2;
            // 
            // growthSelectionComboBox
            // 
            this.growthSelectionComboBox.FormattingEnabled = true;
            this.growthSelectionComboBox.Location = new System.Drawing.Point(90, 175);
            this.growthSelectionComboBox.Name = "growthSelectionComboBox";
            this.growthSelectionComboBox.Size = new System.Drawing.Size(102, 21);
            this.growthSelectionComboBox.TabIndex = 6;
            this.growthSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.growthSelectionComboBox_SelectedIndexChanged);
            // 
            // growthLabel
            // 
            this.growthLabel.Location = new System.Drawing.Point(5, 175);
            this.growthLabel.Name = "growthLabel";
            this.growthLabel.Size = new System.Drawing.Size(78, 13);
            this.growthLabel.TabIndex = 14;
            this.growthLabel.Text = "Growth Affinity:";
            // 
            // magicModifierLabel
            // 
            this.magicModifierLabel.Location = new System.Drawing.Point(5, 100);
            this.magicModifierLabel.Name = "magicModifierLabel";
            this.magicModifierLabel.Size = new System.Drawing.Size(79, 13);
            this.magicModifierLabel.TabIndex = 13;
            this.magicModifierLabel.Text = "Magic Modifier:";
            // 
            // baseResilienceLabel
            // 
            this.baseResilienceLabel.Location = new System.Drawing.Point(5, 75);
            this.baseResilienceLabel.Name = "baseResilienceLabel";
            this.baseResilienceLabel.Size = new System.Drawing.Size(86, 13);
            this.baseResilienceLabel.TabIndex = 12;
            this.baseResilienceLabel.Text = "Base Resilience:";
            // 
            // baseDamageLabel
            // 
            this.baseDamageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseDamageLabel.Location = new System.Drawing.Point(5, 50);
            this.baseDamageLabel.Name = "baseDamageLabel";
            this.baseDamageLabel.Size = new System.Drawing.Size(1, 13);
            this.baseDamageLabel.TabIndex = 11;
            this.baseDamageLabel.Text = "Base Damage:";
            // 
            // healthLabel
            // 
            this.healthLabel.Location = new System.Drawing.Point(5, 25);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(41, 13);
            this.healthLabel.TabIndex = 10;
            this.healthLabel.Text = "Health:";
            // 
            // magicModifierTextBox
            // 
            this.magicModifierTextBox.Location = new System.Drawing.Point(90, 100);
            this.magicModifierTextBox.Name = "magicModifierTextBox";
            this.magicModifierTextBox.Size = new System.Drawing.Size(102, 20);
            this.magicModifierTextBox.TabIndex = 3;
            // 
            // baseDamageTextBox
            // 
            this.baseDamageTextBox.Location = new System.Drawing.Point(90, 50);
            this.baseDamageTextBox.Name = "baseDamageTextBox";
            this.baseDamageTextBox.Size = new System.Drawing.Size(102, 20);
            this.baseDamageTextBox.TabIndex = 1;
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(90, 25);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(102, 20);
            this.healthTextBox.TabIndex = 0;
            // 
            // statsRichTextBox
            // 
            this.statsRichTextBox.Location = new System.Drawing.Point(198, 19);
            this.statsRichTextBox.Name = "statsRichTextBox";
            this.statsRichTextBox.Size = new System.Drawing.Size(220, 168);
            this.statsRichTextBox.TabIndex = 11;
            this.statsRichTextBox.TabStop = false;
            this.statsRichTextBox.Text = "";
            // 
            // randomiseButton
            // 
            this.randomiseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.randomiseButton.Location = new System.Drawing.Point(1133, 65);
            this.randomiseButton.Name = "randomiseButton";
            this.randomiseButton.Size = new System.Drawing.Size(81, 23);
            this.randomiseButton.TabIndex = 15;
            this.randomiseButton.Text = "Randomise";
            this.randomiseButton.UseVisualStyleBackColor = true;
            this.randomiseButton.Click += new System.EventHandler(this.randomStatsButton_Click);
            // 
            // weaponGroupBox
            // 
            this.weaponGroupBox.Controls.Add(this.weaponRichTextBox);
            this.weaponGroupBox.Controls.Add(this.weaponAbilityTextBox);
            this.weaponGroupBox.Controls.Add(this.weaponAffinityTextBox);
            this.weaponGroupBox.Controls.Add(this.aptTextBox);
            this.weaponGroupBox.Controls.Add(this.weaponLevelTextBox);
            this.weaponGroupBox.Controls.Add(this.weaponAbilityLabel);
            this.weaponGroupBox.Controls.Add(this.weaponAffinityLabel);
            this.weaponGroupBox.Controls.Add(this.aptLabel);
            this.weaponGroupBox.Controls.Add(this.weaponLevelLabel);
            this.weaponGroupBox.Controls.Add(this.weaponNameTextBox);
            this.weaponGroupBox.Controls.Add(this.weaponNameLabel);
            this.weaponGroupBox.Location = new System.Drawing.Point(10, 365);
            this.weaponGroupBox.Name = "weaponGroupBox";
            this.weaponGroupBox.Size = new System.Drawing.Size(430, 164);
            this.weaponGroupBox.TabIndex = 16;
            this.weaponGroupBox.TabStop = false;
            this.weaponGroupBox.Text = "Weapon";
            // 
            // weaponRichTextBox
            // 
            this.weaponRichTextBox.Location = new System.Drawing.Point(198, 16);
            this.weaponRichTextBox.Name = "weaponRichTextBox";
            this.weaponRichTextBox.Size = new System.Drawing.Size(220, 125);
            this.weaponRichTextBox.TabIndex = 6;
            this.weaponRichTextBox.TabStop = false;
            this.weaponRichTextBox.Text = "";
            // 
            // weaponAbilityTextBox
            // 
            this.weaponAbilityTextBox.Location = new System.Drawing.Point(90, 125);
            this.weaponAbilityTextBox.Name = "weaponAbilityTextBox";
            this.weaponAbilityTextBox.Size = new System.Drawing.Size(102, 20);
            this.weaponAbilityTextBox.TabIndex = 4;
            this.weaponAbilityTextBox.Text = "Ability";
            // 
            // weaponAffinityTextBox
            // 
            this.weaponAffinityTextBox.Location = new System.Drawing.Point(90, 100);
            this.weaponAffinityTextBox.Name = "weaponAffinityTextBox";
            this.weaponAffinityTextBox.Size = new System.Drawing.Size(102, 20);
            this.weaponAffinityTextBox.TabIndex = 3;
            this.weaponAffinityTextBox.Text = "Affinity";
            // 
            // aptTextBox
            // 
            this.aptTextBox.Location = new System.Drawing.Point(90, 75);
            this.aptTextBox.Name = "aptTextBox";
            this.aptTextBox.Size = new System.Drawing.Size(102, 20);
            this.aptTextBox.TabIndex = 2;
            this.aptTextBox.Text = "3";
            // 
            // weaponLevelTextBox
            // 
            this.weaponLevelTextBox.Location = new System.Drawing.Point(90, 50);
            this.weaponLevelTextBox.Name = "weaponLevelTextBox";
            this.weaponLevelTextBox.Size = new System.Drawing.Size(102, 20);
            this.weaponLevelTextBox.TabIndex = 1;
            this.weaponLevelTextBox.Text = "1";
            // 
            // weaponAbilityLabel
            // 
            this.weaponAbilityLabel.Location = new System.Drawing.Point(5, 125);
            this.weaponAbilityLabel.Name = "weaponAbilityLabel";
            this.weaponAbilityLabel.Size = new System.Drawing.Size(37, 13);
            this.weaponAbilityLabel.TabIndex = 5;
            this.weaponAbilityLabel.Text = "Ability:";
            // 
            // weaponAffinityLabel
            // 
            this.weaponAffinityLabel.Location = new System.Drawing.Point(5, 100);
            this.weaponAffinityLabel.Name = "weaponAffinityLabel";
            this.weaponAffinityLabel.Size = new System.Drawing.Size(41, 13);
            this.weaponAffinityLabel.TabIndex = 4;
            this.weaponAffinityLabel.Text = "Affinity:";
            // 
            // aptLabel
            // 
            this.aptLabel.Location = new System.Drawing.Point(5, 75);
            this.aptLabel.Name = "aptLabel";
            this.aptLabel.Size = new System.Drawing.Size(31, 13);
            this.aptLabel.TabIndex = 3;
            this.aptLabel.Text = "APT:";
            // 
            // weaponLevelLabel
            // 
            this.weaponLevelLabel.Location = new System.Drawing.Point(5, 50);
            this.weaponLevelLabel.Name = "weaponLevelLabel";
            this.weaponLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.weaponLevelLabel.TabIndex = 2;
            this.weaponLevelLabel.Text = "Level:";
            // 
            // weaponNameTextBox
            // 
            this.weaponNameTextBox.Location = new System.Drawing.Point(90, 25);
            this.weaponNameTextBox.Name = "weaponNameTextBox";
            this.weaponNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.weaponNameTextBox.TabIndex = 0;
            this.weaponNameTextBox.Text = "Weapon Name";
            // 
            // weaponNameLabel
            // 
            this.weaponNameLabel.Location = new System.Drawing.Point(5, 25);
            this.weaponNameLabel.Name = "weaponNameLabel";
            this.weaponNameLabel.Size = new System.Drawing.Size(82, 13);
            this.weaponNameLabel.TabIndex = 0;
            this.weaponNameLabel.Text = "Weapon Name:";
            // 
            // spellsGroupBox
            // 
            this.spellsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.spellsGroupBox.Controls.Add(this.spellAbilityTextBox2);
            this.spellsGroupBox.Controls.Add(this.spellAffinityTextBox2);
            this.spellsGroupBox.Controls.Add(this.spellBaseMagicModifierTextBox2);
            this.spellsGroupBox.Controls.Add(this.spellBaseDamageTextBox2);
            this.spellsGroupBox.Controls.Add(this.spellLevelTextBox2);
            this.spellsGroupBox.Controls.Add(this.spellDescriptionTextBox2);
            this.spellsGroupBox.Controls.Add(this.spellNameTextBox2);
            this.spellsGroupBox.Controls.Add(this.spellAbilityLabel2);
            this.spellsGroupBox.Controls.Add(this.spellAffinityLabel2);
            this.spellsGroupBox.Controls.Add(this.spellMagicModifierLabel2);
            this.spellsGroupBox.Controls.Add(this.spellBaseDamageLabel2);
            this.spellsGroupBox.Controls.Add(this.spellLevelLabel2);
            this.spellsGroupBox.Controls.Add(this.spellDescriptionLabel2);
            this.spellsGroupBox.Controls.Add(this.spellNameLabel2);
            this.spellsGroupBox.Controls.Add(this.spellRichTextBox);
            this.spellsGroupBox.Controls.Add(this.spellAbilityTextBox);
            this.spellsGroupBox.Controls.Add(this.spellAffinityTextBox);
            this.spellsGroupBox.Controls.Add(this.spellBaseMagicModifierTextBox);
            this.spellsGroupBox.Controls.Add(this.spellBaseDamageTextBox);
            this.spellsGroupBox.Controls.Add(this.spellLevelTextBox);
            this.spellsGroupBox.Controls.Add(this.spellDescriptionTextBox);
            this.spellsGroupBox.Controls.Add(this.spellNameTextBox);
            this.spellsGroupBox.Controls.Add(this.spellAbilityLabel);
            this.spellsGroupBox.Controls.Add(this.spellAffinityLabel);
            this.spellsGroupBox.Controls.Add(this.spellMagicModifierLabel);
            this.spellsGroupBox.Controls.Add(this.spellBaseDamageLabel);
            this.spellsGroupBox.Controls.Add(this.spellLevelLabel);
            this.spellsGroupBox.Controls.Add(this.spellDescriptionLabel);
            this.spellsGroupBox.Controls.Add(this.spellNameLabel);
            this.spellsGroupBox.Location = new System.Drawing.Point(446, 20);
            this.spellsGroupBox.Name = "spellsGroupBox";
            this.spellsGroupBox.Size = new System.Drawing.Size(439, 502);
            this.spellsGroupBox.TabIndex = 17;
            this.spellsGroupBox.TabStop = false;
            this.spellsGroupBox.Text = "Spells";
            // 
            // spellAbilityTextBox2
            // 
            this.spellAbilityTextBox2.Location = new System.Drawing.Point(95, 375);
            this.spellAbilityTextBox2.Name = "spellAbilityTextBox2";
            this.spellAbilityTextBox2.Size = new System.Drawing.Size(104, 20);
            this.spellAbilityTextBox2.TabIndex = 27;
            this.spellAbilityTextBox2.Text = "Ability";
            // 
            // spellAffinityTextBox2
            // 
            this.spellAffinityTextBox2.Location = new System.Drawing.Point(95, 350);
            this.spellAffinityTextBox2.Name = "spellAffinityTextBox2";
            this.spellAffinityTextBox2.Size = new System.Drawing.Size(104, 20);
            this.spellAffinityTextBox2.TabIndex = 25;
            this.spellAffinityTextBox2.Text = "Affinity";
            // 
            // spellBaseMagicModifierTextBox2
            // 
            this.spellBaseMagicModifierTextBox2.Location = new System.Drawing.Point(95, 325);
            this.spellBaseMagicModifierTextBox2.Name = "spellBaseMagicModifierTextBox2";
            this.spellBaseMagicModifierTextBox2.Size = new System.Drawing.Size(104, 20);
            this.spellBaseMagicModifierTextBox2.TabIndex = 23;
            // 
            // spellBaseDamageTextBox2
            // 
            this.spellBaseDamageTextBox2.Location = new System.Drawing.Point(95, 300);
            this.spellBaseDamageTextBox2.Name = "spellBaseDamageTextBox2";
            this.spellBaseDamageTextBox2.Size = new System.Drawing.Size(104, 20);
            this.spellBaseDamageTextBox2.TabIndex = 21;
            // 
            // spellLevelTextBox2
            // 
            this.spellLevelTextBox2.Location = new System.Drawing.Point(95, 275);
            this.spellLevelTextBox2.Name = "spellLevelTextBox2";
            this.spellLevelTextBox2.Size = new System.Drawing.Size(104, 20);
            this.spellLevelTextBox2.TabIndex = 19;
            this.spellLevelTextBox2.Text = "1";
            // 
            // spellDescriptionTextBox2
            // 
            this.spellDescriptionTextBox2.Location = new System.Drawing.Point(95, 250);
            this.spellDescriptionTextBox2.Name = "spellDescriptionTextBox2";
            this.spellDescriptionTextBox2.Size = new System.Drawing.Size(104, 20);
            this.spellDescriptionTextBox2.TabIndex = 17;
            this.spellDescriptionTextBox2.Text = "Description";
            // 
            // spellNameTextBox2
            // 
            this.spellNameTextBox2.Location = new System.Drawing.Point(95, 225);
            this.spellNameTextBox2.Name = "spellNameTextBox2";
            this.spellNameTextBox2.Size = new System.Drawing.Size(104, 20);
            this.spellNameTextBox2.TabIndex = 15;
            this.spellNameTextBox2.Text = "Spell Name";
            // 
            // spellAbilityLabel2
            // 
            this.spellAbilityLabel2.Location = new System.Drawing.Point(5, 375);
            this.spellAbilityLabel2.Name = "spellAbilityLabel2";
            this.spellAbilityLabel2.Size = new System.Drawing.Size(37, 13);
            this.spellAbilityLabel2.TabIndex = 28;
            this.spellAbilityLabel2.Text = "Ability:";
            // 
            // spellAffinityLabel2
            // 
            this.spellAffinityLabel2.Location = new System.Drawing.Point(5, 350);
            this.spellAffinityLabel2.Name = "spellAffinityLabel2";
            this.spellAffinityLabel2.Size = new System.Drawing.Size(41, 13);
            this.spellAffinityLabel2.TabIndex = 26;
            this.spellAffinityLabel2.Text = "Affinity:";
            // 
            // spellMagicModifierLabel2
            // 
            this.spellMagicModifierLabel2.Location = new System.Drawing.Point(5, 325);
            this.spellMagicModifierLabel2.Name = "spellMagicModifierLabel2";
            this.spellMagicModifierLabel2.Size = new System.Drawing.Size(79, 13);
            this.spellMagicModifierLabel2.TabIndex = 24;
            this.spellMagicModifierLabel2.Text = "Magic Modifier:";
            // 
            // spellBaseDamageLabel2
            // 
            this.spellBaseDamageLabel2.Location = new System.Drawing.Point(5, 300);
            this.spellBaseDamageLabel2.Name = "spellBaseDamageLabel2";
            this.spellBaseDamageLabel2.Size = new System.Drawing.Size(77, 13);
            this.spellBaseDamageLabel2.TabIndex = 22;
            this.spellBaseDamageLabel2.Text = "Base Damage:";
            // 
            // spellLevelLabel2
            // 
            this.spellLevelLabel2.Location = new System.Drawing.Point(5, 275);
            this.spellLevelLabel2.Name = "spellLevelLabel2";
            this.spellLevelLabel2.Size = new System.Drawing.Size(39, 13);
            this.spellLevelLabel2.TabIndex = 20;
            this.spellLevelLabel2.Text = "Level: ";
            // 
            // spellDescriptionLabel2
            // 
            this.spellDescriptionLabel2.Location = new System.Drawing.Point(5, 250);
            this.spellDescriptionLabel2.Name = "spellDescriptionLabel2";
            this.spellDescriptionLabel2.Size = new System.Drawing.Size(89, 13);
            this.spellDescriptionLabel2.TabIndex = 18;
            this.spellDescriptionLabel2.Text = "Spell Description:";
            // 
            // spellNameLabel2
            // 
            this.spellNameLabel2.Location = new System.Drawing.Point(5, 225);
            this.spellNameLabel2.Name = "spellNameLabel2";
            this.spellNameLabel2.Size = new System.Drawing.Size(64, 13);
            this.spellNameLabel2.TabIndex = 16;
            this.spellNameLabel2.Text = "Spell Name:";
            // 
            // spellRichTextBox
            // 
            this.spellRichTextBox.Location = new System.Drawing.Point(205, 22);
            this.spellRichTextBox.MinimumSize = new System.Drawing.Size(28, 46);
            this.spellRichTextBox.Name = "spellRichTextBox";
            this.spellRichTextBox.Size = new System.Drawing.Size(220, 464);
            this.spellRichTextBox.TabIndex = 14;
            this.spellRichTextBox.TabStop = false;
            this.spellRichTextBox.Text = "";
            // 
            // spellAbilityTextBox
            // 
            this.spellAbilityTextBox.Location = new System.Drawing.Point(95, 175);
            this.spellAbilityTextBox.Name = "spellAbilityTextBox";
            this.spellAbilityTextBox.Size = new System.Drawing.Size(104, 20);
            this.spellAbilityTextBox.TabIndex = 6;
            this.spellAbilityTextBox.Text = "Ability";
            // 
            // spellAffinityTextBox
            // 
            this.spellAffinityTextBox.Location = new System.Drawing.Point(95, 150);
            this.spellAffinityTextBox.Name = "spellAffinityTextBox";
            this.spellAffinityTextBox.Size = new System.Drawing.Size(104, 20);
            this.spellAffinityTextBox.TabIndex = 5;
            this.spellAffinityTextBox.Text = "Affinity";
            // 
            // spellBaseMagicModifierTextBox
            // 
            this.spellBaseMagicModifierTextBox.Location = new System.Drawing.Point(95, 125);
            this.spellBaseMagicModifierTextBox.Name = "spellBaseMagicModifierTextBox";
            this.spellBaseMagicModifierTextBox.Size = new System.Drawing.Size(104, 20);
            this.spellBaseMagicModifierTextBox.TabIndex = 4;
            // 
            // spellBaseDamageTextBox
            // 
            this.spellBaseDamageTextBox.Location = new System.Drawing.Point(95, 100);
            this.spellBaseDamageTextBox.Name = "spellBaseDamageTextBox";
            this.spellBaseDamageTextBox.Size = new System.Drawing.Size(104, 20);
            this.spellBaseDamageTextBox.TabIndex = 3;
            // 
            // spellLevelTextBox
            // 
            this.spellLevelTextBox.Location = new System.Drawing.Point(95, 75);
            this.spellLevelTextBox.Name = "spellLevelTextBox";
            this.spellLevelTextBox.Size = new System.Drawing.Size(104, 20);
            this.spellLevelTextBox.TabIndex = 2;
            this.spellLevelTextBox.Text = "1";
            // 
            // spellDescriptionTextBox
            // 
            this.spellDescriptionTextBox.Location = new System.Drawing.Point(95, 50);
            this.spellDescriptionTextBox.Name = "spellDescriptionTextBox";
            this.spellDescriptionTextBox.Size = new System.Drawing.Size(104, 20);
            this.spellDescriptionTextBox.TabIndex = 1;
            this.spellDescriptionTextBox.Text = "Description";
            // 
            // spellNameTextBox
            // 
            this.spellNameTextBox.Location = new System.Drawing.Point(95, 25);
            this.spellNameTextBox.Name = "spellNameTextBox";
            this.spellNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.spellNameTextBox.TabIndex = 0;
            this.spellNameTextBox.Text = "Spell Name";
            // 
            // spellAbilityLabel
            // 
            this.spellAbilityLabel.Location = new System.Drawing.Point(5, 175);
            this.spellAbilityLabel.Name = "spellAbilityLabel";
            this.spellAbilityLabel.Size = new System.Drawing.Size(37, 13);
            this.spellAbilityLabel.TabIndex = 6;
            this.spellAbilityLabel.Text = "Ability:";
            // 
            // spellAffinityLabel
            // 
            this.spellAffinityLabel.Location = new System.Drawing.Point(5, 150);
            this.spellAffinityLabel.Name = "spellAffinityLabel";
            this.spellAffinityLabel.Size = new System.Drawing.Size(41, 13);
            this.spellAffinityLabel.TabIndex = 5;
            this.spellAffinityLabel.Text = "Affinity:";
            // 
            // spellMagicModifierLabel
            // 
            this.spellMagicModifierLabel.Location = new System.Drawing.Point(5, 125);
            this.spellMagicModifierLabel.Name = "spellMagicModifierLabel";
            this.spellMagicModifierLabel.Size = new System.Drawing.Size(79, 13);
            this.spellMagicModifierLabel.TabIndex = 4;
            this.spellMagicModifierLabel.Text = "Magic Modifier:";
            // 
            // spellBaseDamageLabel
            // 
            this.spellBaseDamageLabel.Location = new System.Drawing.Point(5, 100);
            this.spellBaseDamageLabel.Name = "spellBaseDamageLabel";
            this.spellBaseDamageLabel.Size = new System.Drawing.Size(77, 13);
            this.spellBaseDamageLabel.TabIndex = 3;
            this.spellBaseDamageLabel.Text = "Base Damage:";
            // 
            // spellLevelLabel
            // 
            this.spellLevelLabel.Location = new System.Drawing.Point(5, 75);
            this.spellLevelLabel.Name = "spellLevelLabel";
            this.spellLevelLabel.Size = new System.Drawing.Size(39, 13);
            this.spellLevelLabel.TabIndex = 2;
            this.spellLevelLabel.Text = "Level: ";
            // 
            // spellDescriptionLabel
            // 
            this.spellDescriptionLabel.Location = new System.Drawing.Point(5, 50);
            this.spellDescriptionLabel.Name = "spellDescriptionLabel";
            this.spellDescriptionLabel.Size = new System.Drawing.Size(89, 13);
            this.spellDescriptionLabel.TabIndex = 1;
            this.spellDescriptionLabel.Text = "Spell Description:";
            // 
            // spellNameLabel
            // 
            this.spellNameLabel.Location = new System.Drawing.Point(5, 25);
            this.spellNameLabel.Name = "spellNameLabel";
            this.spellNameLabel.Size = new System.Drawing.Size(64, 13);
            this.spellNameLabel.TabIndex = 0;
            this.spellNameLabel.Text = "Spell Name:";
            // 
            // randomiseChecklist
            // 
            this.randomiseChecklist.FormattingEnabled = true;
            this.randomiseChecklist.Items.AddRange(new object[] {
            "Stats",
            "Weapon",
            "Spells"});
            this.randomiseChecklist.Location = new System.Drawing.Point(1133, 94);
            this.randomiseChecklist.MultiColumn = true;
            this.randomiseChecklist.Name = "randomiseChecklist";
            this.randomiseChecklist.Size = new System.Drawing.Size(82, 49);
            this.randomiseChecklist.TabIndex = 18;
            // 
            // exportButton
            // 
            this.exportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportButton.Location = new System.Drawing.Point(1133, 149);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(81, 23);
            this.exportButton.TabIndex = 19;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // abilitiesGroupBox
            // 
            this.abilitiesGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abilitiesGroupBox.Controls.Add(this.addAbilityButton);
            this.abilitiesGroupBox.Controls.Add(this.abilityRichTextBox);
            this.abilitiesGroupBox.Controls.Add(this.abilityDescriptionTextBox);
            this.abilitiesGroupBox.Controls.Add(this.abilityNameTextBox);
            this.abilitiesGroupBox.Controls.Add(this.abilityDescription);
            this.abilitiesGroupBox.Controls.Add(this.abilityNameLabel);
            this.abilitiesGroupBox.Location = new System.Drawing.Point(891, 20);
            this.abilitiesGroupBox.Name = "abilitiesGroupBox";
            this.abilitiesGroupBox.Size = new System.Drawing.Size(236, 502);
            this.abilitiesGroupBox.TabIndex = 20;
            this.abilitiesGroupBox.TabStop = false;
            this.abilitiesGroupBox.Text = "Abilites";
            // 
            // addAbilityButton
            // 
            this.addAbilityButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAbilityButton.Location = new System.Drawing.Point(8, 72);
            this.addAbilityButton.MinimumSize = new System.Drawing.Size(27, 23);
            this.addAbilityButton.Name = "addAbilityButton";
            this.addAbilityButton.Size = new System.Drawing.Size(218, 23);
            this.addAbilityButton.TabIndex = 5;
            this.addAbilityButton.Text = "Add";
            this.addAbilityButton.UseVisualStyleBackColor = true;
            this.addAbilityButton.Click += new System.EventHandler(this.AddAbilityButton_Click);
            // 
            // abilityRichTextBox
            // 
            this.abilityRichTextBox.Location = new System.Drawing.Point(6, 100);
            this.abilityRichTextBox.Name = "abilityRichTextBox";
            this.abilityRichTextBox.Size = new System.Drawing.Size(220, 383);
            this.abilityRichTextBox.TabIndex = 4;
            this.abilityRichTextBox.Text = "";
            // 
            // abilityDescriptionTextBox
            // 
            this.abilityDescriptionTextBox.Location = new System.Drawing.Point(95, 50);
            this.abilityDescriptionTextBox.Name = "abilityDescriptionTextBox";
            this.abilityDescriptionTextBox.Size = new System.Drawing.Size(131, 20);
            this.abilityDescriptionTextBox.TabIndex = 3;
            this.abilityDescriptionTextBox.Text = "-Description";
            // 
            // abilityNameTextBox
            // 
            this.abilityNameTextBox.Location = new System.Drawing.Point(95, 25);
            this.abilityNameTextBox.Name = "abilityNameTextBox";
            this.abilityNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.abilityNameTextBox.TabIndex = 2;
            this.abilityNameTextBox.Text = "Ability Name";
            // 
            // abilityDescription
            // 
            this.abilityDescription.Location = new System.Drawing.Point(5, 50);
            this.abilityDescription.Name = "abilityDescription";
            this.abilityDescription.Size = new System.Drawing.Size(63, 13);
            this.abilityDescription.TabIndex = 1;
            this.abilityDescription.Text = "Description:";
            // 
            // abilityNameLabel
            // 
            this.abilityNameLabel.Location = new System.Drawing.Point(5, 25);
            this.abilityNameLabel.Name = "abilityNameLabel";
            this.abilityNameLabel.Size = new System.Drawing.Size(68, 13);
            this.abilityNameLabel.TabIndex = 0;
            this.abilityNameLabel.Text = "Ability Name:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 530);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.weaponGroupBox);
            this.Controls.Add(this.randomiseChecklist);
            this.Controls.Add(this.abilitiesGroupBox);
            this.Controls.Add(this.randomiseButton);
            this.Controls.Add(this.spellsGroupBox);
            this.Controls.Add(this.createGirl);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.characterGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MG Creator 1.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.characterGroupBox.ResumeLayout(false);
            this.characterGroupBox.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.weaponGroupBox.ResumeLayout(false);
            this.weaponGroupBox.PerformLayout();
            this.spellsGroupBox.ResumeLayout(false);
            this.spellsGroupBox.PerformLayout();
            this.abilitiesGroupBox.ResumeLayout(false);
            this.abilitiesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createGirl;
        private System.Windows.Forms.RichTextBox characterRichTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label affinity1Label;
        private System.Windows.Forms.Label affinity2Label;
        private System.Windows.Forms.TextBox affinity2TextBox;
        private System.Windows.Forms.TextBox affinity1TextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox titlesTextBox;
        private System.Windows.Forms.Label titlesLabel;
        private System.Windows.Forms.TextBox mgTextBox;
        private System.Windows.Forms.Label mgName;
        private System.Windows.Forms.GroupBox characterGroupBox;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.RichTextBox statsRichTextBox;
        private System.Windows.Forms.TextBox magicModifierTextBox;
        private System.Windows.Forms.TextBox baseResilienceTextBox;
        private System.Windows.Forms.TextBox baseDamageTextBox;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.Label magicModifierLabel;
        private System.Windows.Forms.Label baseResilienceLabel;
        private System.Windows.Forms.Label baseDamageLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label growthLabel;
        private System.Windows.Forms.Button randomiseButton;
        private System.Windows.Forms.ComboBox growthSelectionComboBox;
        private System.Windows.Forms.GroupBox weaponGroupBox;
        private System.Windows.Forms.Label weaponNameLabel;
        private System.Windows.Forms.TextBox weaponNameTextBox;
        private System.Windows.Forms.Label aptLabel;
        private System.Windows.Forms.Label weaponLevelLabel;
        private System.Windows.Forms.Label weaponAffinityLabel;
        private System.Windows.Forms.TextBox weaponAbilityTextBox;
        private System.Windows.Forms.TextBox weaponAffinityTextBox;
        private System.Windows.Forms.TextBox aptTextBox;
        private System.Windows.Forms.TextBox weaponLevelTextBox;
        private System.Windows.Forms.Label weaponAbilityLabel;
        private System.Windows.Forms.RichTextBox weaponRichTextBox;
        private System.Windows.Forms.GroupBox spellsGroupBox;
        private System.Windows.Forms.Label spellAbilityLabel;
        private System.Windows.Forms.Label spellAffinityLabel;
        private System.Windows.Forms.Label spellMagicModifierLabel;
        private System.Windows.Forms.Label spellBaseDamageLabel;
        private System.Windows.Forms.Label spellLevelLabel;
        private System.Windows.Forms.Label spellDescriptionLabel;
        private System.Windows.Forms.Label spellNameLabel;
        private System.Windows.Forms.TextBox spellAbilityTextBox;
        private System.Windows.Forms.TextBox spellAffinityTextBox;
        private System.Windows.Forms.TextBox spellBaseMagicModifierTextBox;
        private System.Windows.Forms.TextBox spellBaseDamageTextBox;
        private System.Windows.Forms.TextBox spellLevelTextBox;
        private System.Windows.Forms.TextBox spellDescriptionTextBox;
        private System.Windows.Forms.TextBox spellNameTextBox;
        private System.Windows.Forms.RichTextBox spellRichTextBox;
        private System.Windows.Forms.CheckedListBox randomiseChecklist;
        private System.Windows.Forms.TextBox spellAbilityTextBox2;
        private System.Windows.Forms.TextBox spellAffinityTextBox2;
        private System.Windows.Forms.TextBox spellBaseMagicModifierTextBox2;
        private System.Windows.Forms.TextBox spellBaseDamageTextBox2;
        private System.Windows.Forms.TextBox spellLevelTextBox2;
        private System.Windows.Forms.TextBox spellDescriptionTextBox2;
        private System.Windows.Forms.TextBox spellNameTextBox2;
        private System.Windows.Forms.Label spellAbilityLabel2;
        private System.Windows.Forms.Label spellAffinityLabel2;
        private System.Windows.Forms.Label spellMagicModifierLabel2;
        private System.Windows.Forms.Label spellBaseDamageLabel2;
        private System.Windows.Forms.Label spellLevelLabel2;
        private System.Windows.Forms.Label spellDescriptionLabel2;
        private System.Windows.Forms.Label spellNameLabel2;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox abilitiesGroupBox;
        private System.Windows.Forms.Label abilityNameLabel;
        private System.Windows.Forms.TextBox abilityNameTextBox;
        private System.Windows.Forms.Label abilityDescription;
        private System.Windows.Forms.TextBox abilityDescriptionTextBox;
        private System.Windows.Forms.RichTextBox abilityRichTextBox;
        private System.Windows.Forms.Button addAbilityButton;
    }
}


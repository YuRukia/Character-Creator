using MG_Creator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Start XML Documents
        XmlDocument Growth = new XmlDocument();
        XmlDocument Team = new XmlDocument();
        XmlDocument Locations = new XmlDocument();
        XmlDocument RandomisedStats = new XmlDocument();

        //Define Growth Lists
        List<string> GrowthNames = new List<string>();
        List<int> GrowthWeightings = new List<int>();
        List<KeyValuePair<string, double>> GrowthElements = new List<KeyValuePair<string, double>>();
        int growthTotal;
        string growthSelectedElement = string.Empty;

        //Define Team Lists
        List<string> TeamNames = new List<string>();
        List<int> TeamWeightings = new List<int>();
        List<KeyValuePair<string, double>> TeamElements = new List<KeyValuePair<string, double>>();
        int teamTotal;

        //Define Origin List
        List<string> OriginLocations = new List<string>();

        //Define Stat Lists
        List<KeyValuePair<double, double>> randomisedHealthStat = new List<KeyValuePair<double, double>>();
        List<KeyValuePair<double, double>> randomisedBaseDamageStat = new List<KeyValuePair<double, double>>();
        List<KeyValuePair<double, double>> randomisedBaseResilienceStat = new List<KeyValuePair<double, double>>();
        List<KeyValuePair<double, double>> randomisedMagicModifierStat = new List<KeyValuePair<double, double>>();
        List<KeyValuePair<double, double>> randomisedSpellBaseDamageStat = new List<KeyValuePair<double, double>>();
        List<KeyValuePair<double, double>> randomisedSpellMagicModifierStat = new List<KeyValuePair<double, double>>();

        // Note to self, make this an array/list later
        int statsCheck = 0; int weaponCheck = 0; int spellCheck = 0; int loadGrowth = 0; int loadTeam = 0;
        int loadLocation = 0; int loadHealth = 0; int loadWeapon = 0; int loadSpell = 0; int randomised = 0;

        public Form1()
        {
            InitializeComponent();
            randomiseChecklist.CheckOnClick = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadGrowth = 1;
            XMLReader();

            //Add Growth Names/Weightings to KeyPair
            for (int i = 0; i < GrowthNames.Count; i++)
            {
                GrowthElements.Add(new KeyValuePair<string, double>(GrowthNames[i], GrowthWeightings[i]));
                growthTotal += GrowthWeightings[i];
                growthSelectionComboBox.Items.Add(GrowthNames[i]);
            }

            //Adds Team Names/Weightings to KeyPair
            for (int i = 0; i < TeamNames.Count; i++)
            {
                TeamElements.Add(new KeyValuePair<string, double>(TeamNames[i], TeamWeightings[i]));
                teamTotal += TeamWeightings[i];
            }

            randomisedHealthStat.Add(new KeyValuePair<double, double>(0, 0));
            randomisedBaseDamageStat.Add(new KeyValuePair<double, double>(0, 0));
            randomisedBaseResilienceStat.Add(new KeyValuePair<double, double>(0, 0));
            randomisedMagicModifierStat.Add(new KeyValuePair<double, double>(0, 0));
            randomisedSpellBaseDamageStat.Add(new KeyValuePair<double, double>(0, 0));
            randomisedSpellMagicModifierStat.Add(new KeyValuePair<double, double>(0, 0));
        }

        private void createGirl_Click(object sender, EventArgs e)
        {
            characterRichTextBox.Font = new Font("Calibri", 12);
            characterRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            characterRichTextBox.Text = mgTextBox.Text + Environment.NewLine;
            characterRichTextBox.AppendText(nameTextBox.Text + Environment.NewLine + titlesTextBox.Text);
            characterRichTextBox.AppendText(Environment.NewLine + "Image Goes Here");

            abilityRichTextBox.Clear();
            abilityRichTextBox.Font = new Font("Calibri", 12);
            abilityRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Underline);
            abilityRichTextBox.SelectedText = "Health Controller" + Environment.NewLine;
            abilityRichTextBox.AppendText("-Increase Health by " + healthTextBox.Text + " per level" + Environment.NewLine + Environment.NewLine);
            abilityRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Underline);
            abilityRichTextBox.SelectedText += "Resilience Controller" + Environment.NewLine;
            abilityRichTextBox.AppendText("-Increase Base Resilience by " + baseResilienceTextBox.Text + " per level" + Environment.NewLine + Environment.NewLine);

            if (randomised == 0)
            {
                statsRichTextBox.Clear();
                statsRichTextBox.Font = new Font("Calibri", 12);
                statsRichTextBox.Text = "Health: " + healthTextBox.Text + Environment.NewLine;
                statsRichTextBox.AppendText("Base Damage: " + baseDamageTextBox.Text + Environment.NewLine);
                statsRichTextBox.AppendText("Base Resilience: " + baseResilienceTextBox.Text + Environment.NewLine);
                statsRichTextBox.AppendText("Magic Modifer: " + magicModifierTextBox.Text + Environment.NewLine + Environment.NewLine);
                statsRichTextBox.AppendText("Affinity: " + affinity1TextBox.Text + " | " + affinity2TextBox.Text + " | " + growthSelectionComboBox.Text);

                weaponRichTextBox.Clear();
                weaponRichTextBox.Font = new Font("Calibri", 12);
                weaponRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Underline);
                weaponRichTextBox.SelectedText = weaponNameTextBox.Text + Environment.NewLine;
                weaponRichTextBox.AppendText("Image Goes Here" + Environment.NewLine);
                weaponRichTextBox.AppendText("Level: " + weaponLevelTextBox.Text + Environment.NewLine);
                weaponRichTextBox.AppendText("Actions Per Turn: " + aptTextBox.Text + Environment.NewLine);
                weaponRichTextBox.AppendText("Affinity: " + weaponAffinityTextBox.Text + Environment.NewLine);
                weaponRichTextBox.AppendText("Ability: " + weaponAbilityTextBox.Text);

                spellRichTextBox.Clear();
                spellRichTextBox.Font = new Font("Calibri", 12);
                spellRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Bold);
                spellRichTextBox.SelectedText = spellNameTextBox.Text + Environment.NewLine;
                spellRichTextBox.AppendText(spellDescriptionTextBox.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Level: " + spellLevelTextBox.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Base Damage: " + spellBaseDamageTextBox.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Magic Modifier: " + spellBaseMagicModifierTextBox.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Affinity: " + spellAffinityTextBox.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Ability: " + spellAbilityTextBox.Text + Environment.NewLine + Environment.NewLine);

                spellRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Bold);
                spellRichTextBox.SelectedText = spellNameTextBox2.Text + Environment.NewLine;
                spellRichTextBox.AppendText(spellDescriptionTextBox2.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Level: " + spellLevelTextBox2.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Base Damage: " + spellBaseDamageTextBox2.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Magic Modifier: " + spellBaseMagicModifierTextBox2.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Affinity: " + spellAffinityTextBox2.Text + Environment.NewLine);
                spellRichTextBox.AppendText("Ability: " + spellAbilityTextBox2.Text);
            }
            else
            {
                if(statsCheck == 1)
                {
                    statsRichTextBox.Clear();
                    statsRichTextBox.Font = new Font("Calibri", 12);
                    statsRichTextBox.Text = "Health: " + healthTextBox.Text + Environment.NewLine;
                    statsRichTextBox.AppendText("Base Damage: " + baseDamageTextBox.Text + Environment.NewLine);
                    statsRichTextBox.AppendText("Base Resilience: " + baseResilienceTextBox.Text + Environment.NewLine);
                    statsRichTextBox.AppendText("Magic Modifer: " + magicModifierTextBox.Text + Environment.NewLine + Environment.NewLine);
                    statsRichTextBox.AppendText("Affinity: " + affinity1TextBox.Text + " | " + affinity2TextBox.Text + " | " + growthSelectionComboBox.Text);
                }

                if(weaponCheck == 1)
                {
                    weaponRichTextBox.Clear();
                    weaponRichTextBox.Font = new Font("Calibri", 12);
                    weaponRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Underline);
                    weaponRichTextBox.SelectedText = weaponNameTextBox.Text + Environment.NewLine;
                    weaponRichTextBox.AppendText("Image Goes Here" + Environment.NewLine);
                    weaponRichTextBox.AppendText("Level: " + weaponLevelTextBox.Text + Environment.NewLine);
                    weaponRichTextBox.AppendText("Actions Per Turn: " + aptTextBox.Text + Environment.NewLine);
                    weaponRichTextBox.AppendText("Affinity: " + weaponAffinityTextBox.Text + Environment.NewLine);
                    weaponRichTextBox.AppendText("Ability: " + weaponAbilityTextBox.Text);
                }

                if(spellCheck == 1)
                {
                    spellRichTextBox.Clear();

                    spellRichTextBox.Font = new Font("Calibri", 12);
                    spellRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Bold);
                    spellRichTextBox.SelectedText = spellNameTextBox.Text + Environment.NewLine;
                    spellRichTextBox.AppendText(spellDescriptionTextBox.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Level: " + spellLevelTextBox.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Base Damage: " + spellBaseDamageTextBox.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Magic Modifier: " + spellBaseMagicModifierTextBox.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Affinity: " + spellAffinityTextBox.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Ability: " + spellAbilityTextBox.Text + Environment.NewLine + Environment.NewLine);

                    spellRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Bold);
                    spellRichTextBox.SelectedText = spellNameTextBox2.Text + Environment.NewLine;
                    spellRichTextBox.AppendText(spellDescriptionTextBox2.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Level: " + spellLevelTextBox2.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Base Damage: " + spellBaseDamageTextBox2.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Magic Modifier: " + spellBaseMagicModifierTextBox2.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Affinity: " + spellAffinityTextBox2.Text + Environment.NewLine);
                    spellRichTextBox.AppendText("Ability: " + spellAbilityTextBox2.Text);
                }
            }

            statsCheck = 0;
            weaponCheck = 0;
            spellCheck = 0;
            randomised = 0;
        }

        private void AddAbilityButton_Click(object sender, EventArgs e)
        {
            // Fix this
            abilityRichTextBox.Font = new Font("Calibri", 12);
            abilityRichTextBox.SelectionFont = new Font("Calibri", 12, FontStyle.Underline);
            abilityRichTextBox.SelectedText += abilityNameTextBox.Text + Environment.NewLine;
            abilityRichTextBox.AppendText(abilityDescriptionTextBox.Text + Environment.NewLine + Environment.NewLine);
        }

        //Reads in XML files
        private void XMLReader()
        {
            int lowerTemp = 0;
            int upperTemp = 0;

            //Finds local directory (exe) and locates XML files
            string directory = Directory.GetCurrentDirectory();
            Growth.Load(directory + @"\Data\Growth.xml");
            Team.Load(directory + @"\Data\Team.xml");
            Locations.Load(directory + @"\Data\Locations.xml");
            RandomisedStats.Load(directory + @"\Data\RandomisedStats.xml");

            foreach (XmlNode teamWeights in Team.DocumentElement.SelectNodes("//Weighting"))
            {
                TeamWeightings.Add(int.Parse(teamWeights.InnerText));
            }

            if (loadGrowth == 1)
            {
                foreach (XmlNode growthNames in Growth.DocumentElement.SelectNodes("//Name"))
                {
                    GrowthNames.Add(growthNames.InnerText);
                }

                foreach (XmlNode growthWeightings in Growth.DocumentElement.SelectNodes("//Weighting"))
                {
                    GrowthWeightings.Add(int.Parse(growthWeightings.InnerText));
                }

                loadGrowth = 0;
            }

            if(loadTeam == 1)
            {
                foreach (XmlNode teamNames in Team.DocumentElement.SelectNodes("//Name"))
                {
                    TeamNames.Add(teamNames.InnerText);
                }

                foreach (XmlNode teamWeights in Team.DocumentElement.SelectNodes("//Weighting"))
                {
                    TeamWeightings.Add(int.Parse(teamWeights.InnerText));
                }

                loadTeam = 0;
            }

            if (loadLocation == 1)
            {
                foreach (XmlNode originLocations in Locations.DocumentElement.SelectNodes("//Location"))
                {
                    OriginLocations.Add(originLocations.InnerText);
                }

                loadLocation = 0;
            }

            if(loadHealth == 1)
            {
                foreach (XmlNode healthLower in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/HealthLower"))
                {
                    lowerTemp = int.Parse(healthLower.InnerText);
                }

                foreach (XmlNode healthUpper in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/HealthUpper"))
                {
                    upperTemp = int.Parse(healthUpper.InnerText);
                }

                randomisedHealthStat[0] = new KeyValuePair<double, double>(lowerTemp, upperTemp);

                loadHealth = 0;
            }

            if(loadWeapon == 1)
            {
                foreach (XmlNode baseDamageLower in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/BaseDamageLower"))
                {
                    lowerTemp = int.Parse(baseDamageLower.InnerText);
                }

                foreach (XmlNode baseDamageUpper in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/BaseDamageUpper"))
                {
                    upperTemp = int.Parse(baseDamageUpper.InnerText);
                }

                randomisedBaseDamageStat[0] = new KeyValuePair<double, double>(lowerTemp, upperTemp);

                foreach (XmlNode baseResilienceLower in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/BaseResilienceLower"))
                {
                    lowerTemp = int.Parse(baseResilienceLower.InnerText);
                }

                foreach (XmlNode baseResilienceUpper in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/BaseResilienceUpper"))
                {
                    upperTemp = int.Parse(baseResilienceUpper.InnerText);
                }

                randomisedBaseResilienceStat[0] = new KeyValuePair<double, double>(lowerTemp, upperTemp);

                foreach (XmlNode magicModifierLower in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/MagicModifierLower"))
                {
                    lowerTemp = int.Parse(magicModifierLower.InnerText);
                }

                foreach (XmlNode magicModifierUpper in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/MagicModifierUpper"))
                {
                    upperTemp = int.Parse(magicModifierUpper.InnerText);
                }

                randomisedMagicModifierStat[0] = new KeyValuePair<double, double>(lowerTemp, upperTemp);

                loadWeapon = 0;
            }

            if(loadSpell == 1)
            {
                foreach (XmlNode spellBaseDamageLower in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "//SpellBaseDamageLower"))
                {
                    lowerTemp = int.Parse(spellBaseDamageLower.InnerText);
                }

                foreach (XmlNode spellBaseDamageUpper in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "//SpellBaseDamageUpper"))
                {
                    upperTemp = int.Parse(spellBaseDamageUpper.InnerText);
                }

                randomisedSpellBaseDamageStat[0] = new KeyValuePair<double, double>(lowerTemp, upperTemp);

                foreach (XmlNode spellMagicModifierLower in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/SpellMagicModifierLower"))
                {
                    lowerTemp = int.Parse(spellMagicModifierLower.InnerText);
                }

                foreach (XmlNode spellMagicModifierUpper in RandomisedStats.DocumentElement.SelectNodes(growthSelectedElement + "/SpellMagicModifierUpper"))
                {
                    upperTemp = int.Parse(spellMagicModifierUpper.InnerText);
                }

                randomisedSpellMagicModifierStat[0] = new KeyValuePair<double, double>(lowerTemp, upperTemp);

                loadSpell = 0;
            }
        }

        private void randomStatsButton_Click(object sender, EventArgs e)
        {
            //Define random choice variables
            Random rand = new Random();
            int growthDice = rand.Next(growthTotal);
            int teamDice = rand.Next(teamTotal);
            double cumulative = 0.0;

            //Make sure elements are empty
            string teamSelectedElement = string.Empty;
            string locationSelectedElement = string.Empty;

            if(growthSelectionComboBox.SelectedIndex == -1)
            {
                // Randomly select a result according to weighting
                for (int i = 0; i < GrowthElements.Count; i++)
                {
                    cumulative += GrowthElements[i].Value;
                    if (growthDice < cumulative)
                    {
                        growthSelectedElement = GrowthElements[i].Key;
                        if (growthSelectionComboBox.Items.Contains(growthSelectedElement))
                        {
                            growthSelectionComboBox.SelectedItem = growthSelectedElement;
                            if (growthSelectedElement.Contains(" "))
                            {
                                growthSelectedElement = growthSelectedElement.Replace(" ", "_");
                            }
                            loadGrowth = 1; loadTeam = 1; loadLocation = 1; loadHealth = 1; loadWeapon = 1; loadSpell = 1;
                            XMLReader();
                        }
                        cumulative = 0.0;
                        break;
                    }
                }
            }

            statsCheck = Convert.ToInt32(randomiseChecklist.GetItemCheckState(0));
            weaponCheck = Convert.ToInt32(randomiseChecklist.GetItemCheckState(1));
            spellCheck = Convert.ToInt32(randomiseChecklist.GetItemCheckState(2));

            if (statsCheck == 1)
            {
                healthTextBox.Text = Convert.ToInt32(Math.Round((randomisedHealthStat[0].Key + rand.Next(Convert.ToInt32(randomisedHealthStat[0].Value) - Convert.ToInt32(randomisedHealthStat[0].Key))) / 5) * 5).ToString();
                baseDamageTextBox.Text = Convert.ToInt32(Math.Round((randomisedBaseDamageStat[0].Key + rand.Next(Convert.ToInt32(randomisedBaseDamageStat[0].Value) - Convert.ToInt32(randomisedBaseDamageStat[0].Key))) / 5) * 5).ToString();
                baseResilienceTextBox.Text = Convert.ToInt32(Math.Round((randomisedBaseResilienceStat[0].Key + rand.Next(Convert.ToInt32(randomisedBaseResilienceStat[0].Value) - Convert.ToInt32(randomisedBaseResilienceStat[0].Key))) / 5) * 5).ToString();
                magicModifierTextBox.Text = Convert.ToInt32(Math.Round((randomisedMagicModifierStat[0].Key + rand.Next(Convert.ToInt32(randomisedMagicModifierStat[0].Value) - Convert.ToInt32(randomisedMagicModifierStat[0].Key))) / 5) * 5).ToString();
            }

            if(weaponCheck == 1)
            {

            }

            if(spellCheck == 1)
            {
                spellBaseDamageTextBox.Text = Convert.ToInt32(Math.Round((randomisedSpellBaseDamageStat[0].Key + rand.Next(Convert.ToInt32(randomisedSpellBaseDamageStat[0].Value) - Convert.ToInt32(randomisedSpellBaseDamageStat[0].Key))) / 5) * 5).ToString();
                spellBaseMagicModifierTextBox.Text = Convert.ToInt32(Math.Round((randomisedSpellMagicModifierStat[0].Key + rand.Next(Convert.ToInt32(randomisedSpellMagicModifierStat[0].Value) - Convert.ToInt32(randomisedSpellMagicModifierStat[0].Key))) / 5) * 5).ToString();

                loadSpell = 1;
                XMLReader();

                spellBaseDamageTextBox2.Text = Convert.ToInt32(Math.Round((randomisedSpellBaseDamageStat[0].Key + rand.Next(Convert.ToInt32(randomisedSpellBaseDamageStat[0].Value) - Convert.ToInt32(randomisedSpellBaseDamageStat[0].Key))) / 5) * 5).ToString();
                spellBaseMagicModifierTextBox2.Text = Convert.ToInt32(Math.Round((randomisedSpellMagicModifierStat[0].Key + rand.Next(Convert.ToInt32(randomisedSpellMagicModifierStat[0].Value) - Convert.ToInt32(randomisedSpellMagicModifierStat[0].Key))) / 5) * 5).ToString();
            }

            randomised = 1;
            createGirl_Click(sender, e);

            // Randomly select a result according to weighting
            for (int i = 0; i < TeamElements.Count; i++)
            {
                cumulative += TeamElements[i].Value;
                if (teamDice < cumulative)
                {
                    teamSelectedElement = TeamElements[i].Key;
                    cumulative = 0.0;
                    break;
                }
            }

            // Randomly select a result
            // You can fuck off if you think I'm weighting over 230 countries by hand
            //locationSelectedElement = OriginLocations[rand.Next(OriginLocations.Count)];
        }

        private void growthSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(growthSelectionComboBox.Text != "")
            {
                growthSelectedElement = growthSelectionComboBox.SelectedItem.ToString();
                if (growthSelectedElement.Contains(" "))
                {
                    growthSelectedElement = growthSelectedElement.Replace(" ", "_");
                }
                loadGrowth = 1; loadTeam = 1; loadLocation = 1; loadHealth = 1; loadWeapon = 1; loadSpell = 1;
                XMLReader();
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            List<RichTextBox> exportText = new List<RichTextBox>();
            RichTextBox characterTextBox = new RichTextBox();
            RichTextBox statTextBox = new RichTextBox();
            RichTextBox weaponTextBox = new RichTextBox();
            RichTextBox spellTextBox = new RichTextBox();
            RichTextBox abilityTextBox = new RichTextBox();

            characterTextBox.Rtf = characterRichTextBox.Rtf;
            exportText.Add(characterTextBox);
            statTextBox.Rtf = statsRichTextBox.Rtf;
            exportText.Add(statTextBox);
            weaponTextBox.Rtf = weaponRichTextBox.Rtf;
            exportText.Add(weaponTextBox);
            spellTextBox.Rtf = spellRichTextBox.Rtf;
            exportText.Add(spellTextBox);
            abilityTextBox.Rtf = abilityRichTextBox.Rtf;
            exportText.Add(abilityTextBox);

            var newAppointment = new Export_Form(exportText);
            newAppointment.Show();
        }
    }
}

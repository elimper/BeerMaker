using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeerLibrary;

namespace BeerMaker
{
    public partial class beerCalcForm : Form
    {
        private const string BEERSTYLESFILE = "beer-styles.txt";
        private const string HOPSFILE = "hops.txt";
        private BeerUtility beerCalc = new BeerUtility();
        private Dictionary<string, int> fermentables = new Dictionary<string, int>();

        private decimal gallons;
        private decimal gravity = 0.00m;
        private decimal totalIBU = 0.00m;
        private decimal totalGravityPoints = 0.0m;
        public beerCalcForm()
        {
            InitializeComponent();
        }

        private void loadStyles()
        {
            try
            {
                System.IO.StreamReader fileReader = new System.IO.StreamReader(BEERSTYLESFILE);
                while (!fileReader.EndOfStream)
                {
                    string currentLine = fileReader.ReadLine();
                    beerStyleComboBox.Items.Add(currentLine);
                }
                fileReader.Close();
            }
            catch
            {
                MessageBox.Show("Styles did not load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void beerCalcForm_Load(object sender, EventArgs e)
        {
            loadStyles();
            loadHops();
            loadFermentables();
        }
        private void loadHops()
        {
            try
            {
                System.IO.StreamReader fileReader = new System.IO.StreamReader(HOPSFILE);
                while (!fileReader.EndOfStream)
                {
                    string currentLine = fileReader.ReadLine();
                    hopComboBox.Items.Add(currentLine);
                }
                fileReader.Close();
            }
            catch
            {
                MessageBox.Show("Hops did not load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadFermentables()
        {
            fermentables.Add("Pale Malt", 38);
            fermentables.Add("Crystal Malt", 34);
            fermentables.Add("Dark Malt", 26);
            fermentables.Add("LME", 38);
            fermentables.Add("DME", 40);
            fermentables.Add("Sugar", 46);
            
            foreach(string fermentable in fermentables.Keys)
            {
                fermentablesComboBox.Items.Add(fermentable);
            }

        }
        private void updateLabel()
        {
            recipeNameLabel.Text = beerNameTextBox.Text +
                            "\n" + beerStyleComboBox.SelectedItem.ToString() +
                            "\n" + batchSizeTextBox.Text + " gallon recipe" +
                            "\n" + "Gravity Points: " + totalGravityPoints.ToString("0.00") +
                            "\n" + "IBU: " + totalIBU.ToString("0.00");
        }

        private void resetHopAdditions()
        {
            hopComboBox.SelectedIndex = -1;
            alphaAcidTextBox.Text = "";
            hopOuncesTextBox.Text = "";
            hopMinutesTextBox.Text = "";
        }
        private void resetFermentableAdditions()
        {
            fermentWeightTextBox.Clear();
            fermentablesComboBox.SelectedIndex = -1;
            fermentablesComboBox.Focus();
        }
        private void startRecipeButton_Click(object sender, EventArgs e)
        {
            if(beerNameTextBox != null && beerNameTextBox.Text != "")
            {
                if(batchSizeTextBox != null && batchSizeTextBox.Text != "")
                {
                    //Will crash if typed in
                    if (beerStyleComboBox.SelectedItem != null 
                        || !beerStyleComboBox.SelectedItem.ToString().StartsWith("#")
                        || !beerStyleComboBox.SelectedItem.ToString().Equals(string.Empty))
                    {
                        if (!decimal.TryParse(batchSizeTextBox.Text, out gallons))
                        {
                            MessageBox.Show("Gallons must be a number","Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        fermentablesGroupBox.Visible = true;
                        hopGroupBox.Visible = true;
                        hopsListView.Visible = true;
                        fermentablesListView.Visible = true;
                        resetAllButton.Visible = true;
                        clearRecipeButton.Visible = true;
                        clearSelectedHopButton.Visible = true;
                        clearSelectedMaltButton.Visible = true;
                        updateLabel();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a beer name, style and batch size", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addHopButton_Click(object sender, EventArgs e)
        {
            decimal aa = 0;
            decimal ounces = 0;
            int minutes = 0;
            //empty box selection crashes
            if(hopComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a hop from the list.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!hopComboBox.SelectedItem.ToString().StartsWith("#")
                || !hopComboBox.SelectedItem.ToString().Equals(string.Empty)
                || hopComboBox.SelectedItem != null)
            {
                if (alphaAcidTextBox.Text != null || alphaAcidTextBox.Text != string.Empty)
                {
                    decimal.TryParse(alphaAcidTextBox.Text, out aa);
                    if (hopOuncesTextBox.Text != null || hopOuncesTextBox.Text != string.Empty)
                    {
                        decimal.TryParse(hopOuncesTextBox.Text, out ounces);
                        if (hopMinutesTextBox.Text != null || hopMinutesTextBox.Text != string.Empty)
                        {
                            int.TryParse(hopMinutesTextBox.Text, out minutes);
                            //add hop to recipe, update recipe readout
                            try
                            {
                                ListViewItem hop = new ListViewItem(hopComboBox.SelectedItem.ToString());
                                hopsListView.Items.Add(hop);
                                hop.SubItems.Add(beerCalc.calculateIBU(gallons, aa, ounces, gravity, minutes).ToString("0.00"));
                                totalIBU += beerCalc.calculateIBU(gallons, aa, ounces, gravity, minutes);
                                resetHopAdditions();
                                hopComboBox.Focus();
                                updateLabel();
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter all hop information.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addFermentableButton_Click(object sender, EventArgs e)
        {
            decimal lbs = 0;
            int efficiency = 0;
            if(fermentablesComboBox.SelectedItem != null)
            {
                if(fermentWeightTextBox.Text != null)
                {
                    decimal.TryParse(fermentWeightTextBox.Text, out lbs);
                    if (fermentablesComboBox.SelectedIndex == 0 || 
                        fermentablesComboBox.SelectedIndex == 1 || 
                        fermentablesComboBox.SelectedIndex == 2)
                    {
                        efficiency = 75;
                    }
                    else
                    {
                        efficiency = 100;
                    }
                    try
                    {
                        decimal gp = beerCalc.gravityPoints(fermentablesComboBox.SelectedItem.ToString(), lbs, gallons, efficiency);
                        ListViewItem fermentableItem = new ListViewItem(fermentablesComboBox.SelectedItem.ToString());
                        fermentablesListView.Items.Add(fermentableItem);
                        fermentableItem.SubItems.Add(gp.ToString());
                        totalGravityPoints += gp;
                        resetFermentableAdditions();
                        fermentablesComboBox.Focus();
                        updateLabel();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter all fermentable information.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            hopsListView.Items.Clear();
            fermentablesListView.Items.Clear();
            resetFermentableAdditions();
            resetHopAdditions();
            fermentablesGroupBox.Visible = false;
            hopGroupBox.Visible = false;
            hopsListView.Visible = false;
            fermentablesListView.Visible = false;
            resetAllButton.Visible = false;
            clearRecipeButton.Visible = false;
            clearSelectedHopButton.Visible = false;
            clearSelectedMaltButton.Visible = false;
            recipeNameLabel.Text = string.Empty;
            batchSizeTextBox.Text = string.Empty;
            beerNameTextBox.Text = string.Empty;
            beerStyleComboBox.SelectedIndex = -1;
            beerNameTextBox.Focus();
        }

        private void clearRecipeButton_Click(object sender, EventArgs e)
        {
            hopsListView.Items.Clear();
            fermentablesListView.Items.Clear();
            resetFermentableAdditions();
            resetHopAdditions();
        }

        private void clearSelectedHopButton_Click(object sender, EventArgs e)
        {
            hopsListView.SelectedItems.Clear();
        }

        private void clearSelectedMaltButton_Click(object sender, EventArgs e)
        {
            fermentablesListView.SelectedItems.Clear();
        }
    }
}

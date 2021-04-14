
namespace BeerMaker
{
    partial class beerCalcForm
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
            this.beerNameLabel = new System.Windows.Forms.Label();
            this.beerstyleLabel = new System.Windows.Forms.Label();
            this.batchSizeLabel = new System.Windows.Forms.Label();
            this.beerStyleComboBox = new System.Windows.Forms.ComboBox();
            this.beerNameTextBox = new System.Windows.Forms.TextBox();
            this.batchSizeTextBox = new System.Windows.Forms.TextBox();
            this.startRecipeButton = new System.Windows.Forms.Button();
            this.beerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.hopNameLabel = new System.Windows.Forms.Label();
            this.alphaAcidsLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.hopBoilLabel = new System.Windows.Forms.Label();
            this.hopComboBox = new System.Windows.Forms.ComboBox();
            this.hopGroupBox = new System.Windows.Forms.GroupBox();
            this.addHopButton = new System.Windows.Forms.Button();
            this.hopMinutesTextBox = new System.Windows.Forms.TextBox();
            this.hopOuncesTextBox = new System.Windows.Forms.TextBox();
            this.alphaAcidTextBox = new System.Windows.Forms.TextBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.hopsListView = new System.Windows.Forms.ListView();
            this.hopNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ibuCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fermentablesGroupBox = new System.Windows.Forms.GroupBox();
            this.efficiencyTextBox = new System.Windows.Forms.TextBox();
            this.efficiencyLabel = new System.Windows.Forms.Label();
            this.addFermentableButton = new System.Windows.Forms.Button();
            this.fermentablesComboBox = new System.Windows.Forms.ComboBox();
            this.fermentWeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fermentablesListView = new System.Windows.Forms.ListView();
            this.maltCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gravityCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.beerInfoGroupBox.SuspendLayout();
            this.hopGroupBox.SuspendLayout();
            this.fermentablesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // beerNameLabel
            // 
            this.beerNameLabel.AutoSize = true;
            this.beerNameLabel.Location = new System.Drawing.Point(41, 18);
            this.beerNameLabel.Name = "beerNameLabel";
            this.beerNameLabel.Size = new System.Drawing.Size(87, 17);
            this.beerNameLabel.TabIndex = 0;
            this.beerNameLabel.Text = "Beer Name: ";
            // 
            // beerstyleLabel
            // 
            this.beerstyleLabel.AutoSize = true;
            this.beerstyleLabel.Location = new System.Drawing.Point(81, 45);
            this.beerstyleLabel.Name = "beerstyleLabel";
            this.beerstyleLabel.Size = new System.Drawing.Size(47, 17);
            this.beerstyleLabel.TabIndex = 1;
            this.beerstyleLabel.Text = "Style: ";
            // 
            // batchSizeLabel
            // 
            this.batchSizeLabel.AutoSize = true;
            this.batchSizeLabel.Location = new System.Drawing.Point(16, 74);
            this.batchSizeLabel.Name = "batchSizeLabel";
            this.batchSizeLabel.Size = new System.Drawing.Size(112, 17);
            this.batchSizeLabel.TabIndex = 2;
            this.batchSizeLabel.Text = "Batch Size (gal):";
            // 
            // beerStyleComboBox
            // 
            this.beerStyleComboBox.FormattingEnabled = true;
            this.beerStyleComboBox.Location = new System.Drawing.Point(135, 45);
            this.beerStyleComboBox.Name = "beerStyleComboBox";
            this.beerStyleComboBox.Size = new System.Drawing.Size(249, 24);
            this.beerStyleComboBox.TabIndex = 4;
            // 
            // beerNameTextBox
            // 
            this.beerNameTextBox.Location = new System.Drawing.Point(135, 17);
            this.beerNameTextBox.Name = "beerNameTextBox";
            this.beerNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.beerNameTextBox.TabIndex = 3;
            // 
            // batchSizeTextBox
            // 
            this.batchSizeTextBox.Location = new System.Drawing.Point(135, 74);
            this.batchSizeTextBox.Name = "batchSizeTextBox";
            this.batchSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.batchSizeTextBox.TabIndex = 5;
            // 
            // startRecipeButton
            // 
            this.startRecipeButton.Location = new System.Drawing.Point(290, 74);
            this.startRecipeButton.Name = "startRecipeButton";
            this.startRecipeButton.Size = new System.Drawing.Size(107, 38);
            this.startRecipeButton.TabIndex = 6;
            this.startRecipeButton.Text = "&Start Building";
            this.startRecipeButton.UseVisualStyleBackColor = true;
            this.startRecipeButton.Click += new System.EventHandler(this.startRecipeButton_Click);
            // 
            // beerInfoGroupBox
            // 
            this.beerInfoGroupBox.Controls.Add(this.startRecipeButton);
            this.beerInfoGroupBox.Controls.Add(this.batchSizeTextBox);
            this.beerInfoGroupBox.Controls.Add(this.beerNameTextBox);
            this.beerInfoGroupBox.Controls.Add(this.beerStyleComboBox);
            this.beerInfoGroupBox.Controls.Add(this.batchSizeLabel);
            this.beerInfoGroupBox.Controls.Add(this.beerstyleLabel);
            this.beerInfoGroupBox.Controls.Add(this.beerNameLabel);
            this.beerInfoGroupBox.Location = new System.Drawing.Point(34, 29);
            this.beerInfoGroupBox.Name = "beerInfoGroupBox";
            this.beerInfoGroupBox.Size = new System.Drawing.Size(403, 118);
            this.beerInfoGroupBox.TabIndex = 7;
            this.beerInfoGroupBox.TabStop = false;
            this.beerInfoGroupBox.Text = "Beer Info";
            // 
            // hopNameLabel
            // 
            this.hopNameLabel.AutoSize = true;
            this.hopNameLabel.Location = new System.Drawing.Point(42, 31);
            this.hopNameLabel.Name = "hopNameLabel";
            this.hopNameLabel.Size = new System.Drawing.Size(83, 17);
            this.hopNameLabel.TabIndex = 8;
            this.hopNameLabel.Text = "Hop Name: ";
            // 
            // alphaAcidsLabel
            // 
            this.alphaAcidsLabel.AutoSize = true;
            this.alphaAcidsLabel.Location = new System.Drawing.Point(83, 60);
            this.alphaAcidsLabel.Name = "alphaAcidsLabel";
            this.alphaAcidsLabel.Size = new System.Drawing.Size(42, 17);
            this.alphaAcidsLabel.TabIndex = 9;
            this.alphaAcidsLabel.Text = "AA% ";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(32, 90);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(93, 17);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount (oz): ";
            // 
            // hopBoilLabel
            // 
            this.hopBoilLabel.AutoSize = true;
            this.hopBoilLabel.Location = new System.Drawing.Point(23, 123);
            this.hopBoilLabel.Name = "hopBoilLabel";
            this.hopBoilLabel.Size = new System.Drawing.Size(102, 17);
            this.hopBoilLabel.TabIndex = 11;
            this.hopBoilLabel.Text = "Minutes in boil:";
            // 
            // hopComboBox
            // 
            this.hopComboBox.FormattingEnabled = true;
            this.hopComboBox.Location = new System.Drawing.Point(132, 27);
            this.hopComboBox.Name = "hopComboBox";
            this.hopComboBox.Size = new System.Drawing.Size(252, 24);
            this.hopComboBox.TabIndex = 12;
            // 
            // hopGroupBox
            // 
            this.hopGroupBox.Controls.Add(this.addHopButton);
            this.hopGroupBox.Controls.Add(this.hopMinutesTextBox);
            this.hopGroupBox.Controls.Add(this.hopOuncesTextBox);
            this.hopGroupBox.Controls.Add(this.alphaAcidTextBox);
            this.hopGroupBox.Controls.Add(this.hopComboBox);
            this.hopGroupBox.Controls.Add(this.hopBoilLabel);
            this.hopGroupBox.Controls.Add(this.amountLabel);
            this.hopGroupBox.Controls.Add(this.alphaAcidsLabel);
            this.hopGroupBox.Controls.Add(this.hopNameLabel);
            this.hopGroupBox.Location = new System.Drawing.Point(34, 187);
            this.hopGroupBox.Name = "hopGroupBox";
            this.hopGroupBox.Size = new System.Drawing.Size(406, 160);
            this.hopGroupBox.TabIndex = 13;
            this.hopGroupBox.TabStop = false;
            this.hopGroupBox.Text = "Hop Additions";
            this.hopGroupBox.Visible = false;
            // 
            // addHopButton
            // 
            this.addHopButton.Location = new System.Drawing.Point(290, 112);
            this.addHopButton.Name = "addHopButton";
            this.addHopButton.Size = new System.Drawing.Size(107, 38);
            this.addHopButton.TabIndex = 16;
            this.addHopButton.Text = "Add &Hop";
            this.addHopButton.UseVisualStyleBackColor = true;
            this.addHopButton.Click += new System.EventHandler(this.addHopButton_Click);
            // 
            // hopMinutesTextBox
            // 
            this.hopMinutesTextBox.Location = new System.Drawing.Point(132, 120);
            this.hopMinutesTextBox.Name = "hopMinutesTextBox";
            this.hopMinutesTextBox.Size = new System.Drawing.Size(100, 22);
            this.hopMinutesTextBox.TabIndex = 15;
            // 
            // hopOuncesTextBox
            // 
            this.hopOuncesTextBox.Location = new System.Drawing.Point(132, 87);
            this.hopOuncesTextBox.Name = "hopOuncesTextBox";
            this.hopOuncesTextBox.Size = new System.Drawing.Size(100, 22);
            this.hopOuncesTextBox.TabIndex = 14;
            // 
            // alphaAcidTextBox
            // 
            this.alphaAcidTextBox.Location = new System.Drawing.Point(132, 57);
            this.alphaAcidTextBox.Name = "alphaAcidTextBox";
            this.alphaAcidTextBox.Size = new System.Drawing.Size(100, 22);
            this.alphaAcidTextBox.TabIndex = 13;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Location = new System.Drawing.Point(485, 51);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(0, 17);
            this.recipeNameLabel.TabIndex = 14;
            // 
            // hopsListView
            // 
            this.hopsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hopNameCH,
            this.ibuCH});
            this.hopsListView.GridLines = true;
            this.hopsListView.HideSelection = false;
            this.hopsListView.Location = new System.Drawing.Point(488, 187);
            this.hopsListView.Name = "hopsListView";
            this.hopsListView.Size = new System.Drawing.Size(287, 160);
            this.hopsListView.TabIndex = 15;
            this.hopsListView.UseCompatibleStateImageBehavior = false;
            this.hopsListView.View = System.Windows.Forms.View.Details;
            this.hopsListView.Visible = false;
            // 
            // hopNameCH
            // 
            this.hopNameCH.Text = "Hop Name";
            this.hopNameCH.Width = 162;
            // 
            // ibuCH
            // 
            this.ibuCH.Text = "IBU";
            this.ibuCH.Width = 84;
            // 
            // fermentablesGroupBox
            // 
            this.fermentablesGroupBox.Controls.Add(this.efficiencyTextBox);
            this.fermentablesGroupBox.Controls.Add(this.efficiencyLabel);
            this.fermentablesGroupBox.Controls.Add(this.addFermentableButton);
            this.fermentablesGroupBox.Controls.Add(this.fermentablesComboBox);
            this.fermentablesGroupBox.Controls.Add(this.fermentWeightTextBox);
            this.fermentablesGroupBox.Controls.Add(this.label2);
            this.fermentablesGroupBox.Controls.Add(this.label1);
            this.fermentablesGroupBox.Location = new System.Drawing.Point(34, 373);
            this.fermentablesGroupBox.Name = "fermentablesGroupBox";
            this.fermentablesGroupBox.Size = new System.Drawing.Size(406, 127);
            this.fermentablesGroupBox.TabIndex = 16;
            this.fermentablesGroupBox.TabStop = false;
            this.fermentablesGroupBox.Text = "Fermentables";
            this.fermentablesGroupBox.Visible = false;
            // 
            // efficiencyTextBox
            // 
            this.efficiencyTextBox.Location = new System.Drawing.Point(121, 82);
            this.efficiencyTextBox.Name = "efficiencyTextBox";
            this.efficiencyTextBox.ReadOnly = true;
            this.efficiencyTextBox.Size = new System.Drawing.Size(100, 22);
            this.efficiencyTextBox.TabIndex = 8;
            // 
            // efficiencyLabel
            // 
            this.efficiencyLabel.AutoSize = true;
            this.efficiencyLabel.Location = new System.Drawing.Point(38, 82);
            this.efficiencyLabel.Name = "efficiencyLabel";
            this.efficiencyLabel.Size = new System.Drawing.Size(76, 17);
            this.efficiencyLabel.TabIndex = 7;
            this.efficiencyLabel.Text = "Efficiency: ";
            // 
            // addFermentableButton
            // 
            this.addFermentableButton.Location = new System.Drawing.Point(293, 82);
            this.addFermentableButton.Name = "addFermentableButton";
            this.addFermentableButton.Size = new System.Drawing.Size(107, 38);
            this.addFermentableButton.TabIndex = 6;
            this.addFermentableButton.Text = "Add to &Beer";
            this.addFermentableButton.UseVisualStyleBackColor = true;
            this.addFermentableButton.Click += new System.EventHandler(this.addFermentableButton_Click);
            // 
            // fermentablesComboBox
            // 
            this.fermentablesComboBox.FormattingEnabled = true;
            this.fermentablesComboBox.Location = new System.Drawing.Point(121, 22);
            this.fermentablesComboBox.Name = "fermentablesComboBox";
            this.fermentablesComboBox.Size = new System.Drawing.Size(263, 24);
            this.fermentablesComboBox.TabIndex = 5;
            // 
            // fermentWeightTextBox
            // 
            this.fermentWeightTextBox.Location = new System.Drawing.Point(121, 52);
            this.fermentWeightTextBox.Name = "fermentWeightTextBox";
            this.fermentWeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.fermentWeightTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight (lbs): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fermentable: ";
            // 
            // fermentablesListView
            // 
            this.fermentablesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maltCH,
            this.gravityCH});
            this.fermentablesListView.GridLines = true;
            this.fermentablesListView.HideSelection = false;
            this.fermentablesListView.Location = new System.Drawing.Point(488, 373);
            this.fermentablesListView.Name = "fermentablesListView";
            this.fermentablesListView.Size = new System.Drawing.Size(287, 144);
            this.fermentablesListView.TabIndex = 17;
            this.fermentablesListView.UseCompatibleStateImageBehavior = false;
            this.fermentablesListView.View = System.Windows.Forms.View.Details;
            this.fermentablesListView.Visible = false;
            // 
            // maltCH
            // 
            this.maltCH.Text = "Malt";
            this.maltCH.Width = 162;
            // 
            // gravityCH
            // 
            this.gravityCH.Text = "Gravity";
            this.gravityCH.Width = 84;
            // 
            // beerCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.fermentablesListView);
            this.Controls.Add(this.fermentablesGroupBox);
            this.Controls.Add(this.hopsListView);
            this.Controls.Add(this.recipeNameLabel);
            this.Controls.Add(this.hopGroupBox);
            this.Controls.Add(this.beerInfoGroupBox);
            this.Name = "beerCalcForm";
            this.Text = "Eli\'s Beer Calculator";
            this.Load += new System.EventHandler(this.beerCalcForm_Load);
            this.beerInfoGroupBox.ResumeLayout(false);
            this.beerInfoGroupBox.PerformLayout();
            this.hopGroupBox.ResumeLayout(false);
            this.hopGroupBox.PerformLayout();
            this.fermentablesGroupBox.ResumeLayout(false);
            this.fermentablesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beerNameLabel;
        private System.Windows.Forms.Label beerstyleLabel;
        private System.Windows.Forms.Label batchSizeLabel;
        private System.Windows.Forms.ComboBox beerStyleComboBox;
        private System.Windows.Forms.TextBox beerNameTextBox;
        private System.Windows.Forms.TextBox batchSizeTextBox;
        private System.Windows.Forms.Button startRecipeButton;
        private System.Windows.Forms.GroupBox beerInfoGroupBox;
        private System.Windows.Forms.Label hopNameLabel;
        private System.Windows.Forms.Label alphaAcidsLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label hopBoilLabel;
        private System.Windows.Forms.ComboBox hopComboBox;
        private System.Windows.Forms.GroupBox hopGroupBox;
        private System.Windows.Forms.TextBox hopMinutesTextBox;
        private System.Windows.Forms.TextBox hopOuncesTextBox;
        private System.Windows.Forms.TextBox alphaAcidTextBox;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.Button addHopButton;
        private System.Windows.Forms.ListView hopsListView;
        private System.Windows.Forms.ColumnHeader hopNameCH;
        private System.Windows.Forms.ColumnHeader ibuCH;
        private System.Windows.Forms.GroupBox fermentablesGroupBox;
        private System.Windows.Forms.ListView fermentablesListView;
        private System.Windows.Forms.ColumnHeader maltCH;
        private System.Windows.Forms.ColumnHeader gravityCH;
        private System.Windows.Forms.Button addFermentableButton;
        private System.Windows.Forms.ComboBox fermentablesComboBox;
        private System.Windows.Forms.TextBox fermentWeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox efficiencyTextBox;
        private System.Windows.Forms.Label efficiencyLabel;
    }
}


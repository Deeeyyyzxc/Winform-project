namespace VotingSystem;

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
    private void InitializeComponent()
    {
        
        
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
            
            this.titleLabel = new Label();
            this.option1RadioButton = new RadioButton();
            this.option2RadioButton = new RadioButton();
            this.option3RadioButton = new RadioButton();
            this.option4RadioButton = new RadioButton();
            this.voteButton = new Button();
            this.showResultsButton = new Button();
            this.resultsLabel = new Label();

            // Title Label
            this.titleLabel.Text = "Voting System";
            this.titleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(120, 20);

            // Option 1 RadioButton
            this.option1RadioButton.Text = "Option 1";
            this.option1RadioButton.Location = new System.Drawing.Point(50, 60);

            // Option 2 RadioButton
            this.option2RadioButton.Text = "Option 2";
            this.option2RadioButton.Location = new System.Drawing.Point(50, 90);

            // Option 3 RadioButton
            this.option3RadioButton.Text = "Option 3";
            this.option3RadioButton.Location = new System.Drawing.Point(50, 120);

            // Option 4 RadioButton
            this.option4RadioButton.Text = "Option 4";
            this.option4RadioButton.Location = new System.Drawing.Point(50, 150);

            // Vote Button
            this.voteButton.Text = "Vote";
            this.voteButton.Location = new System.Drawing.Point(50, 180);
            this.voteButton.Click += new EventHandler(this.VoteButton_Click);

            // Show Results Button
            this.showResultsButton.Text = "Show Results";
            this.showResultsButton.Location = new System.Drawing.Point(150, 180);
            this.showResultsButton.Click += new EventHandler(this.ShowResultsButton_Click);

            // Results Label
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(50, 220);

            // MainForm
            this.Text = "Voting System";
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.option1RadioButton);
            this.Controls.Add(this.option2RadioButton);
            this.Controls.Add(this.option3RadioButton);
            this.Controls.Add(this.option4RadioButton);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.showResultsButton);
            this.Controls.Add(this.resultsLabel);
            this.ClientSize = new System.Drawing.Size(300, 300);
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            if (option1RadioButton.Checked)
            {
                option1Votes++;
            }
            else if (option2RadioButton.Checked)
            {
                option2Votes++;
            }
            else if (option3RadioButton.Checked)
            {
                option3Votes++;
            }
            else if (option4RadioButton.Checked)
            {
                option4Votes++;
            }
            else
            {
                MessageBox.Show("Please select an option to vote.");
                return;
            }

            MessageBox.Show("Thank you for your vote!");
        }

        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
            string results = $"Option 1: {option1Votes} votes\n" +
                             $"Option 2: {option2Votes} votes\n" +
                             $"Option 3: {option3Votes} votes\n" +
                             $"Option 4: {option4Votes} votes";

            resultsLabel.Text = results;
        }
    }

    #endregion


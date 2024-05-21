namespace VotingSystem;

public partial class Form1 : Form
{
    private Label titleLabel;
        private RadioButton option1RadioButton;
        private RadioButton option2RadioButton;
        private RadioButton option3RadioButton;
        private RadioButton option4RadioButton;
        private Button voteButton;
        private Button showResultsButton;
        private Label resultsLabel;

        private int option1Votes = 0;
        private int option2Votes = 0;
        private int option3Votes = 0;
        private int option4Votes = 0;

    public Form1()
    {
        InitializeComponent();
    }
}

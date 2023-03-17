namespace Pokemon_5e_Suite
{
    public partial class Main : Form
    {
        public Main()
        {
            Globals.LoadSession();
            Globals.LoadTrainer();
            Globals.LoadPokemon();

            InitializeComponent();
        }

        // function to fetch all saved data and store into global lists
        private void OnMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
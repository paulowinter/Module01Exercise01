namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string enteredText = TextEntry.Text;
            string enteredEmail = EmailEntry.Text;
            DateTime selectedDate = DatePicker.Date;
            string enteredBio = Bio.Text;

            string message = $"Name: {enteredText}\nEmail: {enteredEmail}\nBirthday: {selectedDate.ToShortDateString()} \nBio: {enteredBio}";

            await DisplayAlert("Profile Updated!", message, "OK") ;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.White;
            this.Resources["DynamicColor"] = Colors.Gray;
            this.Resources["DynamicText"] = Colors.Black;
            this.Resources["DynamicText1"] = Colors.White;
        }
    }

}

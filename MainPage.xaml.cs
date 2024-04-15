namespace Module2LabB;
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculateAgeClicked(object sender, EventArgs e)
        {
            DateTime birthday = BirthdayPicker.Date;
            string selectedCountry = CountryPicker.SelectedItem as string;

            if (birthday == DateTime.MinValue)
            {
                ResultLabel.Text = "Please select your birthday.";
                return;
            }

            if (string.IsNullOrEmpty(selectedCountry))
            {
                ResultLabel.Text = "Please select your country.";
                return;
            }

            int age = CalculateAge(birthday);
            int yearsUntil21 = 21 - age;

            switch (selectedCountry)
            {
                case "United States":
                    ResultLabel.Text = $"You are {age} years old. {yearsUntil21} years until you are legal to drink in the {selectedCountry}.";
                    break;
                case "United Kingdom":
                    ResultLabel.Text = $"You are {age} years old. {yearsUntil21} years until you are legal to drink in the {selectedCountry}.";
                    break;
                case "Canada":
                    ResultLabel.Text = $"You are {age} years old. {yearsUntil21} years until you are legal to drink in {selectedCountry}.";
                    break;
                case "Germany":
                    ResultLabel.Text = $"You are {age} years old. {yearsUntil21} years until you are legal to drink in {selectedCountry}.";
                    break;
                default:
                    ResultLabel.Text = "Legal age information not available for the selected country.";
                    break;
            }
        }

        private int CalculateAge(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if (birthday.Date > today.AddYears(-age)) age--;
            return age;
        }
}



namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSpin_Clicked(object sender, EventArgs e)
        {
            
        }
            
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                SpinCountLabel.Text = picker.Items[selectedIndex].ToString();
               

                
            }
            


        }
    
    }
}

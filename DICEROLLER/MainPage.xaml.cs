

namespace DICEROLLER
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }

        private void BtnSpin_Clicked(object sender, EventArgs e)
        {
            int valor = 0;

            //Pegar o valor que foi selecionado pelo usuario no picker
            valor = Convert.ToInt32(SidesPicker.SelectedItem);
            //Jogar esse valor em uma variavel
            // sortear um numero em um dado utilizando o Random
            // Colocar o valor de uma varíavel 
            // Exibir o valor para o usuário na SpinCountLabel
            var valorSorteado = 0;
            valorSorteado = new Random().Next(1, valor+1);
            ResultLabel.Text = valorSorteado.ToString();
        }
    }
}

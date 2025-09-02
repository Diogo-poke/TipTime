namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       // private void OnCounterClicked(object sender, EventArgs e)
        //{
       //     count++;

       //     if (count == 1)
             //   CounterBtn.Text = $"Clicked {count} time";
         //   else
             //   CounterBtn.Text = $"Clicked {count} times";

            ///SemanticScreenReader.Announce(.Text);
      //  }

     private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
      {
            
      }

      private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
       {
            
              PorcentagemSlider.Value = 15;
       }

    private void RoundD_Clicked(object sender, EventArgs e)
      {

      }

       private void RooundU_Clicked(object sender, EventArgs e)
        {

        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
        }
    }

}

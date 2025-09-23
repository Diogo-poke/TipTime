using System.Numerics;


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
            try 
            {
                double porcentagem = PorcentagemSlider.Value;
                PorcentagemLabel.Text = $"{porcentagem}";
                double gorjeta;
                double valortotal = double.Parse(ValorTotalEntry.Text);
                gorjeta = valortotal * (porcentagem / 100);
                //double valortotal = Concert.ToDouble(ValorTotalEnty.Text)
                //Convert e uma classe
                //Parse é um metodo
                double valorfinal = valortotal + gorjeta;
               ValorGorjeta.Text = $"R$ {gorjeta}";
              //  ValorGorjeta.Text = Math.Floor(gorjeta.ToString(""));
                ValorFinal.Text = $"R$  {valorfinal}";
               // PorcentagemLabel.Text = Convert.ToString(PorcentagemSlider.Value);
            }
            catch(Exception ex) 
            { 
                //Toda vez que uso o comando Console.Writeline a saida vai para a consolena aba
               //output
              Console.WriteLine(ex.ToString());
                 DisplayAlert("Erro", "Digitre um valor numerico", "OK");
            }

        }

      private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
       {
            
              PorcentagemSlider.Value = 15;
       }

    private void RoundD_Clicked(object sender, EventArgs e)
      {
            double valorfinal = Convert.ToDouble(ValorTotalEntry.Text) ; 
            double valorArendondadoDown = Math.Floor(valorfinal);
            ValorFinal.Text= $" R$ {valorArendondadoDown}";
      }

       private void RooundU_Clicked(object sender, EventArgs e)
        {
            double valorfinal = Convert.ToDouble(ValorTotalEntry.Text);
            double valorArendondadoDown = Math.Ceiling(valorfinal);
            ValorFinal.Text = $" R$ {valorArendondadoDown}";
        }

        

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;
            
        }
    }

}

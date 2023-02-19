using System.Text;

namespace Desafio
{
    public class Combustivel
    {
        public Combustivel(double valorGasolina, double valorAlcool)
        {
            Validar(valorGasolina, valorAlcool);
            ValorGasolina = valorGasolina;
            ValorAlcool = valorAlcool;
        }      

        public double ValorGasolina { get; private set; }
        public double ValorAlcool { get; private set; }

        public double RelacaoPreco()
        {
            return Math.Round(ValorAlcool / ValorGasolina, 2) * 100;
        }

        private string ObterMelhorOpcao()
        {
            return RelacaoPreco() >= 65 ? "Álcool" : "Gasolina";
        }

        private void Validar(double valorGasolina, double valorAlcool)
        {
            if (valorGasolina <= 0 || valorAlcool <= 0)
                throw new ArgumentException("Os valores de combustível devem ser positivos");
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"A relação de preço é de ({RelacaoPreco()}%)");
            stringBuilder.AppendLine($"garante uma vantagem econômica para o motorista que escolher {ObterMelhorOpcao()} para abastecer o tanque do seu veículo.");

            return stringBuilder.ToString();
        }
    }
}

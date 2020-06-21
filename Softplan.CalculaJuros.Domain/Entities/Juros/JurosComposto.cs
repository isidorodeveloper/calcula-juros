using FluentValidator;
using FluentValidator.Validation;

namespace Softplan.CalculaJuros.Domain.Entities.Juros
{
    public class JurosComposto : Notifiable, IValidatable
    {
        public JurosComposto(decimal valorInicial, int tempo)
        {
            ValorInicial = valorInicial;
            Tempo = tempo;

            Validate();
        }

        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }

        public void Validate()
        {
            AddNotifications(new ValidationContract()
                .Requires()
                .IsGreaterThan(ValorInicial, 0, "ValorInicial", "Valor Inicial deve ser maior que 0!")
                .IsGreaterThan(Tempo, 0, "Tempo", "Tempo deve ser maior que 0!")
            );
        }
    }
}

//using Flunt.Notifications;
//using Flunt.Validations;
//using Softplan.CalculaJuros.Domain.Commands.Contracts;
//using System;

//namespace Softplan.CalculaJuros.Domain.Commands
//{
//    public class ObterTaxaJurosCommand : Notifiable, ICommand
//    {
//        public ObterTaxaJurosCommand() { }
//        public ObterTaxaJurosCommand(int taxa)
//        {
//            Taxa = taxa;
//        }

//        public int Taxa { get; set; }

//        public void Validate()
//        {
//            AddNotifications(
//                new Contract()
//                    .Requires()
//                    .AreEquals(Taxa, 0, 
//            ); ;
//        }
//    }
//}

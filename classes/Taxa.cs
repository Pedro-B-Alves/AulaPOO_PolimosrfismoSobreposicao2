using System;

namespace AulaPOO_PolimosrfismoSobreposicao2.classes
{
    public class Taxa
    {
        private float valor;

        public virtual void ValeRefeicao(){
            Console.WriteLine($"A taxa ser paga é de 5%");
        }
    }
}
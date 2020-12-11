using System;

namespace AulaPOO_PolimosrfismoSobreposicao2.classes
{
    public abstract class Taxa
    {
        private float valor = 5;

        public virtual void ValeRefeicao(){
            Console.WriteLine($"A taxa a ser paga é de {valor}%");
        }
    }
}
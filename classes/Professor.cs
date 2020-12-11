using System;

namespace AulaPOO_PolimosrfismoSobreposicao2.classes
{
    public class Professor : Taxa
    {
        public string turma;

        public override void ValeRefeicao(){
            Console.WriteLine($"A taxa do professor é de 10%");
        }
    }
}
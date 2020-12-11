using System;
using AulaPOO_PolimosrfismoSobreposicao2.classes;

namespace AulaPOO_PolimosrfismoSobreposicao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Coordenador coordenador = new Coordenador();
            Secretario secretario = new Secretario();
            Console.WriteLine("Taxa do professor");
            professor.ValeRefeicao();
            Console.WriteLine("Taxa do coordenador");
            coordenador.ValeRefeicao();
            Console.WriteLine("Taxa do secretario");
            secretario.ValeRefeicao();
        }
    }
}

using DadosProj;
namespace Frontend
{
    class Program
    {
        public static void Main()
        {
            int escolhaArea;
           
            Encapsulamento encapsulamento = new Encapsulamento();
            
            while (true)
            {
                Console.WriteLine("Escolha área do Programa: (1) Gerentes, (2) Utente, (3) Profissional de Saúde");
                escolhaArea = Convert.ToInt32(Console.ReadLine());


                switch (escolhaArea)
                {
                    case 1:
                        Console.Clear();
                        encapsulamento.MenuGerentes();
                        
                        break;
                    case 2:
                        Console.Clear();
                        encapsulamento.MenuUtente();
                        break;
                    case 3:
                        Console.Clear();
                        encapsulamento.MenuProfissionalSaude();
                        break;

                }
                if (!Encapsulamento.VoltarMenu())
                {
                    break;
                }
            }
        }
    }
}
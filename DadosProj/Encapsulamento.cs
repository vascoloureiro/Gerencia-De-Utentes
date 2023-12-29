using API_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProj
{
    public class Encapsulamento
    {

        Dictionary<string, Gestor> gestor = new Dictionary<string, Gestor>();
        Dictionary<int, Utente> utentes = new Dictionary<int, Utente>();
        Dictionary<string, Profissional_Saude> pf_Saude = new Dictionary<string, Profissional_Saude>();

        public Consultas Consultas
        {
            get => default;
            set
            {
            }
        }

        public Profissional_Saude_Funcional Profissional_Saude_Funcional
        {
            get => default;
            set
            {
            }
        }

        public GestorFuncional GestorFuncional
        {
            get => default;
            set
            {
            }
        }

        public UtentesFuncional UtentesFuncional
        {
            get => default;
            set
            {
            }
        }

        // Dictionary<string, Utente> utentes = Utente.CriarUtente();


        /// <summary>
        /// Menu respetivo ao Gestor/ Gerentes
        /// </summary>
        public void MenuGerentes()
        {
            int escolhaG;

            while (true)
            {
                Console.WriteLine("************** Gerente ********************");
                Console.WriteLine("*******************************************\n");
                Console.WriteLine("1. Adicionar um novo Gerente\n");
                Console.WriteLine("2. Salvar Gestor em ficheiro '.txt'\n");
                Console.WriteLine("*******************************************");
                Console.WriteLine("************* Utentes ********************");
                Console.WriteLine("*******************************************\n");
                Console.WriteLine("3. Inserir novos Utentes\n");
                Console.WriteLine("4. Ver Todos Os Utentes\n");
                Console.WriteLine("5. Ver Utentes infetados \n");
                Console.WriteLine("6.  Ver utentes por regiao\n");
                Console.WriteLine("*******************************************");
                Console.WriteLine("******************* Medico *****************");
                Console.WriteLine("*******************************************\n");
                Console.WriteLine("7. Inserir novo Medico.\n");
                Console.WriteLine("8. Procurar Medico(Nome).\n");
                Console.WriteLine("9. Ver Consultas Agendadas dos utentes.\n");
                Console.WriteLine("10. Agendar Consulta.\n\n");

                Console.WriteLine("0. Voltar");

                escolhaG = Convert.ToInt32(Console.ReadLine());

                switch (escolhaG)
                {
                    case 1:

                        Console.Clear();
                        Console.Write("Nome Gestor: ");
                        string nomeGestor = Console.ReadLine();

                        Console.Write("Departamento : ");
                        string departamento= Console.ReadLine();

                        Console.Write("Grupo: ");
                        string grupo = Console.ReadLine();

                        GestorFuncional.AddGestor(gestor, nomeGestor, departamento, grupo);
                        VoltarMenu();
                        Console.Clear();
                        break;
                    case 2:
                        
                        //VoltarMenu();
                        //Console.Clear();
                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine($"Numero Clincio: {Pessoa.MostrarNumeroUtentesClinico()}");

                        Console.Write("Nome Utente: ");
                        string nomeUtente = Console.ReadLine();

                        Console.Write("ID Utente: ");
                       // int id = int.Parse(Console.ReadLine());
                        string idInput= Console.ReadLine();
                        Console.Write("Idade Utente: ");
                        // int idade = int.Parse(Console.ReadLine());
                        string idadeInput= Console.ReadLine();  

                        Console.Write("Estado de Saúde (sim/nao): ");
                        //bool estadoSaudeInput = bool.Parse(Console.ReadLine());
                        string estadoSaudeInput= Console.ReadLine();
                        Console.Write("Região Utente: ");
                        string regiaoUtente = Console.ReadLine();


                        // UtentesFuncional.AddUtente(utentes, nomeUtente, id, idade, estadoSaude, regiaoUtente);
                        UtentesFuncional.AddUtente(utentes, nomeUtente, idInput, idadeInput, estadoSaudeInput, regiaoUtente);
                        VoltarMenu();

                        Console.Clear();
                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine("Todos os Utentes:");
                        UtentesFuncional.VerTodosUtentes(utentes); // por implementar
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Utentes Infetados:");
                        UtentesFuncional.MostrarUtentesInfetados(utentes);
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 6:

                        Console.Clear();
                        UtentesFuncional.MostrarUtentesPorRegiao(utentes);
                        VoltarMenu();
                        Console.Clear();

                        break;

                    case 7:

                        Console.Clear();

                        Console.WriteLine("Nome: ");
                        string nomeMedico = Convert.ToString(Console.ReadLine().ToLower());

                        Console.WriteLine($"Departamento Das Consultas: ");
                        string departamentoConsultas = Convert.ToString(Console.ReadLine().ToLower());

                        Profissional_Saude_Funcional.AddPs(pf_Saude, nomeMedico, departamentoConsultas);
                        VoltarMenu();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Profissional_Saude_Funcional.ProcurarPS(pf_Saude); // por implementar
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 9:
                        Console.Clear();
                        Consultas.VisualizarUtentesComConsultas(utentes);
                        VoltarMenu();
                        Console.Clear();
                        break;
                    case 10:

                        Console.Clear();
                        Consultas.MarcarConsultaPorNumeroClinico(utentes, pf_Saude);
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 0:
                        return; // Exit the method to go back to the main menu
                }
            }
        }

        /// <summary>
        /// Menu respetivo ao Utente
        /// </summary>
        public void MenuUtente()
        {
            int escolhaU;

            do
            {
                Console.WriteLine("1. Ver seus Dados\n");
                Console.WriteLine("2. Ver as suas Consultas\n");
                Console.WriteLine("3. Ver Medico com a qual tem consulta agendade\n");


                Console.WriteLine("0. Voltar");

                escolhaU = Convert.ToInt32(Console.ReadLine());

                switch (escolhaU)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o ID do Utente que deseja visualizar: ");
                        int idBusca = int.Parse(Console.ReadLine());
                        UtentesFuncional.VerUtentePorId(utentes, idBusca); // por implementar
                        VoltarMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Consultas.VerUtenteTemConsulta(utentes);
                        VoltarMenu();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Seu ID: ");
                        int buscaID = Convert.ToInt32(Console.ReadLine());
                        Profissional_Saude_Funcional.MostrarMedicoParaUtente(utentes, buscaID);
                        VoltarMenu();
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        return;
                }
            } while (VoltarMenu());
        }

        /// <summary>
        /// Menu respetivo ao Profissional de Saude
        /// </summary>
        public void MenuProfissionalSaude()
        {
            int escolhaU;

            while (true)
            {

                Console.WriteLine("1. Ver Dados Dos Utentes Infetados\n");
                Console.WriteLine("2. Ver Dados Dos Utentes Por Regiao\n");
                Console.WriteLine("3. Procurar Utente por ID.\n");
                Console.WriteLine("4. Marcar Consulta\n");
                Console.WriteLine("5. Agendar consulta com Medico\n");
                Console.WriteLine("6. Mostrar quantidade de utentes por medico\n");


                escolhaU = Convert.ToInt32(Console.ReadLine());

                switch (escolhaU)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Utentes Infetados:");
                        UtentesFuncional.MostrarUtentesInfetados(utentes);
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 2:

                        Console.Clear();
                        UtentesFuncional.MostrarUtentesPorRegiao(utentes);
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine("Insira o Id de Utente: ");
                        int idBusca = Convert.ToInt32(Console.ReadLine());
                        UtentesFuncional.VerUtentePorId(utentes, idBusca);
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 4:


                        Console.Clear();
                        Console.WriteLine("Insira o Id de Utente: ");
                        idBusca = Convert.ToInt32(Console.ReadLine());
                        Consultas.MarcarConsulta(utentes, idBusca);
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 5:

                        Console.Clear();
                        Consultas.MarcarConsultaPorNumeroClinico(utentes, pf_Saude);
                        VoltarMenu();
                        Console.Clear();
                        break;

                    case 6:

                        Console.Clear();
                        Console.WriteLine("Seu nome como medico\n");
                        string buscaNome = Convert.ToString(Console.ReadLine());
                        Profissional_Saude_Funcional.MostrarQuantidadeUtentesPorMedico(pf_Saude, buscaNome); // nao funciona                
                        VoltarMenu();
                        Console.Clear();
                        break;
                    case 0:
                        return;
                }
                Console.Clear();
            }
        }

        /// <summary>
        /// Meteodo que permite regressar ao menu anterior
        /// </summary>
        /// <returns></returns>
        public static bool VoltarMenu()
        {
            Console.WriteLine("Voltar?[s/n]\n");

            return Console.ReadLine().ToLower() == "s";
        }
    }
}

using API_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProj
{
    public class Consultas
    {
        #region Atributos

        private int numeroConsulta;
        private DateTime dataConsulta;
        private string tratamento;
        private Utente utente;


        //private Utente nomeUtente;

        #endregion

        #region Contrutores

        public Consultas(int numeroConsuta, int dataConsulta, string tratamento)
        {
            this.numeroConsulta = GerarNumeroConsulta();
            this.tratamento = tratamento;

        }
        #endregion

        #region Propriedades

        public int NumeroConsulta
        {
            get { return numeroConsulta; }
            set { numeroConsulta = value; }
        }

        public DateTime DataConsulta
        {
            get { return dataConsulta; }
            set { dataConsulta = value; }
        }

        public string Tratamento
        {
            get { return tratamento; }
            set { tratamento = value; }
        }

        #endregion

        #region Meteodos

        private static int ultimoNumeroConsulta = 1; // Manter o controle do último número de consulta atribuído

        public static void MarcarConsulta(Dictionary<int, Utente> utentes, int idBusca)
        {
            if (utentes.TryGetValue(idBusca, out Utente utente))
            {
                int numeroConsulta = GerarNumeroConsulta();
                utente.NumeroConsulta = numeroConsulta;

                Console.WriteLine($"Consulta Marcada para o Utente com ID {idBusca}; Numero de Consulta {numeroConsulta}");
            }
            else
            {
                Console.WriteLine($"Utente com ID {idBusca} não encontrado.");
            }
        }

        public static void VisualizarUtentesComConsultas(Dictionary<int, Utente> utentes)
        {
            Console.WriteLine("Utentes com Consultas Marcadas:");

            foreach (var utente in utentes.Values)
            {
                if (utente.NumeroConsulta > 0)
                {
                    Console.WriteLine($"Número Clinico: {utente.NumeroClinico}, Número da Consulta: {utente.NumeroConsulta}, ID Utente: {utente.ID}, Nome: {utente.NomeUtente}");
                }
            }
        }
        public static void AgendarComPS(Dictionary<int, Utente> utentes, int idUtente, int numeroConsulta, DateTime dataConsulta, string nomeMedico)
        {
            // Verifica se o Utente já tem uma consulta marcada
            if (utentes.TryGetValue(idUtente, out Utente utente))
            {
                if (utente.NumeroConsulta.HasValue)
                {
                    Console.WriteLine($"O Utente com Número Clínico {utente.NumeroClinico} já tem uma consulta marcada.");
                    return;
                }

                // Atribuir informações da consulta ao Utente
                utente.NumeroConsulta = numeroConsulta;
                utente.DataConsulta = dataConsulta;
                utente.NomeMedico = nomeMedico;


                Console.WriteLine($"Consulta marcada para o Utente com Número Clínico {utente.NumeroClinico}.");
                Console.WriteLine($"Número da Consulta: {utente.NumeroConsulta}, Data: {dataConsulta}, Médico: {nomeMedico}");
            }
            else
            {
                Console.WriteLine($"Utente com ID {idUtente} não encontrado.");
            }
        }

        public static void MarcarConsultaPorNumeroClinico(Dictionary<int, Utente> utentes, Dictionary<string, Profissional_Saude> profissionaisSaude)
        {
            Console.Write("\nDigite o Número de ID do Utente para marcar a consulta: ");
            string numeroClinicoBusca = Console.ReadLine();

            // Procurar o Utente pelo Número Clínico
            if (int.TryParse(numeroClinicoBusca, out int idUtente) && utentes.TryGetValue(idUtente, out Utente utente))
            {
                Console.WriteLine("\nEscolha um médico para a consulta");
                Profissional_Saude_Funcional.ApresentarDadosPS(profissionaisSaude); // Método para listar os médicos
                Console.Write("Digite o Nome do Médico: \n");
                string nomeMedico = Console.ReadLine();

                // Verificar se o médico existe
                if (profissionaisSaude.TryGetValue(nomeMedico, out Profissional_Saude pf_Saude))
                {
                    // Atribuir informações da consulta
                    int numeroConsulta = GerarNumeroConsulta();
                    DateTime dataConsulta = DateTime.Now; // Use a data atual, você pode ajustar conforme necessário
                    Consultas.AgendarComPS(utentes, idUtente, numeroConsulta, dataConsulta, nomeMedico);

                    Console.WriteLine($"\nConsulta marcada para o Utente com Número Clínico {numeroClinicoBusca}.\n");
                    Console.WriteLine($"Número da Consulta: {utente.NumeroConsulta}, Data: {dataConsulta}, Médico: {nomeMedico}");
                }
                else
                {
                    Console.WriteLine($"Médico com o nome {nomeMedico} não encontrado.");
                }
            }
            else
            {
                Console.WriteLine($"Utente com Número Clínico {numeroClinicoBusca} não encontrado ou o número clínico não é válido.");
            }
        }
        private static int GerarNumeroConsulta()
        {
            return ultimoNumeroConsulta++;
        }

        private void ListarProfissionaisSaude(Dictionary<string, Profissional_Saude> profissionionaisSaude)
        {
            Console.WriteLine("Lista de Profissionais de Saúde:");
            foreach (var profissional in profissionionaisSaude.Values)
            {
                Console.WriteLine($"Nome: {profissional.NomeMedico}, Departamento: {profissional.DepartamentoConsultas}");
            }
        }

        public static void MostrarMedicoParaUtente(Dictionary<int, Utente> utentes, int idUtente)
        {
            if (utentes.TryGetValue(idUtente, out Utente utente))
            {
                if (utente.NumeroConsulta.HasValue)
                {
                    Console.WriteLine($"Médico atribuído para a consulta do Utente com Número Clínico: {utente.NumeroClinico} -> {utente.NomeMedico}");
                }
                else
                {
                    Console.WriteLine($"O Utente com Número Clínico {utente.NumeroClinico} não tem uma consulta agendada.");
                }
            }
            else
            {
                Console.WriteLine($"Utente com ID {idUtente} não encontrado.");
            }
        }

        internal static void VerUtenteTemConsulta(Dictionary<int, Utente> utentes)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}

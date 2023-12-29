
using API_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProj
{
    public class Profissional_Saude_Funcional : Pessoa
    {
        public Consultas Consultas
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

        public static void AddPs(Dictionary<string, Profissional_Saude> pf_Saude, string nomeMedico, string departamentoConsultas)
        {
            Profissional_Saude.CriarPs(pf_Saude, nomeMedico, departamentoConsultas);
        }

        public static void ApresentarDadosPS(Dictionary<string, Profissional_Saude> profissionaisSaude)
        {
            Console.WriteLine("Lista de Médicos Disponíveis:");

            foreach (var profissional in profissionaisSaude.Values)
            {
                Console.WriteLine($"Numero Medico : {profissional.NumeroMedico},Nome: {profissional.NomeMedico}, Especialidade: {profissional.DepartamentoConsultas}");
                // Adicione outras informações relevantes do profissional, se necessário
            }
        }

        public static void ProcurarPS(Dictionary<string, Profissional_Saude> pf_Saude)
        {
            Console.Write("Digite o nome do profissional de saúde que deseja consultar: ");
            string nomeConsulta = Console.ReadLine();

            if (pf_Saude.ContainsKey(nomeConsulta))
            {
                Profissional_Saude profissionalConsultado = pf_Saude[nomeConsulta];

                Console.WriteLine("Informações do Profissional de Saúde:");
                Console.WriteLine($"Nome: {profissionalConsultado.NomeMedico}");
                Console.WriteLine($"Especialidade: {profissionalConsultado.DepartamentoConsultas}");
                // Adicione mais propriedades conforme necessário

                // Você também pode adicionar uma opção para editar ou realizar outras ações aqui

            }
            else
            {
                Console.WriteLine("Profissional de saúde não encontrado.");
            }
        }

        public static void MostrarQuantidadeUtentesPorMedico(Dictionary<string, Profissional_Saude>pf_Saude, string nomeMedico)
        {
            int quantidadeUtentes = 0;

            foreach (var utente in pf_Saude.Values)
            {
                if (utente.NomeMedico != null && utente.NomeMedico.Equals(nomeMedico, StringComparison.OrdinalIgnoreCase))
                {
                    quantidadeUtentes++;
                }
            }

            Console.WriteLine($"O médico {nomeMedico} tem {quantidadeUtentes} utente(s) agendado(s).");
        }
        public static void MostrarMedicoParaUtente(Dictionary<int, Utente> utentes, int idUtente)
        {
            if (utentes.TryGetValue(idUtente, out Utente utente))
            {
                if (utente.NumeroConsulta.HasValue)
                {
                    Console.WriteLine($"Médico atribuído para a consulta do Utente com Número Clínico {utente.NumeroClinico}: {utente.NomeMedico}");
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
    }
}

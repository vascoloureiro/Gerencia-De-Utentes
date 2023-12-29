using API_program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProj
{
    public class Texto
    {

        public UtentesFuncional UtentesFuncional
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

        public Consultas Consultas
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

        #region Gestor 
        public static bool AcrescentarGestor()
        {
            Console.WriteLine("Deseja inserir mais um gestor [s/n]?\n");
            string resposta = Convert.ToString(Console.ReadLine());
            if (resposta == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Gestor()
        {

        }

        #endregion


        #region Utentes
        public static void ListaUtentesInfetados(Utente utente)
        {
            Console.WriteLine(value: $"Numero Clinico: {utente.NumeroClinico}, Nome: {utente.NomeUtente}, ID: {utente.ID}, Idade: {utente.Idade}, Região: {utente.RegiaoUtente}");
        }

        public static void VerUtenteID(Utente utente)
        {

            Console.WriteLine($"Detalhes do Utente (ID: {utente.ID}):");
            Console.WriteLine($"Numero Clincio: {utente.NumeroClinico}");
            Console.WriteLine($"Nome Utente: {utente.NomeUtente}");
            Console.WriteLine($"Idade Utente: {utente.Idade}");
            Console.WriteLine($"Estado de Saúde: {(utente.EstadoSaude ? "Sim" : "Não")}");
            Console.WriteLine($"Região Utente: {utente.RegiaoUtente}");
        }

        public static void ApresentarInfoUtente(Utente utente)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Numero Clinico: {utente.NumeroClinico}");
            Console.WriteLine($"Nome: {utente.NomeUtente}");
            Console.WriteLine($"Idade: {utente.Idade}");
            Console.WriteLine($"Identificacao Civil: {utente.ID}");
            Console.WriteLine($"Região: {utente.RegiaoUtente}");
            Console.WriteLine($"Infetado: {utente.EstadoSaude}");
            Console.WriteLine("------------------------");
        }

        #endregion



        #region Profissional de Saude
        public void AcrecentarProfSaude()
        {
            Console.WriteLine("Deseja inserir mais um profissional saude [s/n]");
        }
        public static void ListaMedicosDisponiveis()
        {
            Console.WriteLine("Lista de Médicos Disponíveis:");
        }
        public static void InfoMedicoDisponivel(Profissional_Saude profissional)
        {
            Console.WriteLine($"Numero Medico : {profissional.NumeroMedico},Nome: {profissional.NomeMedico}, Especialidade: {profissional.DepartamentoConsultas}");
        }

        #endregion

    }
    public class Texto_Ex
    {

        public GestorFuncional GestorFuncional
        {
            get => default;
            set
            {
            }
        }

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

        public UtentesFuncional UtentesFuncional
        {
            get => default;
            set
            {
            }
        }
        #region General
        /// <summary>
        /// Mensagem de uma execeção em geral
        /// </summary>
        /// <param name="ex"></param>
        public static void ErroExecao(Exception ex)
        {
            Console.WriteLine($"Erro : {ex.Message}");
        }
        public static void ArgumentOutOfRange(Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }

        #endregion


        #region Gestor  
        public static void ErroSalvarArquivo(Exception ex)
        {
            Console.WriteLine($"Erro ao salvar os dados{ex.Message}");
        }

        public void Gestor()
        {

        }

        #endregion


        #region Utentes

        public static void IdNotFound(int idBusca)
        {
            Console.WriteLine($"Utente com o ID {idBusca} não encontrado.\n");
        }

        public static ArgumentOutOfRangeException ValorNegativo(int idBusca)
        {
            Console.WriteLine($"Utente com Id : {idBusca}, e invalido pois e um numero negativo");
            return new ArgumentOutOfRangeException(nameof(idBusca));
        }

        #endregion


        #region Profissional de Saude
        public void AcrecentarProfSaude()
        {
            Console.WriteLine("Deseja inserir mais um profissional saude [s/n]");
        }

        public static void ListaMedicosDisponiveis()
        {
            Console.WriteLine("Lista de Médicos Disponíveis:");
        }
        public static void InfoMedicoDisponivel(Profissional_Saude profissional)
        {
            Console.WriteLine($"Numero Medico : {profissional.NumeroMedico},Nome: {profissional.NomeMedico}, Especialidade: {profissional.DepartamentoConsultas}");

        }

        #endregion


    }
}

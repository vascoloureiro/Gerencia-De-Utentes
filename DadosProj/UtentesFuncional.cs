using API_program;

namespace DadosProj
{

    public class UtentesFuncional : Pessoa
    {
        //private int NumeroClinico;
        #region Construtor
        
        public UtentesFuncional(int NumeroClinico)
        {
            this.NumeroClinico = MostrarNumeroUtentesClinico();
        }
        #endregion

        #region Meteodos
        public static void AddUtente(Dictionary<int, Utente> utentes, string nomeUtente, string ID, string Idade, string EstadoSaude, string regiaoUtente)
        {
            //   Utente.CriarUtente(utentes, nomeUtente, id, idade, estadoSaude, regiaoUtente); 
            if (utentes == null)
            {
                throw new ArgumentNullException(nameof(utentes), "O dicionário de utentes não pode ser nulo.");
            }

            if (!int.TryParse(ID, out int id) || !int.TryParse(Idade, out int idade) || !bool.TryParse(EstadoSaude, out bool estadoSaude))
            {
                Console.WriteLine("Valor inserido inválido. Certifique-se de inserir números inteiros para ID e Idade e 'true' ou 'false' para Estado de Saúde.");
                // Permita que o usuário tente novamente se desejar
                return;
            }

            // Restante do código para adicionar o utente
            try
            {
                Utente.CriarUtente(utentes, nomeUtente, id, idade, estadoSaude, regiaoUtente);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar utente: {ex.Message}");
                // Permita que o usuário tente novamente se desejar
            }
        }

        public static void MostrarUtentesInfetados(Dictionary<int, Utente> utentes)
        {
            foreach (var utente in utentes.Values)
            {
                if (utente.EstadoSaude)
                {
                    Texto.ListaUtentesInfetados(utente);       
                }
            }
        }

        /// <summary>
        /// Mostra os Utentes por uma determinada regiao
        /// </summary>
        /// <param name="utentes"></param>
        public static void MostrarUtentesPorRegiao(Dictionary<int, Utente> utentes)
        {
            Console.Write("Filtrar Regiao: ");
            string regiaoFiltrar = Console.ReadLine();

            foreach (var utente in utentes.Values)
            {
                if (utente.RegiaoUtente.Equals(regiaoFiltrar, StringComparison.OrdinalIgnoreCase))
                {
                    //  Console.WriteLine($"Numero Clinico: {utente.NumeroClinico}, Nome: {utente.NomeUtente}, ID: {utente.ID}, Idade: {utente.Idade}, Região: {utente.RegiaoUtente}");
                    Texto.ListaUtentesInfetados(utente);
                
                }
            }
        }

        /// <summary>
        /// Permite procurar um utente pelo seu ID
        /// </summary>
        /// <param name="utentes"></param>
        public static void VerUtentePorId(Dictionary<int, Utente> utentes, int idBusca)
        {
            try
            {
                if(idBusca <0)
                {
                    throw new ArgumentOutOfRangeException(nameof(idBusca), Texto_Ex.ValorNegativo(idBusca));
                }

                if (utentes.ContainsKey(idBusca))
                {
                    Utente utente = utentes[idBusca];
                    Texto.VerUtenteID(utente);
                }
                else
                {
                   Texto_Ex.IdNotFound(idBusca);
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Texto_Ex.ArgumentOutOfRange(ex);
            }
            catch (KeyNotFoundException)
            {
                Texto_Ex.IdNotFound(idBusca);
            }
            catch (Exception ex) 
            {
                Texto_Ex.ErroExecao(ex);
            }
           
        }

        /// <summary>
        /// Permite ver todos os utentes
        /// </summary>
        /// <param name="utentes"></param>
        /// 
        public static void VerTodosUtentes(Dictionary<int, Utente> utentes)
        {
            foreach (var utente in utentes.Values)
            {
                //Console.WriteLine($"Numero Clinico: {utente.NumeroClinico}, Nome: {utente.NomeUtente}, ID: {utente.ID}, Idade: {utente.Idade}, Região: {utente.RegiaoUtente}");
                Texto.ListaUtentesInfetados(utente);
            
            }
        }

        /// <summary>
        /// Método para imprimir informações de um único utente
        /// </summary>
        /// <param name="utente"></param>
        public static void ImprimirInformacoesUtente(Utente utente)
        {
           Texto.ApresentarInfoUtente(utente);
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

        #endregion
    }
}
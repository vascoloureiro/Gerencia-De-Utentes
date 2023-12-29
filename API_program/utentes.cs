using static System.Net.Mime.MediaTypeNames;

namespace API_program
{
    public class Utente : Pessoa
    {
        #region Atributos

        /// <summary>
        /// Atributos
        /// </summary>

        private string nomeUtente;
        private int id;
        private int idade;
        private bool estadoSaude;
        private string regiaoUtente;
        internal DateTime DataConsulta;
        public string NomeMedico;
        private  int NumeroClinico;

        #endregion

        #region Meteodos

        #region Propriedades
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeUtente
        {
            get { return nomeUtente; }
            set { nomeUtente = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }

        }
        public bool EstadoSaude
        {
            get { return estadoSaude; }
            set { estadoSaude = value; }
        }
        public string RegiaoUtente
        {
            get { return regiaoUtente; }
            set { regiaoUtente = value; }

        }
        #endregion

        #region Construtores
        /// <summary>
        /// Construtores
        /// </summary>
        /// <param name="nomeUtente"></param>
        /// <param name="id"></param>
        /// <param name="idade"></param>
        /// <param name="estadoSaude"></param>
        /// <param name="regiaoUtente"></param>
        public Utente(string nomeUtente, int id, int idade, bool estadoSaude, string regiaoUtente)
        {
            this.nomeUtente = nomeUtente;
            this.id = id;
            this.idade = idade;
            this.estadoSaude = estadoSaude;
            this.regiaoUtente = regiaoUtente;
            this.NumeroClinico = MostrarNumeroUtentesClinico();
            this.NumeroConsulta = GerarNumeroConsulta();
            
        }
        #endregion

         #region Meteodos
        public static void CriarUtente(Dictionary<int, Utente> utentes, string nomeUtente, int id, int idade, bool estadoSaude, string regiaoUtente)
        {
   
                Utente utente = new Utente(nomeUtente, id, idade, estadoSaude, regiaoUtente);
                utentes.Add(utente.id, utente);
       
        }
          
            #endregion

        #endregion
    }

    public class Class1
    {
    }
}
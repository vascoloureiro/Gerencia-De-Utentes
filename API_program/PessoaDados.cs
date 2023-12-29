using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_program
{
    public class Pessoa
    {
        #region Atributos 

        static int UltimonumeroClinico = 1;
        static int UltimonumeroGerente = 1;
        static int UltimonumeroMedico = 1;
        static int UltimaConsulta = 1;

        int numeroClinico;
        int numeroGerente;
        int numeroMedico;
        private int? numeroConsulta;
        #endregion


        #region  Meteodos

        #region Propriedades
        /// <summary>
        /// Defenição das propriedades
        /// </summary>
        public int NumeroClinico
        {
            get { return numeroClinico; }
            set { numeroClinico = value; }
        }
        public int NumeroGerente
        {
            get { return numeroGerente; }
            set { numeroGerente = value; }
        }
        public int NumeroMedico
        {
            get { return numeroMedico; }
            set { numeroMedico = value; }
        }
        public int? NumeroConsulta
        {
            get { return numeroConsulta; }
            set { numeroConsulta = value; }
        }

        public DateTime DataConsulta { get; set; } = DateTime.Now;
        #endregion

        #region Contrutor

        /// <summary>
        /// Definição do construtor
        /// </summary>
        public Pessoa()
        {

            this.numeroClinico = UltimonumeroClinico;
            UltimonumeroClinico++;
            this.numeroMedico = UltimonumeroMedico;
            UltimonumeroMedico++;
            this.numeroGerente = UltimonumeroGerente;
            UltimonumeroGerente++;

            this.numeroConsulta = UltimaConsulta;
            UltimaConsulta++;
        }

        #endregion

        #region Meteodos

        /// <summary>
        /// Incrementa o Numero de Utente, por cada utente que é inserido
        /// </summary>
        /// <returns></returns>
        public static int MostrarNumeroUtentesClinico()
        {
            int numeroClinico = UltimonumeroClinico;
            UltimonumeroClinico++;
            return UltimonumeroClinico;

        }

        /// <summary>
        /// Incrementa o Numero de Gestor, por cada gestor inserido
        /// </summary>
        /// <returns></returns>
        public static int IncrementarNGestor()
        {
            int numeroGestor = UltimonumeroGerente;
            UltimonumeroGerente++;
            return numeroGestor;
        }

        /// <summary>
        /// Icrementa o numero de medico, por cada medico inserido
        /// </summary>
        /// <returns></returns>
        public static int IncrementarNMedico()
        {
            int numeroMedico = UltimonumeroMedico;
            UltimonumeroMedico++;
            return UltimonumeroMedico;

        }

        public static int GerarNumeroConsulta()
        {
            int numeroConsulta = UltimaConsulta;
            UltimaConsulta++;
            return numeroConsulta;

        }


        #endregion

        #endregion
    }
}

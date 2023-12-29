using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProj
{
    public class Clinica
    {
        #region Atributos 
        static int UltimoNumeroClinica = 1;
        int numeroClinica;

        /// <summary>
        /// Associação, Uma pessoa tem um CLinica
        /// </summary>
        //public Pessoa idC;
        #endregion

        #region Propriedades
        public int NumeroClinica
        {
            get { return numeroClinica; }
            set { numeroClinica = value; }
        }
        #endregion

        #region Contrutor

        public Clinica()
        {

            this.numeroClinica = UltimoNumeroClinica;
            UltimoNumeroClinica++;

        }

        #endregion

        #region Meteodos
        public static int MostrarNumeroUtentesClinico()
        {
            int numeroClinica = UltimoNumeroClinica;
            UltimoNumeroClinica += 2;
            return UltimoNumeroClinica;

        }

        ~Clinica() { }
        #endregion
    }
}

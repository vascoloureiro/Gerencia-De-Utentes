using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_program
{
    public class Profissional_Saude : Pessoa
    {
        #region Atributos


        private string nomeMedico;
        private string departamentoConsultas;
        private int numeroMedico;
        #endregion

        
        #region Meteodos 

        #region Propriedades
        public string NomeMedico
        {
            get { return nomeMedico; }
            set { nomeMedico = value; }
        }
        public string DepartamentoConsultas
        {
            get { return departamentoConsultas; }
            set { departamentoConsultas = value; }
        }

        public int NumeroMedico
        { 
            get;
            set;
        }
        
        #endregion

        #region Construtor
        public Profissional_Saude(string nomeMedico, string departamentoConsultas)
        {
            this.nomeMedico = nomeMedico;
            this.departamentoConsultas = departamentoConsultas;
            this.numeroMedico = IncrementarNMedico();

        }

        #endregion

        public static void CriarPs(Dictionary<string, Profissional_Saude> pf_Saude, string nomeMedico, string departamentoConsultas)
        {
           
            do
            {
                Profissional_Saude profissional = new Profissional_Saude(nomeMedico, departamentoConsultas);
                pf_Saude.Add(profissional.nomeMedico, profissional);

                Console.Write("Deseja inserir mais um profssional Saude? (s/n): ");
            }
            while (Convert.ToString(Console.ReadLine().ToLower()) == "s");

        }

        #endregion
    }
}

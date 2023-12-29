using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace API_program
{
    public class Gestor : Pessoa
    {
        #region Atribuitos

        /// <summary>
        /// Definição dos Atributos
        /// </summary>

        private string nomeGestor;
        private int id_Gestor;
        private string departamento;
        private string grupo;

        #endregion

        #region Meteodos

        #region Construtores
        /// <summary>
        /// Criaçao dos Construtores
        /// </summary>
        /// <param name="departamento"></param>
        /// <param name="grupo"></param>
        /// <param name="nomeGestor"></param>
        public Gestor(string departamento, string grupo, string nomeGestor)
        {
            this.nomeGestor = nomeGestor;
            ;
            this.departamento = departamento;
            this.grupo = grupo;

            // this.NumeroGerente = IncrementarNGestor(); // Herda a funcao presente na classe Clinica
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Defenicao das Propriedades
        /// </summary>
        public string NomeGestor
        {
            get { return nomeGestor; }
            set { nomeGestor = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        #endregion

        public static void CriarGestor(Dictionary<string, Gestor> gestores, string nomeGestor, string departamento, string grupo)
        {

            Gestor gestor = new Gestor(nomeGestor, departamento, grupo);
            gestores.Add(gestor.nomeGestor, gestor);
        }
        #endregion

        public static void Salvar(Gestor gestor)
        {
            string caminhoArquivo = "dados_gestores.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
            {
                // Escrever os dados no arquivo
                sw.WriteLine($"{gestor.NomeGestor},{gestor.Departamento},{gestor.Grupo}");
            }


        }



    }

}
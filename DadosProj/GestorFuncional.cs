using API_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProj
{
    public class GestorFuncional : Pessoa
    {
        public Consultas Consultas
        {
            get => default;
            set
            {
            }
        }

        public static void AddGestor(Dictionary<string, Gestor> gestores, string nomeGestor, string departamento, string grupo)
        {
            do
            {
                Gestor.CriarGestor(gestores, nomeGestor, departamento, grupo);
            }while(Texto.AcrescentarGestor()==true);
        }

        public static void Save_txt(Gestor gestor)
        {
            
            try
            {
                Gestor.Salvar(gestor);
            }
            catch (Exception ex) 
            {
                Texto_Ex.ErroSalvarArquivo(ex);
            }
           
        }

    }
}

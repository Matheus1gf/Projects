using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Setor
    {
        //prop + 2x[tab]
        public int IdSetor { get; set; } 
        public string Nome { get; set; }

        //Relacionamento de Associação (TER-MUITOS)
        public List<Funcionario> Funcionarios { get; set; }

        public Setor()
        {
                
        }

        public Setor(int idSetor, string nome)
        {
            IdSetor = idSetor;
            Nome = nome;
        }
    }
}

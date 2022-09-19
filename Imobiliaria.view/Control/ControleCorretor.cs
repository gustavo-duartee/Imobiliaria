using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.model;
using Imobiliaria.model.Repositories;

namespace Imobiliaria.view.Control
{
    public class ControleCorretor
    {
        RepositoryCorretor _Repository;

        public ControleCorretor()
        {
            _Repository = new RepositoryCorretor();
        }

        public void Incluir(model.Corretor oCorretor)
        {
            _Repository.Incluir(oCorretor);
        }
        public void Alterar(model.Corretor oCorretor)
        {
            _Repository.Alterar(oCorretor);
        }

        public void Remover(int cdCorretor)
        {
            _Repository.Excluir(cdCorretor);
        }

        public List<model.Corretor> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
    }
}

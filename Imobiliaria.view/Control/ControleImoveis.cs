using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.model;
using Imobiliaria.model.Repositories;

namespace Imobiliaria.view.Control
{
    public class ControleImoveis
    {
        RepositoryImoveis _Repository;

        public ControleImoveis()
        {
            _Repository = new RepositoryImoveis();
        }

        public void Incluir(model.Imoveis oImoveis)
        {
            _Repository.Incluir(oImoveis);
        }
        public void Alterar(model.Imoveis oImoveis)
        {
            _Repository.Alterar(oImoveis);
        }

        public void Remover(int cdImoveis)
        {
            _Repository.Excluir(cdImoveis);
        }

        public List<model.Imoveis> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
    }
}

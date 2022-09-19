using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.model;
using Imobiliaria.model.Repositories;

namespace Imobiliaria.view.Control
{
    public class ControleCliente
    {
        RepositoryCliente _Repository;

        public ControleCliente()
        {
            _Repository = new RepositoryCliente();
        }

        public void Incluir(model.Cliente oCliente)
        {
            _Repository.Incluir(oCliente);
        }
        public void Alterar(model.Cliente oCliente)
        {
            _Repository.Alterar(oCliente);
        }

        public void Remover(int cdCliente)
        {
            _Repository.Excluir(cdCliente);
        }

        public List<model.Cliente> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
    }
}

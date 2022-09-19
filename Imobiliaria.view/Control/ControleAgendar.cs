using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.model;
using Imobiliaria.model.Repositories;

namespace Imobiliaria.view.Control
{
    public class ControleAgendar
    {
        RepositoryAgendar _Repository;

        public ControleAgendar()
        {
            _Repository = new RepositoryAgendar();
        }

        public void Incluir(model.Agendar oAgendar)
        {
            _Repository.Incluir(oAgendar);
        }
        public void Alterar(model.Agendar oAgendar)
        {
            _Repository.Alterar(oAgendar);
        }

        public void Remover(int cdAgendar)
        {
            _Repository.Excluir(cdAgendar);
        }

        public List<model.Agendar> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
    }
}

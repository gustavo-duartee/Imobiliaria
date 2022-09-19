using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imobiliaria.model;
using Imobiliaria.model.Repositories;

namespace Imobiliaria.view.Control
{
   
    public class ControleReserva
    {
        RepositoryReserva _Repository;

        public ControleReserva()
        {
            _Repository = new RepositoryReserva();
        }

        public void Incluir(model.Reserva oReserva)
        {
            _Repository.Incluir(oReserva);
        }
        public void Alterar(model.Reserva oReserva)
        {
            _Repository.Alterar(oReserva);
        }

        public void Remover(int cdReserva)
        {
            _Repository.Excluir(cdReserva);
        }

        public List<model.Reserva> SelecionarTodos()
        {
            return _Repository.SelecionarTodos();
        }
    }
}

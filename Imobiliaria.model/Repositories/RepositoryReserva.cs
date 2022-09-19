using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Imobiliaria.model.Repositories
{
    public class RepositoryReserva
    {
        private bool RecebeuContexto = false;
        private IMOBILIARIAContext odb;

        public RepositoryReserva()
        {
            odb = new IMOBILIARIAContext();
        }

        public RepositoryReserva(IMOBILIARIAContext _odb)
        {
            odb = _odb;
            RecebeuContexto = true;
        }

        public void Incluir(Reserva oReserva)
        {
            try
            {
                odb.Reserva.Add(oReserva);
                odb.SaveChanges();
            }
            catch
            {
                return;
            }
        }
        public void Excluir(int cdReserva)
        {
            Reserva oReserva = odb.Reserva.Find(cdReserva);
            odb.Reserva.Remove(oReserva);
            odb.SaveChanges();
        }
        public void Alterar(Reserva oReserva)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oReserva).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Reserva> SelecionarTodos()
        {
            return odb.Reserva.ToList();
        }
    }
}

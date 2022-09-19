using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Imobiliaria.model.Repositories
{
    public class RepositoryCliente
    {
        private bool RecebeuContexto = false;
        private IMOBILIARIAContext odb;

        public RepositoryCliente()
        {
            odb = new IMOBILIARIAContext();
        }

        public RepositoryCliente(IMOBILIARIAContext _odb)
        {
            odb = _odb;
            RecebeuContexto = true;
        }

        public void Incluir(Cliente oCliente)
        {
            try
            {
                odb.Cliente.Add(oCliente);
                odb.SaveChanges();
            }
            catch
            {
                return;
            }
        }
        public void Excluir(int cdCliente)
        {
            Cliente oCliente = odb.Cliente.Find(cdCliente);
            odb.Cliente.Remove(oCliente);
            odb.SaveChanges();
        }
        public void Alterar(Cliente oCliente)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Cliente> SelecionarTodos()
        {
            return odb.Cliente.ToList();
        }
    }
}

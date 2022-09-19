using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Imobiliaria.model.Repositories
{
    public class RepositoryCorretor
    {
        private bool RecebeuContexto = false;
        private IMOBILIARIAContext odb;

        public RepositoryCorretor()
        {
            odb = new IMOBILIARIAContext();
        }

        public RepositoryCorretor(IMOBILIARIAContext _odb)
        {
            odb = _odb;
            RecebeuContexto = true;
        }

        public void Incluir(Corretor oCorretor)
        {
            try
            {
                odb.Corretor.Add(oCorretor);
                odb.SaveChanges();
            }
            catch
            {
                return;
            }
        }
        public void Excluir(int cdCorretor)
        {
            Corretor oCorretor = odb.Corretor.Find(cdCorretor);
            odb.Corretor.Remove(oCorretor);
            odb.SaveChanges();
        }
        public void Alterar(Corretor oCorretor)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oCorretor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Corretor> SelecionarTodos()
        {
            return odb.Corretor.ToList();
        }
    }
}

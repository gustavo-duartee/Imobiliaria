using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Imobiliaria.model.Repositories
{
    public class RepositoryAgendar
    {
        private bool RecebeuContexto = false;
        private IMOBILIARIAContext odb;

        public RepositoryAgendar()
        {
            odb = new IMOBILIARIAContext();
        }

        public RepositoryAgendar(IMOBILIARIAContext _odb)
        {
            odb = _odb;
            RecebeuContexto = true;
        }

        public void Incluir(Agendar oAgendar)
        {
            try
            {
                odb.Agendar.Add(oAgendar);
                odb.SaveChanges();
            }
            catch
            {
                return;
            }
        }
        public void Excluir(int cdAgendar)
        {
            Agendar oAgendar = odb.Agendar.Find(cdAgendar);
            odb.Agendar.Remove(oAgendar);
            odb.SaveChanges();
        }
        public void Alterar(Agendar oAgendar)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oAgendar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Agendar> SelecionarTodos()
        {
            return odb.Agendar.ToList();
        }
    }
}

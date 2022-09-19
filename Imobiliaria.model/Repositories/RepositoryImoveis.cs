using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Imobiliaria.model.Repositories
{
    public class RepositoryImoveis
    {
        private bool RecebeuContexto = false;
        private IMOBILIARIAContext odb;

        public RepositoryImoveis()
        {
            odb = new IMOBILIARIAContext();
        }

        public RepositoryImoveis(IMOBILIARIAContext _odb)
        {
            odb = _odb;
            RecebeuContexto = true;
        }

        public void Incluir(Imoveis oImoveis)
        {
            try
            {
                odb.Imoveis.Add(oImoveis);
                odb.SaveChanges();
            }
            catch
            {
                return;
            }
        }
        public void Excluir(int cdImoveis)
        {
            Imoveis oImoveis = odb.Imoveis.Find(cdImoveis);
            odb.Imoveis.Remove(oImoveis);
            odb.SaveChanges();
        }
        public void Alterar(Imoveis oImoveis)
        {
            odb.ChangeTracker.Clear();
            odb.Entry(oImoveis).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            odb.SaveChanges();
        }
        public List<Imoveis> SelecionarTodos()
        {
            return odb.Imoveis.ToList();
        }
    }
}
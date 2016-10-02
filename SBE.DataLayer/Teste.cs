using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

namespace SBE.DataLayer
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
    }
    public class UofW
    { 
        public void SaveProduct(Cliente cliente)
        {
            DbContext.Set<Cliente>().Attach(cliente);
            DbContext.Entry(cliente).State = EntityState.Modified;
            DbContext.SaveChanges();

        }
}

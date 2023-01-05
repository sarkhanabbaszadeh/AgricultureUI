using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfNewsDal : GenericRepository<News>, INewsDal
    {
        public void NewsStatusToFalse(int id)
        {
            using var context = new AgricultureContext();
            News n = context.Newses.Find(id);
            n.Status = false;
            context.SaveChanges();
        }

        public void NewsStatusToTrue(int id)
        {
            using var context = new AgricultureContext();
            News n = context.Newses.Find(id);
            n.Status = true;
            context.SaveChanges();
        }
    }
}

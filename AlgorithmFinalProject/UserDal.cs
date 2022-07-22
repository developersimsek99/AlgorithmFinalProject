using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmFinalProject
{
    public class UserDal
    {
        public List<User> GetAll2()
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                return context.Users.ToList();
            }
        }
        public void Add(User user)
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}

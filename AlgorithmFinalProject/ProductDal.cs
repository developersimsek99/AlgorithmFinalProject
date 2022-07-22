using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmFinalProject
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                return context.Products.ToList();
            }
        }
        public void Add(Product product)
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (EMarketingContext context = new EMarketingContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}

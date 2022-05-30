using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public ProductType Type { get; set; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}

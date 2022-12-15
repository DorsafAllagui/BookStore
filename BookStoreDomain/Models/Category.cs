using System.Collections.Generic;

namespace BookStoreDomain.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        /* EF Relations */
        public IEnumerable<Book> Books { get; set; }
    }
}
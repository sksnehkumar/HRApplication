using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class CategoryInfo
    {
        public CategoryInfo()
        {

        }

        public CategoryInfo(int categoryId, string name, string description, int createdBy, int lastModifiedBy)
        {
            CategoryId = categoryId;
            Name = name;
            Description = description;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

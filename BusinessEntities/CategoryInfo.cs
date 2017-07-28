using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CategoryInfo
    {
        public CategoryInfo()
        {

        }

        public CategoryInfo(int categoryId, string categoryName, string categoryDescription, int createdBy, int lastModifiedBy)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int CreatedBy { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

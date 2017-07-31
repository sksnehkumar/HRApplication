﻿using System;
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

        public CategoryInfo(string categoryName, string categoryDescription, int createdBy, DateTime ? createdDate, int lastModifiedBy, DateTime lastModifiedDate)
        {
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
            CreatedDate = createdDate;
        }

        public CategoryInfo(int categoryId, string categoryName, string categoryDescription, int createdBy, DateTime ? createdDate, int lastModifiedBy, DateTime lastModifiedDate)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ? CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        
    }
}

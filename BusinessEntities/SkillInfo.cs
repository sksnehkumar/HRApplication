using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class SkillInfo
    {
        public SkillInfo()
        {

        }
        public SkillInfo(int skillId, string skillName, string skillDescription, int categoryId, string categoryName, int createdBy, DateTime createdDate, int lastModifiedBy, DateTime lastModifiedDate)
        {
            SkillId = skillId;
            SkillName = skillName;
            SkillDescription = skillDescription;
            CategoryId = categoryId;
            CategoryName = categoryName;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

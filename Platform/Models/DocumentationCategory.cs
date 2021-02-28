﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Rokono_Control.Models
{
    public partial class DocumentationCategory
    {
        public DocumentationCategory()
        {
            DocumentationCategoryField = new HashSet<DocumentationCategoryField>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? DocumentationId { get; set; }

        public virtual Documentation Documentation { get; set; }
        public virtual ICollection<DocumentationCategoryField> DocumentationCategoryField { get; set; }
    }
}

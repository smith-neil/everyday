using System;
using System.Collections.Generic;

namespace Everyday.Core.Models {
    public class Category : BaseModel {
        public string Text { get; set ;}
        public ICollection<Task> Tasks { get; set; }
    }
}
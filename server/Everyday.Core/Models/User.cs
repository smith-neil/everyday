using System;
using System.Collections.Generic;

namespace Everyday.Core.Models {
    public class User : BaseModel {
        public ICollection<Task> Tasks { get; set; }
    }
}
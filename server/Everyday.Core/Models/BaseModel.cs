using System;

namespace Everyday.Core.Models {
    public abstract class BaseModel {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
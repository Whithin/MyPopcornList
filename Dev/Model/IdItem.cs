using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class IdItem
    {
        public virtual int Id { get; set; }

        public virtual DateTime CreatedAt { get; set; }

        public virtual DateTime UpdatedAt { get; set; }

        public virtual string? CreatedBy { get; set; }

        public virtual string? UpdatedBy { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.Data.Model
{
    class Status
    {
        public virtual long StatusId { get; set; }
        public virtual string Name { get; set; }
        public virtual long Ordinal { get; set; }
        public virtual byte[] Version { get; set; }
    }
}

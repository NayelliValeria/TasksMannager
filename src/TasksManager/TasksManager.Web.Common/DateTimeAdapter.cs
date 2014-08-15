using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManager.Web.Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
    class DateTimeAdapter : IDateTime
    {
        public DateTime UtcNow 
        {
            get { return DateTime.UtcNow; }
        }
    }
}

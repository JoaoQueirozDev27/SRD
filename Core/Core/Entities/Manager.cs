using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Manager
    {
        public IDGuid IDManager { get; private set; }
        public IDGuid IDEmployee { get; private set; }
        public DateTime StartedAt { get; private set; }
        public DateTime FinishedAt { get; private set; }
        public Manager(IDGuid iDManager, IDGuid iDEmployee, DateTime startedAt, DateTime finishedAt)
        {
            IDManager = iDManager;
            IDEmployee = iDEmployee;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
        }
    }
}

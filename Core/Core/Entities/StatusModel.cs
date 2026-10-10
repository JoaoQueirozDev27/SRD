using Domain.Enums;
using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StatusModel
    {
        public IDInt IDModel { get; private set; }
        public IDGuid IDEmployee { get; private set; }
        public IDGuid IDManager { get; private set; }
        public StatusModelType Status { get; private set; }

        public StatusModel(IDInt ID, IDGuid idEmployee,IDGuid idManager, StatusModelType status)
        {
            IDModel = ID;
            IDEmployee = idEmployee;
            Status = status;
        }
    }
}

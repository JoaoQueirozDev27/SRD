using Domain.value_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UseCases.Models.CreateModel.Exceptions;

namespace Application.UseCases.Models.CreateModel
{
    public record CreateModelRequest
    {
        public IDInt ID { get; private set; }
        public Name Name { get; private set; }

        private CreateModelRequest(IDInt id, Name name)
        {            
            if(id == null) throw new ArgumentNullException("ID can't be null" + nameof(id));
            ArgumentNullException.ThrowIfNull(name);
            ID = id;
            Name = name;
        }

        public static CreateModelRequest Create(int id, string name)
        {
            try
            {
                var idInt = new IDInt(id);
                var nameObj = Name.Create(name);
                return new CreateModelRequest(idInt, nameObj);
            }
            catch(Exception ex)
            {
                throw new CreateModelRequestException(ex.Message);
            }
        }

    }
}

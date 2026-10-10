using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Exceptions;
using Domain.value_objects;
using Application.UseCases.Models.CreateModel.Exceptions;

namespace Application.UseCases.Models.CreateModel
{
    public class CreateModelHandler
    {
        private readonly CreateModelRequest _request;
         
        public CreateModelHandler(CreateModelRequest request) {
            if(request == null) throw new ArgumentNullException(nameof(request));
            _request = request;
        } 

        public Model Handle()
        {
            try
            {
                var model = new Model(_request.ID, _request.Name);
                return model;
            }
            
            catch (Exception ex)
            {
                throw new CreateModelException(ex.Message);
            }
        }
    }
}

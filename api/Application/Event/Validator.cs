using Application.Event.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Event
{
    internal class Validator
    {
        private readonly Property.Interfaces.IRepository _propertyRepository;

        public Validator(Property.Interfaces.IRepository propertyRepository)
        {
            _propertyRepository = propertyRepository ?? throw new ArgumentNullException("propertyRepository");
        }

        public ValidationResult Validate(Dto.Model.Event @event)
        {
            var property = _propertyRepository.GetProperty(@event.PropertyID);

            return property != null
                ? new ValidationResult() { Success = true }
                : new ValidationResult()
                {
                    Errors = new Dto.Response.Model.Errors()
                    {
                        ErrorList = new List<Dto.Response.Model.Error>
                        {
                            new Dto.Response.Model.Error()
                            {
                                Id = Guid.NewGuid().ToString(),
                                Detail = "Invalid Property ID",
                                Status = HttpStatusCodes.BadRequestError.ToString(),
                                Title = "Invalid Request"
                            }
                        }
                    }
                };
        }
    }
}

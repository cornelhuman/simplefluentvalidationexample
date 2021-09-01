using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidationFilterTest.Models;

namespace ValidationFilterTest.Validator
{
    public class CreateContactRequestValidator : AbstractValidator<CreateContactRequest>
    {
        public CreateContactRequestValidator()
        {
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Id).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Id).LessThan(10);
        }
    }
}

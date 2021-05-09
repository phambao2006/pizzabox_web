using PizzaBox.Domain.Models;
using PizzaBox.Storing.UnitofWork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PizzaBox.Client.Models
{
    public class OrderMVC : IValidatableObject
    {
        public List<Crust> Crusts { get; set; }

        public List<Size> Sizes { get; set; }

        public List<Topping> Toppings { get; set; }
        [Required(ErrorMessage = "Please Select Crust")]
        public string SelectedCrust { get; set; }
        [Required(ErrorMessage ="Please Select Size")]
        public string SelectedSize { get; set; }
        [Required(ErrorMessage ="Please Select Toppings")]
        public List<string> SelectedToppings { get; set; }
        public void Load(UnitofWork unitofwork)
        {
            Crusts = unitofwork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
            Sizes = unitofwork.Sizes.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
            Toppings = unitofwork.Toppings.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
            {
                result.Add(new ValidationResult("Pizza Need At Least 2 Or At Most 5 Toppings", new[] { "SelectedToppings" })) ;
            }

            return result;
        }
    }
}
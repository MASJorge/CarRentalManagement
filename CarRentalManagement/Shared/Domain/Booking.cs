using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        public string VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; } /*ponemos al signo de pregunta para hacerlo nullable de esa manera no se pone lo que pone por defecto la base de datos*/
        public virtual Customer Customer { get; set; }
        [Required]
        public string CustomerId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(DateIn != null)
            {
                if(DateIn <= DateOut)
                {
                    yield return new ValidationResult("Date In must be greater than Date Out", new[] { "DateIn" });
                }
            }
        }
    }
}
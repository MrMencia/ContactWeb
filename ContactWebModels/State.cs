using System.ComponentModel.DataAnnotations;

namespace ContactWebModels
{
    internal class State
    {
        //State Model Class

        [Key]
        public int Id { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Name of State is Required")]
        [StringLength(ContactManagerConstants.MAX_STATE_LENGTH)]


        public string Name { get; set; }


        [Required(ErrorMessage = "State Abbreviation is required")]
        [StringLength(ContactManagerConstants.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace RESTraunter.Models
{
    public class Review 
    {
        //------ID
        public int id {get; set;}

        //------Reviewer Name
        [Required(ErrorMessage = "A reviewer's name must be entered!")]
        public string reviewerName {get; set;}

        //------Restaurant Name
        [Required(ErrorMessage = "A restaurant's name must be entered!")]
        public string restaurantName {get; set;}

        //------Review
        [Required(ErrorMessage = "A review must be entered!")]
        [MinLength(10, ErrorMessage = "Review must be at least 10 characters in length!")]
        public string review {get; set;}

        //------Stars
        public int stars {get; set;}

        //------Date
        [Required(ErrorMessage = "A date must be entered!")]
        [DataType(DataType.Date)]
        [ErrorFutureDate(ErrorMessage = "Date must be valid; can not be in the future!")]
        public DateTime date {get; set;}

        //------Created At
        public DateTime createdAt {get; set;}

        //------Updated At
        public DateTime updatedAt {get; set;}
    }

    //------Validator(s)
    public class ErrorFutureDate : ValidationAttribute
    {
        public override bool IsValid(object date)
        {
            DateTime inputDate = (DateTime)date;
            return inputDate < DateTime.Now;
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace credit_card_validator.Models;

public class CreditCardModel
{
    [Key] public long CardNumber { set; get; }

    [Required(ErrorMessage = "Please enter card holder's name")]
    [RegularExpression(@"^(4\d{16}|3[47]\d{15}|(22|5[1-5])\d{16}|6011\d{16})$", ErrorMessage = "Invalid card number")]
    public required string CardHolderName { set; get; }

    [Required(ErrorMessage = "Please enter expiration date")]
    public DateOnly ExpirationDate { set; get; }

    [Required(ErrorMessage = "Please enter cvv value")]
    public required int CVV { set; get; }

    [Required(ErrorMessage = "Please enter card bank name")]
    public required string IssuedBank { set; get; }
}
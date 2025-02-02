using System.ComponentModel.DataAnnotations;
using credit_card_validator.Utils;

namespace credit_card_validator.DTO;

public class CreditCardDTO
{
    //   [RegularExpression(@"^(4\d{16}|3[47]\d{15}|(22|5[1-5])\d{16}|6011\d{16})$", ErrorMessage = "Invalid card number")]
    public long CardNumber { set; get; }

    [Required(ErrorMessage = "Please enter card holder's name")]
    public required string CardHolderName { set; get; }

    [Required(ErrorMessage = "Please enter expiration date")]
    public DateOnly ExpirationDate { set; get; }

    [Required(ErrorMessage = "Please enter cvv value")]
    public required int Cvv { set; get; }

    [Required(ErrorMessage = "Please enter card bank name")]
    public required string IssuedBank { set; get; }

    [Required(ErrorMessage = "Please enter card type")]
    public required CardType CardType { set; get; }
}
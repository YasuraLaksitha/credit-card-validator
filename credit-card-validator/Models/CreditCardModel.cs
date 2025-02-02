using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Runtime.InteropServices.JavaScript;

namespace credit_card_validator.Models;

public class CreditCardModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public long CardNumber { set; get; }
    public required string CardHolderName { set; get; }
    public DateOnly ExpirationDate { set; get; }
    public required int Cvv { set; get; }
    public required string IssuedBank { set; get; }
    public required CardType CardType { set; get; }
}
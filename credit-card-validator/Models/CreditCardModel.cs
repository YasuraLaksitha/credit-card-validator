namespace credit_card_validator.Models;

public class CreditCardModel
{
    public long CardNumber { set; get; }
    public string CardHolderName { set; get; }
    public string ExpirationDate { set; get; }
    public int CVV { set; get; }
    public string IssuedBank { set; get; }
}
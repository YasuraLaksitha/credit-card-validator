using credit_card_validator.Models;
using Microsoft.EntityFrameworkCore;

namespace credit_card_validator.Context
{
    public class DataBaseContext(DbContextOptions<DataBaseContext> options) : DbContext(options)
    {
        public DbSet<CreditCardModel> CreditCards { get; set; }
    }
};
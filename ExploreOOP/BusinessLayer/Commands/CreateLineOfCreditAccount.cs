public record CreateLineOfCreditAccount
{
    public string Name { get; set; } = string.Empty;
    public decimal InitialBalance { get; set; }
    public decimal CreditLimit { get; set; }

}
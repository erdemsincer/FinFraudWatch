namespace FinFraudWatch.Shared.Contracts.Events;

public class TransactionCreatedEvent
{
    public int TransactionId { get; set; }
    public int UserId { get; set; }
    public decimal Amount { get; set; }
    public string Location { get; set; }
    public string Merchant { get; set; }
    public DateTime Timestamp { get; set; }
    public string DeviceInfo { get; set; }
}

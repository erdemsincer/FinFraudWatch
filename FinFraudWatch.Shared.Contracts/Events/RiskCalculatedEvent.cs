namespace FinFraudWatch.Shared.Contracts.Events;

public class RiskCalculatedEvent
{
    public int TransactionId { get; set; }
    public int UserId { get; set; }
    public int RiskScore { get; set; }         // 0-100
}

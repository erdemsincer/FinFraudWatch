namespace FinFraudWatch.Shared.Contracts.Events;

public class HighRiskActionTakenEvent
{
    public int TransactionId { get; set; }
    public int UserId { get; set; }
    public string Action { get; set; }         // Örnek: "Transaction Blocked" veya "User Notified"
}

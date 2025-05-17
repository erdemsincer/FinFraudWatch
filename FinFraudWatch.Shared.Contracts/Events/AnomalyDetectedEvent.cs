namespace FinFraudWatch.Shared.Contracts.Events;

public class AnomalyDetectedEvent
{
    public int TransactionId { get; set; }
    public int UserId { get; set; }
    public decimal AnomalyScore { get; set; }  // 0-1 arasında
    public string Reason { get; set; }         // Örnek: "Unusual location"
}

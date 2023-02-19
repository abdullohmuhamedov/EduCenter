using EduCenter.Domain.Enums;

namespace EduCenter.Domain.Entities;

public class CreditCard
{
    public int CreditCardId { get; set; }
    public string CardNumber { get; set; }
    private DateTime _defaultDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

    public DateTime Expiration
    {
        get { return _defaultDate; }
        set { _defaultDate = value; }
    }

    public string CardHolderName { get; set; }

    public PaymentType TypeOfPayment { get; set; }
}

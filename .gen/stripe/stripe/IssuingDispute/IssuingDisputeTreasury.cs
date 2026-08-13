using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingDispute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.issuingDispute.IssuingDisputeTreasury")]
    public class IssuingDisputeTreasury : stripe.IssuingDispute.IIssuingDisputeTreasury
    {
        /// <summary>The Treasury [ReceivedDebit](https://docs.stripe.com/api/treasury/received_debits) that is being disputed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_dispute#received_debit IssuingDispute#received_debit}
        /// </remarks>
        [JsiiProperty(name: "receivedDebit", typeJson: "{\"primitive\":\"string\"}")]
        public string ReceivedDebit
        {
            get;
            set;
        }
    }
}

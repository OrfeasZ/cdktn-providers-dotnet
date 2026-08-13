using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodBacsDebit")]
    public class PaymentMethodBacsDebit : stripe.PaymentMethod.IPaymentMethodBacsDebit
    {
        /// <summary>Account number of the bank account that the funds will be debited from.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountNumber
        {
            get;
            set;
        }

        /// <summary>Sort code of the bank account. (e.g., `10-20-30`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#sort_code PaymentMethod#sort_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sortCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortCode
        {
            get;
            set;
        }
    }
}

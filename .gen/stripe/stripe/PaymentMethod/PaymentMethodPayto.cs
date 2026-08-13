using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodPayto")]
    public class PaymentMethodPayto : stripe.PaymentMethod.IPaymentMethodPayto
    {
        /// <summary>The account number for the bank account.</summary>
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

        /// <summary>Bank-State-Branch number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bsb_number PaymentMethod#bsb_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bsbNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BsbNumber
        {
            get;
            set;
        }

        /// <summary>The PayID alias for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#pay_id PaymentMethod#pay_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PayId
        {
            get;
            set;
        }
    }
}

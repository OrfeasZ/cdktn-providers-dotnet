using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataPayto")]
    public class SetupIntentPaymentMethodDataPayto : stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto
    {
        /// <summary>The account number for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bsb_number SetupIntent#bsb_number}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#pay_id SetupIntent#pay_id}
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

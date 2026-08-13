using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit")]
    public class SetupIntentPaymentMethodDataBacsDebit : stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit
    {
        /// <summary>Account number of the bank account that the funds will be debited from.</summary>
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

        /// <summary>Sort code of the bank account. (e.g., `10-20-30`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sort_code SetupIntent#sort_code}
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

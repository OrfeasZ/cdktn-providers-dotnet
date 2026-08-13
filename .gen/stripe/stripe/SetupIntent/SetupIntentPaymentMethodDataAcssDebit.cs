using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit")]
    public class SetupIntentPaymentMethodDataAcssDebit : stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit
    {
        /// <summary>Customer's bank account number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_number SetupIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountNumber
        {
            get;
            set;
        }

        /// <summary>Institution number of the customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#institution_number SetupIntent#institution_number}
        /// </remarks>
        [JsiiProperty(name: "institutionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string InstitutionNumber
        {
            get;
            set;
        }

        /// <summary>Transit number of the customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#transit_number SetupIntent#transit_number}
        /// </remarks>
        [JsiiProperty(name: "transitNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string TransitNumber
        {
            get;
            set;
        }
    }
}

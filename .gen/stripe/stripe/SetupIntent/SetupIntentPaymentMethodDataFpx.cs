using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataFpx")]
    public class SetupIntentPaymentMethodDataFpx : stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx
    {
        /// <summary>The customer's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bank SetupIntent#bank}
        /// </remarks>
        [JsiiProperty(name: "bank", typeJson: "{\"primitive\":\"string\"}")]
        public string Bank
        {
            get;
            set;
        }

        /// <summary>Account holder type for FPX transaction.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#account_holder_type SetupIntent#account_holder_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountHolderType
        {
            get;
            set;
        }
    }
}

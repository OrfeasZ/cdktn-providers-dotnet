using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentMandateDataCustomerAcceptanceOnline")]
    public class SetupIntentMandateDataCustomerAcceptanceOnline : stripe.SetupIntent.ISetupIntentMandateDataCustomerAcceptanceOnline
    {
        /// <summary>The IP address from which the Mandate was accepted by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#ip_address SetupIntent#ip_address}
        /// </remarks>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string IpAddress
        {
            get;
            set;
        }

        /// <summary>The user agent of the browser from which the Mandate was accepted by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#user_agent SetupIntent#user_agent}
        /// </remarks>
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
        public string UserAgent
        {
            get;
            set;
        }
    }
}

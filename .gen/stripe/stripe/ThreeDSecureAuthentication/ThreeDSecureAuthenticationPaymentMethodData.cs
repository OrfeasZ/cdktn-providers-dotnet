using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodData")]
    public class ThreeDSecureAuthenticationPaymentMethodData : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#card ThreeDSecureAuthentication#card}.</summary>
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCard\"}")]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataCard Card
        {
            get;
            set;
        }

        /// <summary>The type of the PaymentMethod.</summary>
        /// <remarks>
        /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Billing information associated with the PaymentMethod that may be used or required by particular types of payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#billing_details ThreeDSecureAuthentication#billing_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetails\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetails? BillingDetails
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetails")]
    public class ThreeDSecureAuthenticationPaymentMethodDataBillingDetails : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetails
    {
        /// <summary>Billing address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#address ThreeDSecureAuthentication#address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress? Address
        {
            get;
            set;
        }

        /// <summary>Email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#email ThreeDSecureAuthentication#email}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Email
        {
            get;
            set;
        }

        /// <summary>Full name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#name ThreeDSecureAuthentication#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Billing phone number (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#phone ThreeDSecureAuthentication#phone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phone
        {
            get;
            set;
        }
    }
}

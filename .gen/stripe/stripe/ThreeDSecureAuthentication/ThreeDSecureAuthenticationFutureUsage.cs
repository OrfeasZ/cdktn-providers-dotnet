using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsage")]
    public class ThreeDSecureAuthenticationFutureUsage : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsage
    {
        /// <summary>The type of future usage declared for this 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Details about installment payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#installment ThreeDSecureAuthentication#installment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "installment", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageInstallment\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageInstallment? Installment
        {
            get;
            set;
        }

        /// <summary>Details about recurring payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#recurring ThreeDSecureAuthentication#recurring}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recurring", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageRecurring\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageRecurring? Recurring
        {
            get;
            set;
        }
    }
}

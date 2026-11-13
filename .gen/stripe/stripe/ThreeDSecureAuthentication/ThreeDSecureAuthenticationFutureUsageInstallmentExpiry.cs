using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageInstallmentExpiry")]
    public class ThreeDSecureAuthenticationFutureUsageInstallmentExpiry : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageInstallmentExpiry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#date ThreeDSecureAuthentication#date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Date
        {
            get;
            set;
        }
    }
}

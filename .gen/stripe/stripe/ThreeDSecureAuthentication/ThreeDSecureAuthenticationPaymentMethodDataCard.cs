using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCard")]
    public class ThreeDSecureAuthenticationPaymentMethodDataCard : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataCard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#cvc ThreeDSecureAuthentication#cvc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cvc
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#exp_month ThreeDSecureAuthentication#exp_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpMonth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#exp_year ThreeDSecureAuthentication#exp_year}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpYear
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#number ThreeDSecureAuthentication#number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Number
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#token ThreeDSecureAuthentication#token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }
    }
}

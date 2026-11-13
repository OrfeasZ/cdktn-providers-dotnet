using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageInstallment")]
    public class ThreeDSecureAuthenticationFutureUsageInstallment : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageInstallment
    {
        /// <summary>A non-negative integer representing the amount in the [smallest currency unit](/currencies#zero-decimal).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#amount ThreeDSecureAuthentication#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public double Amount
        {
            get;
            set;
        }

        /// <summary>Information about recurring payment expiry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#expiry ThreeDSecureAuthentication#expiry}
        /// </remarks>
        [JsiiProperty(name: "expiry", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageInstallmentExpiry\"}")]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageInstallmentExpiry Expiry
        {
            get;
            set;
        }

        /// <summary>The maximum number of installments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#number ThreeDSecureAuthentication#number}
        /// </remarks>
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public double Number
        {
            get;
            set;
        }

        /// <summary>The unit of time for `interval_count`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#interval ThreeDSecureAuthentication#interval}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Interval
        {
            get;
            set;
        }

        /// <summary>The minimum number of time intervals between authorizations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#interval_count ThreeDSecureAuthentication#interval_count}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalCount
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationFutureUsageRecurring), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageRecurring")]
    public interface IThreeDSecureAuthenticationFutureUsageRecurring
    {
        /// <summary>A non-negative integer representing the amount in the [smallest currency unit](/currencies#zero-decimal).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#amount ThreeDSecureAuthentication#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>Information about recurring payment expiry.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#expiry ThreeDSecureAuthentication#expiry}
        /// </remarks>
        [JsiiProperty(name: "expiry", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageRecurringExpiry\"}")]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageRecurringExpiry Expiry
        {
            get;
        }

        /// <summary>The unit of time for `interval_count`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#interval ThreeDSecureAuthentication#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Interval
        {
            get
            {
                return null;
            }
        }

        /// <summary>The minimum number of time intervals between authorizations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#interval_count ThreeDSecureAuthentication#interval_count}
        /// </remarks>
        [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationFutureUsageRecurring), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageRecurring")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageRecurring
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A non-negative integer representing the amount in the [smallest currency unit](/currencies#zero-decimal).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#amount ThreeDSecureAuthentication#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Information about recurring payment expiry.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#expiry ThreeDSecureAuthentication#expiry}
            /// </remarks>
            [JsiiProperty(name: "expiry", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageRecurringExpiry\"}")]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageRecurringExpiry Expiry
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageRecurringExpiry>()!;
            }

            /// <summary>The unit of time for `interval_count`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#interval ThreeDSecureAuthentication#interval}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Interval
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The minimum number of time intervals between authorizations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#interval_count ThreeDSecureAuthentication#interval_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

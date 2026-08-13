using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPauseCollection), fullyQualifiedName: "stripe.subscription.SubscriptionPauseCollection")]
    public interface ISubscriptionPauseCollection
    {
        /// <summary>The payment collection behavior for this subscription while paused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#behavior Subscription#behavior}
        /// </remarks>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Behavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time after which the subscription will resume collecting payments.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#resumes_at Subscription#resumes_at}
        /// </remarks>
        [JsiiProperty(name: "resumesAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ResumesAt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPauseCollection), fullyQualifiedName: "stripe.subscription.SubscriptionPauseCollection")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPauseCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The payment collection behavior for this subscription while paused.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#behavior Subscription#behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Behavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The time after which the subscription will resume collecting payments.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#resumes_at Subscription#resumes_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resumesAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ResumesAt
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

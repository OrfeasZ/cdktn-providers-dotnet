using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionCancellationDetails), fullyQualifiedName: "stripe.subscription.SubscriptionCancellationDetails")]
    public interface ISubscriptionCancellationDetails
    {
        /// <summary>Additional comments about why the user canceled the subscription, if the subscription was canceled explicitly by the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#comment Subscription#comment}
        /// </remarks>
        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>The customer submitted reason for why they canceled, if the subscription was canceled explicitly by the user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#feedback Subscription#feedback}
        /// </remarks>
        [JsiiProperty(name: "feedback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Feedback
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionCancellationDetails), fullyQualifiedName: "stripe.subscription.SubscriptionCancellationDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionCancellationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Additional comments about why the user canceled the subscription, if the subscription was canceled explicitly by the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#comment Subscription#comment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Comment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The customer submitted reason for why they canceled, if the subscription was canceled explicitly by the user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#feedback Subscription#feedback}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "feedback", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Feedback
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionTransferData), fullyQualifiedName: "stripe.subscription.SubscriptionTransferData")]
    public interface ISubscriptionTransferData
    {
        /// <summary>The account where funds from the payment will be transferred to upon payment success.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#destination Subscription#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the destination account. By default, the entire amount is transferred to the destination.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount_percent Subscription#amount_percent}
        /// </remarks>
        [JsiiProperty(name: "amountPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AmountPercent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionTransferData), fullyQualifiedName: "stripe.subscription.SubscriptionTransferData")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionTransferData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account where funds from the payment will be transferred to upon payment success.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#destination Subscription#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
            /// <remarks>
            /// This represents the percentage of the subscription invoice total that will be transferred to the destination account. By default, the entire amount is transferred to the destination.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount_percent Subscription#amount_percent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AmountPercent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

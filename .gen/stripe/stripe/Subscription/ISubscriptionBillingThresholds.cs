using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionBillingThresholds), fullyQualifiedName: "stripe.subscription.SubscriptionBillingThresholds")]
    public interface ISubscriptionBillingThresholds
    {
        /// <summary>Monetary threshold that triggers the subscription to create an invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount_gte Subscription#amount_gte}
        /// </remarks>
        [JsiiProperty(name: "amountGte", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AmountGte
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if the `billing_cycle_anchor` should be reset when a threshold is reached.</summary>
        /// <remarks>
        /// If true, <c>billing_cycle_anchor</c> will be updated to the date/time the threshold was last reached; otherwise, the value will remain unchanged. This value may not be <c>true</c> if the subscription contains items with plans that have <c>aggregate_usage=last_ever</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#reset_billing_cycle_anchor Subscription#reset_billing_cycle_anchor}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "resetBillingCycleAnchor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResetBillingCycleAnchor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionBillingThresholds), fullyQualifiedName: "stripe.subscription.SubscriptionBillingThresholds")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionBillingThresholds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Monetary threshold that triggers the subscription to create an invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#amount_gte Subscription#amount_gte}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountGte", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AmountGte
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates if the `billing_cycle_anchor` should be reset when a threshold is reached.</summary>
            /// <remarks>
            /// If true, <c>billing_cycle_anchor</c> will be updated to the date/time the threshold was last reached; otherwise, the value will remain unchanged. This value may not be <c>true</c> if the subscription contains items with plans that have <c>aggregate_usage=last_ever</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#reset_billing_cycle_anchor Subscription#reset_billing_cycle_anchor}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resetBillingCycleAnchor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ResetBillingCycleAnchor
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

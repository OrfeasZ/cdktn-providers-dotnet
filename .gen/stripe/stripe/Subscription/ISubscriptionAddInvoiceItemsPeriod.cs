using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionAddInvoiceItemsPeriod), fullyQualifiedName: "stripe.subscription.SubscriptionAddInvoiceItemsPeriod")]
    public interface ISubscriptionAddInvoiceItemsPeriod
    {
        /// <summary>End of the invoice item period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#end Subscription#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodEnd\"}")]
        stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd End
        {
            get;
        }

        /// <summary>Start of the invoice item period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#start Subscription#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodStart\"}")]
        stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodStart Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionAddInvoiceItemsPeriod), fullyQualifiedName: "stripe.subscription.SubscriptionAddInvoiceItemsPeriod")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionAddInvoiceItemsPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>End of the invoice item period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#end Subscription#end}
            /// </remarks>
            [JsiiProperty(name: "end", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodEnd\"}")]
            public stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd End
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodEnd>()!;
            }

            /// <summary>Start of the invoice item period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#start Subscription#start}
            /// </remarks>
            [JsiiProperty(name: "start", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItemsPeriodStart\"}")]
            public stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodStart Start
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionAddInvoiceItemsPeriodStart>()!;
            }
        }
    }
}

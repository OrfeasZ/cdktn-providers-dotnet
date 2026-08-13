using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPendingInvoiceItemInterval), fullyQualifiedName: "stripe.subscription.SubscriptionPendingInvoiceItemInterval")]
    public interface ISubscriptionPendingInvoiceItemInterval
    {
        /// <summary>Specifies invoicing frequency. Either `day`, `week`, `month` or `year`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#interval Subscription#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>The number of intervals between invoices.</summary>
        /// <remarks>
        /// For example, <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of one year interval allowed (1 year, 12 months, or 52 weeks).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#interval_count Subscription#interval_count}
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

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPendingInvoiceItemInterval), fullyQualifiedName: "stripe.subscription.SubscriptionPendingInvoiceItemInterval")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPendingInvoiceItemInterval
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies invoicing frequency. Either `day`, `week`, `month` or `year`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#interval Subscription#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of intervals between invoices.</summary>
            /// <remarks>
            /// For example, <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of one year interval allowed (1 year, 12 months, or 52 weeks).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#interval_count Subscription#interval_count}
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

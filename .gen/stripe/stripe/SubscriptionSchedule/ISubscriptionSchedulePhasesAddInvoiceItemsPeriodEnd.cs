using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd")]
    public interface ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd
    {
        /// <summary>Select how to calculate the end of the invoice item period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>A precise Unix timestamp for the end of the invoice item period.</summary>
        /// <remarks>
        /// Must be greater than or equal to <c>period.start</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#timestamp SubscriptionSchedule#timestamp}
        /// </remarks>
        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timestamp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Select how to calculate the end of the invoice item period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#type SubscriptionSchedule#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A precise Unix timestamp for the end of the invoice item period.</summary>
            /// <remarks>
            /// Must be greater than or equal to <c>period.start</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#timestamp SubscriptionSchedule#timestamp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timestamp
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

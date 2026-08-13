using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePhasesAddInvoiceItemsPeriod), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriod")]
    public interface ISubscriptionSchedulePhasesAddInvoiceItemsPeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#end SubscriptionSchedule#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd\"}")]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd End
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#start SubscriptionSchedule#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodStart\"}")]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodStart Start
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePhasesAddInvoiceItemsPeriod), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriod")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#end SubscriptionSchedule#end}.</summary>
            [JsiiProperty(name: "end", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd\"}")]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd End
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodEnd>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#start SubscriptionSchedule#start}.</summary>
            [JsiiProperty(name: "start", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriodStart\"}")]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodStart Start
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriodStart>()!;
            }
        }
    }
}

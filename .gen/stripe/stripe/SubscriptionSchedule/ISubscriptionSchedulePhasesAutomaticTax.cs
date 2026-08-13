using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePhasesAutomaticTax), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAutomaticTax")]
    public interface ISubscriptionSchedulePhasesAutomaticTax
    {
        /// <summary>Whether Stripe automatically computes tax on invoices created during this phase.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#enabled SubscriptionSchedule#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The account that's liable for tax.</summary>
        /// <remarks>
        /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#liability SubscriptionSchedule#liability}
        /// </remarks>
        [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAutomaticTaxLiability\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAutomaticTaxLiability? Liability
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePhasesAutomaticTax), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAutomaticTax")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAutomaticTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether Stripe automatically computes tax on invoices created during this phase.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#enabled SubscriptionSchedule#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The account that's liable for tax.</summary>
            /// <remarks>
            /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#liability SubscriptionSchedule#liability}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAutomaticTaxLiability\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAutomaticTaxLiability? Liability
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAutomaticTaxLiability?>();
            }
        }
    }
}

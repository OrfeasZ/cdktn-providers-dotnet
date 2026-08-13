using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsAutomaticTax")]
    public class SubscriptionScheduleDefaultSettingsAutomaticTax : stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsAutomaticTax
    {
        private object _enabled;

        /// <summary>Whether Stripe automatically computes tax on invoices created during this phase.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#enabled SubscriptionSchedule#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>The account that's liable for tax.</summary>
        /// <remarks>
        /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#liability SubscriptionSchedule#liability}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsAutomaticTaxLiability\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsAutomaticTaxLiability? Liability
        {
            get;
            set;
        }
    }
}

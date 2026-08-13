using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesBillingThresholds")]
    public class SubscriptionSchedulePhasesBillingThresholds : stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesBillingThresholds
    {
        /// <summary>Monetary threshold that triggers the subscription to create an invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#amount_gte SubscriptionSchedule#amount_gte}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountGte", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AmountGte
        {
            get;
            set;
        }

        private object? _resetBillingCycleAnchor;

        /// <summary>Indicates if the `billing_cycle_anchor` should be reset when a threshold is reached.</summary>
        /// <remarks>
        /// If true, <c>billing_cycle_anchor</c> will be updated to the date/time the threshold was last reached; otherwise, the value will remain unchanged. This value may not be <c>true</c> if the subscription contains items with plans that have <c>aggregate_usage=last_ever</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#reset_billing_cycle_anchor SubscriptionSchedule#reset_billing_cycle_anchor}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resetBillingCycleAnchor", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ResetBillingCycleAnchor
        {
            get => _resetBillingCycleAnchor;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resetBillingCycleAnchor = value;
            }
        }
    }
}

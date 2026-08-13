using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscription.SubscriptionBillingSchedules")]
    public class SubscriptionBillingSchedules : stripe.Subscription.ISubscriptionBillingSchedules
    {
        /// <summary>Specifies the end of billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bill_until Subscription#bill_until}
        /// </remarks>
        [JsiiProperty(name: "billUntil", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesBillUntil\"}")]
        public stripe.Subscription.ISubscriptionBillingSchedulesBillUntil BillUntil
        {
            get;
            set;
        }

        private object? _appliesTo;

        /// <summary>Specifies which subscription items the billing schedule applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#applies_to Subscription#applies_to}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionBillingSchedulesAppliesTo" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appliesTo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedulesAppliesTo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AppliesTo
        {
            get => _appliesTo;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Subscription.ISubscriptionBillingSchedulesAppliesTo[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionBillingSchedulesAppliesTo).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _appliesTo = value;
            }
        }

        /// <summary>Unique identifier for the billing schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#key Subscription#key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }
    }
}

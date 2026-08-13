using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingAlert.BillingAlertUsageThreshold")]
    public class BillingAlertUsageThreshold : stripe.BillingAlert.IBillingAlertUsageThreshold
    {
        /// <summary>The value at which this alert will trigger.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#gte BillingAlert#gte}
        /// </remarks>
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"number\"}")]
        public double Gte
        {
            get;
            set;
        }

        /// <summary>The [Billing Meter](/api/billing/meter) ID whose usage is monitored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#meter BillingAlert#meter}
        /// </remarks>
        [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}")]
        public string Meter
        {
            get;
            set;
        }

        /// <summary>Defines how the alert will behave.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#recurrence BillingAlert#recurrence}
        /// </remarks>
        [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}")]
        public string Recurrence
        {
            get;
            set;
        }

        private object? _filters;

        /// <summary>The filters allow limiting the scope of this usage alert.</summary>
        /// <remarks>
        /// You can only specify up to one filter at this time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#filters BillingAlert#filters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingAlert.IBillingAlertUsageThresholdFilters" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingAlert.BillingAlertUsageThresholdFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Filters
        {
            get => _filters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.BillingAlert.IBillingAlertUsageThresholdFilters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingAlert.IBillingAlertUsageThresholdFilters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filters = value;
            }
        }
    }
}

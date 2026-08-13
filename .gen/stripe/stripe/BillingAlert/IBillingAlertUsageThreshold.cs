using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingAlert
{
    [JsiiInterface(nativeType: typeof(IBillingAlertUsageThreshold), fullyQualifiedName: "stripe.billingAlert.BillingAlertUsageThreshold")]
    public interface IBillingAlertUsageThreshold
    {
        /// <summary>The value at which this alert will trigger.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#gte BillingAlert#gte}
        /// </remarks>
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"number\"}")]
        double Gte
        {
            get;
        }

        /// <summary>The [Billing Meter](/api/billing/meter) ID whose usage is monitored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#meter BillingAlert#meter}
        /// </remarks>
        [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}")]
        string Meter
        {
            get;
        }

        /// <summary>Defines how the alert will behave.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#recurrence BillingAlert#recurrence}
        /// </remarks>
        [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}")]
        string Recurrence
        {
            get;
        }

        /// <summary>The filters allow limiting the scope of this usage alert.</summary>
        /// <remarks>
        /// You can only specify up to one filter at this time.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#filters BillingAlert#filters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingAlert.IBillingAlertUsageThresholdFilters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingAlert.BillingAlertUsageThresholdFilters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingAlertUsageThreshold), fullyQualifiedName: "stripe.billingAlert.BillingAlertUsageThreshold")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingAlert.IBillingAlertUsageThreshold
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The value at which this alert will trigger.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#gte BillingAlert#gte}
            /// </remarks>
            [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"number\"}")]
            public double Gte
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The [Billing Meter](/api/billing/meter) ID whose usage is monitored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#meter BillingAlert#meter}
            /// </remarks>
            [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}")]
            public string Meter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Defines how the alert will behave.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_alert#recurrence BillingAlert#recurrence}
            /// </remarks>
            [JsiiProperty(name: "recurrence", typeJson: "{\"primitive\":\"string\"}")]
            public string Recurrence
            {
                get => GetInstanceProperty<string>()!;
            }

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
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

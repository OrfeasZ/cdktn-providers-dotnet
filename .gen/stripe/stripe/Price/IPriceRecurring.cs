using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiInterface(nativeType: typeof(IPriceRecurring), fullyQualifiedName: "stripe.price.PriceRecurring")]
    public interface IPriceRecurring
    {
        /// <summary>Specifies billing frequency. Either `day`, `week`, `month` or `year`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#interval Price#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>The number of intervals between subscription billings.</summary>
        /// <remarks>
        /// For example, <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of three years interval allowed (3 years, 36 months, or 156 weeks).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#interval_count Price#interval_count}
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

        /// <summary>The meter tracking the usage of a metered price.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#meter Price#meter}
        /// </remarks>
        [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Meter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Default number of trial days when subscribing a customer to this price using [`trial_from_plan=true`](https://stripe.com/docs/api#create_subscription-trial_from_plan).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#trial_period_days Price#trial_period_days}
        /// </remarks>
        [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TrialPeriodDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures how the quantity per period should be determined.</summary>
        /// <remarks>
        /// Can be either <c>metered</c> or <c>licensed</c>. <c>licensed</c> automatically bills the <c>quantity</c> set when adding it to a subscription. <c>metered</c> aggregates the total usage based on usage records. Defaults to <c>licensed</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#usage_type Price#usage_type}
        /// </remarks>
        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPriceRecurring), fullyQualifiedName: "stripe.price.PriceRecurring")]
        internal sealed class _Proxy : DeputyBase, stripe.Price.IPriceRecurring
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies billing frequency. Either `day`, `week`, `month` or `year`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#interval Price#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of intervals between subscription billings.</summary>
            /// <remarks>
            /// For example, <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of three years interval allowed (3 years, 36 months, or 156 weeks).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#interval_count Price#interval_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "intervalCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The meter tracking the usage of a metered price.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#meter Price#meter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Meter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Default number of trial days when subscribing a customer to this price using [`trial_from_plan=true`](https://stripe.com/docs/api#create_subscription-trial_from_plan).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#trial_period_days Price#trial_period_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TrialPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Configures how the quantity per period should be determined.</summary>
            /// <remarks>
            /// Can be either <c>metered</c> or <c>licensed</c>. <c>licensed</c> automatically bills the <c>quantity</c> set when adding it to a subscription. <c>metered</c> aggregates the total usage based on usage records. Defaults to <c>licensed</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/price#usage_type Price#usage_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

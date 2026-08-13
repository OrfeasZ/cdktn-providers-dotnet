using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateProductsAdjustableQuantity")]
    public class BillingPortalConfigurationFeaturesSubscriptionUpdateProductsAdjustableQuantity : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateProductsAdjustableQuantity
    {
        private object _enabled;

        /// <summary>If true, the quantity can be adjusted to any non-negative integer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
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

        /// <summary>The maximum quantity that can be set for the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#maximum BillingPortalConfiguration#maximum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Maximum
        {
            get;
            set;
        }

        /// <summary>The minimum quantity that can be set for the product.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#minimum BillingPortalConfiguration#minimum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minimum
        {
            get;
            set;
        }
    }
}

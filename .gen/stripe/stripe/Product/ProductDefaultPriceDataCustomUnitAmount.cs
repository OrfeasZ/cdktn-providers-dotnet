using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.product.ProductDefaultPriceDataCustomUnitAmount")]
    public class ProductDefaultPriceDataCustomUnitAmount : stripe.Product.IProductDefaultPriceDataCustomUnitAmount
    {
        private object _enabled;

        /// <summary>Pass in `true` to enable `custom_unit_amount`, otherwise omit `custom_unit_amount`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#enabled Product#enabled}
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

        /// <summary>The maximum unit amount the customer can specify for this item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#maximum Product#maximum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Maximum
        {
            get;
            set;
        }

        /// <summary>The minimum unit amount the customer can specify for this item. Must be at least the minimum charge amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#minimum Product#minimum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minimum
        {
            get;
            set;
        }

        /// <summary>The starting unit amount which can be updated by the customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#preset Product#preset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Preset
        {
            get;
            set;
        }
    }
}

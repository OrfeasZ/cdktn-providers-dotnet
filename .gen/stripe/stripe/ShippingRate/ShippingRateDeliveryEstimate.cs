using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiByValue(fqn: "stripe.shippingRate.ShippingRateDeliveryEstimate")]
    public class ShippingRateDeliveryEstimate : stripe.ShippingRate.IShippingRateDeliveryEstimate
    {
        private object? _maximum;

        /// <summary>maximum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/shipping_rate#maximum ShippingRate#maximum}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMaximum\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Maximum
        {
            get => _maximum;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ShippingRate.IShippingRateDeliveryEstimateMaximum).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _maximum = value;
            }
        }

        private object? _minimum;

        /// <summary>minimum block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/shipping_rate#minimum ShippingRate#minimum}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateMinimum\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Minimum
        {
            get => _minimum;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ShippingRate.IShippingRateDeliveryEstimateMinimum).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _minimum = value;
            }
        }
    }
}

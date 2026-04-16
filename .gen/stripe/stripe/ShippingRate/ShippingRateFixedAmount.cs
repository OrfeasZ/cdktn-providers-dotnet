using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.shippingRate.ShippingRateFixedAmount")]
    public class ShippingRateFixedAmount : stripe.ShippingRate.IShippingRateFixedAmount
    {
        /// <summary>A non-negative integer in cents representing how much to charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#amount ShippingRate#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public double Amount
        {
            get;
            set;
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#currency ShippingRate#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        private object? _currencyOptions;

        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#currency_options ShippingRate#currency_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmountCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CurrencyOptions
        {
            get => _currencyOptions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.ShippingRate.IShippingRateFixedAmountCurrencyOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.ShippingRate.IShippingRateFixedAmountCurrencyOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _currencyOptions = value;
            }
        }
    }
}

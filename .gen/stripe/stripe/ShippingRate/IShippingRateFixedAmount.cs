using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    [JsiiInterface(nativeType: typeof(IShippingRateFixedAmount), fullyQualifiedName: "stripe.shippingRate.ShippingRateFixedAmount")]
    public interface IShippingRateFixedAmount
    {
        /// <summary>A non-negative integer in cents representing how much to charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#amount ShippingRate#amount}
        /// </remarks>
        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        double Amount
        {
            get;
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#currency ShippingRate#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        string Currency
        {
            get;
        }

        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#currency_options ShippingRate#currency_options}
        /// </remarks>
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmountCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CurrencyOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IShippingRateFixedAmount), fullyQualifiedName: "stripe.shippingRate.ShippingRateFixedAmount")]
        internal sealed class _Proxy : DeputyBase, stripe.ShippingRate.IShippingRateFixedAmount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A non-negative integer in cents representing how much to charge.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#amount ShippingRate#amount}
            /// </remarks>
            [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
            public double Amount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#currency ShippingRate#currency}
            /// </remarks>
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
            public string Currency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>currency_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#currency_options ShippingRate#currency_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmountCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CurrencyOptions
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

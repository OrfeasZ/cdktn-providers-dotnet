using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiInterface(nativeType: typeof(IProductDefaultPriceDataCurrencyOptionsTiers), fullyQualifiedName: "stripe.product.ProductDefaultPriceDataCurrencyOptionsTiers")]
    public interface IProductDefaultPriceDataCurrencyOptionsTiers
    {
        /// <summary>Specifies the upper bound of this tier.</summary>
        /// <remarks>
        /// The lower bound of a tier is the upper bound of the previous tier adding one. Use <c>inf</c> to define a fallback tier.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#up_to Product#up_to}
        /// </remarks>
        [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"number\"}")]
        double UpTo
        {
            get;
        }

        /// <summary>The flat billing amount for an entire tier, regardless of the number of units in the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#flat_amount Product#flat_amount}
        /// </remarks>
        [JsiiProperty(name: "flatAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FlatAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Same as `flat_amount`, but accepts a decimal value representing an integer in the minor units of the currency.</summary>
        /// <remarks>
        /// Only one of <c>flat_amount</c> and <c>flat_amount_decimal</c> can be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#flat_amount_decimal Product#flat_amount_decimal}
        /// </remarks>
        [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlatAmountDecimal
        {
            get
            {
                return null;
            }
        }

        /// <summary>The per unit billing amount for each individual unit for which this tier applies.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#unit_amount Product#unit_amount}
        /// </remarks>
        [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnitAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Same as `unit_amount`, but accepts a decimal value in cents (or local equivalent) with at most 12 decimal places.</summary>
        /// <remarks>
        /// Only one of <c>unit_amount</c> and <c>unit_amount_decimal</c> can be set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#unit_amount_decimal Product#unit_amount_decimal}
        /// </remarks>
        [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UnitAmountDecimal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProductDefaultPriceDataCurrencyOptionsTiers), fullyQualifiedName: "stripe.product.ProductDefaultPriceDataCurrencyOptionsTiers")]
        internal sealed class _Proxy : DeputyBase, stripe.Product.IProductDefaultPriceDataCurrencyOptionsTiers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the upper bound of this tier.</summary>
            /// <remarks>
            /// The lower bound of a tier is the upper bound of the previous tier adding one. Use <c>inf</c> to define a fallback tier.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#up_to Product#up_to}
            /// </remarks>
            [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"number\"}")]
            public double UpTo
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The flat billing amount for an entire tier, regardless of the number of units in the tier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#flat_amount Product#flat_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flatAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FlatAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Same as `flat_amount`, but accepts a decimal value representing an integer in the minor units of the currency.</summary>
            /// <remarks>
            /// Only one of <c>flat_amount</c> and <c>flat_amount_decimal</c> can be set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#flat_amount_decimal Product#flat_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlatAmountDecimal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The per unit billing amount for each individual unit for which this tier applies.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#unit_amount Product#unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Same as `unit_amount`, but accepts a decimal value in cents (or local equivalent) with at most 12 decimal places.</summary>
            /// <remarks>
            /// Only one of <c>unit_amount</c> and <c>unit_amount_decimal</c> can be set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/product#unit_amount_decimal Product#unit_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UnitAmountDecimal
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

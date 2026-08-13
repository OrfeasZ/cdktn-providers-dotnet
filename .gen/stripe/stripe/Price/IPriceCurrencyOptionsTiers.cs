using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiInterface(nativeType: typeof(IPriceCurrencyOptionsTiers), fullyQualifiedName: "stripe.price.PriceCurrencyOptionsTiers")]
    public interface IPriceCurrencyOptionsTiers
    {
        /// <summary>Up to and including to this quantity will be contained in the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#up_to Price#up_to}
        /// </remarks>
        [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"string\"}")]
        string UpTo
        {
            get;
        }

        /// <summary>Price for the entire tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#flat_amount Price#flat_amount}
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

        /// <summary>Same as `flat_amount`, but contains a decimal value with at most 12 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#flat_amount_decimal Price#flat_amount_decimal}
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

        /// <summary>Per unit price for units relevant to the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount Price#unit_amount}
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

        /// <summary>Same as `unit_amount`, but contains a decimal value with at most 12 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount_decimal Price#unit_amount_decimal}
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

        [JsiiTypeProxy(nativeType: typeof(IPriceCurrencyOptionsTiers), fullyQualifiedName: "stripe.price.PriceCurrencyOptionsTiers")]
        internal sealed class _Proxy : DeputyBase, stripe.Price.IPriceCurrencyOptionsTiers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Up to and including to this quantity will be contained in the tier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#up_to Price#up_to}
            /// </remarks>
            [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"string\"}")]
            public string UpTo
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Price for the entire tier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#flat_amount Price#flat_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flatAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FlatAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Same as `flat_amount`, but contains a decimal value with at most 12 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#flat_amount_decimal Price#flat_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlatAmountDecimal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Per unit price for units relevant to the tier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount Price#unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Same as `unit_amount`, but contains a decimal value with at most 12 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#unit_amount_decimal Price#unit_amount_decimal}
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Plan
{
    [JsiiInterface(nativeType: typeof(IPlanTiers), fullyQualifiedName: "stripe.plan.PlanTiers")]
    public interface IPlanTiers
    {
        /// <summary>Up to and including to this quantity will be contained in the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#up_to Plan#up_to}
        /// </remarks>
        [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"number\"}")]
        double UpTo
        {
            get;
        }

        /// <summary>Price for the entire tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#flat_amount Plan#flat_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#flat_amount_decimal Plan#flat_amount_decimal}
        /// </remarks>
        [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FlatAmountDecimal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Per unit price for units relevant to the tier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#unit_amount Plan#unit_amount}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#unit_amount_decimal Plan#unit_amount_decimal}
        /// </remarks>
        [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnitAmountDecimal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPlanTiers), fullyQualifiedName: "stripe.plan.PlanTiers")]
        internal sealed class _Proxy : DeputyBase, stripe.Plan.IPlanTiers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Up to and including to this quantity will be contained in the tier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#up_to Plan#up_to}
            /// </remarks>
            [JsiiProperty(name: "upTo", typeJson: "{\"primitive\":\"number\"}")]
            public double UpTo
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Price for the entire tier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#flat_amount Plan#flat_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flatAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FlatAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Same as `flat_amount`, but contains a decimal value with at most 12 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#flat_amount_decimal Plan#flat_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flatAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FlatAmountDecimal
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Per unit price for units relevant to the tier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#unit_amount Plan#unit_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Same as `unit_amount`, but contains a decimal value with at most 12 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#unit_amount_decimal Plan#unit_amount_decimal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unitAmountDecimal", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnitAmountDecimal
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    [JsiiInterface(nativeType: typeof(ICouponConfig), fullyQualifiedName: "stripe.coupon.CouponConfig")]
    public interface ICouponConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A positive integer representing the amount to subtract from an invoice total (required if `percent_off` is not passed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#amount_off Coupon#amount_off}
        /// </remarks>
        [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AmountOff
        {
            get
            {
                return null;
            }
        }

        /// <summary>applies_to block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#applies_to Coupon#applies_to}
        /// </remarks>
        [JsiiProperty(name: "appliesTo", typeJson: "{\"fqn\":\"stripe.coupon.CouponAppliesTo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Coupon.ICouponAppliesTo? AppliesTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Three-letter [ISO code for the currency](https://stripe.com/docs/currencies) of the `amount_off` parameter (required if `amount_off` is passed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#currency Coupon#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Currency
        {
            get
            {
                return null;
            }
        }

        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#currency_options Coupon#currency_options}
        /// </remarks>
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.coupon.CouponCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CurrencyOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies how long the discount will be in effect if used on a subscription. Defaults to `once`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#duration Coupon#duration}
        /// </remarks>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Required only if `duration` is `repeating`, in which case it must be a positive integer that specifies the number of months the discount will be in effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#duration_in_months Coupon#duration_in_months}
        /// </remarks>
        [JsiiProperty(name: "durationInMonths", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DurationInMonths
        {
            get
            {
                return null;
            }
        }

        /// <summary>A positive integer specifying the number of times the coupon can be redeemed before it's no longer valid.</summary>
        /// <remarks>
        /// For example, you might have a 50% off coupon that the first 20 readers of your blog can use.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#max_redemptions Coupon#max_redemptions}
        /// </remarks>
        [JsiiProperty(name: "maxRedemptions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRedemptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#metadata Coupon#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the coupon displayed to customers on, for instance invoices, or receipts.</summary>
        /// <remarks>
        /// By default the <c>id</c> is shown if <c>name</c> is not set.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#name Coupon#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>A positive float larger than 0, and smaller or equal to 100, that represents the discount the coupon will apply (required if `amount_off` is not passed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#percent_off Coupon#percent_off}
        /// </remarks>
        [JsiiProperty(name: "percentOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PercentOff
        {
            get
            {
                return null;
            }
        }

        /// <summary>Unix timestamp specifying the last time at which the coupon can be redeemed.</summary>
        /// <remarks>
        /// After the redeem_by date, the coupon can no longer be applied to new customers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#redeem_by Coupon#redeem_by}
        /// </remarks>
        [JsiiProperty(name: "redeemBy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RedeemBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>script block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#script Coupon#script}
        /// </remarks>
        [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"stripe.coupon.CouponScript\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Coupon.ICouponScript? Script
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICouponConfig), fullyQualifiedName: "stripe.coupon.CouponConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Coupon.ICouponConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A positive integer representing the amount to subtract from an invoice total (required if `percent_off` is not passed).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#amount_off Coupon#amount_off}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AmountOff
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>applies_to block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#applies_to Coupon#applies_to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appliesTo", typeJson: "{\"fqn\":\"stripe.coupon.CouponAppliesTo\"}", isOptional: true)]
            public stripe.Coupon.ICouponAppliesTo? AppliesTo
            {
                get => GetInstanceProperty<stripe.Coupon.ICouponAppliesTo?>();
            }

            /// <summary>Three-letter [ISO code for the currency](https://stripe.com/docs/currencies) of the `amount_off` parameter (required if `amount_off` is passed).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#currency Coupon#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>currency_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#currency_options Coupon#currency_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.coupon.CouponCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CurrencyOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specifies how long the discount will be in effect if used on a subscription. Defaults to `once`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#duration Coupon#duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Required only if `duration` is `repeating`, in which case it must be a positive integer that specifies the number of months the discount will be in effect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#duration_in_months Coupon#duration_in_months}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durationInMonths", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DurationInMonths
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A positive integer specifying the number of times the coupon can be redeemed before it's no longer valid.</summary>
            /// <remarks>
            /// For example, you might have a 50% off coupon that the first 20 readers of your blog can use.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#max_redemptions Coupon#max_redemptions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRedemptions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRedemptions
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#metadata Coupon#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Name of the coupon displayed to customers on, for instance invoices, or receipts.</summary>
            /// <remarks>
            /// By default the <c>id</c> is shown if <c>name</c> is not set.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#name Coupon#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A positive float larger than 0, and smaller or equal to 100, that represents the discount the coupon will apply (required if `amount_off` is not passed).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#percent_off Coupon#percent_off}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "percentOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PercentOff
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Unix timestamp specifying the last time at which the coupon can be redeemed.</summary>
            /// <remarks>
            /// After the redeem_by date, the coupon can no longer be applied to new customers.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#redeem_by Coupon#redeem_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redeemBy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RedeemBy
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>script block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#script Coupon#script}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"stripe.coupon.CouponScript\"}", isOptional: true)]
            public stripe.Coupon.ICouponScript? Script
            {
                get => GetInstanceProperty<stripe.Coupon.ICouponScript?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

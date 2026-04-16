using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    [JsiiInterface(nativeType: typeof(IPromotionCodeConfig), fullyQualifiedName: "stripe.promotionCode.PromotionCodeConfig")]
    public interface IPromotionCodeConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>promotion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#promotion PromotionCode#promotion}
        /// </remarks>
        [JsiiProperty(name: "promotion", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodePromotion\"}")]
        stripe.PromotionCode.IPromotionCodePromotion Promotion
        {
            get;
        }

        /// <summary>Whether the promotion code is currently active.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#active PromotionCode#active}
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Active
        {
            get
            {
                return null;
            }
        }

        /// <summary>The customer-facing code.</summary>
        /// <remarks>
        /// Regardless of case, this code must be unique across all active promotion codes for a specific customer. Valid characters are lower case letters (a-z), upper case letters (A-Z), and digits (0-9). If left blank, we will generate one automatically.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#code PromotionCode#code}
        /// </remarks>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Code
        {
            get
            {
                return null;
            }
        }

        /// <summary>The customer that this promotion code can be used by.</summary>
        /// <remarks>
        /// If not set, the promotion code can be used by all customers.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#customer PromotionCode#customer}
        /// </remarks>
        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Customer
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account that this promotion code can be used by.</summary>
        /// <remarks>
        /// If not set, the promotion code can be used by all accounts.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#customer_account PromotionCode#customer_account}
        /// </remarks>
        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>The timestamp at which this promotion code will expire.</summary>
        /// <remarks>
        /// If the coupon has specified a <c>redeems_by</c>, then this value cannot be after the coupon's <c>redeems_by</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#expires_at PromotionCode#expires_at}
        /// </remarks>
        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpiresAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>A positive integer specifying the number of times the promotion code can be redeemed.</summary>
        /// <remarks>
        /// If the coupon has specified a <c>max_redemptions</c>, then this value cannot be greater than the coupon's <c>max_redemptions</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#max_redemptions PromotionCode#max_redemptions}
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

        /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#metadata PromotionCode#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#restrictions PromotionCode#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PromotionCode.IPromotionCodeRestrictions? Restrictions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPromotionCodeConfig), fullyQualifiedName: "stripe.promotionCode.PromotionCodeConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.PromotionCode.IPromotionCodeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>promotion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#promotion PromotionCode#promotion}
            /// </remarks>
            [JsiiProperty(name: "promotion", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodePromotion\"}")]
            public stripe.PromotionCode.IPromotionCodePromotion Promotion
            {
                get => GetInstanceProperty<stripe.PromotionCode.IPromotionCodePromotion>()!;
            }

            /// <summary>Whether the promotion code is currently active.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#active PromotionCode#active}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The customer-facing code.</summary>
            /// <remarks>
            /// Regardless of case, this code must be unique across all active promotion codes for a specific customer. Valid characters are lower case letters (a-z), upper case letters (A-Z), and digits (0-9). If left blank, we will generate one automatically.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#code PromotionCode#code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Code
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The customer that this promotion code can be used by.</summary>
            /// <remarks>
            /// If not set, the promotion code can be used by all customers.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#customer PromotionCode#customer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Customer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The account that this promotion code can be used by.</summary>
            /// <remarks>
            /// If not set, the promotion code can be used by all accounts.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#customer_account PromotionCode#customer_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The timestamp at which this promotion code will expire.</summary>
            /// <remarks>
            /// If the coupon has specified a <c>redeems_by</c>, then this value cannot be after the coupon's <c>redeems_by</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#expires_at PromotionCode#expires_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpiresAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>A positive integer specifying the number of times the promotion code can be redeemed.</summary>
            /// <remarks>
            /// If the coupon has specified a <c>max_redemptions</c>, then this value cannot be greater than the coupon's <c>max_redemptions</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#max_redemptions PromotionCode#max_redemptions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRedemptions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRedemptions
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Set of [key-value pairs](https://stripe.com/docs/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#metadata PromotionCode#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>restrictions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#restrictions PromotionCode#restrictions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictions\"}", isOptional: true)]
            public stripe.PromotionCode.IPromotionCodeRestrictions? Restrictions
            {
                get => GetInstanceProperty<stripe.PromotionCode.IPromotionCodeRestrictions?>();
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

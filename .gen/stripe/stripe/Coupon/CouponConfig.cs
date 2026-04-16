using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    [JsiiByValue(fqn: "stripe.coupon.CouponConfig")]
    public class CouponConfig : stripe.Coupon.ICouponConfig
    {
        /// <summary>A positive integer representing the amount to subtract from an invoice total (required if `percent_off` is not passed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#amount_off Coupon#amount_off}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AmountOff
        {
            get;
            set;
        }

        /// <summary>applies_to block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#applies_to Coupon#applies_to}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appliesTo", typeJson: "{\"fqn\":\"stripe.coupon.CouponAppliesTo\"}", isOptional: true)]
        public stripe.Coupon.ICouponAppliesTo? AppliesTo
        {
            get;
            set;
        }

        /// <summary>Three-letter [ISO code for the currency](https://stripe.com/docs/currencies) of the `amount_off` parameter (required if `amount_off` is passed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#currency Coupon#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        private object? _currencyOptions;

        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#currency_options Coupon#currency_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.coupon.CouponCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case stripe.Coupon.ICouponCurrencyOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Coupon.ICouponCurrencyOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _currencyOptions = value;
            }
        }

        /// <summary>Specifies how long the discount will be in effect if used on a subscription. Defaults to `once`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#duration Coupon#duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }

        /// <summary>Required only if `duration` is `repeating`, in which case it must be a positive integer that specifies the number of months the discount will be in effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#duration_in_months Coupon#duration_in_months}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationInMonths", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationInMonths
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#metadata Coupon#metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>A positive float larger than 0, and smaller or equal to 100, that represents the discount the coupon will apply (required if `amount_off` is not passed).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#percent_off Coupon#percent_off}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "percentOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PercentOff
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>script block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#script Coupon#script}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "script", typeJson: "{\"fqn\":\"stripe.coupon.CouponScript\"}", isOptional: true)]
        public stripe.Coupon.ICouponScript? Script
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}

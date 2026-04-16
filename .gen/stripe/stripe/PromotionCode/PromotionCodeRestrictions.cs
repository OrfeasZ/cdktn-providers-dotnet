using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    [JsiiByValue(fqn: "stripe.promotionCode.PromotionCodeRestrictions")]
    public class PromotionCodeRestrictions : stripe.PromotionCode.IPromotionCodeRestrictions
    {
        private object? _currencyOptions;

        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#currency_options PromotionCode#currency_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case stripe.PromotionCode.IPromotionCodeRestrictionsCurrencyOptions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PromotionCode.IPromotionCodeRestrictionsCurrencyOptions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _currencyOptions = value;
            }
        }

        private object? _firstTimeTransaction;

        /// <summary>A Boolean indicating if the Promotion Code should only be redeemed for Customers without any successful payments or invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#first_time_transaction PromotionCode#first_time_transaction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstTimeTransaction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FirstTimeTransaction
        {
            get => _firstTimeTransaction;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _firstTimeTransaction = value;
            }
        }

        /// <summary>Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase must be $100 or more to work).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount PromotionCode#minimum_amount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumAmount
        {
            get;
            set;
        }

        /// <summary>Three-letter [ISO code](https://stripe.com/docs/currencies) for minimum_amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount_currency PromotionCode#minimum_amount_currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumAmountCurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumAmountCurrency
        {
            get;
            set;
        }
    }
}

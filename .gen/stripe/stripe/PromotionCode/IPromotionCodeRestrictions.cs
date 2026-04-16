using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PromotionCode
{
    [JsiiInterface(nativeType: typeof(IPromotionCodeRestrictions), fullyQualifiedName: "stripe.promotionCode.PromotionCodeRestrictions")]
    public interface IPromotionCodeRestrictions
    {
        /// <summary>currency_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#currency_options PromotionCode#currency_options}
        /// </remarks>
        [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CurrencyOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>A Boolean indicating if the Promotion Code should only be redeemed for Customers without any successful payments or invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#first_time_transaction PromotionCode#first_time_transaction}
        /// </remarks>
        [JsiiProperty(name: "firstTimeTransaction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirstTimeTransaction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase must be $100 or more to work).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount PromotionCode#minimum_amount}
        /// </remarks>
        [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Three-letter [ISO code](https://stripe.com/docs/currencies) for minimum_amount.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount_currency PromotionCode#minimum_amount_currency}
        /// </remarks>
        [JsiiProperty(name: "minimumAmountCurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumAmountCurrency
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPromotionCodeRestrictions), fullyQualifiedName: "stripe.promotionCode.PromotionCodeRestrictions")]
        internal sealed class _Proxy : DeputyBase, stripe.PromotionCode.IPromotionCodeRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>currency_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#currency_options PromotionCode#currency_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currencyOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.promotionCode.PromotionCodeRestrictionsCurrencyOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CurrencyOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A Boolean indicating if the Promotion Code should only be redeemed for Customers without any successful payments or invoices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#first_time_transaction PromotionCode#first_time_transaction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firstTimeTransaction", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FirstTimeTransaction
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Minimum amount required to redeem this Promotion Code into a Coupon (e.g., a purchase must be $100 or more to work).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount PromotionCode#minimum_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Three-letter [ISO code](https://stripe.com/docs/currencies) for minimum_amount.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/promotion_code#minimum_amount_currency PromotionCode#minimum_amount_currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumAmountCurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumAmountCurrency
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

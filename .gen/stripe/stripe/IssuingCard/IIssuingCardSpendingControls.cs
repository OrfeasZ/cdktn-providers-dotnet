using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiInterface(nativeType: typeof(IIssuingCardSpendingControls), fullyQualifiedName: "stripe.issuingCard.IssuingCardSpendingControls")]
    public interface IIssuingCardSpendingControls
    {
        /// <summary>Array of card presence statuses from which authorizations will be allowed.</summary>
        /// <remarks>
        /// Possible options are <c>present</c>, <c>not_present</c>. All other statuses will be blocked. Cannot be set with <c>blocked_card_presences</c>. Provide an empty value to unset this control.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#allowed_card_presences IssuingCard#allowed_card_presences}
        /// </remarks>
        [JsiiProperty(name: "allowedCardPresences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedCardPresences
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) of authorizations to allow. All other categories will be blocked. Cannot be set with `blocked_categories`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#allowed_categories IssuingCard#allowed_categories}
        /// </remarks>
        [JsiiProperty(name: "allowedCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedCategories
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of strings containing representing countries from which authorizations will be allowed.</summary>
        /// <remarks>
        /// Authorizations from merchants in all other countries will be declined. Country codes should be ISO 3166 alpha-2 country codes (e.g. <c>US</c>). Cannot be set with <c>blocked_merchant_countries</c>. Provide an empty value to unset this control.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#allowed_merchant_countries IssuingCard#allowed_merchant_countries}
        /// </remarks>
        [JsiiProperty(name: "allowedMerchantCountries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedMerchantCountries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of card presence statuses from which authorizations will be declined.</summary>
        /// <remarks>
        /// Possible options are <c>present</c>, <c>not_present</c>. Cannot be set with <c>allowed_card_presences</c>. Provide an empty value to unset this control.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#blocked_card_presences IssuingCard#blocked_card_presences}
        /// </remarks>
        [JsiiProperty(name: "blockedCardPresences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BlockedCardPresences
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) of authorizations to decline. All other categories will be allowed. Cannot be set with `allowed_categories`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#blocked_categories IssuingCard#blocked_categories}
        /// </remarks>
        [JsiiProperty(name: "blockedCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BlockedCategories
        {
            get
            {
                return null;
            }
        }

        /// <summary>Array of strings containing representing countries from which authorizations will be declined.</summary>
        /// <remarks>
        /// Country codes should be ISO 3166 alpha-2 country codes (e.g. <c>US</c>). Cannot be set with <c>allowed_merchant_countries</c>. Provide an empty value to unset this control.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#blocked_merchant_countries IssuingCard#blocked_merchant_countries}
        /// </remarks>
        [JsiiProperty(name: "blockedMerchantCountries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BlockedMerchantCountries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Limit spending with amount-based rules that apply across any cards this card replaced (i.e., its `replacement_for` card and _that_ card's `replacement_for` card, up the chain).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#spending_limits IssuingCard#spending_limits}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.IssuingCard.IIssuingCardSpendingControlsSpendingLimits" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "spendingLimits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.issuingCard.IssuingCardSpendingControlsSpendingLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SpendingLimits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardSpendingControls), fullyQualifiedName: "stripe.issuingCard.IssuingCardSpendingControls")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCard.IIssuingCardSpendingControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Array of card presence statuses from which authorizations will be allowed.</summary>
            /// <remarks>
            /// Possible options are <c>present</c>, <c>not_present</c>. All other statuses will be blocked. Cannot be set with <c>blocked_card_presences</c>. Provide an empty value to unset this control.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#allowed_card_presences IssuingCard#allowed_card_presences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedCardPresences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedCardPresences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) of authorizations to allow. All other categories will be blocked. Cannot be set with `blocked_categories`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#allowed_categories IssuingCard#allowed_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedCategories
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Array of strings containing representing countries from which authorizations will be allowed.</summary>
            /// <remarks>
            /// Authorizations from merchants in all other countries will be declined. Country codes should be ISO 3166 alpha-2 country codes (e.g. <c>US</c>). Cannot be set with <c>blocked_merchant_countries</c>. Provide an empty value to unset this control.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#allowed_merchant_countries IssuingCard#allowed_merchant_countries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedMerchantCountries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedMerchantCountries
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Array of card presence statuses from which authorizations will be declined.</summary>
            /// <remarks>
            /// Possible options are <c>present</c>, <c>not_present</c>. Cannot be set with <c>allowed_card_presences</c>. Provide an empty value to unset this control.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#blocked_card_presences IssuingCard#blocked_card_presences}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockedCardPresences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BlockedCardPresences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Array of strings containing [categories](https://docs.stripe.com/api#issuing_authorization_object-merchant_data-category) of authorizations to decline. All other categories will be allowed. Cannot be set with `allowed_categories`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#blocked_categories IssuingCard#blocked_categories}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockedCategories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BlockedCategories
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Array of strings containing representing countries from which authorizations will be declined.</summary>
            /// <remarks>
            /// Country codes should be ISO 3166 alpha-2 country codes (e.g. <c>US</c>). Cannot be set with <c>allowed_merchant_countries</c>. Provide an empty value to unset this control.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#blocked_merchant_countries IssuingCard#blocked_merchant_countries}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockedMerchantCountries", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BlockedMerchantCountries
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Limit spending with amount-based rules that apply across any cards this card replaced (i.e., its `replacement_for` card and _that_ card's `replacement_for` card, up the chain).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#spending_limits IssuingCard#spending_limits}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.IssuingCard.IIssuingCardSpendingControlsSpendingLimits" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spendingLimits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.issuingCard.IssuingCardSpendingControlsSpendingLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SpendingLimits
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

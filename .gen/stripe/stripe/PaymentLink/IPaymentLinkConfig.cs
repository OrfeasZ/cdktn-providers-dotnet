using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkConfig), fullyQualifiedName: "stripe.paymentLink.PaymentLinkConfig")]
    public interface IPaymentLinkConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The line items representing what is being sold.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#line_items PaymentLink#line_items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkLineItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "lineItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkLineItems\"},\"kind\":\"array\"}}]}}")]
        object LineItems
        {
            get;
        }

        /// <summary>Whether the payment link's `url` is active.</summary>
        /// <remarks>
        /// If <c>false</c>, customers visiting the URL will be shown a page saying that the link has been deactivated.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#active PaymentLink#active}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#after_completion PaymentLink#after_completion}.</summary>
        [JsiiProperty(name: "afterCompletion", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkAfterCompletion? AfterCompletion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether user redeemable promotion codes are enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#allow_promotion_codes PaymentLink#allow_promotion_codes}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "allowPromotionCodes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowPromotionCodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>The amount of the application fee (if any) that will be requested to be applied to the payment and transferred to the application owner's Stripe account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#application_fee_amount PaymentLink#application_fee_amount}
        /// </remarks>
        [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ApplicationFeeAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>This represents the percentage of the subscription invoice total that will be transferred to the application owner's Stripe account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#application_fee_percent PaymentLink#application_fee_percent}
        /// </remarks>
        [JsiiProperty(name: "applicationFeePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ApplicationFeePercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#automatic_tax PaymentLink#automatic_tax}.</summary>
        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAutomaticTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkAutomaticTax? AutomaticTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for collecting the customer's billing address. Defaults to `auto`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#billing_address_collection PaymentLink#billing_address_collection}
        /// </remarks>
        [JsiiProperty(name: "billingAddressCollection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingAddressCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>When set, provides configuration to gather active consent from customers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#consent_collection PaymentLink#consent_collection}
        /// </remarks>
        [JsiiProperty(name: "consentCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkConsentCollection? ConsentCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#currency PaymentLink#currency}
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

        /// <summary>Configuration for Customer creation during checkout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#customer_creation PaymentLink#customer_creation}
        /// </remarks>
        [JsiiProperty(name: "customerCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomerCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Collect additional information from your customer using custom fields.</summary>
        /// <remarks>
        /// Up to 3 fields are supported. You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_fields PaymentLink#custom_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkCustomFields" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_text PaymentLink#custom_text}.</summary>
        [JsiiProperty(name: "customText", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomText\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkCustomText? CustomText
        {
            get
            {
                return null;
            }
        }

        /// <summary>The custom message to be displayed to a customer when a payment link is no longer active.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#inactive_message PaymentLink#inactive_message}
        /// </remarks>
        [JsiiProperty(name: "inactiveMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InactiveMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for creating invoice for payment mode payment links.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#invoice_creation PaymentLink#invoice_creation}
        /// </remarks>
        [JsiiProperty(name: "invoiceCreation", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkInvoiceCreation? InvoiceCreation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings for Managed Payments for this Payment Link and resulting [CheckoutSessions](/api/checkout/sessions/object), [PaymentIntents](/api/payment_intents/object), [Invoices](/api/invoices/object), and [Subscriptions](/api/subscriptions/object).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#managed_payments PaymentLink#managed_payments}
        /// </remarks>
        [JsiiProperty(name: "managedPayments", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkManagedPayments\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkManagedPayments? ManagedPayments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#name_collection PaymentLink#name_collection}.</summary>
        [JsiiProperty(name: "nameCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkNameCollection? NameCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account on behalf of which to charge. See the [Connect documentation](https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts) for details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#on_behalf_of PaymentLink#on_behalf_of}
        /// </remarks>
        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnBehalfOf
        {
            get
            {
                return null;
            }
        }

        /// <summary>The optional items presented to the customer at checkout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#optional_items PaymentLink#optional_items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkOptionalItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "optionalItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OptionalItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates the parameters to be passed to PaymentIntent creation during checkout.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_intent_data PaymentLink#payment_intent_data}
        /// </remarks>
        [JsiiProperty(name: "paymentIntentData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentIntentData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkPaymentIntentData? PaymentIntentData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for collecting a payment method during checkout. Defaults to `always`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_collection PaymentLink#payment_method_collection}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodCollection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentMethodCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Payment-method-specific configuration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_options PaymentLink#payment_method_options}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkPaymentMethodOptions? PaymentMethodOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of payment method types that customers can use.</summary>
        /// <remarks>
        /// When <c>null</c>, Stripe will dynamically show relevant payment methods you've enabled in your <a href="https://dashboard.stripe.com/settings/payment_methods">payment method settings</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_types PaymentLink#payment_method_types}
        /// </remarks>
        [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PaymentMethodTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#phone_number_collection PaymentLink#phone_number_collection}.</summary>
        [JsiiProperty(name: "phoneNumberCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPhoneNumberCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkPhoneNumberCollection? PhoneNumberCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings that restrict the usage of a payment link.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#restrictions PaymentLink#restrictions}
        /// </remarks>
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkRestrictions? Restrictions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for collecting the customer's shipping address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_address_collection PaymentLink#shipping_address_collection}
        /// </remarks>
        [JsiiProperty(name: "shippingAddressCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingAddressCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkShippingAddressCollection? ShippingAddressCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>The shipping rate options applied to the session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_options PaymentLink#shipping_options}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkShippingOptions" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "shippingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShippingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates the type of transaction being performed which customizes relevant text on the page, such as the submit button.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#submit_type PaymentLink#submit_type}
        /// </remarks>
        [JsiiProperty(name: "submitType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubmitType
        {
            get
            {
                return null;
            }
        }

        /// <summary>When creating a subscription, the specified configuration data will be used.</summary>
        /// <remarks>
        /// There must be at least one line item with a recurring price to use <c>subscription_data</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#subscription_data PaymentLink#subscription_data}
        /// </remarks>
        [JsiiProperty(name: "subscriptionData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkSubscriptionData? SubscriptionData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#tax_id_collection PaymentLink#tax_id_collection}.</summary>
        [JsiiProperty(name: "taxIdCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkTaxIdCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkTaxIdCollection? TaxIdCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account (if any) the payments will be attributed to for tax reporting, and where funds from each payment will be transferred to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#transfer_data PaymentLink#transfer_data}
        /// </remarks>
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkTransferData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkTransferData? TransferData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkConfig), fullyQualifiedName: "stripe.paymentLink.PaymentLinkConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The line items representing what is being sold.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#line_items PaymentLink#line_items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkLineItems" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "lineItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkLineItems\"},\"kind\":\"array\"}}]}}")]
            public object LineItems
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Whether the payment link's `url` is active.</summary>
            /// <remarks>
            /// If <c>false</c>, customers visiting the URL will be shown a page saying that the link has been deactivated.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#active PaymentLink#active}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Active
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#after_completion PaymentLink#after_completion}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "afterCompletion", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAfterCompletion\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkAfterCompletion? AfterCompletion
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkAfterCompletion?>();
            }

            /// <summary>Whether user redeemable promotion codes are enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#allow_promotion_codes PaymentLink#allow_promotion_codes}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowPromotionCodes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AllowPromotionCodes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The amount of the application fee (if any) that will be requested to be applied to the payment and transferred to the application owner's Stripe account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#application_fee_amount PaymentLink#application_fee_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApplicationFeeAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>This represents the percentage of the subscription invoice total that will be transferred to the application owner's Stripe account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#application_fee_percent PaymentLink#application_fee_percent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationFeePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApplicationFeePercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#automatic_tax PaymentLink#automatic_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAutomaticTax\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkAutomaticTax? AutomaticTax
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkAutomaticTax?>();
            }

            /// <summary>Configuration for collecting the customer's billing address. Defaults to `auto`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#billing_address_collection PaymentLink#billing_address_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingAddressCollection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingAddressCollection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When set, provides configuration to gather active consent from customers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#consent_collection PaymentLink#consent_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consentCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkConsentCollection\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkConsentCollection? ConsentCollection
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkConsentCollection?>();
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#currency PaymentLink#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configuration for Customer creation during checkout.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#customer_creation PaymentLink#customer_creation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerCreation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerCreation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Collect additional information from your customer using custom fields.</summary>
            /// <remarks>
            /// Up to 3 fields are supported. You can't set this parameter if <c>ui_mode</c> is <c>custom</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_fields PaymentLink#custom_fields}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkCustomFields" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom_text PaymentLink#custom_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customText", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkCustomText\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkCustomText? CustomText
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkCustomText?>();
            }

            /// <summary>The custom message to be displayed to a customer when a payment link is no longer active.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#inactive_message PaymentLink#inactive_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inactiveMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InactiveMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configuration for creating invoice for payment mode payment links.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#invoice_creation PaymentLink#invoice_creation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invoiceCreation", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkInvoiceCreation\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkInvoiceCreation? InvoiceCreation
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkInvoiceCreation?>();
            }

            /// <summary>Settings for Managed Payments for this Payment Link and resulting [CheckoutSessions](/api/checkout/sessions/object), [PaymentIntents](/api/payment_intents/object), [Invoices](/api/invoices/object), and [Subscriptions](/api/subscriptions/object).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#managed_payments PaymentLink#managed_payments}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedPayments", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkManagedPayments\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkManagedPayments? ManagedPayments
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkManagedPayments?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#metadata PaymentLink#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#name_collection PaymentLink#name_collection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nameCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkNameCollection\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkNameCollection? NameCollection
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkNameCollection?>();
            }

            /// <summary>The account on behalf of which to charge. See the [Connect documentation](https://support.stripe.com/questions/sending-invoices-on-behalf-of-connected-accounts) for details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#on_behalf_of PaymentLink#on_behalf_of}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnBehalfOf
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The optional items presented to the customer at checkout.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#optional_items PaymentLink#optional_items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkOptionalItems" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "optionalItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OptionalItems
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates the parameters to be passed to PaymentIntent creation during checkout.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_intent_data PaymentLink#payment_intent_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentIntentData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentIntentData\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkPaymentIntentData? PaymentIntentData
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkPaymentIntentData?>();
            }

            /// <summary>Configuration for collecting a payment method during checkout. Defaults to `always`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_collection PaymentLink#payment_method_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodCollection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentMethodCollection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Payment-method-specific configuration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_options PaymentLink#payment_method_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodOptions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPaymentMethodOptions\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkPaymentMethodOptions? PaymentMethodOptions
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkPaymentMethodOptions?>();
            }

            /// <summary>The list of payment method types that customers can use.</summary>
            /// <remarks>
            /// When <c>null</c>, Stripe will dynamically show relevant payment methods you've enabled in your <a href="https://dashboard.stripe.com/settings/payment_methods">payment method settings</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#payment_method_types PaymentLink#payment_method_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PaymentMethodTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#phone_number_collection PaymentLink#phone_number_collection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumberCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkPhoneNumberCollection\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkPhoneNumberCollection? PhoneNumberCollection
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkPhoneNumberCollection?>();
            }

            /// <summary>Settings that restrict the usage of a payment link.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#restrictions PaymentLink#restrictions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkRestrictions\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkRestrictions? Restrictions
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkRestrictions?>();
            }

            /// <summary>Configuration for collecting the customer's shipping address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_address_collection PaymentLink#shipping_address_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingAddressCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingAddressCollection\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkShippingAddressCollection? ShippingAddressCollection
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkShippingAddressCollection?>();
            }

            /// <summary>The shipping rate options applied to the session.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#shipping_options PaymentLink#shipping_options}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.PaymentLink.IPaymentLinkShippingOptions" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingOptions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.paymentLink.PaymentLinkShippingOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ShippingOptions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Indicates the type of transaction being performed which customizes relevant text on the page, such as the submit button.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#submit_type PaymentLink#submit_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "submitType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubmitType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When creating a subscription, the specified configuration data will be used.</summary>
            /// <remarks>
            /// There must be at least one line item with a recurring price to use <c>subscription_data</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#subscription_data PaymentLink#subscription_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkSubscriptionData\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkSubscriptionData? SubscriptionData
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkSubscriptionData?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#tax_id_collection PaymentLink#tax_id_collection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taxIdCollection", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkTaxIdCollection\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkTaxIdCollection? TaxIdCollection
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkTaxIdCollection?>();
            }

            /// <summary>The account (if any) the payments will be attributed to for tax reporting, and where funds from each payment will be transferred to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#transfer_data PaymentLink#transfer_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkTransferData\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkTransferData? TransferData
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkTransferData?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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

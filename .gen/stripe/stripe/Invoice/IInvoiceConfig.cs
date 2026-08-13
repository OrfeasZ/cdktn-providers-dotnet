using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceConfig), fullyQualifiedName: "stripe.invoice.InvoiceConfig")]
    public interface IInvoiceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The account tax IDs associated with the invoice. Only editable when the invoice is a draft.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#account_tax_ids Invoice#account_tax_ids}
        /// </remarks>
        [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AccountTaxIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>A fee in cents (or local equivalent) that will be applied to the invoice and transferred to the application owner's Stripe account.</summary>
        /// <remarks>
        /// The request must be made with an OAuth key or the Stripe-Account header in order to take an application fee. For more information, see the application fees <a href="https://docs.stripe.com/billing/invoices/connect#collecting-fees">documentation</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#application_fee_amount Invoice#application_fee_amount}
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

        /// <summary>Controls whether Stripe performs [automatic collection](https://docs.stripe.com/invoicing/integration/automatic-advancement-collection) of the invoice. If `false`, the invoice's state doesn't automatically advance without an explicit action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#auto_advance Invoice#auto_advance}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "autoAdvance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoAdvance
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time when this invoice is currently scheduled to be automatically finalized.</summary>
        /// <remarks>
        /// The field will be <c>null</c> if the invoice is not scheduled to finalize in the future. If the invoice is not in the draft state, this field will always be <c>null</c> - see <c>finalized_at</c> for the time when an already-finalized invoice was finalized.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#automatically_finalizes_at Invoice#automatically_finalizes_at}
        /// </remarks>
        [JsiiProperty(name: "automaticallyFinalizesAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AutomaticallyFinalizesAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#automatic_tax Invoice#automatic_tax}.</summary>
        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceAutomaticTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceAutomaticTax? AutomaticTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Either `charge_automatically`, or `send_invoice`.</summary>
        /// <remarks>
        /// When charging automatically, Stripe will attempt to pay this invoice using the default source attached to the customer. When sending an invoice, Stripe will email this invoice to the customer with payment instructions.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#collection_method Invoice#collection_method}
        /// </remarks>
        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CollectionMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#currency Invoice#currency}
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

        /// <summary>The ID of the customer to bill.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#customer Invoice#customer}
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

        /// <summary>The ID of the account representing the customer to bill.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#customer_account Invoice#customer_account}
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

        /// <summary>Custom fields displayed on the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#custom_fields Invoice#custom_fields}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceCustomFields" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of days from when the invoice is created until it is due.</summary>
        /// <remarks>
        /// Valid only for invoices where <c>collection_method=send_invoice</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#days_until_due Invoice#days_until_due}
        /// </remarks>
        [JsiiProperty(name: "daysUntilDue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DaysUntilDue
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the default payment method for the invoice.</summary>
        /// <remarks>
        /// It must belong to the customer associated with the invoice. If not set, defaults to the subscription's default payment method, if any, or to the default payment method in the customer's invoice settings.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_payment_method Invoice#default_payment_method}
        /// </remarks>
        [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultPaymentMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the default payment source for the invoice.</summary>
        /// <remarks>
        /// It must belong to the customer associated with the invoice and be in a chargeable state. If not set, defaults to the subscription's default source, if any, or to the customer's default source.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_source Invoice#default_source}
        /// </remarks>
        [JsiiProperty(name: "defaultSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tax rates applied to this invoice, if any.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_tax_rates Invoice#default_tax_rates}
        /// </remarks>
        [JsiiProperty(name: "defaultTaxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DefaultTaxRates
        {
            get
            {
                return null;
            }
        }

        /// <summary>An arbitrary string attached to the object. Often useful for displaying to users. Referenced as 'memo' in the Dashboard.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#description Invoice#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>The discounts applied to the invoice.</summary>
        /// <remarks>
        /// Line item discounts are applied before invoice discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#discounts Invoice#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceDiscounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Discounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The date on which payment for this invoice is due. This value will be `null` for invoices where `collection_method=charge_automatically`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#due_date Invoice#due_date}
        /// </remarks>
        [JsiiProperty(name: "dueDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DueDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The date when this invoice is in effect.</summary>
        /// <remarks>
        /// Same as <c>finalized_at</c> unless overwritten. When defined, this value replaces the system-generated 'Date of issue' printed on the invoice PDF and receipt.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#effective_at Invoice#effective_at}
        /// </remarks>
        [JsiiProperty(name: "effectiveAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EffectiveAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Footer displayed on the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#footer Invoice#footer}
        /// </remarks>
        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Footer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Details of the invoice that was cloned. See the [revision documentation](https://docs.stripe.com/invoicing/invoice-revisions) for more details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#from_invoice Invoice#from_invoice}
        /// </remarks>
        [JsiiProperty(name: "fromInvoice", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceFromInvoice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceFromInvoice? FromInvoice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#issuer Invoice#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceIssuer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceIssuer? Issuer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#metadata Invoice#metadata}
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

        /// <summary>A unique, identifying string that appears on emails sent to the customer for this invoice.</summary>
        /// <remarks>
        /// This starts with the customer's unique invoice_prefix if it is specified.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#number Invoice#number}
        /// </remarks>
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Number
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account (if any) for which the funds of the invoice payment are intended.</summary>
        /// <remarks>
        /// If set, the invoice will be presented with the branding and support information of the specified account. See the <a href="https://docs.stripe.com/billing/invoices/connect">Invoices with Connect</a> documentation for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#on_behalf_of Invoice#on_behalf_of}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#payment_settings Invoice#payment_settings}.</summary>
        [JsiiProperty(name: "paymentSettings", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoicePaymentSettings? PaymentSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>How to handle pending invoice items on invoice creation. Defaults to `exclude` if the parameter is omitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#pending_invoice_items_behavior Invoice#pending_invoice_items_behavior}
        /// </remarks>
        [JsiiProperty(name: "pendingInvoiceItemsBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PendingInvoiceItemsBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>The rendering-related settings that control how the invoice is displayed on customer-facing surfaces such as PDF and Hosted Invoice Page.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#rendering Invoice#rendering}
        /// </remarks>
        [JsiiProperty(name: "rendering", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceRendering\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceRendering? Rendering
        {
            get
            {
                return null;
            }
        }

        /// <summary>The details of the cost of shipping, including the ShippingRate applied on the invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_cost Invoice#shipping_cost}
        /// </remarks>
        [JsiiProperty(name: "shippingCost", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCost\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceShippingCost? ShippingCost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Shipping details for the invoice.</summary>
        /// <remarks>
        /// The Invoice PDF will use the <c>shipping_details</c> value if it is set, otherwise the PDF will render the shipping address from the customer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_details Invoice#shipping_details}
        /// </remarks>
        [JsiiProperty(name: "shippingDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceShippingDetails? ShippingDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Extra information about an invoice for the customer's credit card statement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#statement_descriptor Invoice#statement_descriptor}
        /// </remarks>
        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StatementDescriptor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#subscription Invoice#subscription}.</summary>
        [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subscription
        {
            get
            {
                return null;
            }
        }

        /// <summary>If specified, the funds from the invoice will be transferred to the destination and the ID of the resulting transfer will be found on the invoice's charge.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#transfer_data Invoice#transfer_data}
        /// </remarks>
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceTransferData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceTransferData? TransferData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceConfig), fullyQualifiedName: "stripe.invoice.InvoiceConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The account tax IDs associated with the invoice. Only editable when the invoice is a draft.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#account_tax_ids Invoice#account_tax_ids}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AccountTaxIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A fee in cents (or local equivalent) that will be applied to the invoice and transferred to the application owner's Stripe account.</summary>
            /// <remarks>
            /// The request must be made with an OAuth key or the Stripe-Account header in order to take an application fee. For more information, see the application fees <a href="https://docs.stripe.com/billing/invoices/connect#collecting-fees">documentation</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#application_fee_amount Invoice#application_fee_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationFeeAmount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApplicationFeeAmount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Controls whether Stripe performs [automatic collection](https://docs.stripe.com/invoicing/integration/automatic-advancement-collection) of the invoice. If `false`, the invoice's state doesn't automatically advance without an explicit action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#auto_advance Invoice#auto_advance}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoAdvance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AutoAdvance
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The time when this invoice is currently scheduled to be automatically finalized.</summary>
            /// <remarks>
            /// The field will be <c>null</c> if the invoice is not scheduled to finalize in the future. If the invoice is not in the draft state, this field will always be <c>null</c> - see <c>finalized_at</c> for the time when an already-finalized invoice was finalized.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#automatically_finalizes_at Invoice#automatically_finalizes_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automaticallyFinalizesAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AutomaticallyFinalizesAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#automatic_tax Invoice#automatic_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceAutomaticTax\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceAutomaticTax? AutomaticTax
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceAutomaticTax?>();
            }

            /// <summary>Either `charge_automatically`, or `send_invoice`.</summary>
            /// <remarks>
            /// When charging automatically, Stripe will attempt to pay this invoice using the default source attached to the customer. When sending an invoice, Stripe will email this invoice to the customer with payment instructions.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#collection_method Invoice#collection_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CollectionMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#currency Invoice#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the customer to bill.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#customer Invoice#customer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Customer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The ID of the account representing the customer to bill.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#customer_account Invoice#customer_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerAccount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Custom fields displayed on the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#custom_fields Invoice#custom_fields}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceCustomFields" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The number of days from when the invoice is created until it is due.</summary>
            /// <remarks>
            /// Valid only for invoices where <c>collection_method=send_invoice</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#days_until_due Invoice#days_until_due}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "daysUntilDue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DaysUntilDue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ID of the default payment method for the invoice.</summary>
            /// <remarks>
            /// It must belong to the customer associated with the invoice. If not set, defaults to the subscription's default payment method, if any, or to the default payment method in the customer's invoice settings.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_payment_method Invoice#default_payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultPaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the default payment source for the invoice.</summary>
            /// <remarks>
            /// It must belong to the customer associated with the invoice and be in a chargeable state. If not set, defaults to the subscription's default source, if any, or to the customer's default source.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_source Invoice#default_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The tax rates applied to this invoice, if any.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#default_tax_rates Invoice#default_tax_rates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTaxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DefaultTaxRates
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>An arbitrary string attached to the object. Often useful for displaying to users. Referenced as 'memo' in the Dashboard.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#description Invoice#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The discounts applied to the invoice.</summary>
            /// <remarks>
            /// Line item discounts are applied before invoice discounts. Use <c>expand[]=discounts</c> to expand each discount.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#discounts Invoice#discounts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Invoice.IInvoiceDiscounts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.invoice.InvoiceDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Discounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The date on which payment for this invoice is due. This value will be `null` for invoices where `collection_method=charge_automatically`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#due_date Invoice#due_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dueDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DueDate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The date when this invoice is in effect.</summary>
            /// <remarks>
            /// Same as <c>finalized_at</c> unless overwritten. When defined, this value replaces the system-generated 'Date of issue' printed on the invoice PDF and receipt.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#effective_at Invoice#effective_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "effectiveAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EffectiveAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Footer displayed on the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#footer Invoice#footer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Footer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Details of the invoice that was cloned. See the [revision documentation](https://docs.stripe.com/invoicing/invoice-revisions) for more details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#from_invoice Invoice#from_invoice}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fromInvoice", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceFromInvoice\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceFromInvoice? FromInvoice
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceFromInvoice?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#issuer Invoice#issuer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceIssuer\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceIssuer? Issuer
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceIssuer?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#metadata Invoice#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A unique, identifying string that appears on emails sent to the customer for this invoice.</summary>
            /// <remarks>
            /// This starts with the customer's unique invoice_prefix if it is specified.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#number Invoice#number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Number
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The account (if any) for which the funds of the invoice payment are intended.</summary>
            /// <remarks>
            /// If set, the invoice will be presented with the branding and support information of the specified account. See the <a href="https://docs.stripe.com/billing/invoices/connect">Invoices with Connect</a> documentation for details.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#on_behalf_of Invoice#on_behalf_of}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnBehalfOf
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#payment_settings Invoice#payment_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paymentSettings", typeJson: "{\"fqn\":\"stripe.invoice.InvoicePaymentSettings\"}", isOptional: true)]
            public stripe.Invoice.IInvoicePaymentSettings? PaymentSettings
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoicePaymentSettings?>();
            }

            /// <summary>How to handle pending invoice items on invoice creation. Defaults to `exclude` if the parameter is omitted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#pending_invoice_items_behavior Invoice#pending_invoice_items_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pendingInvoiceItemsBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PendingInvoiceItemsBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The rendering-related settings that control how the invoice is displayed on customer-facing surfaces such as PDF and Hosted Invoice Page.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#rendering Invoice#rendering}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rendering", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceRendering\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceRendering? Rendering
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceRendering?>();
            }

            /// <summary>The details of the cost of shipping, including the ShippingRate applied on the invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_cost Invoice#shipping_cost}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingCost", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCost\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceShippingCost? ShippingCost
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceShippingCost?>();
            }

            /// <summary>Shipping details for the invoice.</summary>
            /// <remarks>
            /// The Invoice PDF will use the <c>shipping_details</c> value if it is set, otherwise the PDF will render the shipping address from the customer.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_details Invoice#shipping_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingDetails", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingDetails\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceShippingDetails? ShippingDetails
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceShippingDetails?>();
            }

            /// <summary>Extra information about an invoice for the customer's credit card statement.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#statement_descriptor Invoice#statement_descriptor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StatementDescriptor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#subscription Invoice#subscription}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subscription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If specified, the funds from the invoice will be transferred to the destination and the ID of the resulting transfer will be found on the invoice's charge.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#transfer_data Invoice#transfer_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceTransferData\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceTransferData? TransferData
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceTransferData?>();
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

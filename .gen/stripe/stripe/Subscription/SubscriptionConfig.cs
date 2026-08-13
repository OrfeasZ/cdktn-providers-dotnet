using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionConfig")]
    public class SubscriptionConfig : stripe.Subscription.ISubscriptionConfig
    {
        private object? _addInvoiceItems;

        /// <summary>A list of prices and quantities that will generate invoice items appended to the next invoice for this subscription.</summary>
        /// <remarks>
        /// You may pass up to 20 items.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#add_invoice_items Subscription#add_invoice_items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionAddInvoiceItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addInvoiceItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AddInvoiceItems
        {
            get => _addInvoiceItems;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Subscription.ISubscriptionAddInvoiceItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionAddInvoiceItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addInvoiceItems = value;
            }
        }

        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the application owner's Stripe account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#application_fee_percent Subscription#application_fee_percent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationFeePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ApplicationFeePercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#automatic_tax Subscription#automatic_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAutomaticTax\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionAutomaticTax? AutomaticTax
        {
            get;
            set;
        }

        /// <summary>A past timestamp to backdate the subscription's start date to.</summary>
        /// <remarks>
        /// If set, the first invoice will contain line items for the timespan between the start date and the current time. Can be combined with trials and the billing cycle anchor.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#backdate_start_date Subscription#backdate_start_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backdateStartDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackdateStartDate
        {
            get;
            set;
        }

        /// <summary>The reference point that aligns future [billing cycle](https://docs.stripe.com/subscriptions/billing-cycle) dates. It sets the day of week for `week` intervals, the day of month for `month` and `year` intervals, and the month of year for `year` intervals. The timestamp is in UTC format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_cycle_anchor Subscription#billing_cycle_anchor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BillingCycleAnchor
        {
            get;
            set;
        }

        /// <summary>The fixed values used to calculate the `billing_cycle_anchor`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_cycle_anchor_config Subscription#billing_cycle_anchor_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingCycleAnchorConfig", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingCycleAnchorConfig\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionBillingCycleAnchorConfig? BillingCycleAnchorConfig
        {
            get;
            set;
        }

        /// <summary>The billing mode of the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_mode Subscription#billing_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingMode", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingMode\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionBillingMode? BillingMode
        {
            get;
            set;
        }

        private object? _billingSchedules;

        /// <summary>Billing schedules for this subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_schedules Subscription#billing_schedules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionBillingSchedules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingSchedules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BillingSchedules
        {
            get => _billingSchedules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Subscription.ISubscriptionBillingSchedules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionBillingSchedules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _billingSchedules = value;
            }
        }

        /// <summary>Define thresholds at which an invoice will be sent, and the subscription advanced to a new billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_thresholds Subscription#billing_thresholds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingThresholds\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionBillingThresholds? BillingThresholds
        {
            get;
            set;
        }

        /// <summary>A date in the future at which the subscription will automatically get canceled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancel_at Subscription#cancel_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cancelAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CancelAt
        {
            get;
            set;
        }

        private object? _cancelAtPeriodEnd;

        /// <summary>Whether this subscription will (if `status=active`) or did (if `status=canceled`) cancel at the end of the current billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancel_at_period_end Subscription#cancel_at_period_end}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cancelAtPeriodEnd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CancelAtPeriodEnd
        {
            get => _cancelAtPeriodEnd;
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
                _cancelAtPeriodEnd = value;
            }
        }

        /// <summary>Details about why this subscription was cancelled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancellation_details Subscription#cancellation_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cancellationDetails", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionCancellationDetails\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionCancellationDetails? CancellationDetails
        {
            get;
            set;
        }

        /// <summary>Either `charge_automatically`, or `send_invoice`.</summary>
        /// <remarks>
        /// When charging automatically, Stripe will attempt to pay this subscription at the end of the cycle using the default source attached to the customer. When sending an invoice, Stripe will email your customer an invoice with payment instructions and mark the subscription as <c>active</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#collection_method Subscription#collection_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "collectionMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CollectionMethod
        {
            get;
            set;
        }

        /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#currency Subscription#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        /// <summary>ID of the customer who owns the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer Subscription#customer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Customer
        {
            get;
            set;
        }

        /// <summary>ID of the account representing the customer who owns the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer_account Subscription#customer_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomerAccount
        {
            get;
            set;
        }

        /// <summary>Number of days a customer has to pay invoices generated by this subscription.</summary>
        /// <remarks>
        /// This value will be <c>null</c> for subscriptions where <c>collection_method=charge_automatically</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#days_until_due Subscription#days_until_due}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "daysUntilDue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DaysUntilDue
        {
            get;
            set;
        }

        /// <summary>ID of the default payment method for the subscription.</summary>
        /// <remarks>
        /// It must belong to the customer associated with the subscription. This takes precedence over <c>default_source</c>. If neither are set, invoices will use the customer's <a href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a> or <a href="https://docs.stripe.com/api/customers/object#customer_object-default_source">default_source</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#default_payment_method Subscription#default_payment_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultPaymentMethod
        {
            get;
            set;
        }

        /// <summary>ID of the default payment source for the subscription.</summary>
        /// <remarks>
        /// It must belong to the customer associated with the subscription and be in a chargeable state. If <c>default_payment_method</c> is also set, <c>default_payment_method</c> will take precedence. If neither are set, invoices will use the customer's <a href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a> or <a href="https://docs.stripe.com/api/customers/object#customer_object-default_source">default_source</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#default_source Subscription#default_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultSource
        {
            get;
            set;
        }

        /// <summary>The tax rates that will apply to any subscription item that does not have `tax_rates` set.</summary>
        /// <remarks>
        /// Invoices created will have their <c>default_tax_rates</c> populated from the subscription.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#default_tax_rates Subscription#default_tax_rates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultTaxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DefaultTaxRates
        {
            get;
            set;
        }

        /// <summary>The subscription's description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#description Subscription#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _discounts;

        /// <summary>The discounts applied to the subscription.</summary>
        /// <remarks>
        /// Subscription item discounts are applied before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#discounts Subscription#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionDiscounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Discounts
        {
            get => _discounts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Subscription.ISubscriptionDiscounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionDiscounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _discounts = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#invoice_settings Subscription#invoice_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionInvoiceSettings\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionInvoiceSettings? InvoiceSettings
        {
            get;
            set;
        }

        private object? _items;

        /// <summary>List of subscription items, each with an attached price.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#items Subscription#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Items
        {
            get => _items;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Subscription.ISubscriptionItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _items = value;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#metadata Subscription#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        private object? _offSession;

        /// <summary>Indicates if a customer is on or off-session while an invoice payment is attempted. Defaults to `false` (on-session).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#off_session Subscription#off_session}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "offSession", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? OffSession
        {
            get => _offSession;
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
                _offSession = value;
            }
        }

        /// <summary>The account (if any) the charge was made on behalf of for charges associated with this subscription.</summary>
        /// <remarks>
        /// See the <a href="https://docs.stripe.com/connect/subscriptions#on-behalf-of">Connect documentation</a> for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#on_behalf_of Subscription#on_behalf_of}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnBehalfOf
        {
            get;
            set;
        }

        /// <summary>If specified, payment collection for this subscription will be paused.</summary>
        /// <remarks>
        /// Note that the subscription status will be unchanged and will not be updated to <c>paused</c>. Learn more about <a href="https://docs.stripe.com/billing/subscriptions/pause-payment">pausing collection</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#pause_collection Subscription#pause_collection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pauseCollection", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPauseCollection\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPauseCollection? PauseCollection
        {
            get;
            set;
        }

        /// <summary>Controls how Stripe handles the first invoice when payment is required and `collection_method=charge_automatically`.</summary>
        /// <remarks>
        /// Subscriptions with <c>collection_method=send_invoice</c> are automatically activated regardless of the first Invoice status.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_behavior Subscription#payment_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentBehavior
        {
            get;
            set;
        }

        /// <summary>Payment settings passed on to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_settings Subscription#payment_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettings\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettings? PaymentSettings
        {
            get;
            set;
        }

        /// <summary>Specifies an interval for how often to bill for any pending invoice items.</summary>
        /// <remarks>
        /// It is analogous to calling <a href="/api/invoices/create">Create an invoice</a> for the given subscription at the specified interval.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#pending_invoice_item_interval Subscription#pending_invoice_item_interval}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pendingInvoiceItemInterval", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPendingInvoiceItemInterval\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPendingInvoiceItemInterval? PendingInvoiceItemInterval
        {
            get;
            set;
        }

        /// <summary>Determines how to handle [prorations](https://docs.stripe.com/billing/subscriptions/prorations) resulting from the `billing_cycle_anchor`. If no value is passed, the default is `create_prorations`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#proration_behavior Subscription#proration_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProrationBehavior
        {
            get;
            set;
        }

        /// <summary>The account (if any) the subscription's payments will be attributed to for tax reporting, and where funds from each payment will be transferred to for each of the subscription's invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#transfer_data Subscription#transfer_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTransferData\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionTransferData? TransferData
        {
            get;
            set;
        }

        /// <summary>If the subscription has a trial, the end of that trial.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_end Subscription#trial_end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialEnd", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrialEnd
        {
            get;
            set;
        }

        private object? _trialFromPlan;

        /// <summary>Indicates if a plan's `trial_period_days` should be applied to the subscription.</summary>
        /// <remarks>
        /// Setting <c>trial_end</c> per subscription is preferred, and this defaults to <c>false</c>. Setting this flag to <c>true</c> together with <c>trial_end</c> is not allowed. See <a href="https://docs.stripe.com/billing/subscriptions/trials">Using trial periods on subscriptions</a> to learn more.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_from_plan Subscription#trial_from_plan}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialFromPlan", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TrialFromPlan
        {
            get => _trialFromPlan;
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
                _trialFromPlan = value;
            }
        }

        /// <summary>Integer representing the number of trial period days before the customer is charged for the first time.</summary>
        /// <remarks>
        /// This will always overwrite any trials that might apply via a subscribed plan. See <a href="https://docs.stripe.com/billing/subscriptions/trials">Using trial periods on subscriptions</a> to learn more.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_period_days Subscription#trial_period_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrialPeriodDays
        {
            get;
            set;
        }

        /// <summary>Settings related to subscription trials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_settings Subscription#trial_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTrialSettings\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionTrialSettings? TrialSettings
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
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
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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

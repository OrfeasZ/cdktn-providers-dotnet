using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionConfig), fullyQualifiedName: "stripe.subscription.SubscriptionConfig")]
    public interface ISubscriptionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>A list of prices and quantities that will generate invoice items appended to the next invoice for this subscription.</summary>
        /// <remarks>
        /// You may pass up to 20 items.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#add_invoice_items Subscription#add_invoice_items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionAddInvoiceItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "addInvoiceItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionAddInvoiceItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AddInvoiceItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the application owner's Stripe account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#application_fee_percent Subscription#application_fee_percent}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#automatic_tax Subscription#automatic_tax}.</summary>
        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAutomaticTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionAutomaticTax? AutomaticTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>A past timestamp to backdate the subscription's start date to.</summary>
        /// <remarks>
        /// If set, the first invoice will contain line items for the timespan between the start date and the current time. Can be combined with trials and the billing cycle anchor.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#backdate_start_date Subscription#backdate_start_date}
        /// </remarks>
        [JsiiProperty(name: "backdateStartDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackdateStartDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The reference point that aligns future [billing cycle](https://docs.stripe.com/subscriptions/billing-cycle) dates. It sets the day of week for `week` intervals, the day of month for `month` and `year` intervals, and the month of year for `year` intervals. The timestamp is in UTC format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_cycle_anchor Subscription#billing_cycle_anchor}
        /// </remarks>
        [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BillingCycleAnchor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The fixed values used to calculate the `billing_cycle_anchor`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_cycle_anchor_config Subscription#billing_cycle_anchor_config}
        /// </remarks>
        [JsiiProperty(name: "billingCycleAnchorConfig", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingCycleAnchorConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionBillingCycleAnchorConfig? BillingCycleAnchorConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>The billing mode of the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_mode Subscription#billing_mode}
        /// </remarks>
        [JsiiProperty(name: "billingMode", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingMode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionBillingMode? BillingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Billing schedules for this subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_schedules Subscription#billing_schedules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionBillingSchedules" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "billingSchedules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BillingSchedules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define thresholds at which an invoice will be sent, and the subscription advanced to a new billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_thresholds Subscription#billing_thresholds}
        /// </remarks>
        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingThresholds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionBillingThresholds? BillingThresholds
        {
            get
            {
                return null;
            }
        }

        /// <summary>A date in the future at which the subscription will automatically get canceled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancel_at Subscription#cancel_at}
        /// </remarks>
        [JsiiProperty(name: "cancelAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CancelAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this subscription will (if `status=active`) or did (if `status=canceled`) cancel at the end of the current billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancel_at_period_end Subscription#cancel_at_period_end}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "cancelAtPeriodEnd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CancelAtPeriodEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Details about why this subscription was cancelled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancellation_details Subscription#cancellation_details}
        /// </remarks>
        [JsiiProperty(name: "cancellationDetails", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionCancellationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionCancellationDetails? CancellationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Either `charge_automatically`, or `send_invoice`.</summary>
        /// <remarks>
        /// When charging automatically, Stripe will attempt to pay this subscription at the end of the cycle using the default source attached to the customer. When sending an invoice, Stripe will email your customer an invoice with payment instructions and mark the subscription as <c>active</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#collection_method Subscription#collection_method}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#currency Subscription#currency}
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

        /// <summary>ID of the customer who owns the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer Subscription#customer}
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

        /// <summary>ID of the account representing the customer who owns the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer_account Subscription#customer_account}
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

        /// <summary>Number of days a customer has to pay invoices generated by this subscription.</summary>
        /// <remarks>
        /// This value will be <c>null</c> for subscriptions where <c>collection_method=charge_automatically</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#days_until_due Subscription#days_until_due}
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

        /// <summary>ID of the default payment method for the subscription.</summary>
        /// <remarks>
        /// It must belong to the customer associated with the subscription. This takes precedence over <c>default_source</c>. If neither are set, invoices will use the customer's <a href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a> or <a href="https://docs.stripe.com/api/customers/object#customer_object-default_source">default_source</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#default_payment_method Subscription#default_payment_method}
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

        /// <summary>ID of the default payment source for the subscription.</summary>
        /// <remarks>
        /// It must belong to the customer associated with the subscription and be in a chargeable state. If <c>default_payment_method</c> is also set, <c>default_payment_method</c> will take precedence. If neither are set, invoices will use the customer's <a href="https://docs.stripe.com/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a> or <a href="https://docs.stripe.com/api/customers/object#customer_object-default_source">default_source</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#default_source Subscription#default_source}
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

        /// <summary>The tax rates that will apply to any subscription item that does not have `tax_rates` set.</summary>
        /// <remarks>
        /// Invoices created will have their <c>default_tax_rates</c> populated from the subscription.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#default_tax_rates Subscription#default_tax_rates}
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

        /// <summary>The subscription's description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#description Subscription#description}
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

        /// <summary>The discounts applied to the subscription.</summary>
        /// <remarks>
        /// Subscription item discounts are applied before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#discounts Subscription#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionDiscounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Discounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#invoice_settings Subscription#invoice_settings}.</summary>
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionInvoiceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionInvoiceSettings? InvoiceSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of subscription items, each with an attached price.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#items Subscription#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Items
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#metadata Subscription#metadata}
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

        /// <summary>Indicates if a customer is on or off-session while an invoice payment is attempted. Defaults to `false` (on-session).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#off_session Subscription#off_session}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "offSession", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OffSession
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account (if any) the charge was made on behalf of for charges associated with this subscription.</summary>
        /// <remarks>
        /// See the <a href="https://docs.stripe.com/connect/subscriptions#on-behalf-of">Connect documentation</a> for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#on_behalf_of Subscription#on_behalf_of}
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

        /// <summary>If specified, payment collection for this subscription will be paused.</summary>
        /// <remarks>
        /// Note that the subscription status will be unchanged and will not be updated to <c>paused</c>. Learn more about <a href="https://docs.stripe.com/billing/subscriptions/pause-payment">pausing collection</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#pause_collection Subscription#pause_collection}
        /// </remarks>
        [JsiiProperty(name: "pauseCollection", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPauseCollection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPauseCollection? PauseCollection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls how Stripe handles the first invoice when payment is required and `collection_method=charge_automatically`.</summary>
        /// <remarks>
        /// Subscriptions with <c>collection_method=send_invoice</c> are automatically activated regardless of the first Invoice status.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_behavior Subscription#payment_behavior}
        /// </remarks>
        [JsiiProperty(name: "paymentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Payment settings passed on to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_settings Subscription#payment_settings}
        /// </remarks>
        [JsiiProperty(name: "paymentSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettings? PaymentSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies an interval for how often to bill for any pending invoice items.</summary>
        /// <remarks>
        /// It is analogous to calling <a href="/api/invoices/create">Create an invoice</a> for the given subscription at the specified interval.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#pending_invoice_item_interval Subscription#pending_invoice_item_interval}
        /// </remarks>
        [JsiiProperty(name: "pendingInvoiceItemInterval", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPendingInvoiceItemInterval\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPendingInvoiceItemInterval? PendingInvoiceItemInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines how to handle [prorations](https://docs.stripe.com/billing/subscriptions/prorations) resulting from the `billing_cycle_anchor`. If no value is passed, the default is `create_prorations`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#proration_behavior Subscription#proration_behavior}
        /// </remarks>
        [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProrationBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account (if any) the subscription's payments will be attributed to for tax reporting, and where funds from each payment will be transferred to for each of the subscription's invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#transfer_data Subscription#transfer_data}
        /// </remarks>
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTransferData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionTransferData? TransferData
        {
            get
            {
                return null;
            }
        }

        /// <summary>If the subscription has a trial, the end of that trial.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_end Subscription#trial_end}
        /// </remarks>
        [JsiiProperty(name: "trialEnd", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TrialEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates if a plan's `trial_period_days` should be applied to the subscription.</summary>
        /// <remarks>
        /// Setting <c>trial_end</c> per subscription is preferred, and this defaults to <c>false</c>. Setting this flag to <c>true</c> together with <c>trial_end</c> is not allowed. See <a href="https://docs.stripe.com/billing/subscriptions/trials">Using trial periods on subscriptions</a> to learn more.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_from_plan Subscription#trial_from_plan}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "trialFromPlan", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TrialFromPlan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Integer representing the number of trial period days before the customer is charged for the first time.</summary>
        /// <remarks>
        /// This will always overwrite any trials that might apply via a subscribed plan. See <a href="https://docs.stripe.com/billing/subscriptions/trials">Using trial periods on subscriptions</a> to learn more.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_period_days Subscription#trial_period_days}
        /// </remarks>
        [JsiiProperty(name: "trialPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TrialPeriodDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Settings related to subscription trials.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_settings Subscription#trial_settings}
        /// </remarks>
        [JsiiProperty(name: "trialSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTrialSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionTrialSettings? TrialSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionConfig), fullyQualifiedName: "stripe.subscription.SubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#automatic_tax Subscription#automatic_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionAutomaticTax\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionAutomaticTax? AutomaticTax
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionAutomaticTax?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The reference point that aligns future [billing cycle](https://docs.stripe.com/subscriptions/billing-cycle) dates. It sets the day of week for `week` intervals, the day of month for `month` and `year` intervals, and the month of year for `year` intervals. The timestamp is in UTC format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_cycle_anchor Subscription#billing_cycle_anchor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BillingCycleAnchor
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The fixed values used to calculate the `billing_cycle_anchor`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_cycle_anchor_config Subscription#billing_cycle_anchor_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingCycleAnchorConfig", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingCycleAnchorConfig\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionBillingCycleAnchorConfig? BillingCycleAnchorConfig
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionBillingCycleAnchorConfig?>();
            }

            /// <summary>The billing mode of the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_mode Subscription#billing_mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingMode", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingMode\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionBillingMode? BillingMode
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionBillingMode?>();
            }

            /// <summary>Billing schedules for this subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_schedules Subscription#billing_schedules}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionBillingSchedules" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingSchedules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionBillingSchedules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? BillingSchedules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Define thresholds at which an invoice will be sent, and the subscription advanced to a new billing period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_thresholds Subscription#billing_thresholds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionBillingThresholds\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionBillingThresholds? BillingThresholds
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionBillingThresholds?>();
            }

            /// <summary>A date in the future at which the subscription will automatically get canceled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancel_at Subscription#cancel_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cancelAt", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CancelAt
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether this subscription will (if `status=active`) or did (if `status=canceled`) cancel at the end of the current billing period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancel_at_period_end Subscription#cancel_at_period_end}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cancelAtPeriodEnd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CancelAtPeriodEnd
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Details about why this subscription was cancelled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#cancellation_details Subscription#cancellation_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cancellationDetails", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionCancellationDetails\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionCancellationDetails? CancellationDetails
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionCancellationDetails?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Three-letter [ISO currency code](https://www.iso.org/iso-4217-currency-codes.html), in lowercase. Must be a [supported currency](https://stripe.com/docs/currencies).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#currency Subscription#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the customer who owns the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer Subscription#customer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Customer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the account representing the customer who owns the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer_account Subscription#customer_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomerAccount
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string[]?>();
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
                get => GetInstanceProperty<string?>();
            }

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
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#invoice_settings Subscription#invoice_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionInvoiceSettings\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionInvoiceSettings? InvoiceSettings
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionInvoiceSettings?>();
            }

            /// <summary>List of subscription items, each with an attached price.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#items Subscription#items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionItems" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Items
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#metadata Subscription#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Indicates if a customer is on or off-session while an invoice payment is attempted. Defaults to `false` (on-session).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#off_session Subscription#off_session}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "offSession", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OffSession
            {
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPauseCollection?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Payment settings passed on to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payment_settings Subscription#payment_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettings\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettings? PaymentSettings
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettings?>();
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
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPendingInvoiceItemInterval?>();
            }

            /// <summary>Determines how to handle [prorations](https://docs.stripe.com/billing/subscriptions/prorations) resulting from the `billing_cycle_anchor`. If no value is passed, the default is `create_prorations`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#proration_behavior Subscription#proration_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProrationBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The account (if any) the subscription's payments will be attributed to for tax reporting, and where funds from each payment will be transferred to for each of the subscription's invoices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#transfer_data Subscription#transfer_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTransferData\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionTransferData? TransferData
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionTransferData?>();
            }

            /// <summary>If the subscription has a trial, the end of that trial.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_end Subscription#trial_end}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trialEnd", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TrialEnd
            {
                get => GetInstanceProperty<double?>();
            }

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
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Settings related to subscription trials.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#trial_settings Subscription#trial_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trialSettings", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionTrialSettings\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionTrialSettings? TrialSettings
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionTrialSettings?>();
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

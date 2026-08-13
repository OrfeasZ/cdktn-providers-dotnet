using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.subscriptionSchedule.SubscriptionSchedulePhases")]
    public class SubscriptionSchedulePhases : stripe.SubscriptionSchedule.ISubscriptionSchedulePhases
    {
        private object _items;

        /// <summary>Subscription items to configure the subscription to during this phase of the subscription schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#items SubscriptionSchedule#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesItems\"},\"kind\":\"array\"}}]}}")]
        public object Items
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
                        case stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesItems).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _items = value;
            }
        }

        private object? _addInvoiceItems;

        /// <summary>A list of prices and quantities that will generate invoice items appended to the next invoice for this phase.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#add_invoice_items SubscriptionSchedule#add_invoice_items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItems" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addInvoiceItems", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItems[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItems).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _addInvoiceItems = value;
            }
        }

        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the application owner's Stripe account during this phase of the schedule.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#application_fee_percent SubscriptionSchedule#application_fee_percent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationFeePercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ApplicationFeePercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#automatic_tax SubscriptionSchedule#automatic_tax}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAutomaticTax\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAutomaticTax? AutomaticTax
        {
            get;
            set;
        }

        /// <summary>Possible values are `phase_start` or `automatic`.</summary>
        /// <remarks>
        /// If <c>phase_start</c> then billing cycle anchor of the subscription is set to the start of the phase when entering the phase. If <c>automatic</c> then the billing cycle anchor is automatically modified as needed when entering the phase. For more information, see the billing cycle <a href="https://docs.stripe.com/billing/subscriptions/billing-cycle">documentation</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#billing_cycle_anchor SubscriptionSchedule#billing_cycle_anchor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BillingCycleAnchor
        {
            get;
            set;
        }

        /// <summary>Define thresholds at which an invoice will be sent, and the subscription advanced to a new billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#billing_thresholds SubscriptionSchedule#billing_thresholds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesBillingThresholds\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesBillingThresholds? BillingThresholds
        {
            get;
            set;
        }

        /// <summary>Either `charge_automatically`, or `send_invoice`.</summary>
        /// <remarks>
        /// When charging automatically, Stripe will attempt to pay the underlying subscription at the end of each billing cycle using the default source attached to the customer. When sending an invoice, Stripe will email your customer an invoice with payment instructions and mark the subscription as <c>active</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#collection_method SubscriptionSchedule#collection_method}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#currency SubscriptionSchedule#currency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Currency
        {
            get;
            set;
        }

        /// <summary>ID of the default payment method for the subscription schedule.</summary>
        /// <remarks>
        /// It must belong to the customer associated with the subscription schedule. If not set, invoices will use the default payment method in the customer's invoice settings.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#default_payment_method SubscriptionSchedule#default_payment_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultPaymentMethod
        {
            get;
            set;
        }

        /// <summary>The default tax rates to apply to the subscription during this phase of the subscription schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#default_tax_rates SubscriptionSchedule#default_tax_rates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultTaxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DefaultTaxRates
        {
            get;
            set;
        }

        /// <summary>Subscription description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#description SubscriptionSchedule#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _discounts;

        /// <summary>The stackable discounts that will be applied to the subscription on this phase.</summary>
        /// <remarks>
        /// Subscription item discounts are applied before subscription discounts.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#discounts SubscriptionSchedule#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesDiscounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesDiscounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesDiscounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _discounts = value;
            }
        }

        /// <summary>The number of intervals the phase should last. If set, `end_date` must not be set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#duration SubscriptionSchedule#duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesDuration\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesDuration? Duration
        {
            get;
            set;
        }

        /// <summary>The end of this phase of the subscription schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#end_date SubscriptionSchedule#end_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EndDate
        {
            get;
            set;
        }

        /// <summary>The invoice settings applicable during this phase.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#invoice_settings SubscriptionSchedule#invoice_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettings\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettings? InvoiceSettings
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to a phase. Metadata on a schedule's phase will update the underlying subscription's `metadata` when the phase is entered. Updating the underlying subscription's `metadata` directly will not affect the current phase's `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#metadata SubscriptionSchedule#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>The account (if any) the charge was made on behalf of for charges associated with the schedule's subscription.</summary>
        /// <remarks>
        /// See the Connect documentation for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#on_behalf_of SubscriptionSchedule#on_behalf_of}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onBehalfOf", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OnBehalfOf
        {
            get;
            set;
        }

        /// <summary>When transitioning phases, controls how prorations are handled (if any). Possible values are `create_prorations`, `none`, and `always_invoice`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#proration_behavior SubscriptionSchedule#proration_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProrationBehavior
        {
            get;
            set;
        }

        /// <summary>The start of this phase of the subscription schedule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#start_date SubscriptionSchedule#start_date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartDate
        {
            get;
            set;
        }

        /// <summary>The account (if any) the associated subscription's payments will be attributed to for tax reporting, and where funds from each payment will be transferred to for each of the subscription's invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#transfer_data SubscriptionSchedule#transfer_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesTransferData\"}", isOptional: true)]
        public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesTransferData? TransferData
        {
            get;
            set;
        }

        private object? _trial;

        /// <summary>If set to true the entire phase is counted as a trial and the customer will not be charged for any fees.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#trial SubscriptionSchedule#trial}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trial", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Trial
        {
            get => _trial;
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
                _trial = value;
            }
        }

        /// <summary>When the trial ends within the phase.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#trial_end SubscriptionSchedule#trial_end}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trialEnd", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrialEnd
        {
            get;
            set;
        }
    }
}

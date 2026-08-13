using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionScheduleDefaultSettings), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettings")]
    public interface ISubscriptionScheduleDefaultSettings
    {
        /// <summary>A non-negative decimal between 0 and 100, with at most two decimal places.</summary>
        /// <remarks>
        /// This represents the percentage of the subscription invoice total that will be transferred to the application owner's Stripe account during this phase of the schedule.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#application_fee_percent SubscriptionSchedule#application_fee_percent}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#automatic_tax SubscriptionSchedule#automatic_tax}.</summary>
        [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsAutomaticTax\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsAutomaticTax? AutomaticTax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Possible values are `phase_start` or `automatic`.</summary>
        /// <remarks>
        /// If <c>phase_start</c> then billing cycle anchor of the subscription is set to the start of the phase when entering the phase. If <c>automatic</c> then the billing cycle anchor is automatically modified as needed when entering the phase. For more information, see the billing cycle <a href="https://docs.stripe.com/billing/subscriptions/billing-cycle">documentation</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#billing_cycle_anchor SubscriptionSchedule#billing_cycle_anchor}
        /// </remarks>
        [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingCycleAnchor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Define thresholds at which an invoice will be sent, and the subscription advanced to a new billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#billing_thresholds SubscriptionSchedule#billing_thresholds}
        /// </remarks>
        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsBillingThresholds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsBillingThresholds? BillingThresholds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Either `charge_automatically`, or `send_invoice`.</summary>
        /// <remarks>
        /// When charging automatically, Stripe will attempt to pay the underlying subscription at the end of each billing cycle using the default source attached to the customer. When sending an invoice, Stripe will email your customer an invoice with payment instructions and mark the subscription as <c>active</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#collection_method SubscriptionSchedule#collection_method}
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

        /// <summary>ID of the default payment method for the subscription schedule.</summary>
        /// <remarks>
        /// If not set, invoices will use the default payment method in the customer's invoice settings.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#default_payment_method SubscriptionSchedule#default_payment_method}
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

        /// <summary>Subscription description, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// Use this field to optionally store an explanation of the subscription for rendering in Stripe surfaces and certain local payment methods UIs.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#description SubscriptionSchedule#description}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#invoice_settings SubscriptionSchedule#invoice_settings}.</summary>
        [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsInvoiceSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsInvoiceSettings? InvoiceSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>The account (if any) the charge was made on behalf of for charges associated with the schedule's subscription.</summary>
        /// <remarks>
        /// See the Connect documentation for details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#on_behalf_of SubscriptionSchedule#on_behalf_of}
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

        /// <summary>The account (if any) the associated subscription's payments will be attributed to for tax reporting, and where funds from each payment will be transferred to for each of the subscription's invoices.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#transfer_data SubscriptionSchedule#transfer_data}
        /// </remarks>
        [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsTransferData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsTransferData? TransferData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionScheduleDefaultSettings), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#automatic_tax SubscriptionSchedule#automatic_tax}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticTax", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsAutomaticTax\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsAutomaticTax? AutomaticTax
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsAutomaticTax?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Define thresholds at which an invoice will be sent, and the subscription advanced to a new billing period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#billing_thresholds SubscriptionSchedule#billing_thresholds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsBillingThresholds\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsBillingThresholds? BillingThresholds
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsBillingThresholds?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the default payment method for the subscription schedule.</summary>
            /// <remarks>
            /// If not set, invoices will use the default payment method in the customer's invoice settings.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#default_payment_method SubscriptionSchedule#default_payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultPaymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultPaymentMethod
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#invoice_settings SubscriptionSchedule#invoice_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invoiceSettings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsInvoiceSettings\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsInvoiceSettings? InvoiceSettings
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsInvoiceSettings?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The account (if any) the associated subscription's payments will be attributed to for tax reporting, and where funds from each payment will be transferred to for each of the subscription's invoices.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#transfer_data SubscriptionSchedule#transfer_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferData", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsTransferData\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsTransferData? TransferData
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettingsTransferData?>();
            }
        }
    }
}

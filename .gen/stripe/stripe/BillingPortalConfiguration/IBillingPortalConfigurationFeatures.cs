using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationFeatures), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeatures")]
    public interface IBillingPortalConfigurationFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#customer_update BillingPortalConfiguration#customer_update}.</summary>
        [JsiiProperty(name: "customerUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesCustomerUpdate? CustomerUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#invoice_history BillingPortalConfiguration#invoice_history}.</summary>
        [JsiiProperty(name: "invoiceHistory", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesInvoiceHistory? InvoiceHistory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#payment_method_update BillingPortalConfiguration#payment_method_update}.</summary>
        [JsiiProperty(name: "paymentMethodUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesPaymentMethodUpdate? PaymentMethodUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#subscription_cancel BillingPortalConfiguration#subscription_cancel}.</summary>
        [JsiiProperty(name: "subscriptionCancel", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancel\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel? SubscriptionCancel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#subscription_update BillingPortalConfiguration#subscription_update}.</summary>
        [JsiiProperty(name: "subscriptionUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate? SubscriptionUpdate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationFeatures), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeatures")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#customer_update BillingPortalConfiguration#customer_update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customerUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdate\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesCustomerUpdate? CustomerUpdate
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesCustomerUpdate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#invoice_history BillingPortalConfiguration#invoice_history}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invoiceHistory", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistory\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesInvoiceHistory? InvoiceHistory
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesInvoiceHistory?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#payment_method_update BillingPortalConfiguration#payment_method_update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethodUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdate\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesPaymentMethodUpdate? PaymentMethodUpdate
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesPaymentMethodUpdate?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#subscription_cancel BillingPortalConfiguration#subscription_cancel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionCancel", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancel\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel? SubscriptionCancel
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#subscription_update BillingPortalConfiguration#subscription_update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdate\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate? SubscriptionUpdate
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate?>();
            }
        }
    }
}

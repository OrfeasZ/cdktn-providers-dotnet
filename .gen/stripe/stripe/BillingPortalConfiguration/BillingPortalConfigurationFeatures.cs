using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiByValue(fqn: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeatures")]
    public class BillingPortalConfigurationFeatures : stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#customer_update BillingPortalConfiguration#customer_update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customerUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesCustomerUpdate\"}", isOptional: true)]
        public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesCustomerUpdate? CustomerUpdate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#invoice_history BillingPortalConfiguration#invoice_history}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invoiceHistory", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesInvoiceHistory\"}", isOptional: true)]
        public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesInvoiceHistory? InvoiceHistory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#payment_method_update BillingPortalConfiguration#payment_method_update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesPaymentMethodUpdate\"}", isOptional: true)]
        public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesPaymentMethodUpdate? PaymentMethodUpdate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#subscription_cancel BillingPortalConfiguration#subscription_cancel}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionCancel", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancel\"}", isOptional: true)]
        public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel? SubscriptionCancel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#subscription_update BillingPortalConfiguration#subscription_update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subscriptionUpdate", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdate\"}", isOptional: true)]
        public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate? SubscriptionUpdate
        {
            get;
            set;
        }
    }
}

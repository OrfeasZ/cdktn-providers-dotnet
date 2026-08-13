using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptions")]
    public class SubscriptionPaymentSettingsPaymentMethodOptions : stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptions
    {
        /// <summary>This sub-hash contains details about the Canadian pre-authorized debit payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#acss_debit Subscription#acss_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit? AcssDebit
        {
            get;
            set;
        }

        /// <summary>This sub-hash contains details about the Bancontact payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bancontact Subscription#bancontact}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBancontact\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBancontact? Bancontact
        {
            get;
            set;
        }

        /// <summary>This sub-hash contains details about the Card payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#card Subscription#card}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCard\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCard? Card
        {
            get;
            set;
        }

        /// <summary>This sub-hash contains details about the Bank transfer payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer_balance Subscription#customer_balance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerBalance", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance? CustomerBalance
        {
            get;
            set;
        }

        /// <summary>This sub-hash contains details about the PayTo payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payto Subscription#payto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPayto\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPayto? Payto
        {
            get;
            set;
        }

        /// <summary>This sub-hash contains details about the Pix payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#pix Subscription#pix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPix\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPix? Pix
        {
            get;
            set;
        }

        /// <summary>This sub-hash contains details about the UPI payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#upi Subscription#upi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUpi\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUpi? Upi
        {
            get;
            set;
        }

        /// <summary>This sub-hash contains details about the ACH direct debit payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#us_bank_account Subscription#us_bank_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount? UsBankAccount
        {
            get;
            set;
        }
    }
}

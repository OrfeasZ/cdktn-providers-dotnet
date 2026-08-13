using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiInterface(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptions")]
    public interface ISubscriptionPaymentSettingsPaymentMethodOptions
    {
        /// <summary>This sub-hash contains details about the Canadian pre-authorized debit payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#acss_debit Subscription#acss_debit}
        /// </remarks>
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit? AcssDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>This sub-hash contains details about the Bancontact payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bancontact Subscription#bancontact}
        /// </remarks>
        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBancontact\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBancontact? Bancontact
        {
            get
            {
                return null;
            }
        }

        /// <summary>This sub-hash contains details about the Card payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#card Subscription#card}
        /// </remarks>
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCard? Card
        {
            get
            {
                return null;
            }
        }

        /// <summary>This sub-hash contains details about the Bank transfer payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer_balance Subscription#customer_balance}
        /// </remarks>
        [JsiiProperty(name: "customerBalance", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance? CustomerBalance
        {
            get
            {
                return null;
            }
        }

        /// <summary>This sub-hash contains details about the PayTo payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payto Subscription#payto}
        /// </remarks>
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPayto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPayto? Payto
        {
            get
            {
                return null;
            }
        }

        /// <summary>This sub-hash contains details about the Pix payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#pix Subscription#pix}
        /// </remarks>
        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPix? Pix
        {
            get
            {
                return null;
            }
        }

        /// <summary>This sub-hash contains details about the UPI payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#upi Subscription#upi}
        /// </remarks>
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUpi? Upi
        {
            get
            {
                return null;
            }
        }

        /// <summary>This sub-hash contains details about the ACH direct debit payment method options to pass to invoices created by the subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#us_bank_account Subscription#us_bank_account}
        /// </remarks>
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount? UsBankAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionPaymentSettingsPaymentMethodOptions), fullyQualifiedName: "stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>This sub-hash contains details about the Canadian pre-authorized debit payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#acss_debit Subscription#acss_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit? AcssDebit
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit?>();
            }

            /// <summary>This sub-hash contains details about the Bancontact payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#bancontact Subscription#bancontact}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsBancontact\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBancontact? Bancontact
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsBancontact?>();
            }

            /// <summary>This sub-hash contains details about the Card payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#card Subscription#card}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCard\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCard? Card
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCard?>();
            }

            /// <summary>This sub-hash contains details about the Bank transfer payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#customer_balance Subscription#customer_balance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerBalance", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance? CustomerBalance
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance?>();
            }

            /// <summary>This sub-hash contains details about the PayTo payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#payto Subscription#payto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPayto\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPayto? Payto
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPayto?>();
            }

            /// <summary>This sub-hash contains details about the Pix payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#pix Subscription#pix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsPix\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPix? Pix
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsPix?>();
            }

            /// <summary>This sub-hash contains details about the UPI payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#upi Subscription#upi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUpi\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUpi? Upi
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUpi?>();
            }

            /// <summary>This sub-hash contains details about the ACH direct debit payment method options to pass to invoices created by the subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#us_bank_account Subscription#us_bank_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount\"}", isOptional: true)]
            public stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount? UsBankAccount
            {
                get => GetInstanceProperty<stripe.Subscription.ISubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptions")]
    public interface ISetupIntentPaymentMethodOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#acss_debit SetupIntent#acss_debit}.</summary>
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsAcssDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsAcssDebit? AcssDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bacs_debit SetupIntent#bacs_debit}.</summary>
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebit? BacsDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#card SetupIntent#card}.</summary>
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCard? Card
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#klarna SetupIntent#klarna}.</summary>
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarna\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna? Klarna
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#link SetupIntent#link}.</summary>
        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsLink\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsLink? Link
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#paypal SetupIntent#paypal}.</summary>
        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPaypal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPaypal? Paypal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payto SetupIntent#payto}.</summary>
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPayto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPayto? Payto
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#pix SetupIntent#pix}.</summary>
        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPix\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPix? Pix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sepa_debit SetupIntent#sepa_debit}.</summary>
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsSepaDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsSepaDebit? SepaDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#upi SetupIntent#upi}.</summary>
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUpi? Upi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#us_bank_account SetupIntent#us_bank_account}.</summary>
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount? UsBankAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodOptions), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodOptions")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#acss_debit SetupIntent#acss_debit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsAcssDebit\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsAcssDebit? AcssDebit
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsAcssDebit?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bacs_debit SetupIntent#bacs_debit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebit\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebit? BacsDebit
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebit?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#card SetupIntent#card}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCard\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCard? Card
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCard?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#klarna SetupIntent#klarna}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarna\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna? Klarna
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#link SetupIntent#link}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsLink\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsLink? Link
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsLink?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#paypal SetupIntent#paypal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPaypal\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPaypal? Paypal
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPaypal?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payto SetupIntent#payto}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPayto\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPayto? Payto
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPayto?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#pix SetupIntent#pix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPix\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPix? Pix
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPix?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sepa_debit SetupIntent#sepa_debit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsSepaDebit\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsSepaDebit? SepaDebit
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsSepaDebit?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#upi SetupIntent#upi}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUpi\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUpi? Upi
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUpi?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#us_bank_account SetupIntent#us_bank_account}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccount\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount? UsBankAccount
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount?>();
            }
        }
    }
}

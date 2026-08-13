using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptions")]
    public class SetupIntentPaymentMethodOptions : stripe.SetupIntent.ISetupIntentPaymentMethodOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#acss_debit SetupIntent#acss_debit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsAcssDebit\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsAcssDebit? AcssDebit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bacs_debit SetupIntent#bacs_debit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsBacsDebit\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsBacsDebit? BacsDebit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#card SetupIntent#card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsCard\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsCard? Card
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#klarna SetupIntent#klarna}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsKlarna\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsKlarna? Klarna
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#link SetupIntent#link}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsLink\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsLink? Link
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#paypal SetupIntent#paypal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPaypal\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPaypal? Paypal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payto SetupIntent#payto}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPayto\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPayto? Payto
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#pix SetupIntent#pix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsPix\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsPix? Pix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sepa_debit SetupIntent#sepa_debit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsSepaDebit\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsSepaDebit? SepaDebit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#upi SetupIntent#upi}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUpi\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUpi? Upi
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#us_bank_account SetupIntent#us_bank_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccount\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccount? UsBankAccount
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodData")]
    public class SetupIntentPaymentMethodData : stripe.SetupIntent.ISetupIntentPaymentMethodData
    {
        /// <summary>The type of the PaymentMethod.</summary>
        /// <remarks>
        /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#type SetupIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>If this is an `acss_debit` PaymentMethod, this hash contains details about the ACSS Debit payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#acss_debit SetupIntent#acss_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit? AcssDebit
        {
            get;
            set;
        }

        /// <summary>This field indicates whether this payment method can be shown again to its customer in a checkout flow.</summary>
        /// <remarks>
        /// Stripe products such as Checkout and Elements use this field to determine whether a payment method can be shown as a saved payment method in a checkout flow. The field defaults to <c>unspecified</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#allow_redisplay SetupIntent#allow_redisplay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowRedisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllowRedisplay
        {
            get;
            set;
        }

        /// <summary>If this is an `au_becs_debit` PaymentMethod, this hash contains details about the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#au_becs_debit SetupIntent#au_becs_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebit\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit? AuBecsDebit
        {
            get;
            set;
        }

        /// <summary>If this is a `bacs_debit` PaymentMethod, this hash contains details about the Bacs Direct Debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bacs_debit SetupIntent#bacs_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit? BacsDebit
        {
            get;
            set;
        }

        /// <summary>Billing information associated with the PaymentMethod that may be used or required by particular types of payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#billing_details SetupIntent#billing_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetails\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails? BillingDetails
        {
            get;
            set;
        }

        /// <summary>If this is a `boleto` PaymentMethod, this hash contains details about the Boleto payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#boleto SetupIntent#boleto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBoleto\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto? Boleto
        {
            get;
            set;
        }

        /// <summary>If this is an `eps` PaymentMethod, this hash contains details about the EPS payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#eps SetupIntent#eps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataEps\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataEps? Eps
        {
            get;
            set;
        }

        /// <summary>If this is an `fpx` PaymentMethod, this hash contains details about the FPX payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#fpx SetupIntent#fpx}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataFpx\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx? Fpx
        {
            get;
            set;
        }

        /// <summary>If this is an `ideal` PaymentMethod, this hash contains details about the iDEAL payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#ideal SetupIntent#ideal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataIdeal\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal? Ideal
        {
            get;
            set;
        }

        /// <summary>If this is a `klarna` PaymentMethod, this hash contains details about the Klarna payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#klarna SetupIntent#klarna}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarna\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna? Klarna
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#metadata SetupIntent#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>If this is a `naver_pay` PaymentMethod, this hash contains details about the Naver Pay payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#naver_pay SetupIntent#naver_pay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay? NaverPay
        {
            get;
            set;
        }

        /// <summary>If this is an nz_bank_account PaymentMethod, this hash contains details about the nz_bank_account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#nz_bank_account SetupIntent#nz_bank_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNzBankAccount\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataNzBankAccount? NzBankAccount
        {
            get;
            set;
        }

        /// <summary>If this is a `p24` PaymentMethod, this hash contains details about the P24 payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#p24 SetupIntent#p24}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataP24\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataP24? P24
        {
            get;
            set;
        }

        /// <summary>If this is a `payto` PaymentMethod, this hash contains details about the PayTo payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payto SetupIntent#payto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataPayto\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto? Payto
        {
            get;
            set;
        }

        /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#radar_options SetupIntent#radar_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataRadarOptions\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataRadarOptions? RadarOptions
        {
            get;
            set;
        }

        /// <summary>If this is a `sepa_debit` PaymentMethod, this hash contains details about the SEPA debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sepa_debit SetupIntent#sepa_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebit\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit? SepaDebit
        {
            get;
            set;
        }

        /// <summary>If this is a `sofort` PaymentMethod, this hash contains details about the SOFORT payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sofort SetupIntent#sofort}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSofort\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort? Sofort
        {
            get;
            set;
        }

        /// <summary>If this is a `upi` PaymentMethod, this hash contains details about the UPI payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#upi SetupIntent#upi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpi\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi? Upi
        {
            get;
            set;
        }

        /// <summary>If this is an `us_bank_account` PaymentMethod, this hash contains details about the US bank account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#us_bank_account SetupIntent#us_bank_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUsBankAccount\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodDataUsBankAccount? UsBankAccount
        {
            get;
            set;
        }
    }
}

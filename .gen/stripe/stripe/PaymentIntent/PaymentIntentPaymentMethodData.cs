using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodData")]
    public class PaymentIntentPaymentMethodData : stripe.PaymentIntent.IPaymentIntentPaymentMethodData
    {
        /// <summary>The type of the PaymentMethod.</summary>
        /// <remarks>
        /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>If this is an `acss_debit` PaymentMethod, this hash contains details about the ACSS Debit payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#acss_debit PaymentIntent#acss_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebit\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit? AcssDebit
        {
            get;
            set;
        }

        /// <summary>This field indicates whether this payment method can be shown again to its customer in a checkout flow.</summary>
        /// <remarks>
        /// Stripe products such as Checkout and Elements use this field to determine whether a payment method can be shown as a saved payment method in a checkout flow. The field defaults to <c>unspecified</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#allow_redisplay PaymentIntent#allow_redisplay}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#au_becs_debit PaymentIntent#au_becs_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebit\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit? AuBecsDebit
        {
            get;
            set;
        }

        /// <summary>If this is a `bacs_debit` PaymentMethod, this hash contains details about the Bacs Direct Debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bacs_debit PaymentIntent#bacs_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBacsDebit\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBacsDebit? BacsDebit
        {
            get;
            set;
        }

        /// <summary>Billing information associated with the PaymentMethod that may be used or required by particular types of payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#billing_details PaymentIntent#billing_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetails\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails? BillingDetails
        {
            get;
            set;
        }

        /// <summary>If this is a `boleto` PaymentMethod, this hash contains details about the Boleto payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#boleto PaymentIntent#boleto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBoleto\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto? Boleto
        {
            get;
            set;
        }

        /// <summary>If this is an `eps` PaymentMethod, this hash contains details about the EPS payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#eps PaymentIntent#eps}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataEps\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataEps? Eps
        {
            get;
            set;
        }

        /// <summary>If this is an `fpx` PaymentMethod, this hash contains details about the FPX payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#fpx PaymentIntent#fpx}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataFpx\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx? Fpx
        {
            get;
            set;
        }

        /// <summary>If this is an `ideal` PaymentMethod, this hash contains details about the iDEAL payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#ideal PaymentIntent#ideal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataIdeal\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal? Ideal
        {
            get;
            set;
        }

        /// <summary>If this is a `klarna` PaymentMethod, this hash contains details about the Klarna payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#klarna PaymentIntent#klarna}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna? Klarna
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#metadata PaymentIntent#metadata}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#naver_pay PaymentIntent#naver_pay}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNaverPay\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNaverPay? NaverPay
        {
            get;
            set;
        }

        /// <summary>If this is an nz_bank_account PaymentMethod, this hash contains details about the nz_bank_account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#nz_bank_account PaymentIntent#nz_bank_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccount\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount? NzBankAccount
        {
            get;
            set;
        }

        /// <summary>If this is a `p24` PaymentMethod, this hash contains details about the P24 payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#p24 PaymentIntent#p24}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataP24\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24? P24
        {
            get;
            set;
        }

        /// <summary>If this is a `payto` PaymentMethod, this hash contains details about the PayTo payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payto PaymentIntent#payto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataPayto\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto? Payto
        {
            get;
            set;
        }

        /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#radar_options PaymentIntent#radar_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataRadarOptions\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataRadarOptions? RadarOptions
        {
            get;
            set;
        }

        /// <summary>If this is a `sepa_debit` PaymentMethod, this hash contains details about the SEPA debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#sepa_debit PaymentIntent#sepa_debit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebit\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit? SepaDebit
        {
            get;
            set;
        }

        /// <summary>If this is a `sofort` PaymentMethod, this hash contains details about the SOFORT payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#sofort PaymentIntent#sofort}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSofort\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSofort? Sofort
        {
            get;
            set;
        }

        /// <summary>If this is a `upi` PaymentMethod, this hash contains details about the UPI payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#upi PaymentIntent#upi}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUpi\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUpi? Upi
        {
            get;
            set;
        }

        /// <summary>If this is an `us_bank_account` PaymentMethod, this hash contains details about the US bank account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#us_bank_account PaymentIntent#us_bank_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUsBankAccount\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount? UsBankAccount
        {
            get;
            set;
        }
    }
}

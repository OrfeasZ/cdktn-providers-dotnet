using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodData), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodData")]
    public interface IPaymentIntentPaymentMethodData
    {
        /// <summary>The type of the PaymentMethod.</summary>
        /// <remarks>
        /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>If this is an `acss_debit` PaymentMethod, this hash contains details about the ACSS Debit payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#acss_debit PaymentIntent#acss_debit}
        /// </remarks>
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit? AcssDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>This field indicates whether this payment method can be shown again to its customer in a checkout flow.</summary>
        /// <remarks>
        /// Stripe products such as Checkout and Elements use this field to determine whether a payment method can be shown as a saved payment method in a checkout flow. The field defaults to <c>unspecified</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#allow_redisplay PaymentIntent#allow_redisplay}
        /// </remarks>
        [JsiiProperty(name: "allowRedisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowRedisplay
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `au_becs_debit` PaymentMethod, this hash contains details about the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#au_becs_debit PaymentIntent#au_becs_debit}
        /// </remarks>
        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit? AuBecsDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `bacs_debit` PaymentMethod, this hash contains details about the Bacs Direct Debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bacs_debit PaymentIntent#bacs_debit}
        /// </remarks>
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBacsDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBacsDebit? BacsDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Billing information associated with the PaymentMethod that may be used or required by particular types of payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#billing_details PaymentIntent#billing_details}
        /// </remarks>
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails? BillingDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `boleto` PaymentMethod, this hash contains details about the Boleto payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#boleto PaymentIntent#boleto}
        /// </remarks>
        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBoleto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto? Boleto
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `eps` PaymentMethod, this hash contains details about the EPS payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#eps PaymentIntent#eps}
        /// </remarks>
        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataEps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataEps? Eps
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `fpx` PaymentMethod, this hash contains details about the FPX payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#fpx PaymentIntent#fpx}
        /// </remarks>
        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataFpx\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx? Fpx
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `ideal` PaymentMethod, this hash contains details about the iDEAL payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#ideal PaymentIntent#ideal}
        /// </remarks>
        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataIdeal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal? Ideal
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `klarna` PaymentMethod, this hash contains details about the Klarna payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#klarna PaymentIntent#klarna}
        /// </remarks>
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna? Klarna
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#metadata PaymentIntent#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `naver_pay` PaymentMethod, this hash contains details about the Naver Pay payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#naver_pay PaymentIntent#naver_pay}
        /// </remarks>
        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNaverPay\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNaverPay? NaverPay
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an nz_bank_account PaymentMethod, this hash contains details about the nz_bank_account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#nz_bank_account PaymentIntent#nz_bank_account}
        /// </remarks>
        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount? NzBankAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `p24` PaymentMethod, this hash contains details about the P24 payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#p24 PaymentIntent#p24}
        /// </remarks>
        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataP24\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24? P24
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `payto` PaymentMethod, this hash contains details about the PayTo payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payto PaymentIntent#payto}
        /// </remarks>
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataPayto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto? Payto
        {
            get
            {
                return null;
            }
        }

        /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#radar_options PaymentIntent#radar_options}
        /// </remarks>
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataRadarOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataRadarOptions? RadarOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `sepa_debit` PaymentMethod, this hash contains details about the SEPA debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#sepa_debit PaymentIntent#sepa_debit}
        /// </remarks>
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit? SepaDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `sofort` PaymentMethod, this hash contains details about the SOFORT payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#sofort PaymentIntent#sofort}
        /// </remarks>
        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSofort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSofort? Sofort
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `upi` PaymentMethod, this hash contains details about the UPI payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#upi PaymentIntent#upi}
        /// </remarks>
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUpi? Upi
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `us_bank_account` PaymentMethod, this hash contains details about the US bank account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#us_bank_account PaymentIntent#us_bank_account}
        /// </remarks>
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUsBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount? UsBankAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodData), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodData")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of the PaymentMethod.</summary>
            /// <remarks>
            /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#type PaymentIntent#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If this is an `acss_debit` PaymentMethod, this hash contains details about the ACSS Debit payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#acss_debit PaymentIntent#acss_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebit\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit? AcssDebit
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If this is an `au_becs_debit` PaymentMethod, this hash contains details about the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#au_becs_debit PaymentIntent#au_becs_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebit\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit? AuBecsDebit
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit?>();
            }

            /// <summary>If this is a `bacs_debit` PaymentMethod, this hash contains details about the Bacs Direct Debit bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#bacs_debit PaymentIntent#bacs_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBacsDebit\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBacsDebit? BacsDebit
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBacsDebit?>();
            }

            /// <summary>Billing information associated with the PaymentMethod that may be used or required by particular types of payment methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#billing_details PaymentIntent#billing_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetails\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails? BillingDetails
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails?>();
            }

            /// <summary>If this is a `boleto` PaymentMethod, this hash contains details about the Boleto payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#boleto PaymentIntent#boleto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBoleto\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto? Boleto
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto?>();
            }

            /// <summary>If this is an `eps` PaymentMethod, this hash contains details about the EPS payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#eps PaymentIntent#eps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataEps\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataEps? Eps
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataEps?>();
            }

            /// <summary>If this is an `fpx` PaymentMethod, this hash contains details about the FPX payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#fpx PaymentIntent#fpx}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataFpx\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx? Fpx
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx?>();
            }

            /// <summary>If this is an `ideal` PaymentMethod, this hash contains details about the iDEAL payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#ideal PaymentIntent#ideal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataIdeal\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal? Ideal
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal?>();
            }

            /// <summary>If this is a `klarna` PaymentMethod, this hash contains details about the Klarna payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#klarna PaymentIntent#klarna}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna? Klarna
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#metadata PaymentIntent#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>If this is a `naver_pay` PaymentMethod, this hash contains details about the Naver Pay payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#naver_pay PaymentIntent#naver_pay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNaverPay\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNaverPay? NaverPay
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNaverPay?>();
            }

            /// <summary>If this is an nz_bank_account PaymentMethod, this hash contains details about the nz_bank_account payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#nz_bank_account PaymentIntent#nz_bank_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccount\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount? NzBankAccount
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount?>();
            }

            /// <summary>If this is a `p24` PaymentMethod, this hash contains details about the P24 payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#p24 PaymentIntent#p24}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataP24\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24? P24
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24?>();
            }

            /// <summary>If this is a `payto` PaymentMethod, this hash contains details about the PayTo payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#payto PaymentIntent#payto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataPayto\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto? Payto
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto?>();
            }

            /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#radar_options PaymentIntent#radar_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataRadarOptions\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataRadarOptions? RadarOptions
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataRadarOptions?>();
            }

            /// <summary>If this is a `sepa_debit` PaymentMethod, this hash contains details about the SEPA debit bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#sepa_debit PaymentIntent#sepa_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebit\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit? SepaDebit
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit?>();
            }

            /// <summary>If this is a `sofort` PaymentMethod, this hash contains details about the SOFORT payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#sofort PaymentIntent#sofort}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSofort\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSofort? Sofort
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSofort?>();
            }

            /// <summary>If this is a `upi` PaymentMethod, this hash contains details about the UPI payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#upi PaymentIntent#upi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUpi\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUpi? Upi
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUpi?>();
            }

            /// <summary>If this is an `us_bank_account` PaymentMethod, this hash contains details about the US bank account payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#us_bank_account PaymentIntent#us_bank_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUsBankAccount\"}", isOptional: true)]
            public stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount? UsBankAccount
            {
                get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount?>();
            }
        }
    }
}

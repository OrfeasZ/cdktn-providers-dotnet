using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodData), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodData")]
    public interface ISetupIntentPaymentMethodData
    {
        /// <summary>The type of the PaymentMethod.</summary>
        /// <remarks>
        /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#type SetupIntent#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>If this is an `acss_debit` PaymentMethod, this hash contains details about the ACSS Debit payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#acss_debit SetupIntent#acss_debit}
        /// </remarks>
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit? AcssDebit
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#allow_redisplay SetupIntent#allow_redisplay}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#au_becs_debit SetupIntent#au_becs_debit}
        /// </remarks>
        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit? AuBecsDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `bacs_debit` PaymentMethod, this hash contains details about the Bacs Direct Debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bacs_debit SetupIntent#bacs_debit}
        /// </remarks>
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit? BacsDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Billing information associated with the PaymentMethod that may be used or required by particular types of payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#billing_details SetupIntent#billing_details}
        /// </remarks>
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails? BillingDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `boleto` PaymentMethod, this hash contains details about the Boleto payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#boleto SetupIntent#boleto}
        /// </remarks>
        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBoleto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto? Boleto
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `eps` PaymentMethod, this hash contains details about the EPS payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#eps SetupIntent#eps}
        /// </remarks>
        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataEps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataEps? Eps
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `fpx` PaymentMethod, this hash contains details about the FPX payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#fpx SetupIntent#fpx}
        /// </remarks>
        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataFpx\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx? Fpx
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `ideal` PaymentMethod, this hash contains details about the iDEAL payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#ideal SetupIntent#ideal}
        /// </remarks>
        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataIdeal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal? Ideal
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `klarna` PaymentMethod, this hash contains details about the Klarna payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#klarna SetupIntent#klarna}
        /// </remarks>
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarna\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna? Klarna
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#metadata SetupIntent#metadata}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#naver_pay SetupIntent#naver_pay}
        /// </remarks>
        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay? NaverPay
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an nz_bank_account PaymentMethod, this hash contains details about the nz_bank_account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#nz_bank_account SetupIntent#nz_bank_account}
        /// </remarks>
        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNzBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataNzBankAccount? NzBankAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `p24` PaymentMethod, this hash contains details about the P24 payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#p24 SetupIntent#p24}
        /// </remarks>
        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataP24\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataP24? P24
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `payto` PaymentMethod, this hash contains details about the PayTo payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payto SetupIntent#payto}
        /// </remarks>
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataPayto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto? Payto
        {
            get
            {
                return null;
            }
        }

        /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#radar_options SetupIntent#radar_options}
        /// </remarks>
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataRadarOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataRadarOptions? RadarOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `sepa_debit` PaymentMethod, this hash contains details about the SEPA debit bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sepa_debit SetupIntent#sepa_debit}
        /// </remarks>
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit? SepaDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `sofort` PaymentMethod, this hash contains details about the SOFORT payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sofort SetupIntent#sofort}
        /// </remarks>
        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSofort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort? Sofort
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is a `upi` PaymentMethod, this hash contains details about the UPI payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#upi SetupIntent#upi}
        /// </remarks>
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi? Upi
        {
            get
            {
                return null;
            }
        }

        /// <summary>If this is an `us_bank_account` PaymentMethod, this hash contains details about the US bank account payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#us_bank_account SetupIntent#us_bank_account}
        /// </remarks>
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUsBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SetupIntent.ISetupIntentPaymentMethodDataUsBankAccount? UsBankAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodData), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodData")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The type of the PaymentMethod.</summary>
            /// <remarks>
            /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#type SetupIntent#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>If this is an `acss_debit` PaymentMethod, this hash contains details about the ACSS Debit payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#acss_debit SetupIntent#acss_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit? AcssDebit
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If this is an `au_becs_debit` PaymentMethod, this hash contains details about the bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#au_becs_debit SetupIntent#au_becs_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebit\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit? AuBecsDebit
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit?>();
            }

            /// <summary>If this is a `bacs_debit` PaymentMethod, this hash contains details about the Bacs Direct Debit bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#bacs_debit SetupIntent#bacs_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit? BacsDebit
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit?>();
            }

            /// <summary>Billing information associated with the PaymentMethod that may be used or required by particular types of payment methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#billing_details SetupIntent#billing_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetails\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails? BillingDetails
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails?>();
            }

            /// <summary>If this is a `boleto` PaymentMethod, this hash contains details about the Boleto payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#boleto SetupIntent#boleto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBoleto\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto? Boleto
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto?>();
            }

            /// <summary>If this is an `eps` PaymentMethod, this hash contains details about the EPS payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#eps SetupIntent#eps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataEps\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataEps? Eps
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataEps?>();
            }

            /// <summary>If this is an `fpx` PaymentMethod, this hash contains details about the FPX payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#fpx SetupIntent#fpx}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataFpx\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx? Fpx
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx?>();
            }

            /// <summary>If this is an `ideal` PaymentMethod, this hash contains details about the iDEAL payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#ideal SetupIntent#ideal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataIdeal\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal? Ideal
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal?>();
            }

            /// <summary>If this is a `klarna` PaymentMethod, this hash contains details about the Klarna payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#klarna SetupIntent#klarna}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarna\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna? Klarna
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#metadata SetupIntent#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>If this is a `naver_pay` PaymentMethod, this hash contains details about the Naver Pay payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#naver_pay SetupIntent#naver_pay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay? NaverPay
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay?>();
            }

            /// <summary>If this is an nz_bank_account PaymentMethod, this hash contains details about the nz_bank_account payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#nz_bank_account SetupIntent#nz_bank_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNzBankAccount\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataNzBankAccount? NzBankAccount
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataNzBankAccount?>();
            }

            /// <summary>If this is a `p24` PaymentMethod, this hash contains details about the P24 payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#p24 SetupIntent#p24}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataP24\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataP24? P24
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataP24?>();
            }

            /// <summary>If this is a `payto` PaymentMethod, this hash contains details about the PayTo payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#payto SetupIntent#payto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataPayto\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto? Payto
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto?>();
            }

            /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#radar_options SetupIntent#radar_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataRadarOptions\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataRadarOptions? RadarOptions
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataRadarOptions?>();
            }

            /// <summary>If this is a `sepa_debit` PaymentMethod, this hash contains details about the SEPA debit bank account.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sepa_debit SetupIntent#sepa_debit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebit\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit? SepaDebit
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit?>();
            }

            /// <summary>If this is a `sofort` PaymentMethod, this hash contains details about the SOFORT payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#sofort SetupIntent#sofort}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSofort\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort? Sofort
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort?>();
            }

            /// <summary>If this is a `upi` PaymentMethod, this hash contains details about the UPI payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#upi SetupIntent#upi}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpi\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi? Upi
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi?>();
            }

            /// <summary>If this is an `us_bank_account` PaymentMethod, this hash contains details about the US bank account payment method.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#us_bank_account SetupIntent#us_bank_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUsBankAccount\"}", isOptional: true)]
            public stripe.SetupIntent.ISetupIntentPaymentMethodDataUsBankAccount? UsBankAccount
            {
                get => GetInstanceProperty<stripe.SetupIntent.ISetupIntentPaymentMethodDataUsBankAccount?>();
            }
        }
    }
}

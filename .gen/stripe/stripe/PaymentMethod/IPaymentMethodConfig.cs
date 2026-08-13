using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodConfig), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodConfig")]
    public interface IPaymentMethodConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#acss_debit PaymentMethod#acss_debit}.</summary>
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAcssDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodAcssDebit? AcssDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>This field indicates whether this payment method can be shown again to its customer in a checkout flow.</summary>
        /// <remarks>
        /// Stripe products such as Checkout and Elements use this field to determine whether a payment method can be shown as a saved payment method in a checkout flow. The field defaults to “unspecified”.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#allow_redisplay PaymentMethod#allow_redisplay}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#au_becs_debit PaymentMethod#au_becs_debit}.</summary>
        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAuBecsDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodAuBecsDebit? AuBecsDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bacs_debit PaymentMethod#bacs_debit}.</summary>
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBacsDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodBacsDebit? BacsDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#billing_details PaymentMethod#billing_details}.</summary>
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBillingDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodBillingDetails? BillingDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#boleto PaymentMethod#boleto}.</summary>
        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBoleto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodBoleto? Boleto
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#card PaymentMethod#card}.</summary>
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodCard? Card
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#cashapp PaymentMethod#cashapp}.</summary>
        [JsiiProperty(name: "cashapp", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCashapp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodCashapp? Cashapp
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the Customer to which this PaymentMethod is saved.</summary>
        /// <remarks>
        /// This will not be set when the PaymentMethod has not been saved to a Customer.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#customer PaymentMethod#customer}
        /// </remarks>
        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Customer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#eps PaymentMethod#eps}.</summary>
        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodEps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodEps? Eps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#fpx PaymentMethod#fpx}.</summary>
        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodFpx\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodFpx? Fpx
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#ideal PaymentMethod#ideal}.</summary>
        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodIdeal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodIdeal? Ideal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#interac_present PaymentMethod#interac_present}.</summary>
        [JsiiProperty(name: "interacPresent", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodInteracPresent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodInteracPresent? InteracPresent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#klarna PaymentMethod#klarna}.</summary>
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarna\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodKlarna? Klarna
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#kr_card PaymentMethod#kr_card}.</summary>
        [JsiiProperty(name: "krCard", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKrCard\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodKrCard? KrCard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#link PaymentMethod#link}.</summary>
        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodLink\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodLink? Link
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#metadata PaymentMethod#metadata}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#naver_pay PaymentMethod#naver_pay}.</summary>
        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNaverPay\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodNaverPay? NaverPay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#nz_bank_account PaymentMethod#nz_bank_account}.</summary>
        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNzBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodNzBankAccount? NzBankAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#p24 PaymentMethod#p24}.</summary>
        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodP24\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodP24? P24
        {
            get
            {
                return null;
            }
        }

        /// <summary>The PaymentMethod to share.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#payment_method PaymentMethod#payment_method}
        /// </remarks>
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#paypal PaymentMethod#paypal}.</summary>
        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPaypal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodPaypal? Paypal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#payto PaymentMethod#payto}.</summary>
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPayto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodPayto? Payto
        {
            get
            {
                return null;
            }
        }

        /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#radar_options PaymentMethod#radar_options}
        /// </remarks>
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodRadarOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodRadarOptions? RadarOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#sepa_debit PaymentMethod#sepa_debit}.</summary>
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSepaDebit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodSepaDebit? SepaDebit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#sofort PaymentMethod#sofort}.</summary>
        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSofort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodSofort? Sofort
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of the PaymentMethod.</summary>
        /// <remarks>
        /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#type PaymentMethod#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#upi PaymentMethod#upi}.</summary>
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpi\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodUpi? Upi
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#us_bank_account PaymentMethod#us_bank_account}.</summary>
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentMethod.IPaymentMethodUsBankAccount? UsBankAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodConfig), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#acss_debit PaymentMethod#acss_debit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAcssDebit\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodAcssDebit? AcssDebit
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodAcssDebit?>();
            }

            /// <summary>This field indicates whether this payment method can be shown again to its customer in a checkout flow.</summary>
            /// <remarks>
            /// Stripe products such as Checkout and Elements use this field to determine whether a payment method can be shown as a saved payment method in a checkout flow. The field defaults to “unspecified”.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#allow_redisplay PaymentMethod#allow_redisplay}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowRedisplay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowRedisplay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#au_becs_debit PaymentMethod#au_becs_debit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAuBecsDebit\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodAuBecsDebit? AuBecsDebit
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodAuBecsDebit?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bacs_debit PaymentMethod#bacs_debit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBacsDebit\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodBacsDebit? BacsDebit
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodBacsDebit?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#billing_details PaymentMethod#billing_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBillingDetails\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodBillingDetails? BillingDetails
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodBillingDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#boleto PaymentMethod#boleto}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBoleto\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodBoleto? Boleto
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodBoleto?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#card PaymentMethod#card}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCard\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodCard? Card
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCard?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#cashapp PaymentMethod#cashapp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cashapp", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCashapp\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodCashapp? Cashapp
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodCashapp?>();
            }

            /// <summary>The ID of the Customer to which this PaymentMethod is saved.</summary>
            /// <remarks>
            /// This will not be set when the PaymentMethod has not been saved to a Customer.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#customer PaymentMethod#customer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Customer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#eps PaymentMethod#eps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodEps\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodEps? Eps
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodEps?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#fpx PaymentMethod#fpx}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodFpx\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodFpx? Fpx
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodFpx?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#ideal PaymentMethod#ideal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodIdeal\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodIdeal? Ideal
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodIdeal?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#interac_present PaymentMethod#interac_present}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interacPresent", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodInteracPresent\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodInteracPresent? InteracPresent
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodInteracPresent?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#klarna PaymentMethod#klarna}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarna\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodKlarna? Klarna
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodKlarna?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#kr_card PaymentMethod#kr_card}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "krCard", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKrCard\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodKrCard? KrCard
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodKrCard?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#link PaymentMethod#link}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodLink\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodLink? Link
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodLink?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#metadata PaymentMethod#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#naver_pay PaymentMethod#naver_pay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNaverPay\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodNaverPay? NaverPay
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodNaverPay?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#nz_bank_account PaymentMethod#nz_bank_account}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNzBankAccount\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodNzBankAccount? NzBankAccount
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodNzBankAccount?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#p24 PaymentMethod#p24}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodP24\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodP24? P24
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodP24?>();
            }

            /// <summary>The PaymentMethod to share.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#payment_method PaymentMethod#payment_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#paypal PaymentMethod#paypal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPaypal\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodPaypal? Paypal
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodPaypal?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#payto PaymentMethod#payto}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPayto\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodPayto? Payto
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodPayto?>();
            }

            /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#radar_options PaymentMethod#radar_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodRadarOptions\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodRadarOptions? RadarOptions
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodRadarOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#sepa_debit PaymentMethod#sepa_debit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSepaDebit\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodSepaDebit? SepaDebit
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodSepaDebit?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#sofort PaymentMethod#sofort}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSofort\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodSofort? Sofort
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodSofort?>();
            }

            /// <summary>The type of the PaymentMethod.</summary>
            /// <remarks>
            /// An additional hash is included on the PaymentMethod with a name matching this value. It contains additional information specific to the PaymentMethod type.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#type PaymentMethod#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#upi PaymentMethod#upi}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpi\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodUpi? Upi
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodUpi?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#us_bank_account PaymentMethod#us_bank_account}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccount\"}", isOptional: true)]
            public stripe.PaymentMethod.IPaymentMethodUsBankAccount? UsBankAccount
            {
                get => GetInstanceProperty<stripe.PaymentMethod.IPaymentMethodUsBankAccount?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

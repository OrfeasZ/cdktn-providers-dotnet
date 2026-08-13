using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodConfig")]
    public class PaymentMethodConfig : stripe.PaymentMethod.IPaymentMethodConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#acss_debit PaymentMethod#acss_debit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAcssDebit\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodAcssDebit? AcssDebit
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#au_becs_debit PaymentMethod#au_becs_debit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAuBecsDebit\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodAuBecsDebit? AuBecsDebit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bacs_debit PaymentMethod#bacs_debit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBacsDebit\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodBacsDebit? BacsDebit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#billing_details PaymentMethod#billing_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBillingDetails\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodBillingDetails? BillingDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#boleto PaymentMethod#boleto}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBoleto\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodBoleto? Boleto
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#card PaymentMethod#card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCard\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodCard? Card
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#cashapp PaymentMethod#cashapp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cashapp", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCashapp\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodCashapp? Cashapp
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#eps PaymentMethod#eps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodEps\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodEps? Eps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#fpx PaymentMethod#fpx}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodFpx\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodFpx? Fpx
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#ideal PaymentMethod#ideal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodIdeal\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodIdeal? Ideal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#interac_present PaymentMethod#interac_present}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interacPresent", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodInteracPresent\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodInteracPresent? InteracPresent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#klarna PaymentMethod#klarna}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarna\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodKlarna? Klarna
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#kr_card PaymentMethod#kr_card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "krCard", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKrCard\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodKrCard? KrCard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#link PaymentMethod#link}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodLink\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodLink? Link
        {
            get;
            set;
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#metadata PaymentMethod#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#naver_pay PaymentMethod#naver_pay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNaverPay\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodNaverPay? NaverPay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#nz_bank_account PaymentMethod#nz_bank_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNzBankAccount\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodNzBankAccount? NzBankAccount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#p24 PaymentMethod#p24}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodP24\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodP24? P24
        {
            get;
            set;
        }

        /// <summary>The PaymentMethod to share.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#payment_method PaymentMethod#payment_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PaymentMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#paypal PaymentMethod#paypal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPaypal\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodPaypal? Paypal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#payto PaymentMethod#payto}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPayto\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodPayto? Payto
        {
            get;
            set;
        }

        /// <summary>Options to configure Radar. See [Radar Session](https://docs.stripe.com/radar/radar-session) for more information.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#radar_options PaymentMethod#radar_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodRadarOptions\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodRadarOptions? RadarOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#sepa_debit PaymentMethod#sepa_debit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSepaDebit\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodSepaDebit? SepaDebit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#sofort PaymentMethod#sofort}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSofort\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodSofort? Sofort
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#upi PaymentMethod#upi}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpi\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodUpi? Upi
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#us_bank_account PaymentMethod#us_bank_account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccount\"}", isOptional: true)]
        public stripe.PaymentMethod.IPaymentMethodUsBankAccount? UsBankAccount
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}

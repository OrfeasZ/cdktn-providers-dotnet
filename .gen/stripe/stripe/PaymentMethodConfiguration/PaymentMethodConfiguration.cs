using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethodConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration stripe_payment_method_configuration}.</summary>
    [JsiiClass(nativeType: typeof(stripe.PaymentMethodConfiguration.PaymentMethodConfiguration), fullyQualifiedName: "stripe.paymentMethodConfiguration.PaymentMethodConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationConfig\"}}]")]
    public class PaymentMethodConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration stripe_payment_method_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PaymentMethodConfiguration(Constructs.Construct scope, string id, stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethodConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PaymentMethodConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PaymentMethodConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing PaymentMethodConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PaymentMethodConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PaymentMethodConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PaymentMethodConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PaymentMethodConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.PaymentMethodConfiguration.PaymentMethodConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAcssDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAcssDebit\"}}]")]
        public virtual void PutAcssDebit(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAcssDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAcssDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAffirm", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAffirm\"}}]")]
        public virtual void PutAffirm(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAffirm @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAffirm)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAfterpayClearpay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAfterpayClearpay\"}}]")]
        public virtual void PutAfterpayClearpay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAfterpayClearpay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAfterpayClearpay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlipay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlipay\"}}]")]
        public virtual void PutAlipay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlipay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlipay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAlma", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlma\"}}]")]
        public virtual void PutAlma(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlma @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlma)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAmazonPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAmazonPay\"}}]")]
        public virtual void PutAmazonPay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAmazonPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAmazonPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApplePay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePay\"}}]")]
        public virtual void PutApplePay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationApplePay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationApplePay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApplePayLater", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePayLater\"}}]")]
        public virtual void PutApplePayLater(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationApplePayLater @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationApplePayLater)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuBecsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAuBecsDebit\"}}]")]
        public virtual void PutAuBecsDebit(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAuBecsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAuBecsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBacsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBacsDebit\"}}]")]
        public virtual void PutBacsDebit(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBacsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBacsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBancontact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBancontact\"}}]")]
        public virtual void PutBancontact(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBancontact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBancontact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBillie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBillie\"}}]")]
        public virtual void PutBillie(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBillie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBillie)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBizum", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBizum\"}}]")]
        public virtual void PutBizum(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBizum @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBizum)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlik", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBlik\"}}]")]
        public virtual void PutBlik(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBlik @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBlik)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoleto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBoleto\"}}]")]
        public virtual void PutBoleto(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBoleto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBoleto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCard\"}}]")]
        public virtual void PutCard(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCartesBancaires", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCartesBancaires\"}}]")]
        public virtual void PutCartesBancaires(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCartesBancaires @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCartesBancaires)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCashapp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCashapp\"}}]")]
        public virtual void PutCashapp(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCashapp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCashapp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCrypto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCrypto\"}}]")]
        public virtual void PutCrypto(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCrypto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCrypto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomerBalance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCustomerBalance\"}}]")]
        public virtual void PutCustomerBalance(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCustomerBalance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCustomerBalance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationEps\"}}]")]
        public virtual void PutEps(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationEps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationEps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFpx", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationFpx\"}}]")]
        public virtual void PutFpx(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationFpx @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationFpx)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGiropay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGiropay\"}}]")]
        public virtual void PutGiropay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGiropay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGiropay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGooglePay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGooglePay\"}}]")]
        public virtual void PutGooglePay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGooglePay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGooglePay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrabpay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGrabpay\"}}]")]
        public virtual void PutGrabpay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGrabpay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGrabpay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdeal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationIdeal\"}}]")]
        public virtual void PutIdeal(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationIdeal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationIdeal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJcb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationJcb\"}}]")]
        public virtual void PutJcb(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationJcb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationJcb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKakaoPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKakaoPay\"}}]")]
        public virtual void PutKakaoPay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKakaoPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKakaoPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKlarna", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarna\"}}]")]
        public virtual void PutKlarna(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarna @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarna)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKonbini", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKonbini\"}}]")]
        public virtual void PutKonbini(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKonbini @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKonbini)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKrCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKrCard\"}}]")]
        public virtual void PutKrCard(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKrCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKrCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLink", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationLink\"}}]")]
        public virtual void PutLink(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationLink @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationLink)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMbWay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMbWay\"}}]")]
        public virtual void PutMbWay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMbWay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMbWay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMobilepay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMobilepay\"}}]")]
        public virtual void PutMobilepay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMobilepay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMobilepay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMultibanco", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMultibanco\"}}]")]
        public virtual void PutMultibanco(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMultibanco @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMultibanco)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNaverPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationNaverPay\"}}]")]
        public virtual void PutNaverPay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationNaverPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationNaverPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNzBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationNzBankAccount\"}}]")]
        public virtual void PutNzBankAccount(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationNzBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationNzBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOxxo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationOxxo\"}}]")]
        public virtual void PutOxxo(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationOxxo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationOxxo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putP24", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationP24\"}}]")]
        public virtual void PutP24(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationP24 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationP24)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayByBank", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPayByBank\"}}]")]
        public virtual void PutPayByBank(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayByBank @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayByBank)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayco", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPayco\"}}]")]
        public virtual void PutPayco(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayco @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayco)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaynow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynow\"}}]")]
        public virtual void PutPaynow(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaypal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaypal\"}}]")]
        public virtual void PutPaypal(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaypal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaypal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPayto\"}}]")]
        public virtual void PutPayto(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPix\"}}]")]
        public virtual void PutPix(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPix)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPromptpay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpay\"}}]")]
        public virtual void PutPromptpay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRevolutPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationRevolutPay\"}}]")]
        public virtual void PutRevolutPay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationRevolutPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationRevolutPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSamsungPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSamsungPay\"}}]")]
        public virtual void PutSamsungPay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSamsungPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSamsungPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSatispay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSatispay\"}}]")]
        public virtual void PutSatispay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSatispay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSatispay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalapay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationScalapay\"}}]")]
        public virtual void PutScalapay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationScalapay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationScalapay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSepaDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSepaDebit\"}}]")]
        public virtual void PutSepaDebit(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSepaDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSepaDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSofort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSofort\"}}]")]
        public virtual void PutSofort(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSofort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSofort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSunbit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSunbit\"}}]")]
        public virtual void PutSunbit(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSunbit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSunbit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSwish", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSwish\"}}]")]
        public virtual void PutSwish(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSwish @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSwish)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationTwint\"}}]")]
        public virtual void PutTwint(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationTwint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationTwint)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUpi\"}}]")]
        public virtual void PutUpi(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUsBankAccount\"}}]")]
        public virtual void PutUsBankAccount(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUsBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUsBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWechatPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationWechatPay\"}}]")]
        public virtual void PutWechatPay(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationWechatPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationWechatPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZip", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationZip\"}}]")]
        public virtual void PutZip(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationZip @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationZip)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcssDebit")]
        public virtual void ResetAcssDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetActive")]
        public virtual void ResetActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAffirm")]
        public virtual void ResetAffirm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAfterpayClearpay")]
        public virtual void ResetAfterpayClearpay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlipay")]
        public virtual void ResetAlipay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlma")]
        public virtual void ResetAlma()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAmazonPay")]
        public virtual void ResetAmazonPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplePay")]
        public virtual void ResetApplePay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplePayLater")]
        public virtual void ResetApplePayLater()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuBecsDebit")]
        public virtual void ResetAuBecsDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBacsDebit")]
        public virtual void ResetBacsDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBancontact")]
        public virtual void ResetBancontact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillie")]
        public virtual void ResetBillie()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBizum")]
        public virtual void ResetBizum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlik")]
        public virtual void ResetBlik()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBoleto")]
        public virtual void ResetBoleto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCard")]
        public virtual void ResetCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCartesBancaires")]
        public virtual void ResetCartesBancaires()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCashapp")]
        public virtual void ResetCashapp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrypto")]
        public virtual void ResetCrypto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerBalance")]
        public virtual void ResetCustomerBalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEps")]
        public virtual void ResetEps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFpx")]
        public virtual void ResetFpx()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGiropay")]
        public virtual void ResetGiropay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGooglePay")]
        public virtual void ResetGooglePay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrabpay")]
        public virtual void ResetGrabpay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdeal")]
        public virtual void ResetIdeal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJcb")]
        public virtual void ResetJcb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKakaoPay")]
        public virtual void ResetKakaoPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKlarna")]
        public virtual void ResetKlarna()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKonbini")]
        public virtual void ResetKonbini()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKrCard")]
        public virtual void ResetKrCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLink")]
        public virtual void ResetLink()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMbWay")]
        public virtual void ResetMbWay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMobilepay")]
        public virtual void ResetMobilepay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultibanco")]
        public virtual void ResetMultibanco()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNaverPay")]
        public virtual void ResetNaverPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNzBankAccount")]
        public virtual void ResetNzBankAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOxxo")]
        public virtual void ResetOxxo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetP24")]
        public virtual void ResetP24()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParent")]
        public virtual void ResetParent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayByBank")]
        public virtual void ResetPayByBank()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayco")]
        public virtual void ResetPayco()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaynow")]
        public virtual void ResetPaynow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaypal")]
        public virtual void ResetPaypal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayto")]
        public virtual void ResetPayto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPix")]
        public virtual void ResetPix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPromptpay")]
        public virtual void ResetPromptpay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevolutPay")]
        public virtual void ResetRevolutPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamsungPay")]
        public virtual void ResetSamsungPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSatispay")]
        public virtual void ResetSatispay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalapay")]
        public virtual void ResetScalapay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSepaDebit")]
        public virtual void ResetSepaDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSofort")]
        public virtual void ResetSofort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSunbit")]
        public virtual void ResetSunbit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSwish")]
        public virtual void ResetSwish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwint")]
        public virtual void ResetTwint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpi")]
        public virtual void ResetUpi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsBankAccount")]
        public virtual void ResetUsBankAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWechatPay")]
        public virtual void ResetWechatPay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZip")]
        public virtual void ResetZip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.PaymentMethodConfiguration.PaymentMethodConfiguration))!;

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAcssDebitOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "affirm", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAffirmOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAffirmOutputReference Affirm
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAffirmOutputReference>()!;
        }

        [JsiiProperty(name: "afterpayClearpay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAfterpayClearpayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAfterpayClearpayOutputReference AfterpayClearpay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAfterpayClearpayOutputReference>()!;
        }

        [JsiiProperty(name: "alipay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlipayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAlipayOutputReference Alipay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAlipayOutputReference>()!;
        }

        [JsiiProperty(name: "alma", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlmaOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAlmaOutputReference Alma
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAlmaOutputReference>()!;
        }

        [JsiiProperty(name: "amazonPay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAmazonPayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAmazonPayOutputReference AmazonPay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAmazonPayOutputReference>()!;
        }

        [JsiiProperty(name: "applePay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationApplePayOutputReference ApplePay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationApplePayOutputReference>()!;
        }

        [JsiiProperty(name: "applePayLater", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePayLaterOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationApplePayLaterOutputReference ApplePayLater
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationApplePayLaterOutputReference>()!;
        }

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAuBecsDebitOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAuBecsDebitOutputReference AuBecsDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationAuBecsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBacsDebitOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBacsDebitOutputReference BacsDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBacsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBancontactOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBancontactOutputReference Bancontact
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBancontactOutputReference>()!;
        }

        [JsiiProperty(name: "billie", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBillieOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBillieOutputReference Billie
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBillieOutputReference>()!;
        }

        [JsiiProperty(name: "bizum", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBizumOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBizumOutputReference Bizum
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBizumOutputReference>()!;
        }

        [JsiiProperty(name: "blik", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBlikOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBlikOutputReference Blik
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBlikOutputReference>()!;
        }

        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBoletoOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBoletoOutputReference Boleto
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationBoletoOutputReference>()!;
        }

        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCardOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCardOutputReference Card
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCardOutputReference>()!;
        }

        [JsiiProperty(name: "cartesBancaires", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCartesBancairesOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCartesBancairesOutputReference CartesBancaires
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCartesBancairesOutputReference>()!;
        }

        [JsiiProperty(name: "cashapp", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCashappOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCashappOutputReference Cashapp
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCashappOutputReference>()!;
        }

        [JsiiProperty(name: "crypto", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCryptoOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCryptoOutputReference Crypto
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCryptoOutputReference>()!;
        }

        [JsiiProperty(name: "customerBalance", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCustomerBalanceOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCustomerBalanceOutputReference CustomerBalance
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationCustomerBalanceOutputReference>()!;
        }

        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationEpsOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationEpsOutputReference Eps
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationEpsOutputReference>()!;
        }

        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationFpxOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationFpxOutputReference Fpx
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationFpxOutputReference>()!;
        }

        [JsiiProperty(name: "giropay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGiropayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationGiropayOutputReference Giropay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationGiropayOutputReference>()!;
        }

        [JsiiProperty(name: "googlePay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGooglePayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationGooglePayOutputReference GooglePay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationGooglePayOutputReference>()!;
        }

        [JsiiProperty(name: "grabpay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGrabpayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationGrabpayOutputReference Grabpay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationGrabpayOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationIdealOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationIdealOutputReference Ideal
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationIdealOutputReference>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "jcb", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationJcbOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationJcbOutputReference Jcb
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationJcbOutputReference>()!;
        }

        [JsiiProperty(name: "kakaoPay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKakaoPayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKakaoPayOutputReference KakaoPay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKakaoPayOutputReference>()!;
        }

        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarnaOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKlarnaOutputReference Klarna
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKlarnaOutputReference>()!;
        }

        [JsiiProperty(name: "konbini", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKonbiniOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKonbiniOutputReference Konbini
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKonbiniOutputReference>()!;
        }

        [JsiiProperty(name: "krCard", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKrCardOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKrCardOutputReference KrCard
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationKrCardOutputReference>()!;
        }

        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationLinkOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationLinkOutputReference Link
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationLinkOutputReference>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mbWay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMbWayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationMbWayOutputReference MbWay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationMbWayOutputReference>()!;
        }

        [JsiiProperty(name: "mobilepay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMobilepayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationMobilepayOutputReference Mobilepay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationMobilepayOutputReference>()!;
        }

        [JsiiProperty(name: "multibanco", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMultibancoOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationMultibancoOutputReference Multibanco
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationMultibancoOutputReference>()!;
        }

        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationNaverPayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationNaverPayOutputReference NaverPay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationNaverPayOutputReference>()!;
        }

        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationNzBankAccountOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationNzBankAccountOutputReference NzBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationNzBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oxxo", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationOxxoOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationOxxoOutputReference Oxxo
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationOxxoOutputReference>()!;
        }

        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationP24OutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationP24OutputReference P24
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationP24OutputReference>()!;
        }

        [JsiiProperty(name: "payByBank", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPayByBankOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPayByBankOutputReference PayByBank
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPayByBankOutputReference>()!;
        }

        [JsiiProperty(name: "payco", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaycoOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaycoOutputReference Payco
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaycoOutputReference>()!;
        }

        [JsiiProperty(name: "paynow", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynowOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaynowOutputReference Paynow
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaynowOutputReference>()!;
        }

        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaypalOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaypalOutputReference Paypal
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaypalOutputReference>()!;
        }

        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaytoOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaytoOutputReference Payto
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPaytoOutputReference>()!;
        }

        [JsiiProperty(name: "pix", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPixOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPixOutputReference Pix
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPixOutputReference>()!;
        }

        [JsiiProperty(name: "promptpay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPromptpayOutputReference Promptpay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationPromptpayOutputReference>()!;
        }

        [JsiiProperty(name: "revolutPay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationRevolutPayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationRevolutPayOutputReference RevolutPay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationRevolutPayOutputReference>()!;
        }

        [JsiiProperty(name: "samsungPay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSamsungPayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSamsungPayOutputReference SamsungPay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSamsungPayOutputReference>()!;
        }

        [JsiiProperty(name: "satispay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSatispayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSatispayOutputReference Satispay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSatispayOutputReference>()!;
        }

        [JsiiProperty(name: "scalapay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationScalapayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationScalapayOutputReference Scalapay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationScalapayOutputReference>()!;
        }

        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSepaDebitOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSepaDebitOutputReference SepaDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSepaDebitOutputReference>()!;
        }

        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSofortOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSofortOutputReference Sofort
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSofortOutputReference>()!;
        }

        [JsiiProperty(name: "sunbit", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSunbitOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSunbitOutputReference Sunbit
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSunbitOutputReference>()!;
        }

        [JsiiProperty(name: "swish", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSwishOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSwishOutputReference Swish
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationSwishOutputReference>()!;
        }

        [JsiiProperty(name: "twint", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationTwintOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationTwintOutputReference Twint
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationTwintOutputReference>()!;
        }

        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUpiOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationUpiOutputReference Upi
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationUpiOutputReference>()!;
        }

        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUsBankAccountOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationUsBankAccountOutputReference UsBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationUsBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "wechatPay", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationWechatPayOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationWechatPayOutputReference WechatPay
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationWechatPayOutputReference>()!;
        }

        [JsiiProperty(name: "zip", typeJson: "{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationZipOutputReference\"}")]
        public virtual stripe.PaymentMethodConfiguration.PaymentMethodConfigurationZipOutputReference Zip
        {
            get => GetInstanceProperty<stripe.PaymentMethodConfiguration.PaymentMethodConfigurationZipOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAcssDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAcssDebit\"}]}}", isOptional: true)]
        public virtual object? AcssDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAffirm" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "affirmInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAffirm\"}]}}", isOptional: true)]
        public virtual object? AffirmInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAfterpayClearpay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "afterpayClearpayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAfterpayClearpay\"}]}}", isOptional: true)]
        public virtual object? AfterpayClearpayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlipay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alipayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlipay\"}]}}", isOptional: true)]
        public virtual object? AlipayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAlma" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "almaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAlma\"}]}}", isOptional: true)]
        public virtual object? AlmaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAmazonPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAmazonPay\"}]}}", isOptional: true)]
        public virtual object? AmazonPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationApplePay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applePayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePay\"}]}}", isOptional: true)]
        public virtual object? ApplePayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationApplePayLater" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applePayLaterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationApplePayLater\"}]}}", isOptional: true)]
        public virtual object? ApplePayLaterInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationAuBecsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationAuBecsDebit\"}]}}", isOptional: true)]
        public virtual object? AuBecsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBacsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBacsDebit\"}]}}", isOptional: true)]
        public virtual object? BacsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBancontact" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bancontactInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBancontact\"}]}}", isOptional: true)]
        public virtual object? BancontactInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBillie" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billieInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBillie\"}]}}", isOptional: true)]
        public virtual object? BillieInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBizum" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bizumInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBizum\"}]}}", isOptional: true)]
        public virtual object? BizumInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBlik" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blikInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBlik\"}]}}", isOptional: true)]
        public virtual object? BlikInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationBoleto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boletoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationBoleto\"}]}}", isOptional: true)]
        public virtual object? BoletoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCard\"}]}}", isOptional: true)]
        public virtual object? CardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCartesBancaires" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cartesBancairesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCartesBancaires\"}]}}", isOptional: true)]
        public virtual object? CartesBancairesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCashapp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cashappInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCashapp\"}]}}", isOptional: true)]
        public virtual object? CashappInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCrypto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cryptoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCrypto\"}]}}", isOptional: true)]
        public virtual object? CryptoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationCustomerBalance" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerBalanceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationCustomerBalance\"}]}}", isOptional: true)]
        public virtual object? CustomerBalanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationEps" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "epsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationEps\"}]}}", isOptional: true)]
        public virtual object? EpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationFpx" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationFpx\"}]}}", isOptional: true)]
        public virtual object? FpxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGiropay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "giropayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGiropay\"}]}}", isOptional: true)]
        public virtual object? GiropayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGooglePay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "googlePayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGooglePay\"}]}}", isOptional: true)]
        public virtual object? GooglePayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationGrabpay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grabpayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationGrabpay\"}]}}", isOptional: true)]
        public virtual object? GrabpayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationIdeal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idealInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationIdeal\"}]}}", isOptional: true)]
        public virtual object? IdealInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationJcb" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jcbInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationJcb\"}]}}", isOptional: true)]
        public virtual object? JcbInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKakaoPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kakaoPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKakaoPay\"}]}}", isOptional: true)]
        public virtual object? KakaoPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "klarnaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKlarna\"}]}}", isOptional: true)]
        public virtual object? KlarnaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKonbini" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "konbiniInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKonbini\"}]}}", isOptional: true)]
        public virtual object? KonbiniInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationKrCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "krCardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationKrCard\"}]}}", isOptional: true)]
        public virtual object? KrCardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationLink" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationLink\"}]}}", isOptional: true)]
        public virtual object? LinkInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMbWay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mbWayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMbWay\"}]}}", isOptional: true)]
        public virtual object? MbWayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMobilepay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mobilepayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMobilepay\"}]}}", isOptional: true)]
        public virtual object? MobilepayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationMultibanco" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "multibancoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationMultibanco\"}]}}", isOptional: true)]
        public virtual object? MultibancoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationNaverPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naverPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationNaverPay\"}]}}", isOptional: true)]
        public virtual object? NaverPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationNzBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationNzBankAccount\"}]}}", isOptional: true)]
        public virtual object? NzBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationOxxo" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oxxoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationOxxo\"}]}}", isOptional: true)]
        public virtual object? OxxoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationP24" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "p24Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationP24\"}]}}", isOptional: true)]
        public virtual object? P24Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayByBank" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payByBankInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPayByBank\"}]}}", isOptional: true)]
        public virtual object? PayByBankInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayco" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paycoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPayco\"}]}}", isOptional: true)]
        public virtual object? PaycoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaynow" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paynowInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaynow\"}]}}", isOptional: true)]
        public virtual object? PaynowInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPaypal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paypalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPaypal\"}]}}", isOptional: true)]
        public virtual object? PaypalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPayto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paytoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPayto\"}]}}", isOptional: true)]
        public virtual object? PaytoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPix" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pixInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPix\"}]}}", isOptional: true)]
        public virtual object? PixInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationPromptpay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "promptpayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationPromptpay\"}]}}", isOptional: true)]
        public virtual object? PromptpayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationRevolutPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revolutPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationRevolutPay\"}]}}", isOptional: true)]
        public virtual object? RevolutPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSamsungPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "samsungPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSamsungPay\"}]}}", isOptional: true)]
        public virtual object? SamsungPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSatispay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "satispayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSatispay\"}]}}", isOptional: true)]
        public virtual object? SatispayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationScalapay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scalapayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationScalapay\"}]}}", isOptional: true)]
        public virtual object? ScalapayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSepaDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSepaDebit\"}]}}", isOptional: true)]
        public virtual object? SepaDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSofort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sofortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSofort\"}]}}", isOptional: true)]
        public virtual object? SofortInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSunbit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sunbitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSunbit\"}]}}", isOptional: true)]
        public virtual object? SunbitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationSwish" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "swishInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationSwish\"}]}}", isOptional: true)]
        public virtual object? SwishInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationTwint" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "twintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationTwint\"}]}}", isOptional: true)]
        public virtual object? TwintInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUpi\"}]}}", isOptional: true)]
        public virtual object? UpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationUsBankAccount\"}]}}", isOptional: true)]
        public virtual object? UsBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationWechatPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wechatPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationWechatPay\"}]}}", isOptional: true)]
        public virtual object? WechatPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethodConfiguration.IPaymentMethodConfigurationZip" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethodConfiguration.PaymentMethodConfigurationZip\"}]}}", isOptional: true)]
        public virtual object? ZipInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Active
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Parent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

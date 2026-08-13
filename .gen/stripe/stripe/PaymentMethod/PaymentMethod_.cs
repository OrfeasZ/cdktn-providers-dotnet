using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method stripe_payment_method}.</summary>
    [JsiiClass(nativeType: typeof(stripe.PaymentMethod.PaymentMethod_), fullyQualifiedName: "stripe.paymentMethod.PaymentMethod", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodConfig\"}}]")]
    public class PaymentMethod_ : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method stripe_payment_method} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PaymentMethod_(Constructs.Construct scope, string id, stripe.PaymentMethod.IPaymentMethodConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.PaymentMethod.IPaymentMethodConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethod_(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentMethod_(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PaymentMethod resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PaymentMethod to import.</param>
        /// <param name="importFromId">The id of the existing PaymentMethod that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PaymentMethod to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PaymentMethod to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PaymentMethod that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PaymentMethod to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.PaymentMethod.PaymentMethod_), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAcssDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodAcssDebit\"}}]")]
        public virtual void PutAcssDebit(stripe.PaymentMethod.IPaymentMethodAcssDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodAcssDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuBecsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodAuBecsDebit\"}}]")]
        public virtual void PutAuBecsDebit(stripe.PaymentMethod.IPaymentMethodAuBecsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodAuBecsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBacsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodBacsDebit\"}}]")]
        public virtual void PutBacsDebit(stripe.PaymentMethod.IPaymentMethodBacsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodBacsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBillingDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodBillingDetails\"}}]")]
        public virtual void PutBillingDetails(stripe.PaymentMethod.IPaymentMethodBillingDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodBillingDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoleto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodBoleto\"}}]")]
        public virtual void PutBoleto(stripe.PaymentMethod.IPaymentMethodBoleto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodBoleto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodCard\"}}]")]
        public virtual void PutCard(stripe.PaymentMethod.IPaymentMethodCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCashapp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodCashapp\"}}]")]
        public virtual void PutCashapp(stripe.PaymentMethod.IPaymentMethodCashapp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodCashapp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodEps\"}}]")]
        public virtual void PutEps(stripe.PaymentMethod.IPaymentMethodEps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodEps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFpx", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodFpx\"}}]")]
        public virtual void PutFpx(stripe.PaymentMethod.IPaymentMethodFpx @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodFpx)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdeal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodIdeal\"}}]")]
        public virtual void PutIdeal(stripe.PaymentMethod.IPaymentMethodIdeal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodIdeal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInteracPresent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodInteracPresent\"}}]")]
        public virtual void PutInteracPresent(stripe.PaymentMethod.IPaymentMethodInteracPresent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodInteracPresent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKlarna", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarna\"}}]")]
        public virtual void PutKlarna(stripe.PaymentMethod.IPaymentMethodKlarna @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodKlarna)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKrCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodKrCard\"}}]")]
        public virtual void PutKrCard(stripe.PaymentMethod.IPaymentMethodKrCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodKrCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLink", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodLink\"}}]")]
        public virtual void PutLink(stripe.PaymentMethod.IPaymentMethodLink @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodLink)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNaverPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodNaverPay\"}}]")]
        public virtual void PutNaverPay(stripe.PaymentMethod.IPaymentMethodNaverPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodNaverPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNzBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodNzBankAccount\"}}]")]
        public virtual void PutNzBankAccount(stripe.PaymentMethod.IPaymentMethodNzBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodNzBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putP24", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodP24\"}}]")]
        public virtual void PutP24(stripe.PaymentMethod.IPaymentMethodP24 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodP24)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaypal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodPaypal\"}}]")]
        public virtual void PutPaypal(stripe.PaymentMethod.IPaymentMethodPaypal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodPaypal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodPayto\"}}]")]
        public virtual void PutPayto(stripe.PaymentMethod.IPaymentMethodPayto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodPayto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRadarOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodRadarOptions\"}}]")]
        public virtual void PutRadarOptions(stripe.PaymentMethod.IPaymentMethodRadarOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodRadarOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSepaDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodSepaDebit\"}}]")]
        public virtual void PutSepaDebit(stripe.PaymentMethod.IPaymentMethodSepaDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodSepaDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSofort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodSofort\"}}]")]
        public virtual void PutSofort(stripe.PaymentMethod.IPaymentMethodSofort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodSofort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpi\"}}]")]
        public virtual void PutUpi(stripe.PaymentMethod.IPaymentMethodUpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodUpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccount\"}}]")]
        public virtual void PutUsBankAccount(stripe.PaymentMethod.IPaymentMethodUsBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentMethod.IPaymentMethodUsBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcssDebit")]
        public virtual void ResetAcssDebit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowRedisplay")]
        public virtual void ResetAllowRedisplay()
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

        [JsiiMethod(name: "resetBillingDetails")]
        public virtual void ResetBillingDetails()
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

        [JsiiMethod(name: "resetCashapp")]
        public virtual void ResetCashapp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomer")]
        public virtual void ResetCustomer()
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

        [JsiiMethod(name: "resetIdeal")]
        public virtual void ResetIdeal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInteracPresent")]
        public virtual void ResetInteracPresent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKlarna")]
        public virtual void ResetKlarna()
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

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
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

        [JsiiMethod(name: "resetP24")]
        public virtual void ResetP24()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethod")]
        public virtual void ResetPaymentMethod()
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

        [JsiiMethod(name: "resetRadarOptions")]
        public virtual void ResetRadarOptions()
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

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(stripe.PaymentMethod.PaymentMethod_))!;

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAcssDebitOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodAuBecsDebitOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodAuBecsDebitOutputReference AuBecsDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodAuBecsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBacsDebitOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodBacsDebitOutputReference BacsDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodBacsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBillingDetailsOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodBillingDetailsOutputReference BillingDetails
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodBillingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodBoletoOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodBoletoOutputReference Boleto
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodBoletoOutputReference>()!;
        }

        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardOutputReference Card
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardOutputReference>()!;
        }

        [JsiiProperty(name: "cardPresent", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCardPresentOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCardPresentOutputReference CardPresent
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCardPresentOutputReference>()!;
        }

        [JsiiProperty(name: "cashapp", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodCashappOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodCashappOutputReference Cashapp
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodCashappOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodEpsOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodEpsOutputReference Eps
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodEpsOutputReference>()!;
        }

        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodFpxOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodFpxOutputReference Fpx
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodFpxOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodIdealOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodIdealOutputReference Ideal
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodIdealOutputReference>()!;
        }

        [JsiiProperty(name: "interacPresent", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodInteracPresentOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodInteracPresentOutputReference InteracPresent
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodInteracPresentOutputReference>()!;
        }

        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarnaOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodKlarnaOutputReference Klarna
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodKlarnaOutputReference>()!;
        }

        [JsiiProperty(name: "krCard", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodKrCardOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodKrCardOutputReference KrCard
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodKrCardOutputReference>()!;
        }

        [JsiiProperty(name: "link", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodLinkOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodLinkOutputReference Link
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodLinkOutputReference>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNaverPayOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodNaverPayOutputReference NaverPay
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodNaverPayOutputReference>()!;
        }

        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodNzBankAccountOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodNzBankAccountOutputReference NzBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodNzBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodP24OutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodP24OutputReference P24
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodP24OutputReference>()!;
        }

        [JsiiProperty(name: "paypal", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPaypalOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodPaypalOutputReference Paypal
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodPaypalOutputReference>()!;
        }

        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodPaytoOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodPaytoOutputReference Payto
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodPaytoOutputReference>()!;
        }

        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodRadarOptionsOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodRadarOptionsOutputReference RadarOptions
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodRadarOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSepaDebitOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodSepaDebitOutputReference SepaDebit
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodSepaDebitOutputReference>()!;
        }

        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodSofortOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodSofortOutputReference Sofort
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodSofortOutputReference>()!;
        }

        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpiOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodUpiOutputReference Upi
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodUpiOutputReference>()!;
        }

        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccountOutputReference\"}")]
        public virtual stripe.PaymentMethod.PaymentMethodUsBankAccountOutputReference UsBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentMethod.PaymentMethodUsBankAccountOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodAcssDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodAcssDebit\"}]}}", isOptional: true)]
        public virtual object? AcssDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowRedisplayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllowRedisplayInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodAuBecsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodAuBecsDebit\"}]}}", isOptional: true)]
        public virtual object? AuBecsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodBacsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodBacsDebit\"}]}}", isOptional: true)]
        public virtual object? BacsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodBillingDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodBillingDetails\"}]}}", isOptional: true)]
        public virtual object? BillingDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodBoleto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boletoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodBoleto\"}]}}", isOptional: true)]
        public virtual object? BoletoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodCard\"}]}}", isOptional: true)]
        public virtual object? CardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodCashapp" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cashappInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodCashapp\"}]}}", isOptional: true)]
        public virtual object? CashappInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodEps" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "epsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodEps\"}]}}", isOptional: true)]
        public virtual object? EpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodFpx" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodFpx\"}]}}", isOptional: true)]
        public virtual object? FpxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodIdeal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idealInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodIdeal\"}]}}", isOptional: true)]
        public virtual object? IdealInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodInteracPresent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interacPresentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodInteracPresent\"}]}}", isOptional: true)]
        public virtual object? InteracPresentInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "klarnaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodKlarna\"}]}}", isOptional: true)]
        public virtual object? KlarnaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodKrCard" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "krCardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodKrCard\"}]}}", isOptional: true)]
        public virtual object? KrCardInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodLink" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linkInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodLink\"}]}}", isOptional: true)]
        public virtual object? LinkInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodNaverPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naverPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodNaverPay\"}]}}", isOptional: true)]
        public virtual object? NaverPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodNzBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodNzBankAccount\"}]}}", isOptional: true)]
        public virtual object? NzBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodP24" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "p24Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodP24\"}]}}", isOptional: true)]
        public virtual object? P24Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodPaypal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paypalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodPaypal\"}]}}", isOptional: true)]
        public virtual object? PaypalInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodPayto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paytoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodPayto\"}]}}", isOptional: true)]
        public virtual object? PaytoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodRadarOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodRadarOptions\"}]}}", isOptional: true)]
        public virtual object? RadarOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodSepaDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodSepaDebit\"}]}}", isOptional: true)]
        public virtual object? SepaDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodSofort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sofortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodSofort\"}]}}", isOptional: true)]
        public virtual object? SofortInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodUpi\"}]}}", isOptional: true)]
        public virtual object? UpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentMethod.IPaymentMethodUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentMethod.PaymentMethodUsBankAccount\"}]}}", isOptional: true)]
        public virtual object? UsBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "allowRedisplay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowRedisplay
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

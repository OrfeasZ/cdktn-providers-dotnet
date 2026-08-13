using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentPaymentMethodDataOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentPaymentMethodDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentPaymentMethodDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentPaymentMethodDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentPaymentMethodDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcssDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebit\"}}]")]
        public virtual void PutAcssDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuBecsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebit\"}}]")]
        public virtual void PutAuBecsDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBacsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBacsDebit\"}}]")]
        public virtual void PutBacsDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBacsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBacsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBillingDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetails\"}}]")]
        public virtual void PutBillingDetails(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoleto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBoleto\"}}]")]
        public virtual void PutBoleto(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataEps\"}}]")]
        public virtual void PutEps(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataEps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataEps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFpx", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataFpx\"}}]")]
        public virtual void PutFpx(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdeal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataIdeal\"}}]")]
        public virtual void PutIdeal(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKlarna", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna\"}}]")]
        public virtual void PutKlarna(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNaverPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNaverPay\"}}]")]
        public virtual void PutNaverPay(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNaverPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNaverPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNzBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccount\"}}]")]
        public virtual void PutNzBankAccount(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putP24", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataP24\"}}]")]
        public virtual void PutP24(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataPayto\"}}]")]
        public virtual void PutPayto(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRadarOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataRadarOptions\"}}]")]
        public virtual void PutRadarOptions(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataRadarOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataRadarOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSepaDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebit\"}}]")]
        public virtual void PutSepaDebit(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSofort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSofort\"}}]")]
        public virtual void PutSofort(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSofort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSofort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUpi\"}}]")]
        public virtual void PutUpi(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUsBankAccount\"}}]")]
        public virtual void PutUsBankAccount(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount)}, new object[]{@value});
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

        [JsiiMethod(name: "resetKlarna")]
        public virtual void ResetKlarna()
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

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataAuBecsDebitOutputReference AuBecsDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataAuBecsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBacsDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataBacsDebitOutputReference BacsDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataBacsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetailsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataBillingDetailsOutputReference BillingDetails
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataBillingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBoletoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataBoletoOutputReference Boleto
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataBoletoOutputReference>()!;
        }

        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataEpsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataEpsOutputReference Eps
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataEpsOutputReference>()!;
        }

        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataFpxOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataFpxOutputReference Fpx
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataFpxOutputReference>()!;
        }

        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataIdealOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataIdealOutputReference Ideal
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataIdealOutputReference>()!;
        }

        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarnaOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataKlarnaOutputReference Klarna
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataKlarnaOutputReference>()!;
        }

        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNaverPayOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataNaverPayOutputReference NaverPay
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataNaverPayOutputReference>()!;
        }

        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccountOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataNzBankAccountOutputReference NzBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataNzBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataP24OutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataP24OutputReference P24
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataP24OutputReference>()!;
        }

        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataPaytoOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataPaytoOutputReference Payto
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataPaytoOutputReference>()!;
        }

        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataRadarOptionsOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataRadarOptionsOutputReference RadarOptions
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataRadarOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebitOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataSepaDebitOutputReference SepaDebit
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataSepaDebitOutputReference>()!;
        }

        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSofortOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataSofortOutputReference Sofort
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataSofortOutputReference>()!;
        }

        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUpiOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataUpiOutputReference Upi
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataUpiOutputReference>()!;
        }

        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUsBankAccountOutputReference\"}")]
        public virtual stripe.PaymentIntent.PaymentIntentPaymentMethodDataUsBankAccountOutputReference UsBankAccount
        {
            get => GetInstanceProperty<stripe.PaymentIntent.PaymentIntentPaymentMethodDataUsBankAccountOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAcssDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAcssDebit\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataAuBecsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataAuBecsDebit\"}]}}", isOptional: true)]
        public virtual object? AuBecsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBacsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBacsDebit\"}]}}", isOptional: true)]
        public virtual object? BacsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBillingDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBillingDetails\"}]}}", isOptional: true)]
        public virtual object? BillingDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boletoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataBoleto\"}]}}", isOptional: true)]
        public virtual object? BoletoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataEps" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "epsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataEps\"}]}}", isOptional: true)]
        public virtual object? EpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataFpx" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataFpx\"}]}}", isOptional: true)]
        public virtual object? FpxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataIdeal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idealInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataIdeal\"}]}}", isOptional: true)]
        public virtual object? IdealInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "klarnaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataKlarna\"}]}}", isOptional: true)]
        public virtual object? KlarnaInput
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNaverPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naverPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNaverPay\"}]}}", isOptional: true)]
        public virtual object? NaverPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataNzBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataNzBankAccount\"}]}}", isOptional: true)]
        public virtual object? NzBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataP24" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "p24Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataP24\"}]}}", isOptional: true)]
        public virtual object? P24Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataPayto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paytoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataPayto\"}]}}", isOptional: true)]
        public virtual object? PaytoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataRadarOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataRadarOptions\"}]}}", isOptional: true)]
        public virtual object? RadarOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSepaDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSepaDebit\"}]}}", isOptional: true)]
        public virtual object? SepaDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataSofort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sofortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataSofort\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUpi\"}]}}", isOptional: true)]
        public virtual object? UpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodDataUsBankAccount\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.PaymentIntent.IPaymentIntentPaymentMethodData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodData\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.PaymentIntent.IPaymentIntentPaymentMethodData cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.PaymentIntent.IPaymentIntentPaymentMethodData).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

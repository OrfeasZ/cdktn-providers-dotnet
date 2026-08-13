using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiClass(nativeType: typeof(stripe.SetupIntent.SetupIntentPaymentMethodDataOutputReference), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SetupIntentPaymentMethodDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SetupIntentPaymentMethodDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SetupIntentPaymentMethodDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SetupIntentPaymentMethodDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcssDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit\"}}]")]
        public virtual void PutAcssDebit(stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuBecsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebit\"}}]")]
        public virtual void PutAuBecsDebit(stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBacsDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit\"}}]")]
        public virtual void PutBacsDebit(stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBillingDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetails\"}}]")]
        public virtual void PutBillingDetails(stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBoleto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBoleto\"}}]")]
        public virtual void PutBoleto(stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataEps\"}}]")]
        public virtual void PutEps(stripe.SetupIntent.ISetupIntentPaymentMethodDataEps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataEps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFpx", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataFpx\"}}]")]
        public virtual void PutFpx(stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdeal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataIdeal\"}}]")]
        public virtual void PutIdeal(stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKlarna", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarna\"}}]")]
        public virtual void PutKlarna(stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNaverPay", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay\"}}]")]
        public virtual void PutNaverPay(stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNzBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNzBankAccount\"}}]")]
        public virtual void PutNzBankAccount(stripe.SetupIntent.ISetupIntentPaymentMethodDataNzBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataNzBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putP24", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataP24\"}}]")]
        public virtual void PutP24(stripe.SetupIntent.ISetupIntentPaymentMethodDataP24 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataP24)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataPayto\"}}]")]
        public virtual void PutPayto(stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRadarOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataRadarOptions\"}}]")]
        public virtual void PutRadarOptions(stripe.SetupIntent.ISetupIntentPaymentMethodDataRadarOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataRadarOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSepaDebit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebit\"}}]")]
        public virtual void PutSepaDebit(stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSofort", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSofort\"}}]")]
        public virtual void PutSofort(stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpi\"}}]")]
        public virtual void PutUpi(stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUsBankAccount\"}}]")]
        public virtual void PutUsBankAccount(stripe.SetupIntent.ISetupIntentPaymentMethodDataUsBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SetupIntent.ISetupIntentPaymentMethodDataUsBankAccount)}, new object[]{@value});
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

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebitOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebitOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataAuBecsDebitOutputReference AuBecsDebit
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataAuBecsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bacsDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebitOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataBacsDebitOutputReference BacsDebit
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataBacsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "billingDetails", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetailsOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataBillingDetailsOutputReference BillingDetails
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataBillingDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "boleto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBoletoOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataBoletoOutputReference Boleto
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataBoletoOutputReference>()!;
        }

        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataEpsOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataEpsOutputReference Eps
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataEpsOutputReference>()!;
        }

        [JsiiProperty(name: "fpx", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataFpxOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataFpxOutputReference Fpx
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataFpxOutputReference>()!;
        }

        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataIdealOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataIdealOutputReference Ideal
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataIdealOutputReference>()!;
        }

        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarnaOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataKlarnaOutputReference Klarna
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataKlarnaOutputReference>()!;
        }

        [JsiiProperty(name: "naverPay", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNaverPayOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataNaverPayOutputReference NaverPay
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataNaverPayOutputReference>()!;
        }

        [JsiiProperty(name: "nzBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNzBankAccountOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataNzBankAccountOutputReference NzBankAccount
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataNzBankAccountOutputReference>()!;
        }

        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataP24OutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataP24OutputReference P24
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataP24OutputReference>()!;
        }

        [JsiiProperty(name: "payto", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataPaytoOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataPaytoOutputReference Payto
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataPaytoOutputReference>()!;
        }

        [JsiiProperty(name: "radarOptions", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataRadarOptionsOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataRadarOptionsOutputReference RadarOptions
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataRadarOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebitOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataSepaDebitOutputReference SepaDebit
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataSepaDebitOutputReference>()!;
        }

        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSofortOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataSofortOutputReference Sofort
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataSofortOutputReference>()!;
        }

        [JsiiProperty(name: "upi", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpiOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataUpiOutputReference Upi
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataUpiOutputReference>()!;
        }

        [JsiiProperty(name: "usBankAccount", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUsBankAccountOutputReference\"}")]
        public virtual stripe.SetupIntent.SetupIntentPaymentMethodDataUsBankAccountOutputReference UsBankAccount
        {
            get => GetInstanceProperty<stripe.SetupIntent.SetupIntentPaymentMethodDataUsBankAccountOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataAcssDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acssDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAcssDebit\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataAuBecsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auBecsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataAuBecsDebit\"}]}}", isOptional: true)]
        public virtual object? AuBecsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataBacsDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bacsDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBacsDebit\"}]}}", isOptional: true)]
        public virtual object? BacsDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataBillingDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBillingDetails\"}]}}", isOptional: true)]
        public virtual object? BillingDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boletoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataBoleto\"}]}}", isOptional: true)]
        public virtual object? BoletoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataEps" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "epsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataEps\"}]}}", isOptional: true)]
        public virtual object? EpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataFpx" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataFpx\"}]}}", isOptional: true)]
        public virtual object? FpxInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataIdeal" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idealInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataIdeal\"}]}}", isOptional: true)]
        public virtual object? IdealInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataKlarna" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "klarnaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataKlarna\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataNaverPay" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "naverPayInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNaverPay\"}]}}", isOptional: true)]
        public virtual object? NaverPayInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataNzBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nzBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataNzBankAccount\"}]}}", isOptional: true)]
        public virtual object? NzBankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataP24" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "p24Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataP24\"}]}}", isOptional: true)]
        public virtual object? P24Input
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataPayto" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paytoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataPayto\"}]}}", isOptional: true)]
        public virtual object? PaytoInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataRadarOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "radarOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataRadarOptions\"}]}}", isOptional: true)]
        public virtual object? RadarOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataSepaDebit" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sepaDebitInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSepaDebit\"}]}}", isOptional: true)]
        public virtual object? SepaDebitInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataSofort" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sofortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataSofort\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataUpi" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUpi\"}]}}", isOptional: true)]
        public virtual object? UpiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodDataUsBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usBankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodDataUsBankAccount\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SetupIntent.ISetupIntentPaymentMethodData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodData\"}]}}", isOptional: true)]
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
                        case stripe.SetupIntent.ISetupIntentPaymentMethodData cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SetupIntent.ISetupIntentPaymentMethodData).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

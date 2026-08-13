using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card stripe_issuing_card}.</summary>
    [JsiiClass(nativeType: typeof(stripe.IssuingCard.IssuingCard), fullyQualifiedName: "stripe.issuingCard.IssuingCard", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardConfig\"}}]")]
    public class IssuingCard : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card stripe_issuing_card} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IssuingCard(Constructs.Construct scope, string id, stripe.IssuingCard.IIssuingCardConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.IssuingCard.IIssuingCardConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCard(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCard(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IssuingCard resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IssuingCard to import.</param>
        /// <param name="importFromId">The id of the existing IssuingCard that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IssuingCard to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IssuingCard to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IssuingCard that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IssuingCard to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.IssuingCard.IssuingCard), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLifecycleControls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControls\"}}]")]
        public virtual void PutLifecycleControls(stripe.IssuingCard.IIssuingCardLifecycleControls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardLifecycleControls)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardPin\"}}]")]
        public virtual void PutPin(stripe.IssuingCard.IIssuingCardPin @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardPin)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShipping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardShipping\"}}]")]
        public virtual void PutShipping(stripe.IssuingCard.IIssuingCardShipping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardShipping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpendingControls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCard.IssuingCardSpendingControls\"}}]")]
        public virtual void PutSpendingControls(stripe.IssuingCard.IIssuingCardSpendingControls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCard.IIssuingCardSpendingControls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCardholder")]
        public virtual void ResetCardholder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpMonth")]
        public virtual void ResetExpMonth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpYear")]
        public virtual void ResetExpYear()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFinancialAccount")]
        public virtual void ResetFinancialAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleControls")]
        public virtual void ResetLifecycleControls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersonalizationDesign")]
        public virtual void ResetPersonalizationDesign()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPin")]
        public virtual void ResetPin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplacementFor")]
        public virtual void ResetReplacementFor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplacementReason")]
        public virtual void ResetReplacementReason()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShipping")]
        public virtual void ResetShipping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpendingControls")]
        public virtual void ResetSpendingControls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
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
        = GetStaticProperty<string>(typeof(stripe.IssuingCard.IssuingCard))!;

        [JsiiProperty(name: "brand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Brand
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cvc
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "last4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Last4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestFraudWarning", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLatestFraudWarningOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardLatestFraudWarningOutputReference LatestFraudWarning
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardLatestFraudWarningOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleControls", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardLifecycleControlsOutputReference LifecycleControls
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardLifecycleControlsOutputReference>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Number
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pin", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardPinOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardPinOutputReference Pin
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardPinOutputReference>()!;
        }

        [JsiiProperty(name: "replacedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplacedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shipping", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardShippingOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardShippingOutputReference Shipping
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardShippingOutputReference>()!;
        }

        [JsiiProperty(name: "spendingControls", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardSpendingControlsOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardSpendingControlsOutputReference SpendingControls
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardSpendingControlsOutputReference>()!;
        }

        [JsiiProperty(name: "wallets", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardWalletsOutputReference\"}")]
        public virtual stripe.IssuingCard.IssuingCardWalletsOutputReference Wallets
        {
            get => GetInstanceProperty<stripe.IssuingCard.IssuingCardWalletsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cardholderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CardholderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expMonthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpMonthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expYearInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpYearInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "financialAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FinancialAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardLifecycleControls" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleControlsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControls\"}]}}", isOptional: true)]
        public virtual object? LifecycleControlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "personalizationDesignInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersonalizationDesignInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardPin" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pinInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardPin\"}]}}", isOptional: true)]
        public virtual object? PinInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replacementForInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplacementForInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replacementReasonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplacementReasonInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardShipping" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardShipping\"}]}}", isOptional: true)]
        public virtual object? ShippingInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCard.IIssuingCardSpendingControls" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spendingControlsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCard.IssuingCardSpendingControls\"}]}}", isOptional: true)]
        public virtual object? SpendingControlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cardholder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cardholder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpMonth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpYear
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FinancialAccount
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

        [JsiiProperty(name: "personalizationDesign", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersonalizationDesign
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replacementFor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplacementFor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replacementReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplacementReason
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
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

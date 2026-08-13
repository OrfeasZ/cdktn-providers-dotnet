using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source stripe_source}.</summary>
    [JsiiClass(nativeType: typeof(stripe.Source.Source), fullyQualifiedName: "stripe.source.Source", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.source.SourceConfig\"}}]")]
    public class Source : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source stripe_source} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Source(Constructs.Construct scope, string id, stripe.Source.ISourceConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.Source.ISourceConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Source(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Source(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Source resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Source to import.</param>
        /// <param name="importFromId">The id of the existing Source that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Source to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Source to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Source that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Source to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.Source.Source), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMandate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.source.SourceMandate\"}}]")]
        public virtual void PutMandate(stripe.Source.ISourceMandate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Source.ISourceMandate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOwner", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.source.SourceOwner\"}}]")]
        public virtual void PutOwner(stripe.Source.ISourceOwner @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Source.ISourceOwner)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReceiver", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.source.SourceReceiver\"}}]")]
        public virtual void PutReceiver(stripe.Source.ISourceReceiver @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Source.ISourceReceiver)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.source.SourceRedirect\"}}]")]
        public virtual void PutRedirect(stripe.Source.ISourceRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Source.ISourceRedirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceOrder", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.source.SourceSourceOrder\"}}]")]
        public virtual void PutSourceOrder(stripe.Source.ISourceSourceOrder @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Source.ISourceSourceOrder)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmount")]
        public virtual void ResetAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomer")]
        public virtual void ResetCustomer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlow")]
        public virtual void ResetFlow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMandate")]
        public virtual void ResetMandate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginalSource")]
        public virtual void ResetOriginalSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwner")]
        public virtual void ResetOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReceiver")]
        public virtual void ResetReceiver()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirect")]
        public virtual void ResetRedirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceOrder")]
        public virtual void ResetSourceOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatementDescriptor")]
        public virtual void ResetStatementDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetToken")]
        public virtual void ResetToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsage")]
        public virtual void ResetUsage()
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
        = GetStaticProperty<string>(typeof(stripe.Source.Source))!;

        [JsiiProperty(name: "achCreditTransfer", typeJson: "{\"fqn\":\"stripe.source.SourceAchCreditTransferOutputReference\"}")]
        public virtual stripe.Source.SourceAchCreditTransferOutputReference AchCreditTransfer
        {
            get => GetInstanceProperty<stripe.Source.SourceAchCreditTransferOutputReference>()!;
        }

        [JsiiProperty(name: "achDebit", typeJson: "{\"fqn\":\"stripe.source.SourceAchDebitOutputReference\"}")]
        public virtual stripe.Source.SourceAchDebitOutputReference AchDebit
        {
            get => GetInstanceProperty<stripe.Source.SourceAchDebitOutputReference>()!;
        }

        [JsiiProperty(name: "acssDebit", typeJson: "{\"fqn\":\"stripe.source.SourceAcssDebitOutputReference\"}")]
        public virtual stripe.Source.SourceAcssDebitOutputReference AcssDebit
        {
            get => GetInstanceProperty<stripe.Source.SourceAcssDebitOutputReference>()!;
        }

        [JsiiProperty(name: "alipay", typeJson: "{\"fqn\":\"stripe.source.SourceAlipayOutputReference\"}")]
        public virtual stripe.Source.SourceAlipayOutputReference Alipay
        {
            get => GetInstanceProperty<stripe.Source.SourceAlipayOutputReference>()!;
        }

        [JsiiProperty(name: "allowRedisplay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowRedisplay
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auBecsDebit", typeJson: "{\"fqn\":\"stripe.source.SourceAuBecsDebitOutputReference\"}")]
        public virtual stripe.Source.SourceAuBecsDebitOutputReference AuBecsDebit
        {
            get => GetInstanceProperty<stripe.Source.SourceAuBecsDebitOutputReference>()!;
        }

        [JsiiProperty(name: "bancontact", typeJson: "{\"fqn\":\"stripe.source.SourceBancontactOutputReference\"}")]
        public virtual stripe.Source.SourceBancontactOutputReference Bancontact
        {
            get => GetInstanceProperty<stripe.Source.SourceBancontactOutputReference>()!;
        }

        [JsiiProperty(name: "card", typeJson: "{\"fqn\":\"stripe.source.SourceCardOutputReference\"}")]
        public virtual stripe.Source.SourceCardOutputReference Card
        {
            get => GetInstanceProperty<stripe.Source.SourceCardOutputReference>()!;
        }

        [JsiiProperty(name: "cardPresent", typeJson: "{\"fqn\":\"stripe.source.SourceCardPresentOutputReference\"}")]
        public virtual stripe.Source.SourceCardPresentOutputReference CardPresent
        {
            get => GetInstanceProperty<stripe.Source.SourceCardPresentOutputReference>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "codeVerification", typeJson: "{\"fqn\":\"stripe.source.SourceCodeVerificationOutputReference\"}")]
        public virtual stripe.Source.SourceCodeVerificationOutputReference CodeVerification
        {
            get => GetInstanceProperty<stripe.Source.SourceCodeVerificationOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "eps", typeJson: "{\"fqn\":\"stripe.source.SourceEpsOutputReference\"}")]
        public virtual stripe.Source.SourceEpsOutputReference Eps
        {
            get => GetInstanceProperty<stripe.Source.SourceEpsOutputReference>()!;
        }

        [JsiiProperty(name: "giropay", typeJson: "{\"fqn\":\"stripe.source.SourceGiropayOutputReference\"}")]
        public virtual stripe.Source.SourceGiropayOutputReference Giropay
        {
            get => GetInstanceProperty<stripe.Source.SourceGiropayOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ideal", typeJson: "{\"fqn\":\"stripe.source.SourceIdealOutputReference\"}")]
        public virtual stripe.Source.SourceIdealOutputReference Ideal
        {
            get => GetInstanceProperty<stripe.Source.SourceIdealOutputReference>()!;
        }

        [JsiiProperty(name: "klarna", typeJson: "{\"fqn\":\"stripe.source.SourceKlarnaOutputReference\"}")]
        public virtual stripe.Source.SourceKlarnaOutputReference Klarna
        {
            get => GetInstanceProperty<stripe.Source.SourceKlarnaOutputReference>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mandate", typeJson: "{\"fqn\":\"stripe.source.SourceMandateOutputReference\"}")]
        public virtual stripe.Source.SourceMandateOutputReference Mandate
        {
            get => GetInstanceProperty<stripe.Source.SourceMandateOutputReference>()!;
        }

        [JsiiProperty(name: "multibanco", typeJson: "{\"fqn\":\"stripe.source.SourceMultibancoOutputReference\"}")]
        public virtual stripe.Source.SourceMultibancoOutputReference Multibanco
        {
            get => GetInstanceProperty<stripe.Source.SourceMultibancoOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "owner", typeJson: "{\"fqn\":\"stripe.source.SourceOwnerOutputReference\"}")]
        public virtual stripe.Source.SourceOwnerOutputReference Owner
        {
            get => GetInstanceProperty<stripe.Source.SourceOwnerOutputReference>()!;
        }

        [JsiiProperty(name: "p24", typeJson: "{\"fqn\":\"stripe.source.SourceP24OutputReference\"}")]
        public virtual stripe.Source.SourceP24OutputReference P24
        {
            get => GetInstanceProperty<stripe.Source.SourceP24OutputReference>()!;
        }

        [JsiiProperty(name: "receiver", typeJson: "{\"fqn\":\"stripe.source.SourceReceiverOutputReference\"}")]
        public virtual stripe.Source.SourceReceiverOutputReference Receiver
        {
            get => GetInstanceProperty<stripe.Source.SourceReceiverOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"stripe.source.SourceRedirectOutputReference\"}")]
        public virtual stripe.Source.SourceRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<stripe.Source.SourceRedirectOutputReference>()!;
        }

        [JsiiProperty(name: "sepaCreditTransfer", typeJson: "{\"fqn\":\"stripe.source.SourceSepaCreditTransferOutputReference\"}")]
        public virtual stripe.Source.SourceSepaCreditTransferOutputReference SepaCreditTransfer
        {
            get => GetInstanceProperty<stripe.Source.SourceSepaCreditTransferOutputReference>()!;
        }

        [JsiiProperty(name: "sepaDebit", typeJson: "{\"fqn\":\"stripe.source.SourceSepaDebitOutputReference\"}")]
        public virtual stripe.Source.SourceSepaDebitOutputReference SepaDebit
        {
            get => GetInstanceProperty<stripe.Source.SourceSepaDebitOutputReference>()!;
        }

        [JsiiProperty(name: "sofort", typeJson: "{\"fqn\":\"stripe.source.SourceSofortOutputReference\"}")]
        public virtual stripe.Source.SourceSofortOutputReference Sofort
        {
            get => GetInstanceProperty<stripe.Source.SourceSofortOutputReference>()!;
        }

        [JsiiProperty(name: "sourceOrder", typeJson: "{\"fqn\":\"stripe.source.SourceSourceOrderOutputReference\"}")]
        public virtual stripe.Source.SourceSourceOrderOutputReference SourceOrder
        {
            get => GetInstanceProperty<stripe.Source.SourceSourceOrderOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threeDSecure", typeJson: "{\"fqn\":\"stripe.source.SourceThreeDSecureOutputReference\"}")]
        public virtual stripe.Source.SourceThreeDSecureOutputReference ThreeDSecure
        {
            get => GetInstanceProperty<stripe.Source.SourceThreeDSecureOutputReference>()!;
        }

        [JsiiProperty(name: "wechat", typeJson: "{\"fqn\":\"stripe.source.SourceWechatOutputReference\"}")]
        public virtual stripe.Source.SourceWechatOutputReference Wechat
        {
            get => GetInstanceProperty<stripe.Source.SourceWechatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "flowInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FlowInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceMandate" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mandateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceMandate\"}]}}", isOptional: true)]
        public virtual object? MandateInput
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
        [JsiiProperty(name: "originalSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginalSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceOwner" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceOwner\"}]}}", isOptional: true)]
        public virtual object? OwnerInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceReceiver" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "receiverInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceReceiver\"}]}}", isOptional: true)]
        public virtual object? ReceiverInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceRedirect" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceRedirect\"}]}}", isOptional: true)]
        public virtual object? RedirectInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Source.ISourceSourceOrder" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceOrderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.source.SourceSourceOrder\"}]}}", isOptional: true)]
        public virtual object? SourceOrderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatementDescriptorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
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

        [JsiiProperty(name: "flow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Flow
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

        [JsiiProperty(name: "originalSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginalSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatementDescriptor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Token
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

        [JsiiProperty(name: "usage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Usage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

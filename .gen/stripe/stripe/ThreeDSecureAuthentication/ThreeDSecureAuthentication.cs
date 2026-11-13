using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication stripe_three_d_secure_authentication}.</summary>
    [JsiiClass(nativeType: typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthentication), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthentication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationConfig\"}}]")]
    public class ThreeDSecureAuthentication : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication stripe_three_d_secure_authentication} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ThreeDSecureAuthentication(Constructs.Construct scope, string id, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthentication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ThreeDSecureAuthentication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ThreeDSecureAuthentication resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ThreeDSecureAuthentication to import.</param>
        /// <param name="importFromId">The id of the existing ThreeDSecureAuthentication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ThreeDSecureAuthentication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ThreeDSecureAuthentication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ThreeDSecureAuthentication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ThreeDSecureAuthentication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthentication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAcquirerDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails\"}}]")]
        public virtual void PutAcquirerDetails(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putChannel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel\"}}]")]
        public virtual void PutChannel(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFlowPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference\"}}]")]
        public virtual void PutFlowPreference(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFutureUsage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsage\"}}]")]
        public virtual void PutFutureUsage(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPaymentMethodData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodData\"}}]")]
        public virtual void PutPaymentMethodData(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShippingAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationShippingAddress\"}}]")]
        public virtual void PutShippingAddress(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationShippingAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationShippingAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcquirerDetails")]
        public virtual void ResetAcquirerDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetDirectoryServer")]
        public virtual void ResetDirectoryServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFlowPreference")]
        public virtual void ResetFlowPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFutureUsage")]
        public virtual void ResetFutureUsage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethod")]
        public virtual void ResetPaymentMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPaymentMethodData")]
        public virtual void ResetPaymentMethodData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReason")]
        public virtual void ResetReason()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShippingAddress")]
        public virtual void ResetShippingAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubmit")]
        public virtual void ResetSubmit()
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
        = GetStaticProperty<string>(typeof(stripe.ThreeDSecureAuthentication.ThreeDSecureAuthentication))!;

        [JsiiProperty(name: "acquirerDetails", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetailsOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetailsOutputReference AcquirerDetails
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "challengeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChallengeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "channel", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationChannelOutputReference Channel
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationChannelOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "fingerprintingUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FingerprintingUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flowPreference", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceOutputReference FlowPreference
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceOutputReference>()!;
        }

        [JsiiProperty(name: "futureUsage", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageOutputReference FutureUsage
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outcome", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Outcome
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outcomeDetails", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsOutputReference OutcomeDetails
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationOutcomeDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "paymentMethodData", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataOutputReference PaymentMethodData
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataOutputReference>()!;
        }

        [JsiiProperty(name: "shippingAddress", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationShippingAddressOutputReference\"}")]
        public virtual stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationShippingAddressOutputReference ShippingAddress
        {
            get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.ThreeDSecureAuthenticationShippingAddressOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationAcquirerDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acquirerDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationAcquirerDetails\"}]}}", isOptional: true)]
        public virtual object? AcquirerDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "channelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel\"}]}}", isOptional: true)]
        public virtual object? ChannelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryServerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryServerInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flowPreferenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference\"}]}}", isOptional: true)]
        public virtual object? FlowPreferenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsage" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "futureUsageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsage\"}]}}", isOptional: true)]
        public virtual object? FutureUsageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageCategoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MessageCategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodData\"}]}}", isOptional: true)]
        public virtual object? PaymentMethodDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "paymentMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PaymentMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reasonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReasonInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationShippingAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingAddressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationShippingAddress\"}]}}", isOptional: true)]
        public virtual object? ShippingAddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "submitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubmitInput
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

        [JsiiProperty(name: "directoryServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryServer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "messageCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageCategory
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

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "submit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Submit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

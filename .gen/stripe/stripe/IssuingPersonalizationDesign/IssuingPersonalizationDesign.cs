using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingPersonalizationDesign
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design stripe_issuing_personalization_design}.</summary>
    [JsiiClass(nativeType: typeof(stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesign), fullyQualifiedName: "stripe.issuingPersonalizationDesign.IssuingPersonalizationDesign", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignConfig\"}}]")]
    public class IssuingPersonalizationDesign : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design stripe_issuing_personalization_design} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IssuingPersonalizationDesign(Constructs.Construct scope, string id, stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingPersonalizationDesign(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingPersonalizationDesign(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IssuingPersonalizationDesign resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IssuingPersonalizationDesign to import.</param>
        /// <param name="importFromId">The id of the existing IssuingPersonalizationDesign that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IssuingPersonalizationDesign to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IssuingPersonalizationDesign to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_personalization_design#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IssuingPersonalizationDesign that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IssuingPersonalizationDesign to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesign), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCarrierText", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierText\"}}]")]
        public virtual void PutCarrierText(stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferences\"}}]")]
        public virtual void PutPreferences(stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCardLogo")]
        public virtual void ResetCardLogo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCarrierText")]
        public virtual void ResetCarrierText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLookupKey")]
        public virtual void ResetLookupKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferences")]
        public virtual void ResetPreferences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferLookupKey")]
        public virtual void ResetTransferLookupKey()
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
        = GetStaticProperty<string>(typeof(stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesign))!;

        [JsiiProperty(name: "carrierText", typeJson: "{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierTextOutputReference\"}")]
        public virtual stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesignCarrierTextOutputReference CarrierText
        {
            get => GetInstanceProperty<stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesignCarrierTextOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferencesOutputReference\"}")]
        public virtual stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesignPreferencesOutputReference Preferences
        {
            get => GetInstanceProperty<stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesignPreferencesOutputReference>()!;
        }

        [JsiiProperty(name: "rejectionReasons", typeJson: "{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignRejectionReasonsOutputReference\"}")]
        public virtual stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesignRejectionReasonsOutputReference RejectionReasons
        {
            get => GetInstanceProperty<stripe.IssuingPersonalizationDesign.IssuingPersonalizationDesignRejectionReasonsOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cardLogoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CardLogoInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignCarrierText" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "carrierTextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignCarrierText\"}]}}", isOptional: true)]
        public virtual object? CarrierTextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lookupKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LookupKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "physicalBundleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhysicalBundleInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingPersonalizationDesign.IIssuingPersonalizationDesignPreferences" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferencesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingPersonalizationDesign.IssuingPersonalizationDesignPreferences\"}]}}", isOptional: true)]
        public virtual object? PreferencesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferLookupKeyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TransferLookupKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cardLogo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CardLogo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupKey
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "physicalBundle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhysicalBundle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "transferLookupKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object TransferLookupKey
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
    }
}

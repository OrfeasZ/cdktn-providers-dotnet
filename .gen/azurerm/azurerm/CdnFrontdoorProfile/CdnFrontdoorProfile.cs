using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorProfile
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_profile azurerm_cdn_frontdoor_profile}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorProfile.CdnFrontdoorProfile), fullyQualifiedName: "azurerm.cdnFrontdoorProfile.CdnFrontdoorProfile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileConfig\"}}]")]
    public class CdnFrontdoorProfile : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_profile azurerm_cdn_frontdoor_profile} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CdnFrontdoorProfile(Constructs.Construct scope, string id, azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorProfile(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a CdnFrontdoorProfile resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CdnFrontdoorProfile to import.</param>
        /// <param name="importFromId">The id of the existing CdnFrontdoorProfile that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CdnFrontdoorProfile to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CdnFrontdoorProfile to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_profile#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CdnFrontdoorProfile that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CdnFrontdoorProfile to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.CdnFrontdoorProfile.CdnFrontdoorProfile), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileIdentity)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileLogScrubbingRule" />)[]</param>
        [JsiiMethod(name: "putLogScrubbingRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogScrubbingRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileLogScrubbingRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileLogScrubbingRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileLogScrubbingRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogScrubbingRule")]
        public virtual void ResetLogScrubbingRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseTimeoutSeconds")]
        public virtual void ResetResponseTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.CdnFrontdoorProfile.CdnFrontdoorProfile))!;

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileIdentityOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "logScrubbingRule", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRuleList\"}")]
        public virtual azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRuleList LogScrubbingRule
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRuleList>()!;
        }

        [JsiiProperty(name: "resourceGuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileTimeoutsOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorProfile.CdnFrontdoorProfileTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileIdentity\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileLogScrubbingRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logScrubbingRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogScrubbingRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseTimeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ResponseTimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResponseTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

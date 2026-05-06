using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy oci_waas_waas_policy}.</summary>
    [JsiiClass(nativeType: typeof(oci.WaasWaasPolicy.WaasWaasPolicy), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyConfig\"}}]")]
    public class WaasWaasPolicy : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy oci_waas_waas_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WaasWaasPolicy(Constructs.Construct scope, string id, oci.WaasWaasPolicy.IWaasWaasPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.WaasWaasPolicy.IWaasWaasPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaasWaasPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WaasWaasPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WaasWaasPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WaasWaasPolicy to import.</param>
        /// <param name="importFromId">The id of the existing WaasWaasPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WaasWaasPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WaasWaasPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WaasWaasPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WaasWaasPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.WaasWaasPolicy.WaasWaasPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOriginGroups", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginGroups\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOriginGroups(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WaasWaasPolicy.IWaasWaasPolicyOriginGroups[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyOriginGroups).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyOriginGroups).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrigins", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOrigins\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOrigins(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WaasWaasPolicy.IWaasWaasPolicyOrigins[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyOrigins).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyOrigins).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPolicyConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfig\"}}]")]
        public virtual void PutPolicyConfig(oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.WaasWaasPolicy.IWaasWaasPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWafConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfig\"}}]")]
        public virtual void PutWafConfig(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalDomains")]
        public virtual void ResetAdditionalDomains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginGroups")]
        public virtual void ResetOriginGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrigins")]
        public virtual void ResetOrigins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyConfig")]
        public virtual void ResetPolicyConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWafConfig")]
        public virtual void ResetWafConfig()
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
        = GetStaticProperty<string>(typeof(oci.WaasWaasPolicy.WaasWaasPolicy))!;

        [JsiiProperty(name: "cname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "originGroups", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginGroupsList\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyOriginGroupsList OriginGroups
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyOriginGroupsList>()!;
        }

        [JsiiProperty(name: "origins", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginsList\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyOriginsList Origins
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyOriginsList>()!;
        }

        [JsiiProperty(name: "policyConfig", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyPolicyConfigOutputReference PolicyConfig
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyPolicyConfigOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyTimeoutsOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "wafConfig", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigOutputReference\"}")]
        public virtual oci.WaasWaasPolicy.WaasWaasPolicyWafConfigOutputReference WafConfig
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.WaasWaasPolicyWafConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalDomainsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AdditionalDomainsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originGroupsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOriginGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OriginGroupsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyOrigins\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OriginsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyConfigInput", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyPolicyConfig\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfig? PolicyConfigInput
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wafConfigInput", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfig\"}", isOptional: true)]
        public virtual oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig? WafConfigInput
        {
            get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfig?>();
        }

        [JsiiProperty(name: "additionalDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdditionalDomains
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

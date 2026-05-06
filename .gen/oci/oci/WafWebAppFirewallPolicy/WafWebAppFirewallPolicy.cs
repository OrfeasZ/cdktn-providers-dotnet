using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy oci_waf_web_app_firewall_policy}.</summary>
    [JsiiClass(nativeType: typeof(oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicy), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyConfig\"}}]")]
    public class WafWebAppFirewallPolicy : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy oci_waf_web_app_firewall_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WafWebAppFirewallPolicy(Constructs.Construct scope, string id, oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAppFirewallPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAppFirewallPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a WafWebAppFirewallPolicy resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the WafWebAppFirewallPolicy to import.</param>
        /// <param name="importFromId">The id of the existing WafWebAppFirewallPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the WafWebAppFirewallPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the WafWebAppFirewallPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waf_web_app_firewall_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing WafWebAppFirewallPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the WafWebAppFirewallPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyActions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutActions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyActions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyActions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyActions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestAccessControl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestAccessControl\"}}]")]
        public virtual void PutRequestAccessControl(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestAccessControl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestAccessControl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestProtection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtection\"}}]")]
        public virtual void PutRequestProtection(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestRateLimiting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimiting\"}}]")]
        public virtual void PutRequestRateLimiting(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimiting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimiting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResponseAccessControl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControl\"}}]")]
        public virtual void PutResponseAccessControl(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResponseProtection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtection\"}}]")]
        public virtual void PutResponseProtection(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActions")]
        public virtual void ResetActions()
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

        [JsiiMethod(name: "resetRequestAccessControl")]
        public virtual void ResetRequestAccessControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestProtection")]
        public virtual void ResetRequestProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestRateLimiting")]
        public virtual void ResetRequestRateLimiting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseAccessControl")]
        public virtual void ResetResponseAccessControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseProtection")]
        public virtual void ResetResponseProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSystemTags")]
        public virtual void ResetSystemTags()
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
        = GetStaticProperty<string>(typeof(oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicy))!;

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyActionsList\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyActionsList Actions
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyActionsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestAccessControl", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestAccessControlOutputReference\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestAccessControlOutputReference RequestAccessControl
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestAccessControlOutputReference>()!;
        }

        [JsiiProperty(name: "requestProtection", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionOutputReference\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionOutputReference RequestProtection
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtectionOutputReference>()!;
        }

        [JsiiProperty(name: "requestRateLimiting", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimitingOutputReference\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimitingOutputReference RequestRateLimiting
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimitingOutputReference>()!;
        }

        [JsiiProperty(name: "responseAccessControl", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlOutputReference\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlOutputReference ResponseAccessControl
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControlOutputReference>()!;
        }

        [JsiiProperty(name: "responseProtection", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionOutputReference\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionOutputReference ResponseProtection
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionOutputReference>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyTimeoutsOutputReference\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyActions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ActionsInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "requestAccessControlInput", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestAccessControl\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestAccessControl? RequestAccessControlInput
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestAccessControl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestProtectionInput", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestProtection\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtection? RequestProtectionInput
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestProtection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestRateLimitingInput", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyRequestRateLimiting\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimiting? RequestRateLimitingInput
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyRequestRateLimiting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseAccessControlInput", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseAccessControl\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControl? ResponseAccessControlInput
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseAccessControl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseProtectionInput", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtection\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtection? ResponseProtectionInput
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SystemTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "systemTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SystemTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}

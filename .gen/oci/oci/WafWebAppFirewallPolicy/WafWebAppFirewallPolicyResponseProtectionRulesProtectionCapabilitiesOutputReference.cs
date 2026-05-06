using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiClass(nativeType: typeof(oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesOutputReference), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCollaborativeWeights", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeights\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCollaborativeWeights(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeights[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeights).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeights).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExclusions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions\"}}]")]
        public virtual void PutExclusions(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActionName")]
        public virtual void ResetActionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCollaborativeActionThreshold")]
        public virtual void ResetCollaborativeActionThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCollaborativeWeights")]
        public virtual void ResetCollaborativeWeights()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExclusions")]
        public virtual void ResetExclusions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "collaborativeWeights", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeightsList\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeightsList CollaborativeWeights
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeightsList>()!;
        }

        [JsiiProperty(name: "exclusions", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusionsOutputReference\"}")]
        public virtual oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusionsOutputReference Exclusions
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "collaborativeActionThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CollaborativeActionThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "collaborativeWeightsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesCollaborativeWeights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CollaborativeWeightsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exclusionsInput", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions? ExclusionsInput
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilitiesExclusions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "actionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "collaborativeActionThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CollaborativeActionThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities\"}]}}", isOptional: true)]
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
                        case oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyResponseProtectionRulesProtectionCapabilities).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

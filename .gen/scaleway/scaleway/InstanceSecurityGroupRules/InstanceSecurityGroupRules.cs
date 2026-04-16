using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSecurityGroupRules
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules scaleway_instance_security_group_rules}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRules), fullyQualifiedName: "scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRules", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesConfig\"}}]")]
    public class InstanceSecurityGroupRules : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules scaleway_instance_security_group_rules} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public InstanceSecurityGroupRules(Constructs.Construct scope, string id, scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstanceSecurityGroupRules(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstanceSecurityGroupRules(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a InstanceSecurityGroupRules resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the InstanceSecurityGroupRules to import.</param>
        /// <param name="importFromId">The id of the existing InstanceSecurityGroupRules that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the InstanceSecurityGroupRules to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the InstanceSecurityGroupRules to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing InstanceSecurityGroupRules that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the InstanceSecurityGroupRules to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRules), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putInboundRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesInboundRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInboundRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesInboundRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesInboundRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesInboundRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutboundRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesOutboundRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOutboundRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesOutboundRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesOutboundRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesOutboundRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInboundRule")]
        public virtual void ResetInboundRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundRule")]
        public virtual void ResetOutboundRule()
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
        = GetStaticProperty<string>(typeof(scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRules))!;

        [JsiiProperty(name: "inboundRule", typeJson: "{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesInboundRuleList\"}")]
        public virtual scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRulesInboundRuleList InboundRule
        {
            get => GetInstanceProperty<scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRulesInboundRuleList>()!;
        }

        [JsiiProperty(name: "outboundRule", typeJson: "{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesOutboundRuleList\"}")]
        public virtual scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRulesOutboundRuleList OutboundRule
        {
            get => GetInstanceProperty<scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRulesOutboundRuleList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesTimeoutsOutputReference\"}")]
        public virtual scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRulesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.InstanceSecurityGroupRules.InstanceSecurityGroupRulesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inboundRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesInboundRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InboundRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesOutboundRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OutboundRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesTimeouts\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "securityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccount
{
    [JsiiClass(nativeType: typeof(azurerm.CognitiveAccount.CognitiveAccountNetworkAclsOutputReference), fullyQualifiedName: "azurerm.cognitiveAccount.CognitiveAccountNetworkAclsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitiveAccountNetworkAclsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitiveAccountNetworkAclsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CognitiveAccountNetworkAclsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitiveAccountNetworkAclsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules" />)[]</param>
        [JsiiMethod(name: "putVirtualNetworkRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVirtualNetworkRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBypass")]
        public virtual void ResetBypass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpRules")]
        public virtual void ResetIpRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualNetworkRules")]
        public virtual void ResetVirtualNetworkRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "virtualNetworkRules", typeJson: "{\"fqn\":\"azurerm.cognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRulesList\"}")]
        public virtual azurerm.CognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRulesList VirtualNetworkRules
        {
            get => GetInstanceProperty<azurerm.CognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRulesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bypassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BypassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipRulesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IpRulesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VirtualNetworkRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bypass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bypass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpRules
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cognitiveAccount.CognitiveAccountNetworkAcls\"}", isOptional: true)]
        public virtual azurerm.CognitiveAccount.ICognitiveAccountNetworkAcls? InternalValue
        {
            get => GetInstanceProperty<azurerm.CognitiveAccount.ICognitiveAccountNetworkAcls?>();
            set => SetInstanceProperty(value);
        }
    }
}

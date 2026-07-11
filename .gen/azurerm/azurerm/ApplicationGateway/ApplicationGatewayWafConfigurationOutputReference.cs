using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiClass(nativeType: typeof(azurerm.ApplicationGateway.ApplicationGatewayWafConfigurationOutputReference), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayWafConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApplicationGatewayWafConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApplicationGatewayWafConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApplicationGatewayWafConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationGatewayWafConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup" />)[]</param>
        [JsiiMethod(name: "putDisabledRuleGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroup\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDisabledRuleGroup(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion" />)[]</param>
        [JsiiMethod(name: "putExclusion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationExclusion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExclusion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisabledRuleGroup")]
        public virtual void ResetDisabledRuleGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExclusion")]
        public virtual void ResetExclusion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileUploadLimitMb")]
        public virtual void ResetFileUploadLimitMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxRequestBodySizeKb")]
        public virtual void ResetMaxRequestBodySizeKb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestBodyCheck")]
        public virtual void ResetRequestBodyCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleSetType")]
        public virtual void ResetRuleSetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "disabledRuleGroup", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroupList\"}")]
        public virtual azurerm.ApplicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroupList DisabledRuleGroup
        {
            get => GetInstanceProperty<azurerm.ApplicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroupList>()!;
        }

        [JsiiProperty(name: "exclusion", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationExclusionList\"}")]
        public virtual azurerm.ApplicationGateway.ApplicationGatewayWafConfigurationExclusionList Exclusion
        {
            get => GetInstanceProperty<azurerm.ApplicationGateway.ApplicationGatewayWafConfigurationExclusionList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationDisabledRuleGroup" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabledRuleGroupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationDisabledRuleGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DisabledRuleGroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfigurationExclusion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExclusionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileUploadLimitMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FileUploadLimitMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firewallModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirewallModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRequestBodySizeKbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRequestBodySizeKbInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestBodyCheckInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequestBodyCheckInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleSetTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleSetTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleSetVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleSetVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "fileUploadLimitMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FileUploadLimitMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firewallMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirewallMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxRequestBodySizeKb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRequestBodySizeKb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requestBodyCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RequestBodyCheck
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

        [JsiiProperty(name: "ruleSetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleSetType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleSetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleSetVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayWafConfiguration\"}", isOptional: true)]
        public virtual azurerm.ApplicationGateway.IApplicationGatewayWafConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewayWafConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetOutputReference), fullyQualifiedName: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomationSoftwareUpdateConfigurationTargetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomationSoftwareUpdateConfigurationTargetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomationSoftwareUpdateConfigurationTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationSoftwareUpdateConfigurationTargetOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery" />)[]</param>
        [JsiiMethod(name: "putAzureQuery", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQuery\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAzureQuery(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery" />)[]</param>
        [JsiiMethod(name: "putNonAzureQuery", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQuery\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNonAzureQuery(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureQuery")]
        public virtual void ResetAzureQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNonAzureQuery")]
        public virtual void ResetNonAzureQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "azureQuery", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQueryList\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQueryList AzureQuery
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQueryList>()!;
        }

        [JsiiProperty(name: "nonAzureQuery", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQueryList\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQueryList NonAzureQuery
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQueryList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetAzureQuery" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureQueryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AzureQueryInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTargetNonAzureQuery" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nonAzureQueryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetNonAzureQuery\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NonAzureQueryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget\"}", isOptional: true)]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}

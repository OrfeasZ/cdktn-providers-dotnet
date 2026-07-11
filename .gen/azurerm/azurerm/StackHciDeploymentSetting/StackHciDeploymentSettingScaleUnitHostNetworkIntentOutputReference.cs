using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    [JsiiClass(nativeType: typeof(azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentOutputReference), fullyQualifiedName: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class StackHciDeploymentSettingScaleUnitHostNetworkIntentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public StackHciDeploymentSettingScaleUnitHostNetworkIntentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected StackHciDeploymentSettingScaleUnitHostNetworkIntentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackHciDeploymentSettingScaleUnitHostNetworkIntentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdapterPropertyOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride\"}}]")]
        public virtual void PutAdapterPropertyOverride(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQosPolicyOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride\"}}]")]
        public virtual void PutQosPolicyOverride(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualSwitchConfigurationOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride\"}}]")]
        public virtual void PutVirtualSwitchConfigurationOverride(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdapterPropertyOverride")]
        public virtual void ResetAdapterPropertyOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdapterPropertyOverrideEnabled")]
        public virtual void ResetAdapterPropertyOverrideEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQosPolicyOverride")]
        public virtual void ResetQosPolicyOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQosPolicyOverrideEnabled")]
        public virtual void ResetQosPolicyOverrideEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualSwitchConfigurationOverride")]
        public virtual void ResetVirtualSwitchConfigurationOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualSwitchConfigurationOverrideEnabled")]
        public virtual void ResetVirtualSwitchConfigurationOverrideEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "adapterPropertyOverride", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference\"}")]
        public virtual azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference AdapterPropertyOverride
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverrideOutputReference>()!;
        }

        [JsiiProperty(name: "qosPolicyOverride", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference\"}")]
        public virtual azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference QosPolicyOverride
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverrideOutputReference>()!;
        }

        [JsiiProperty(name: "virtualSwitchConfigurationOverride", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverrideOutputReference\"}")]
        public virtual azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverrideOutputReference VirtualSwitchConfigurationOverride
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverrideOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adapterInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AdapterInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adapterPropertyOverrideEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AdapterPropertyOverrideEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adapterPropertyOverrideInput", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride\"}", isOptional: true)]
        public virtual azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride? AdapterPropertyOverrideInput
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentAdapterPropertyOverride?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "qosPolicyOverrideEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? QosPolicyOverrideEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qosPolicyOverrideInput", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride\"}", isOptional: true)]
        public virtual azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride? QosPolicyOverrideInput
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentQosPolicyOverride?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficTypeInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TrafficTypeInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualSwitchConfigurationOverrideEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VirtualSwitchConfigurationOverrideEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualSwitchConfigurationOverrideInput", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride\"}", isOptional: true)]
        public virtual azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride? VirtualSwitchConfigurationOverrideInput
        {
            get => GetInstanceProperty<azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntentVirtualSwitchConfigurationOverride?>();
        }

        [JsiiProperty(name: "adapter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Adapter
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "adapterPropertyOverrideEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AdapterPropertyOverrideEnabled
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "qosPolicyOverrideEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object QosPolicyOverrideEnabled
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

        [JsiiProperty(name: "trafficType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrafficType
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "virtualSwitchConfigurationOverrideEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object VirtualSwitchConfigurationOverrideEnabled
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntent" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetworkIntent\"}]}}", isOptional: true)]
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
                        case azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntent cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetworkIntent).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

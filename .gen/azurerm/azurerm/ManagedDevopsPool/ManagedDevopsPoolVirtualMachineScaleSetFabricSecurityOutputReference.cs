using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiClass(nativeType: typeof(azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKeyVaultManagement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement\"}}]")]
        public virtual void PutKeyVaultManagement(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInteractiveLogonEnabled")]
        public virtual void ResetInteractiveLogonEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultManagement")]
        public virtual void ResetKeyVaultManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "keyVaultManagement", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagementOutputReference\"}")]
        public virtual azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagementOutputReference KeyVaultManagement
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagementOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "interactiveLogonEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InteractiveLogonEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultManagementInput", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement? KeyVaultManagementInput
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurityKeyVaultManagement?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "interactiveLogonEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object InteractiveLogonEnabled
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolVirtualMachineScaleSetFabricSecurity\"}", isOptional: true)]
        public virtual azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity? InternalValue
        {
            get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolVirtualMachineScaleSetFabricSecurity?>();
            set => SetInstanceProperty(value);
        }
    }
}

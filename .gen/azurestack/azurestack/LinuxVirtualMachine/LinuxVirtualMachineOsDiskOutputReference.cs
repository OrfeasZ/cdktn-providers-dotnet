using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.LinuxVirtualMachine
{
    [JsiiClass(nativeType: typeof(azurestack.LinuxVirtualMachine.LinuxVirtualMachineOsDiskOutputReference), fullyQualifiedName: "azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxVirtualMachineOsDiskOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxVirtualMachineOsDiskOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxVirtualMachineOsDiskOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxVirtualMachineOsDiskOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDiffDiskSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettings\"}}]")]
        public virtual void PutDiffDiskSettings(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDiskDiffDiskSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDiskDiffDiskSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDiffDiskSettings")]
        public virtual void ResetDiffDiskSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskEncryptionSetId")]
        public virtual void ResetDiskEncryptionSetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskSizeGb")]
        public virtual void ResetDiskSizeGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteAcceleratorEnabled")]
        public virtual void ResetWriteAcceleratorEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "diffDiskSettings", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettingsOutputReference\"}")]
        public virtual azurestack.LinuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettingsOutputReference DiffDiskSettings
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CachingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diffDiskSettingsInput", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDiskDiffDiskSettings\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDiskDiffDiskSettings? DiffDiskSettingsInput
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDiskDiffDiskSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiskEncryptionSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskSizeGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DiskSizeGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageAccountTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageAccountTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "writeAcceleratorEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WriteAcceleratorEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Caching
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskEncryptionSetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "diskSizeGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiskSizeGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageAccountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageAccountType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "writeAcceleratorEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object WriteAcceleratorEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurestack.linuxVirtualMachine.LinuxVirtualMachineOsDisk\"}", isOptional: true)]
        public virtual azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk? InternalValue
        {
            get => GetInstanceProperty<azurestack.LinuxVirtualMachine.ILinuxVirtualMachineOsDisk?>();
            set => SetInstanceProperty(value);
        }
    }
}

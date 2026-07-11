using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance
{
    [JsiiClass(nativeType: typeof(azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareOutputReference), fullyQualifiedName: "azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpuCount")]
        public virtual void ResetCpuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamicMemoryMaxInMb")]
        public virtual void ResetDynamicMemoryMaxInMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamicMemoryMinInMb")]
        public virtual void ResetDynamicMemoryMinInMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimitCpuForMigrationEnabled")]
        public virtual void ResetLimitCpuForMigrationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryInMb")]
        public virtual void ResetMemoryInMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamicMemoryMaxInMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DynamicMemoryMaxInMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamicMemoryMinInMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DynamicMemoryMinInMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limitCpuForMigrationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LimitCpuForMigrationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryInMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamicMemoryMaxInMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DynamicMemoryMaxInMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamicMemoryMinInMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DynamicMemoryMinInMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "limitCpuForMigrationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object LimitCpuForMigrationEnabled
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

        [JsiiProperty(name: "memoryInMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryInMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.systemCenterVirtualMachineManagerVirtualMachineInstance.SystemCenterVirtualMachineManagerVirtualMachineInstanceHardware\"}", isOptional: true)]
        public virtual azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceHardware? InternalValue
        {
            get => GetInstanceProperty<azurerm.SystemCenterVirtualMachineManagerVirtualMachineInstance.ISystemCenterVirtualMachineManagerVirtualMachineInstanceHardware?>();
            set => SetInstanceProperty(value);
        }
    }
}

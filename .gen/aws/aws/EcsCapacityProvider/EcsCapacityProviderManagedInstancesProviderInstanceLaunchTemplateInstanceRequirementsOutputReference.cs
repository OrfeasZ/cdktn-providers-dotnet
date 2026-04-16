using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiClass(nativeType: typeof(aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAcceleratorCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount\"}}]")]
        public virtual void PutAcceleratorCount(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAcceleratorTotalMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib\"}}]")]
        public virtual void PutAcceleratorTotalMemoryMib(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBaselineEbsBandwidthMbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps\"}}]")]
        public virtual void PutBaselineEbsBandwidthMbps(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryGibPerVcpu", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu\"}}]")]
        public virtual void PutMemoryGibPerVcpu(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMemoryMib", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib\"}}]")]
        public virtual void PutMemoryMib(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkBandwidthGbps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps\"}}]")]
        public virtual void PutNetworkBandwidthGbps(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterfaceCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount\"}}]")]
        public virtual void PutNetworkInterfaceCount(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTotalLocalStorageGb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb\"}}]")]
        public virtual void PutTotalLocalStorageGb(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVcpuCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount\"}}]")]
        public virtual void PutVcpuCount(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceleratorCount")]
        public virtual void ResetAcceleratorCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorManufacturers")]
        public virtual void ResetAcceleratorManufacturers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorNames")]
        public virtual void ResetAcceleratorNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorTotalMemoryMib")]
        public virtual void ResetAcceleratorTotalMemoryMib()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcceleratorTypes")]
        public virtual void ResetAcceleratorTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedInstanceTypes")]
        public virtual void ResetAllowedInstanceTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBareMetal")]
        public virtual void ResetBareMetal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBaselineEbsBandwidthMbps")]
        public virtual void ResetBaselineEbsBandwidthMbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBurstablePerformance")]
        public virtual void ResetBurstablePerformance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuManufacturers")]
        public virtual void ResetCpuManufacturers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludedInstanceTypes")]
        public virtual void ResetExcludedInstanceTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceGenerations")]
        public virtual void ResetInstanceGenerations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalStorage")]
        public virtual void ResetLocalStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalStorageTypes")]
        public virtual void ResetLocalStorageTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
        public virtual void ResetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryGibPerVcpu")]
        public virtual void ResetMemoryGibPerVcpu()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkBandwidthGbps")]
        public virtual void ResetNetworkBandwidthGbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterfaceCount")]
        public virtual void ResetNetworkInterfaceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandMaxPricePercentageOverLowestPrice")]
        public virtual void ResetOnDemandMaxPricePercentageOverLowestPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireHibernateSupport")]
        public virtual void ResetRequireHibernateSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotMaxPricePercentageOverLowestPrice")]
        public virtual void ResetSpotMaxPricePercentageOverLowestPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalLocalStorageGb")]
        public virtual void ResetTotalLocalStorageGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "acceleratorCount", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCountOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCountOutputReference AcceleratorCount
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCountOutputReference>()!;
        }

        [JsiiProperty(name: "acceleratorTotalMemoryMib", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibOutputReference AcceleratorTotalMemoryMib
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "baselineEbsBandwidthMbps", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference BaselineEbsBandwidthMbps
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbpsOutputReference>()!;
        }

        [JsiiProperty(name: "memoryGibPerVcpu", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpuOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpuOutputReference MemoryGibPerVcpu
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpuOutputReference>()!;
        }

        [JsiiProperty(name: "memoryMib", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMibOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMibOutputReference MemoryMib
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMibOutputReference>()!;
        }

        [JsiiProperty(name: "networkBandwidthGbps", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbpsOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbpsOutputReference NetworkBandwidthGbps
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbpsOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterfaceCount", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCountOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCountOutputReference NetworkInterfaceCount
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCountOutputReference>()!;
        }

        [JsiiProperty(name: "totalLocalStorageGb", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGbOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGbOutputReference TotalLocalStorageGb
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGbOutputReference>()!;
        }

        [JsiiProperty(name: "vcpuCount", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCountOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCountOutputReference VcpuCount
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorCountInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCountInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorManufacturersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AcceleratorManufacturersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AcceleratorNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTotalMemoryMibInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMibInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AcceleratorTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedInstanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedInstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bareMetalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BareMetalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "baselineEbsBandwidthMbpsInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbpsInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "burstablePerformanceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BurstablePerformanceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuManufacturersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CpuManufacturersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludedInstanceTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludedInstanceTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceGenerationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? InstanceGenerationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localStorageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalStorageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localStorageTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LocalStorageTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSpotPriceAsPercentageOfOptimalOnDemandPriceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryGibPerVcpuInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpuInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryMibInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib? MemoryMibInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkBandwidthGbpsInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbpsInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceCountInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCountInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OnDemandMaxPricePercentageOverLowestPriceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireHibernateSupportInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireHibernateSupportInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SpotMaxPricePercentageOverLowestPriceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalLocalStorageGbInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGbInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcpuCountInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount? VcpuCountInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount?>();
        }

        [JsiiProperty(name: "acceleratorManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorManufacturers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acceleratorNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acceleratorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AcceleratorTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BareMetal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "burstablePerformance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BurstablePerformance
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuManufacturers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CpuManufacturers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludedInstanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludedInstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceGenerations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstanceGenerations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localStorage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalStorage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localStorageTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LocalStorageTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSpotPriceAsPercentageOfOptimalOnDemandPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onDemandMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnDemandMaxPricePercentageOverLowestPrice
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireHibernateSupport", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RequireHibernateSupport
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

        [JsiiProperty(name: "spotMaxPricePercentageOverLowestPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpotMaxPricePercentageOverLowestPrice
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InternalValue
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements?>();
            set => SetInstanceProperty(value);
        }
    }
}

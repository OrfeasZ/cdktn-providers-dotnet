using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiClass(nativeType: typeof(aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceRequirements", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements\"}}]")]
        public virtual void PutInstanceRequirements(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration\"}}]")]
        public virtual void PutStorageConfiguration(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityOptionType")]
        public virtual void ResetCapacityOptionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceRequirements")]
        public virtual void ResetInstanceRequirements()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoring")]
        public virtual void ResetMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageConfiguration")]
        public virtual void ResetStorageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference InstanceRequirements
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "storageConfiguration", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfigurationOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfigurationOutputReference StorageConfiguration
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityOptionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityOptionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceProfileArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Ec2InstanceProfileArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceRequirementsInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirementsInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonitoringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration?>();
        }

        [JsiiProperty(name: "capacityOptionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityOptionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2InstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceProfileArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Monitoring
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate? InternalValue
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}

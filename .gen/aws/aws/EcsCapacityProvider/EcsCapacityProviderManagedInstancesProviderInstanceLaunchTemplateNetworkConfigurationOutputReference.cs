using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiClass(nativeType: typeof(aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Subnets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

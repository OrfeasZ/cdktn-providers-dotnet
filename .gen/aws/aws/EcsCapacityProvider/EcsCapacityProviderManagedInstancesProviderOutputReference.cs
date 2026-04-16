using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCapacityProvider
{
    [JsiiClass(nativeType: typeof(aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderOutputReference), fullyQualifiedName: "aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsCapacityProviderManagedInstancesProviderOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsCapacityProviderManagedInstancesProviderOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsCapacityProviderManagedInstancesProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderManagedInstancesProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInfrastructureOptimization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization\"}}]")]
        public virtual void PutInfrastructureOptimization(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceLaunchTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate\"}}]")]
        public virtual void PutInstanceLaunchTemplate(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInfrastructureOptimization")]
        public virtual void ResetInfrastructureOptimization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagateTags")]
        public virtual void ResetPropagateTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "infrastructureOptimization", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimizationOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimizationOutputReference InfrastructureOptimization
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimizationOutputReference>()!;
        }

        [JsiiProperty(name: "instanceLaunchTemplate", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference\"}")]
        public virtual aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference InstanceLaunchTemplate
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureOptimizationInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInfrastructureOptimization\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization? InfrastructureOptimizationInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInfrastructureOptimization?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InfrastructureRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceLaunchTemplateInput", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate? InstanceLaunchTemplateInput
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProviderInstanceLaunchTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagateTagsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PropagateTagsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "infrastructureRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "propagateTags", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PropagateTags
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsCapacityProvider.EcsCapacityProviderManagedInstancesProvider\"}", isOptional: true)]
        public virtual aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProvider? InternalValue
        {
            get => GetInstanceProperty<aws.EcsCapacityProvider.IEcsCapacityProviderManagedInstancesProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}

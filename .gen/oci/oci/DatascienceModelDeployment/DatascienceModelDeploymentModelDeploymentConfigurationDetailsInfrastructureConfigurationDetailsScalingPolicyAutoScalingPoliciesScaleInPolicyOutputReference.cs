using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCoolDownInSeconds")]
        public virtual void ResetCoolDownInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCountAdjustment")]
        public virtual void ResetInstanceCountAdjustment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPendingDuration")]
        public virtual void ResetPendingDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "coolDownInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoolDownInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountAdjustmentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountAdjustmentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pendingDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PendingDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "coolDownInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoolDownInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCountAdjustment", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCountAdjustment
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsScalingPolicyAutoScalingPoliciesScaleInPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiClass(nativeType: typeof(oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsOutputReference), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceComputeTargetComputeConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceComputeTargetComputeConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceComputeTargetComputeConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceComputeTargetComputeConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration\"}}]")]
        public virtual void PutInstanceConfiguration(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicy\"}}]")]
        public virtual void PutScalingPolicy(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetScalingPolicy")]
        public virtual void ResetScalingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference\"}")]
        public virtual oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference InstanceConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference\"}")]
        public virtual oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference ScalingPolicy
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration? InstanceConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingPolicyInput", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicy\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy? ScalingPolicyInput
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy?>();
        }

        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

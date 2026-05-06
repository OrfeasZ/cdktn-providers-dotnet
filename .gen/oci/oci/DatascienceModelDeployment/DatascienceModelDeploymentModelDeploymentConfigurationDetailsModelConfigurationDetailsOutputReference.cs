using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiClass(nativeType: typeof(oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration\"}}]")]
        public virtual void PutInstanceConfiguration(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy\"}}]")]
        public virtual void PutScalingPolicy(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBandwidthMbps")]
        public virtual void ResetBandwidthMbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceConfiguration")]
        public virtual void ResetInstanceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumBandwidthMbps")]
        public virtual void ResetMaximumBandwidthMbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelId")]
        public virtual void ResetModelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScalingPolicy")]
        public virtual void ResetScalingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfigurationOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfigurationOutputReference InstanceConfiguration
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "scalingPolicy", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyOutputReference\"}")]
        public virtual oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyOutputReference ScalingPolicy
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bandwidthMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BandwidthMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceConfigurationInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration? InstanceConfigurationInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsInstanceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBandwidthMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBandwidthMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingPolicyInput", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy? ScalingPolicyInput
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetailsScalingPolicy?>();
        }

        [JsiiProperty(name: "bandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BandwidthMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumBandwidthMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBandwidthMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails\"}", isOptional: true)]
        public virtual oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsModelConfigurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

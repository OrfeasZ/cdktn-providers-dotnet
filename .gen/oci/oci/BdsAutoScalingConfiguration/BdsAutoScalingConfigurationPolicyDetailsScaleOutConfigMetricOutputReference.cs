using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricOutputReference), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putThreshold", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold\"}}]")]
        public virtual void PutThreshold(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMetricType")]
        public virtual void ResetMetricType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreshold")]
        public virtual void ResetThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThresholdOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThresholdOutputReference Threshold
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThresholdOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold? ThresholdInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetricThreshold?>();
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric? InternalValue
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfigMetric?>();
            set => SetInstanceProperty(value);
        }
    }
}

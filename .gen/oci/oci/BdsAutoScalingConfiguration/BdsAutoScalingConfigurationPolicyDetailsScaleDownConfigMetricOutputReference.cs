using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricOutputReference), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putThreshold", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold\"}}]")]
        public virtual void PutThreshold(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold)}, new object[]{@value});
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

        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThresholdOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThresholdOutputReference Threshold
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThresholdOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold? ThresholdInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricThreshold?>();
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric? InternalValue
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetric?>();
            set => SetInstanceProperty(value);
        }
    }
}

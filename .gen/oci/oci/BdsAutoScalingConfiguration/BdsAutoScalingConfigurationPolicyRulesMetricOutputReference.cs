using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricOutputReference), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsAutoScalingConfigurationPolicyRulesMetricOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsAutoScalingConfigurationPolicyRulesMetricOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsAutoScalingConfigurationPolicyRulesMetricOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsAutoScalingConfigurationPolicyRulesMetricOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putThreshold", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricThreshold\"}}]")]
        public virtual void PutThreshold(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyRulesMetricThreshold @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyRulesMetricThreshold)}, new object[]{@value});
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricThresholdOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricThresholdOutputReference Threshold
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricThresholdOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetricThreshold\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyRulesMetricThreshold? ThresholdInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyRulesMetricThreshold?>();
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyRulesMetric\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyRulesMetric? InternalValue
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyRulesMetric?>();
            set => SetInstanceProperty(value);
        }
    }
}

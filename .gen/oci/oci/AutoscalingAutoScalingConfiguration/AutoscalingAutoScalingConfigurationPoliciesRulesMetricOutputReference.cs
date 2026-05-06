using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AutoscalingAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricOutputReference), fullyQualifiedName: "oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingAutoScalingConfigurationPoliciesRulesMetricOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingAutoScalingConfigurationPoliciesRulesMetricOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingAutoScalingConfigurationPoliciesRulesMetricOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingAutoScalingConfigurationPoliciesRulesMetricOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putThreshold", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold\"}}]")]
        public virtual void PutThreshold(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMetricCompartmentId")]
        public virtual void ResetMetricCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricSource")]
        public virtual void ResetMetricSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricType")]
        public virtual void ResetMetricType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespace")]
        public virtual void ResetNamespace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPendingDuration")]
        public virtual void ResetPendingDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuery")]
        public virtual void ResetQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceGroup")]
        public virtual void ResetResourceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreshold")]
        public virtual void ResetThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricThresholdOutputReference\"}")]
        public virtual oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricThresholdOutputReference Threshold
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricThresholdOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricCompartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricCompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MetricTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pendingDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PendingDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdInput", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold\"}", isOptional: true)]
        public virtual oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold? ThresholdInput
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetricThreshold?>();
        }

        [JsiiProperty(name: "metricCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricCompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.autoscalingAutoScalingConfiguration.AutoscalingAutoScalingConfigurationPoliciesRulesMetric\"}", isOptional: true)]
        public virtual oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetric? InternalValue
        {
            get => GetInstanceProperty<oci.AutoscalingAutoScalingConfiguration.IAutoscalingAutoScalingConfigurationPoliciesRulesMetric?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAutoscalingAutoScalingConfigurations
{
    [JsiiClass(nativeType: typeof(oci.DataOciAutoscalingAutoScalingConfigurations.DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricOutputReference), fullyQualifiedName: "oci.dataOciAutoscalingAutoScalingConfigurations.DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "metricCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pendingDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PendingDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "threshold", typeJson: "{\"fqn\":\"oci.dataOciAutoscalingAutoScalingConfigurations.DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricThresholdList\"}")]
        public virtual oci.DataOciAutoscalingAutoScalingConfigurations.DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricThresholdList Threshold
        {
            get => GetInstanceProperty<oci.DataOciAutoscalingAutoScalingConfigurations.DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetricThresholdList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAutoscalingAutoScalingConfigurations.DataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetric\"}", isOptional: true)]
        public virtual oci.DataOciAutoscalingAutoScalingConfigurations.IDataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetric? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAutoscalingAutoScalingConfigurations.IDataOciAutoscalingAutoScalingConfigurationsAutoScalingConfigurationsPoliciesRulesMetric?>();
            set => SetInstanceProperty(value);
        }
    }
}

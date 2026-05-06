using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBdsAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.DataOciBdsAutoScalingConfiguration.DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference), fullyQualifiedName: "oci.dataOciBdsAutoScalingConfiguration.DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "memoryStepSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryStepSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"oci.dataOciBdsAutoScalingConfiguration.DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricList\"}")]
        public virtual oci.DataOciBdsAutoScalingConfiguration.DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricList Metric
        {
            get => GetInstanceProperty<oci.DataOciBdsAutoScalingConfiguration.DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfigMetricList>()!;
        }

        [JsiiProperty(name: "minMemoryPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinMemoryPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minOcpusPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinOcpusPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpuStepSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuStepSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBdsAutoScalingConfiguration.DataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig\"}", isOptional: true)]
        public virtual oci.DataOciBdsAutoScalingConfiguration.IDataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBdsAutoScalingConfiguration.IDataOciBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

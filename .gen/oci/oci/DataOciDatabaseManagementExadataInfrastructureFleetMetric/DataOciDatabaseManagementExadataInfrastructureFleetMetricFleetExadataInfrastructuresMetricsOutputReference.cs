using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "baselineValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BaselineValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsDimensionsList\"}")]
        public virtual oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsDimensionsList Dimensions
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsDimensionsList>()!;
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "percentageChange", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentageChange
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Unit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetrics\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.IDataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetrics? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.IDataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetrics?>();
            set => SetInstanceProperty(value);
        }
    }
}

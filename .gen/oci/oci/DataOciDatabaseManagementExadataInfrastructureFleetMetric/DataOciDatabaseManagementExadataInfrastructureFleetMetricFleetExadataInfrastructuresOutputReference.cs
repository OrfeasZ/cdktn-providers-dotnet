using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infrastructureName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsList\"}")]
        public virtual oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsList Metrics
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructuresMetricsList>()!;
        }

        [JsiiProperty(name: "numberOfDbSystems", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfDbSystems
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rackSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RackSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageServerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageServerCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementExadataInfrastructureFleetMetric.DataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructures\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.IDataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructures? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementExadataInfrastructureFleetMetric.IDataOciDatabaseManagementExadataInfrastructureFleetMetricFleetExadataInfrastructures?>();
            set => SetInstanceProperty(value);
        }
    }
}

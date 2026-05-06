using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataflowSqlEndpoints
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "driverShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DriverShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsDriverShapeConfigList\"}")]
        public virtual oci.DataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsDriverShapeConfigList DriverShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsDriverShapeConfigList>()!;
        }

        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutorShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsExecutorShapeConfigList\"}")]
        public virtual oci.DataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsExecutorShapeConfigList ExecutorShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsExecutorShapeConfigList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jdbcEndpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JdbcEndpointUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lakeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LakeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxExecutorCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxExecutorCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetastoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minExecutorCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinExecutorCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"oci.dataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsNetworkConfigurationList\"}")]
        public virtual oci.DataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<oci.DataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItemsNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "sparkAdvancedConfigurations", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SparkAdvancedConfigurations
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "sqlEndpointVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlEndpointVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarehouseBucketUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataflowSqlEndpoints.DataOciDataflowSqlEndpointsSqlEndpointCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataflowSqlEndpoints.IDataOciDataflowSqlEndpointsSqlEndpointCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataflowSqlEndpoints.IDataOciDataflowSqlEndpointsSqlEndpointCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}

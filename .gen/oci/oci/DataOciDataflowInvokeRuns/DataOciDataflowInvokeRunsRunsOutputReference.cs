using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataflowInvokeRuns
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsOutputReference), fullyQualifiedName: "oci.dataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataflowInvokeRunsRunsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataflowInvokeRunsRunsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataflowInvokeRunsRunsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataflowInvokeRunsRunsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationLogConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsApplicationLogConfigList\"}")]
        public virtual oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsApplicationLogConfigList ApplicationLogConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsApplicationLogConfigList>()!;
        }

        [JsiiProperty(name: "archiveUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArchiveUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arguments", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Arguments
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "asynchronous", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Asynchronous
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "className", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClassName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Configuration
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "dataReadInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataReadInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataWrittenInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataWrittenInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsDriverShapeConfigList\"}")]
        public virtual oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsDriverShapeConfigList DriverShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsDriverShapeConfigList>()!;
        }

        [JsiiProperty(name: "execute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Execute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executorShape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutorShape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsExecutorShapeConfigList\"}")]
        public virtual oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsExecutorShapeConfigList ExecutorShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsExecutorShapeConfigList>()!;
        }

        [JsiiProperty(name: "fileUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileUri
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdleTimeoutInMinutes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Language
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logsBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogsBucketUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxDurationInMinutes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxDurationInMinutes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metastoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetastoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numExecutors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumExecutors
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcParentRptUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "opcRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerPrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerPrincipalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsParametersList\"}")]
        public virtual oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsParametersList Parameters
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRunsParametersList>()!;
        }

        [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointDnsZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateEndpointDnsZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointMaxHostCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrivateEndpointMaxHostCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "privateEndpointNsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateEndpointNsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "privateEndpointSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runDurationInMilliseconds", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunDurationInMilliseconds
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sparkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SparkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "totalOcpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalOcpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warehouseBucketUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WarehouseBucketUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRuns.DataOciDataflowInvokeRunsRuns\"}", isOptional: true)]
        public virtual oci.DataOciDataflowInvokeRuns.IDataOciDataflowInvokeRunsRuns? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRuns.IDataOciDataflowInvokeRunsRuns?>();
            set => SetInstanceProperty(value);
        }
    }
}

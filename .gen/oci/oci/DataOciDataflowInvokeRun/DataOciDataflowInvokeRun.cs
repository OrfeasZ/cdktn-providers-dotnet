using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataflowInvokeRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dataflow_invoke_run oci_dataflow_invoke_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRun), fullyQualifiedName: "oci.dataOciDataflowInvokeRun.DataOciDataflowInvokeRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataflowInvokeRun.DataOciDataflowInvokeRunConfig\"}}]")]
    public class DataOciDataflowInvokeRun : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dataflow_invoke_run oci_dataflow_invoke_run} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataflowInvokeRun(Constructs.Construct scope, string id, oci.DataOciDataflowInvokeRun.IDataOciDataflowInvokeRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataflowInvokeRun.IDataOciDataflowInvokeRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataflowInvokeRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataflowInvokeRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataflowInvokeRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataflowInvokeRun to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataflowInvokeRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataflowInvokeRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataflowInvokeRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/dataflow_invoke_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataflowInvokeRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataflowInvokeRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRun))!;

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationLogConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRun.DataOciDataflowInvokeRunApplicationLogConfigList\"}")]
        public virtual oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunApplicationLogConfigList ApplicationLogConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunApplicationLogConfigList>()!;
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

        [JsiiProperty(name: "driverShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRun.DataOciDataflowInvokeRunDriverShapeConfigList\"}")]
        public virtual oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunDriverShapeConfigList DriverShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunDriverShapeConfigList>()!;
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

        [JsiiProperty(name: "executorShapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRun.DataOciDataflowInvokeRunExecutorShapeConfigList\"}")]
        public virtual oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunExecutorShapeConfigList ExecutorShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunExecutorShapeConfigList>()!;
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

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"oci.dataOciDataflowInvokeRun.DataOciDataflowInvokeRunParametersList\"}")]
        public virtual oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunParametersList Parameters
        {
            get => GetInstanceProperty<oci.DataOciDataflowInvokeRun.DataOciDataflowInvokeRunParametersList>()!;
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
        [JsiiProperty(name: "runIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "runId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

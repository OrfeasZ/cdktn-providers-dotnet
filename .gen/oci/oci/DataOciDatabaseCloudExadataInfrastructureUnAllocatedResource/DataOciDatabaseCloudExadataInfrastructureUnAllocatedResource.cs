using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_cloud_exadata_infrastructure_un_allocated_resource oci_database_cloud_exadata_infrastructure_un_allocated_resource}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource), fullyQualifiedName: "oci.dataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResourceConfig\"}}]")]
    public class DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_cloud_exadata_infrastructure_un_allocated_resource oci_database_cloud_exadata_infrastructure_un_allocated_resource} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource(Constructs.Construct scope, string id, oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.IDataOciDatabaseCloudExadataInfrastructureUnAllocatedResourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.IDataOciDatabaseCloudExadataInfrastructureUnAllocatedResourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_cloud_exadata_infrastructure_un_allocated_resource#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetDbServers")]
        public virtual void ResetDbServers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource))!;

        [JsiiProperty(name: "cloudAutonomousVmClusters", typeJson: "{\"fqn\":\"oci.dataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResourceCloudAutonomousVmClustersList\"}")]
        public virtual oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResourceCloudAutonomousVmClustersList CloudAutonomousVmClusters
        {
            get => GetInstanceProperty<oci.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResource.DataOciDatabaseCloudExadataInfrastructureUnAllocatedResourceCloudAutonomousVmClustersList>()!;
        }

        [JsiiProperty(name: "cloudExadataInfrastructureDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataStorageInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExadataStorageInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "localStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudExadataInfrastructureIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudExadataInfrastructureIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DbServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

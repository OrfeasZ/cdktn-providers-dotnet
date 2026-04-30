using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOdbCloudExadataInfrastructure
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/odb_cloud_exadata_infrastructure aws_odb_cloud_exadata_infrastructure}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructure), fullyQualifiedName: "aws.dataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructure", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructureConfig\"}}]")]
    public class DataAwsOdbCloudExadataInfrastructure : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/odb_cloud_exadata_infrastructure aws_odb_cloud_exadata_infrastructure} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsOdbCloudExadataInfrastructure(Constructs.Construct scope, string id, aws.DataAwsOdbCloudExadataInfrastructure.IDataAwsOdbCloudExadataInfrastructureConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsOdbCloudExadataInfrastructure.IDataAwsOdbCloudExadataInfrastructureConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbCloudExadataInfrastructure(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbCloudExadataInfrastructure(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsOdbCloudExadataInfrastructure resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsOdbCloudExadataInfrastructure to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsOdbCloudExadataInfrastructure that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsOdbCloudExadataInfrastructure to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsOdbCloudExadataInfrastructure to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/odb_cloud_exadata_infrastructure#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsOdbCloudExadataInfrastructure that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsOdbCloudExadataInfrastructure to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructure), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructure))!;

        [JsiiProperty(name: "activatedStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActivatedStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "additionalStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availableStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerContactsToSendToOci", typeJson: "{\"fqn\":\"aws.dataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructureCustomerContactsToSendToOciList\"}")]
        public virtual aws.DataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructureCustomerContactsToSendToOciList CustomerContactsToSendToOci
        {
            get => GetInstanceProperty<aws.DataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructureCustomerContactsToSendToOciList>()!;
        }

        [JsiiProperty(name: "databaseServerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseServerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbNodeStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DbNodeStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"aws.dataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructureMaintenanceWindowList\"}")]
        public virtual aws.DataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructureMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<aws.DataAwsOdbCloudExadataInfrastructure.DataAwsOdbCloudExadataInfrastructureMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maxCpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxDataStorageInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDataStorageInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxDbNodeStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDbNodeStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxMemoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxMemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "monthlyDbServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlyDbServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monthlyStorageServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlyStorageServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociResourceAnchorName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciResourceAnchorName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ociUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "percentProgress", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentProgress
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageServerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageServerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "totalStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

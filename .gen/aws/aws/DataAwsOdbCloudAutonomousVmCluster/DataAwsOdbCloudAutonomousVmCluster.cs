using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsOdbCloudAutonomousVmCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/odb_cloud_autonomous_vm_cluster aws_odb_cloud_autonomous_vm_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmCluster), fullyQualifiedName: "aws.dataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterConfig\"}}]")]
    public class DataAwsOdbCloudAutonomousVmCluster : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/odb_cloud_autonomous_vm_cluster aws_odb_cloud_autonomous_vm_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsOdbCloudAutonomousVmCluster(Constructs.Construct scope, string id, aws.DataAwsOdbCloudAutonomousVmCluster.IDataAwsOdbCloudAutonomousVmClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsOdbCloudAutonomousVmCluster.IDataAwsOdbCloudAutonomousVmClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbCloudAutonomousVmCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOdbCloudAutonomousVmCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsOdbCloudAutonomousVmCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsOdbCloudAutonomousVmCluster to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsOdbCloudAutonomousVmCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsOdbCloudAutonomousVmCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsOdbCloudAutonomousVmCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/odb_cloud_autonomous_vm_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsOdbCloudAutonomousVmCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsOdbCloudAutonomousVmCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousDataStoragePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutonomousDataStoragePercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "autonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutonomousDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableAutonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableAutonomousDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cloudExadataInfrastructureArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCountPerNode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbServers
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exadataStorageInTbsLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExadataStorageInTbsLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isMtlsEnabledVmCluster", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMtlsEnabledVmCluster
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"aws.dataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowList\"}")]
        public virtual aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<aws.DataAwsOdbCloudAutonomousVmCluster.DataAwsOdbCloudAutonomousVmClusterMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maxAcdsLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAcdsLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryPerOracleComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerOracleComputeUnitInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nonProvisionableAutonomousContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NonProvisionableAutonomousContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "odbNetworkArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OdbNetworkArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "odbNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OdbNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "odbNodeStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OdbNodeStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "percentProgress", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PercentProgress
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionableAutonomousContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionableAutonomousContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionedAutonomousContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedAutonomousContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reclaimableCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReclaimableCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "reservedCpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReservedCpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanListenerPortNonTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortNonTls
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scanListenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortTls
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeDatabaseSslCertificateExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeDatabaseSslCertificateExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeOrdsCertificateExpires", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeOrdsCertificateExpires
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalContainerDatabases
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

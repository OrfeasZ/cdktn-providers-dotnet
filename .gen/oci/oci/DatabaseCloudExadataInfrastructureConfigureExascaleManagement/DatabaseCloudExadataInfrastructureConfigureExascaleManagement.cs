using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management oci_database_cloud_exadata_infrastructure_configure_exascale_management}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagement), fullyQualifiedName: "oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementConfig\"}}]")]
    public class DatabaseCloudExadataInfrastructureConfigureExascaleManagement : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management oci_database_cloud_exadata_infrastructure_configure_exascale_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseCloudExadataInfrastructureConfigureExascaleManagement(Constructs.Construct scope, string id, oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.IDatabaseCloudExadataInfrastructureConfigureExascaleManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.IDatabaseCloudExadataInfrastructureConfigureExascaleManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseCloudExadataInfrastructureConfigureExascaleManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseCloudExadataInfrastructureConfigureExascaleManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseCloudExadataInfrastructureConfigureExascaleManagement resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseCloudExadataInfrastructureConfigureExascaleManagement to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseCloudExadataInfrastructureConfigureExascaleManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseCloudExadataInfrastructureConfigureExascaleManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseCloudExadataInfrastructureConfigureExascaleManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure_configure_exascale_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseCloudExadataInfrastructureConfigureExascaleManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseCloudExadataInfrastructureConfigureExascaleManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.IDatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.IDatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagement))!;

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

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availableStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "clusterPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "customerContacts", typeJson: "{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementCustomerContactsList\"}")]
        public virtual oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementCustomerContactsList CustomerContacts
        {
            get => GetInstanceProperty<oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementCustomerContactsList>()!;
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

        [JsiiProperty(name: "definedFileSystemConfigurations", typeJson: "{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementDefinedFileSystemConfigurationsList\"}")]
        public virtual oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementDefinedFileSystemConfigurationsList DefinedFileSystemConfigurations
        {
            get => GetInstanceProperty<oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementDefinedFileSystemConfigurationsList>()!;
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

        [JsiiProperty(name: "exascaleConfig", typeJson: "{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementExascaleConfigList\"}")]
        public virtual oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementExascaleConfigList ExascaleConfig
        {
            get => GetInstanceProperty<oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementExascaleConfigList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "isSchedulingPolicyAssociated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSchedulingPolicyAssociated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementMaintenanceWindowList\"}")]
        public virtual oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementMaintenanceWindowList>()!;
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

        [JsiiProperty(name: "maxDbNodeStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDbNodeStorageInGbs
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

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storageServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalStorageSizeInGbs
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseCloudExadataInfrastructureConfigureExascaleManagement.DatabaseCloudExadataInfrastructureConfigureExascaleManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalStorageInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalStorageInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cloudExadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}

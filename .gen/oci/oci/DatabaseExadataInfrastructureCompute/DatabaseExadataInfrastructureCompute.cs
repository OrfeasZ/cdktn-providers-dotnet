using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructureCompute
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_compute oci_database_exadata_infrastructure_compute}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureCompute), fullyQualifiedName: "oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureCompute", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeConfig\"}}]")]
    public class DatabaseExadataInfrastructureCompute : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_compute oci_database_exadata_infrastructure_compute} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseExadataInfrastructureCompute(Constructs.Construct scope, string id, oci.DatabaseExadataInfrastructureCompute.IDatabaseExadataInfrastructureComputeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseExadataInfrastructureCompute.IDatabaseExadataInfrastructureComputeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExadataInfrastructureCompute(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExadataInfrastructureCompute(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseExadataInfrastructureCompute resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseExadataInfrastructureCompute to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseExadataInfrastructureCompute that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseExadataInfrastructureCompute to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseExadataInfrastructureCompute to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure_compute#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseExadataInfrastructureCompute that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseExadataInfrastructureCompute to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureCompute), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseExadataInfrastructureCompute.IDatabaseExadataInfrastructureComputeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseExadataInfrastructureCompute.IDatabaseExadataInfrastructureComputeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivationFile")]
        public virtual void ResetActivationFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdditionalComputeCountComputeManagedResource")]
        public virtual void ResetAdditionalComputeCountComputeManagedResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdditionalComputeSystemModelComputeManagedResource")]
        public virtual void ResetAdditionalComputeSystemModelComputeManagedResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureCompute))!;

        [JsiiProperty(name: "activatedStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActivatedStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "additionalComputeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalComputeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "additionalComputeSystemModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalComputeSystemModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "additionalStorageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalStorageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "adminNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminNetworkCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer2
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

        [JsiiProperty(name: "contacts", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeContactsList\"}")]
        public virtual oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeContactsList Contacts
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeContactsList>()!;
        }

        [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CorporateProxy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpusEnabled
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createAsync", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CreateAsync
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "csiNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsiNumber
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

        [JsiiProperty(name: "dnsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServer
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gateway
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "infiniBandNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfiniBandNetworkCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCpsOfflineReportEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCpsOfflineReportEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceSloStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceSloStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowList\"}")]
        public virtual oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeMaintenanceWindowList>()!;
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

        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Netmask
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ntpServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NtpServer
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activationFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActivationFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalComputeCountComputeManagedResourceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AdditionalComputeCountComputeManagedResourceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalComputeSystemModelComputeManagedResourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdditionalComputeSystemModelComputeManagedResourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exadataInfrastructureIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExadataInfrastructureIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseExadataInfrastructureCompute.DatabaseExadataInfrastructureComputeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "activationFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivationFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "additionalComputeCountComputeManagedResource", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalComputeCountComputeManagedResource
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "additionalComputeSystemModelComputeManagedResource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalComputeSystemModelComputeManagedResource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "exadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInfrastructureId
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
    }
}

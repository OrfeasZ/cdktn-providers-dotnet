using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster oci_database_autonomous_vm_cluster}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmCluster), fullyQualifiedName: "oci.databaseAutonomousVmCluster.DatabaseAutonomousVmCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterConfig\"}}]")]
    public class DatabaseAutonomousVmCluster : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster oci_database_autonomous_vm_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseAutonomousVmCluster(Constructs.Construct scope, string id, oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousVmCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseAutonomousVmCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseAutonomousVmCluster resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseAutonomousVmCluster to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseAutonomousVmCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseAutonomousVmCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseAutonomousVmCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseAutonomousVmCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseAutonomousVmCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMaintenanceWindowDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMaintenanceWindowDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterMaintenanceWindowDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterMaintenanceWindowDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterMaintenanceWindowDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutonomousDataStorageSizeInTbs")]
        public virtual void ResetAutonomousDataStorageSizeInTbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeModel")]
        public virtual void ResetComputeModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuCoreCountPerNode")]
        public virtual void ResetCpuCoreCountPerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDbServers")]
        public virtual void ResetDbServers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsLocalBackupEnabled")]
        public virtual void ResetIsLocalBackupEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsMtlsEnabled")]
        public virtual void ResetIsMtlsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseModel")]
        public virtual void ResetLicenseModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindowDetails")]
        public virtual void ResetMaintenanceWindowDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryPerOracleComputeUnitInGbs")]
        public virtual void ResetMemoryPerOracleComputeUnitInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanListenerPortNonTls")]
        public virtual void ResetScanListenerPortNonTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanListenerPortTls")]
        public virtual void ResetScanListenerPortTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeZone")]
        public virtual void ResetTimeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalContainerDatabases")]
        public virtual void ResetTotalContainerDatabases()
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
        = GetStaticProperty<string>(typeof(oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmCluster))!;

        [JsiiProperty(name: "autonomousDataStoragePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutonomousDataStoragePercentage
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

        [JsiiProperty(name: "availableDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailableDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpuPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpusEnabled
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cpusLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpusLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "exadataStorageInTbsLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExadataStorageInTbsLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowList\"}")]
        public virtual oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "maintenanceWindowDetails", typeJson: "{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowDetailsList\"}")]
        public virtual oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowDetailsList MaintenanceWindowDetails
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowDetailsList>()!;
        }

        [JsiiProperty(name: "maxAcdsLowestScaledValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAcdsLowestScaledValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryPerComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerComputeUnitInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nextMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "ocpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpusEnabled
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

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseAutonomousVmCluster.DatabaseAutonomousVmClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalAutonomousDataStorageInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalAutonomousDataStorageInTbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autonomousDataStorageSizeInTbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AutonomousDataStorageSizeInTbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuCoreCountPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuCoreCountPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DbServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isLocalBackupEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsLocalBackupEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isMtlsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsMtlsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MaintenanceWindowDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryPerOracleComputeUnitInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryPerOracleComputeUnitInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanListenerPortNonTlsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScanListenerPortNonTlsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanListenerPortTlsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScanListenerPortTlsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalContainerDatabasesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalContainerDatabasesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmClusterNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autonomousDataStorageSizeInTbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AutonomousDataStorageSizeInTbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuCoreCountPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCountPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dbServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isLocalBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsLocalBackupEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "isMtlsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsMtlsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryPerOracleComputeUnitInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryPerOracleComputeUnitInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanListenerPortNonTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortNonTls
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanListenerPortTls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScanListenerPortTls
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalContainerDatabases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalContainerDatabases
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmClusterNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

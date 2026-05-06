using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmClusterAddVirtualMachine
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine oci_database_vm_cluster_add_virtual_machine}.</summary>
    [JsiiClass(nativeType: typeof(oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachine), fullyQualifiedName: "oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineConfig\"}}]")]
    public class DatabaseVmClusterAddVirtualMachine : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine oci_database_vm_cluster_add_virtual_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatabaseVmClusterAddVirtualMachine(Constructs.Construct scope, string id, oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseVmClusterAddVirtualMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseVmClusterAddVirtualMachine(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DatabaseVmClusterAddVirtualMachine resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatabaseVmClusterAddVirtualMachine to import.</param>
        /// <param name="importFromId">The id of the existing DatabaseVmClusterAddVirtualMachine that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatabaseVmClusterAddVirtualMachine to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatabaseVmClusterAddVirtualMachine to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster_add_virtual_machine#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatabaseVmClusterAddVirtualMachine that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatabaseVmClusterAddVirtualMachine to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachine), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDbServers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDbServers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDbServers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineDbServers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineDbServers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineDbServers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseVmClusterAddVirtualMachine.IDatabaseVmClusterAddVirtualMachineTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachine))!;

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudAutomationUpdateDetails", typeJson: "{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineCloudAutomationUpdateDetailsList\"}")]
        public virtual oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineCloudAutomationUpdateDetailsList CloudAutomationUpdateDetails
        {
            get => GetInstanceProperty<oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineCloudAutomationUpdateDetailsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpusEnabled
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataCollectionOptions", typeJson: "{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDataCollectionOptionsList\"}")]
        public virtual oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDataCollectionOptionsList DataCollectionOptions
        {
            get => GetInstanceProperty<oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDataCollectionOptionsList>()!;
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

        [JsiiProperty(name: "dbServers", typeJson: "{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDbServersList\"}")]
        public virtual oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDbServersList DbServers
        {
            get => GetInstanceProperty<oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDbServersList>()!;
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

        [JsiiProperty(name: "exadataInfrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExadataInfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exascaleDbStorageVaultId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExascaleDbStorageVaultId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemConfigurationDetails", typeJson: "{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineFileSystemConfigurationDetailsList\"}")]
        public virtual oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineFileSystemConfigurationDetailsList FileSystemConfigurationDetails
        {
            get => GetInstanceProperty<oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineFileSystemConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "giVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GiVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isLocalBackupEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLocalBackupEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSparseDiskgroupEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSparseDiskgroupEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastPatchHistoryEntryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastPatchHistoryEntryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memorySizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpusEnabled", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpusEnabled
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sshPublicKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SshPublicKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageManagementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageManagementType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineTimeoutsOutputReference\"}")]
        public virtual oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DatabaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmClusterNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterNetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmClusterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbServersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineDbServers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DbServersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.databaseVmClusterAddVirtualMachine.DatabaseVmClusterAddVirtualMachineTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

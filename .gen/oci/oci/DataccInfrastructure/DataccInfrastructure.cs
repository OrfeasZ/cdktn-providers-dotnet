using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataccInfrastructure
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datacc_infrastructure oci_datacc_infrastructure}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataccInfrastructure.DataccInfrastructure), fullyQualifiedName: "oci.dataccInfrastructure.DataccInfrastructure", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureConfig\"}}]")]
    public class DataccInfrastructure : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datacc_infrastructure oci_datacc_infrastructure} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataccInfrastructure(Constructs.Construct scope, string id, oci.DataccInfrastructure.IDataccInfrastructureConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataccInfrastructure.IDataccInfrastructureConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataccInfrastructure(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataccInfrastructure(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataccInfrastructure resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataccInfrastructure to import.</param>
        /// <param name="importFromId">The id of the existing DataccInfrastructure that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataccInfrastructure to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataccInfrastructure to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datacc_infrastructure#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataccInfrastructure that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataccInfrastructure to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataccInfrastructure.DataccInfrastructure), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccInfrastructure.IDataccInfrastructureContacts" />)[]</param>
        [JsiiMethod(name: "putContacts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureContacts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContacts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataccInfrastructure.IDataccInfrastructureContacts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccInfrastructure.IDataccInfrastructureContacts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataccInfrastructure.IDataccInfrastructureContacts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureMaintenanceWindow\"}}]")]
        public virtual void PutMaintenanceWindow(oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.DataccInfrastructure.IDataccInfrastructureTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DataccInfrastructure.IDataccInfrastructureTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcfsFileSystemStorageInGbs")]
        public virtual void ResetAcfsFileSystemStorageInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminNetworkcidr")]
        public virtual void ResetAdminNetworkcidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupNetworkBondingInterface")]
        public virtual void ResetBackupNetworkBondingInterface()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupNetworkBondingMode")]
        public virtual void ResetBackupNetworkBondingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientNetworkBondingInterface")]
        public virtual void ResetClientNetworkBondingInterface()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientNetworkBondingMode")]
        public virtual void ResetClientNetworkBondingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContacts")]
        public virtual void ResetContacts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorporateProxy")]
        public virtual void ResetCorporateProxy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpsNetworkBondingInterface")]
        public virtual void ResetCpsNetworkBondingInterface()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpsNetworkBondingMode")]
        public virtual void ResetCpsNetworkBondingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataDiskPercentage")]
        public virtual void ResetDataDiskPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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

        [JsiiMethod(name: "resetMaintenanceWindow")]
        public virtual void ResetMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleStorageTrigger")]
        public virtual void ResetScaleStorageTrigger()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVlanId")]
        public virtual void ResetVlanId()
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
        = GetStaticProperty<string>(typeof(oci.DataccInfrastructure.DataccInfrastructure))!;

        [JsiiProperty(name: "acfsFileSystemUsedStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcfsFileSystemUsedStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "computeCapacity", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureComputeCapacityList\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureComputeCapacityList ComputeCapacity
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureComputeCapacityList>()!;
        }

        [JsiiProperty(name: "contacts", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureContactsList\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureContactsList Contacts
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureContactsList>()!;
        }

        [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureMaintenanceWindowOutputReference\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureMaintenanceWindowOutputReference MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureMaintenanceWindowOutputReference>()!;
        }

        [JsiiProperty(name: "networkAdapterConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAdapterConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rackSerialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RackSerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recoDiskPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoDiskPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "servers", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureServersList\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureServersList Servers
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureServersList>()!;
        }

        [JsiiProperty(name: "ssdConfigurationRequested", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SsdConfigurationRequested
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageCapacity", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureStorageCapacityList\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureStorageCapacityList StorageCapacity
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureStorageCapacityList>()!;
        }

        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionPlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemStorageCapacity", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureSystemStorageCapacityList\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureSystemStorageCapacityList SystemStorageCapacity
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureSystemStorageCapacityList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeActivated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeActivated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastStateUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastStateUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureTimeoutsOutputReference\"}")]
        public virtual oci.DataccInfrastructure.DataccInfrastructureTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.DataccInfrastructureTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acfsFileSystemStorageInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AcfsFileSystemStorageInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminNetworkcidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminNetworkcidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkBondingInterfaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupNetworkBondingInterfaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkBondingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupNetworkBondingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientNetworkBondingInterfaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientNetworkBondingInterfaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientNetworkBondingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientNetworkBondingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudControlPlaneServer1Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudControlPlaneServer1Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudControlPlaneServer2Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudControlPlaneServer2Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataccInfrastructure.IDataccInfrastructureContacts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contactsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureContacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContactsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corporateProxyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CorporateProxyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpsNetworkBondingInterfaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpsNetworkBondingInterfaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpsNetworkBondingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpsNetworkBondingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataDiskPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataDiskPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DnsServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayInput
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
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureMaintenanceWindow\"}", isOptional: true)]
        public virtual oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow? MaintenanceWindowInput
        {
            get => GetInstanceProperty<oci.DataccInfrastructure.IDataccInfrastructureMaintenanceWindow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "netmaskInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetmaskInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ntpServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NtpServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleStorageTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScaleStorageTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "systemModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SystemModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DataccInfrastructure.IDataccInfrastructureTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dataccInfrastructure.DataccInfrastructureTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acfsFileSystemStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcfsFileSystemStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adminNetworkcidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminNetworkcidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer1
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer2
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CorporateProxy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpsNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpsNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpsNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpsNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataDiskPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataDiskPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gateway
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

        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Netmask
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ntpServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NtpServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleStorageTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScaleStorageTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "systemModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

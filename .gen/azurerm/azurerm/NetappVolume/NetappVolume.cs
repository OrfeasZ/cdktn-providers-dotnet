using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolume
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/netapp_volume azurerm_netapp_volume}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NetappVolume.NetappVolume), fullyQualifiedName: "azurerm.netappVolume.NetappVolume", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeConfig\"}}]")]
    public class NetappVolume : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/netapp_volume azurerm_netapp_volume} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetappVolume(Constructs.Construct scope, string id, azurerm.NetappVolume.INetappVolumeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NetappVolume.INetappVolumeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolume(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolume(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a NetappVolume resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetappVolume to import.</param>
        /// <param name="importFromId">The id of the existing NetappVolume that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetappVolume to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetappVolume to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/netapp_volume#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetappVolume that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetappVolume to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.NetappVolume.NetappVolume), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCoolAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeCoolAccess\"}}]")]
        public virtual void PutCoolAccess(azurerm.NetappVolume.INetappVolumeCoolAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolume.INetappVolumeCoolAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataProtectionAdvancedRansomware", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionAdvancedRansomware\"}}]")]
        public virtual void PutDataProtectionAdvancedRansomware(azurerm.NetappVolume.INetappVolumeDataProtectionAdvancedRansomware @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolume.INetappVolumeDataProtectionAdvancedRansomware)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataProtectionBackupPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionBackupPolicy\"}}]")]
        public virtual void PutDataProtectionBackupPolicy(azurerm.NetappVolume.INetappVolumeDataProtectionBackupPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolume.INetappVolumeDataProtectionBackupPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataProtectionReplication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionReplication\"}}]")]
        public virtual void PutDataProtectionReplication(azurerm.NetappVolume.INetappVolumeDataProtectionReplication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolume.INetappVolumeDataProtectionReplication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataProtectionSnapshotPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionSnapshotPolicy\"}}]")]
        public virtual void PutDataProtectionSnapshotPolicy(azurerm.NetappVolume.INetappVolumeDataProtectionSnapshotPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolume.INetappVolumeDataProtectionSnapshotPolicy)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetappVolume.INetappVolumeExportPolicyRule" />)[]</param>
        [JsiiMethod(name: "putExportPolicyRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExportPolicyRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.NetappVolume.INetappVolumeExportPolicyRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetappVolume.INetappVolumeExportPolicyRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.NetappVolume.INetappVolumeExportPolicyRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NetappVolume.INetappVolumeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappVolume.INetappVolumeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptGrowCapacityPoolForShortTermCloneSplit")]
        public virtual void ResetAcceptGrowCapacityPoolForShortTermCloneSplit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureVmwareDataStoreEnabled")]
        public virtual void ResetAzureVmwareDataStoreEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBreakthroughModeEnabled")]
        public virtual void ResetBreakthroughModeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoolAccess")]
        public virtual void ResetCoolAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateFromSnapshotResourceId")]
        public virtual void ResetCreateFromSnapshotResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataProtectionAdvancedRansomware")]
        public virtual void ResetDataProtectionAdvancedRansomware()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataProtectionBackupPolicy")]
        public virtual void ResetDataProtectionBackupPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataProtectionReplication")]
        public virtual void ResetDataProtectionReplication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataProtectionSnapshotPolicy")]
        public virtual void ResetDataProtectionSnapshotPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionKeySource")]
        public virtual void ResetEncryptionKeySource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExportPolicyRule")]
        public virtual void ResetExportPolicyRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosEnabled")]
        public virtual void ResetKerberosEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultPrivateEndpointId")]
        public virtual void ResetKeyVaultPrivateEndpointId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLargeVolumeEnabled")]
        public virtual void ResetLargeVolumeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkFeatures")]
        public virtual void ResetNetworkFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocols")]
        public virtual void ResetProtocols()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityStyle")]
        public virtual void ResetSecurityStyle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmb3ProtocolEncryptionEnabled")]
        public virtual void ResetSmb3ProtocolEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbAccessBasedEnumerationEnabled")]
        public virtual void ResetSmbAccessBasedEnumerationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbContinuousAvailabilityEnabled")]
        public virtual void ResetSmbContinuousAvailabilityEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbNonBrowsableEnabled")]
        public virtual void ResetSmbNonBrowsableEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotDirectoryVisible")]
        public virtual void ResetSnapshotDirectoryVisible()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThroughputInMibps")]
        public virtual void ResetThroughputInMibps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZone")]
        public virtual void ResetZone()
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
        = GetStaticProperty<string>(typeof(azurerm.NetappVolume.NetappVolume))!;

        [JsiiProperty(name: "coolAccess", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeCoolAccessOutputReference\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeCoolAccessOutputReference CoolAccess
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeCoolAccessOutputReference>()!;
        }

        [JsiiProperty(name: "dataProtectionAdvancedRansomware", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionAdvancedRansomwareOutputReference\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeDataProtectionAdvancedRansomwareOutputReference DataProtectionAdvancedRansomware
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeDataProtectionAdvancedRansomwareOutputReference>()!;
        }

        [JsiiProperty(name: "dataProtectionBackupPolicy", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionBackupPolicyOutputReference\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeDataProtectionBackupPolicyOutputReference DataProtectionBackupPolicy
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeDataProtectionBackupPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "dataProtectionReplication", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionReplicationOutputReference\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeDataProtectionReplicationOutputReference DataProtectionReplication
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeDataProtectionReplicationOutputReference>()!;
        }

        [JsiiProperty(name: "dataProtectionSnapshotPolicy", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionSnapshotPolicyOutputReference\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeDataProtectionSnapshotPolicyOutputReference DataProtectionSnapshotPolicy
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeDataProtectionSnapshotPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "exportPolicyRule", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeExportPolicyRuleList\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeExportPolicyRuleList ExportPolicyRule
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeExportPolicyRuleList>()!;
        }

        [JsiiProperty(name: "mountTarget", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeMountTargetList\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeMountTargetList MountTarget
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeMountTargetList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeTimeoutsOutputReference\"}")]
        public virtual azurerm.NetappVolume.NetappVolumeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NetappVolume.NetappVolumeTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptGrowCapacityPoolForShortTermCloneSplitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcceptGrowCapacityPoolForShortTermCloneSplitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureVmwareDataStoreEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AzureVmwareDataStoreEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "breakthroughModeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BreakthroughModeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coolAccessInput", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeCoolAccess\"}", isOptional: true)]
        public virtual azurerm.NetappVolume.INetappVolumeCoolAccess? CoolAccessInput
        {
            get => GetInstanceProperty<azurerm.NetappVolume.INetappVolumeCoolAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createFromSnapshotResourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateFromSnapshotResourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionAdvancedRansomwareInput", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionAdvancedRansomware\"}", isOptional: true)]
        public virtual azurerm.NetappVolume.INetappVolumeDataProtectionAdvancedRansomware? DataProtectionAdvancedRansomwareInput
        {
            get => GetInstanceProperty<azurerm.NetappVolume.INetappVolumeDataProtectionAdvancedRansomware?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionBackupPolicyInput", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionBackupPolicy\"}", isOptional: true)]
        public virtual azurerm.NetappVolume.INetappVolumeDataProtectionBackupPolicy? DataProtectionBackupPolicyInput
        {
            get => GetInstanceProperty<azurerm.NetappVolume.INetappVolumeDataProtectionBackupPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionReplicationInput", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionReplication\"}", isOptional: true)]
        public virtual azurerm.NetappVolume.INetappVolumeDataProtectionReplication? DataProtectionReplicationInput
        {
            get => GetInstanceProperty<azurerm.NetappVolume.INetappVolumeDataProtectionReplication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataProtectionSnapshotPolicyInput", typeJson: "{\"fqn\":\"azurerm.netappVolume.NetappVolumeDataProtectionSnapshotPolicy\"}", isOptional: true)]
        public virtual azurerm.NetappVolume.INetappVolumeDataProtectionSnapshotPolicy? DataProtectionSnapshotPolicyInput
        {
            get => GetInstanceProperty<azurerm.NetappVolume.INetappVolumeDataProtectionSnapshotPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeySourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionKeySourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.NetappVolume.INetappVolumeExportPolicyRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportPolicyRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.netappVolume.NetappVolumeExportPolicyRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExportPolicyRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kerberosEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? KerberosEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultPrivateEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyVaultPrivateEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "largeVolumeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LargeVolumeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkFeaturesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkFeaturesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ProtocolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityStyleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityStyleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smb3ProtocolEncryptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? Smb3ProtocolEncryptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smbAccessBasedEnumerationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SmbAccessBasedEnumerationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smbContinuousAvailabilityEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SmbContinuousAvailabilityEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smbNonBrowsableEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SmbNonBrowsableEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotDirectoryVisibleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SnapshotDirectoryVisibleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageQuotaInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageQuotaInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throughputInMibpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThroughputInMibpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.NetappVolume.INetappVolumeTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.netappVolume.NetappVolumeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acceptGrowCapacityPoolForShortTermCloneSplit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptGrowCapacityPoolForShortTermCloneSplit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "azureVmwareDataStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AzureVmwareDataStoreEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "breakthroughModeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object BreakthroughModeEnabled
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

        [JsiiProperty(name: "createFromSnapshotResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateFromSnapshotResourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionKeySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKeySource
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "kerberosEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object KerberosEnabled
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

        [JsiiProperty(name: "keyVaultPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "largeVolumeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object LargeVolumeEnabled
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkFeatures", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFeatures
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocols
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStyle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "smb3ProtocolEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Smb3ProtocolEncryptionEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "smbAccessBasedEnumerationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SmbAccessBasedEnumerationEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "smbContinuousAvailabilityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SmbContinuousAvailabilityEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "smbNonBrowsableEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SmbNonBrowsableEnabled
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

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "snapshotDirectoryVisible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SnapshotDirectoryVisible
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

        [JsiiProperty(name: "storageQuotaInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageQuotaInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "throughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThroughputInMibps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance scaleway_rdb_instance}.</summary>
    [JsiiClass(nativeType: typeof(scaleway.RdbInstance.RdbInstance), fullyQualifiedName: "scaleway.rdbInstance.RdbInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"scaleway.rdbInstance.RdbInstanceConfig\"}}]")]
    public class RdbInstance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance scaleway_rdb_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RdbInstance(Constructs.Construct scope, string id, scaleway.RdbInstance.IRdbInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, scaleway.RdbInstance.IRdbInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RdbInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RdbInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a RdbInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the RdbInstance to import.</param>
        /// <param name="importFromId">The id of the existing RdbInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the RdbInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the RdbInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing RdbInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the RdbInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(scaleway.RdbInstance.RdbInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLoadBalancer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLoadBalancer\"}}]")]
        public virtual void PutLoadBalancer(scaleway.RdbInstance.IRdbInstanceLoadBalancer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.RdbInstance.IRdbInstanceLoadBalancer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogsPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLogsPolicy\"}}]")]
        public virtual void PutLogsPolicy(scaleway.RdbInstance.IRdbInstanceLogsPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.RdbInstance.IRdbInstanceLogsPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateIp\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateIp(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case scaleway.RdbInstance.IRdbInstancePrivateIp[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.RdbInstance.IRdbInstancePrivateIp).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.RdbInstance.IRdbInstancePrivateIp).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateNetwork\"}}]")]
        public virtual void PutPrivateNetwork(scaleway.RdbInstance.IRdbInstancePrivateNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.RdbInstance.IRdbInstancePrivateNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.rdbInstance.RdbInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(scaleway.RdbInstance.IRdbInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.RdbInstance.IRdbInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupSameRegion")]
        public virtual void ResetBackupSameRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupScheduleFrequency")]
        public virtual void ResetBackupScheduleFrequency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupScheduleRetention")]
        public virtual void ResetBackupScheduleRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableBackup")]
        public virtual void ResetDisableBackup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionAtRest")]
        public virtual void ResetEncryptionAtRest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEngine")]
        public virtual void ResetEngine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitSettings")]
        public virtual void ResetInitSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsHaCluster")]
        public virtual void ResetIsHaCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancer")]
        public virtual void ResetLoadBalancer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogsPolicy")]
        public virtual void ResetLogsPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordWo")]
        public virtual void ResetPasswordWo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordWoVersion")]
        public virtual void ResetPasswordWoVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIp")]
        public virtual void ResetPrivateIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateNetwork")]
        public virtual void ResetPrivateNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectId")]
        public virtual void ResetProjectId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSettings")]
        public virtual void ResetSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotId")]
        public virtual void ResetSnapshotId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserName")]
        public virtual void ResetUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeSizeInGb")]
        public virtual void ResetVolumeSizeInGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeType")]
        public virtual void ResetVolumeType()
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
        = GetStaticProperty<string>(typeof(scaleway.RdbInstance.RdbInstance))!;

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EndpointPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLoadBalancerOutputReference\"}")]
        public virtual scaleway.RdbInstance.RdbInstanceLoadBalancerOutputReference LoadBalancer
        {
            get => GetInstanceProperty<scaleway.RdbInstance.RdbInstanceLoadBalancerOutputReference>()!;
        }

        [JsiiProperty(name: "logsPolicy", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLogsPolicyOutputReference\"}")]
        public virtual scaleway.RdbInstance.RdbInstanceLogsPolicyOutputReference LogsPolicy
        {
            get => GetInstanceProperty<scaleway.RdbInstance.RdbInstanceLogsPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateIpList\"}")]
        public virtual scaleway.RdbInstance.RdbInstancePrivateIpList PrivateIp
        {
            get => GetInstanceProperty<scaleway.RdbInstance.RdbInstancePrivateIpList>()!;
        }

        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateNetworkOutputReference\"}")]
        public virtual scaleway.RdbInstance.RdbInstancePrivateNetworkOutputReference PrivateNetwork
        {
            get => GetInstanceProperty<scaleway.RdbInstance.RdbInstancePrivateNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "readReplicas", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceReadReplicasList\"}")]
        public virtual scaleway.RdbInstance.RdbInstanceReadReplicasList ReadReplicas
        {
            get => GetInstanceProperty<scaleway.RdbInstance.RdbInstanceReadReplicasList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceTimeoutsOutputReference\"}")]
        public virtual scaleway.RdbInstance.RdbInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<scaleway.RdbInstance.RdbInstanceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "upgradableVersions", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceUpgradableVersionsList\"}")]
        public virtual scaleway.RdbInstance.RdbInstanceUpgradableVersionsList UpgradableVersions
        {
            get => GetInstanceProperty<scaleway.RdbInstance.RdbInstanceUpgradableVersionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupSameRegionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BackupSameRegionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupScheduleFrequencyInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackupScheduleFrequencyInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupScheduleRetentionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackupScheduleRetentionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableBackupInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableBackupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtRestInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptionAtRestInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineInput
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
        [JsiiProperty(name: "initSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? InitSettingsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isHaClusterInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsHaClusterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInput", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLoadBalancer\"}", isOptional: true)]
        public virtual scaleway.RdbInstance.IRdbInstanceLoadBalancer? LoadBalancerInput
        {
            get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstanceLoadBalancer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsPolicyInput", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstanceLogsPolicy\"}", isOptional: true)]
        public virtual scaleway.RdbInstance.IRdbInstanceLogsPolicy? LogsPolicyInput
        {
            get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstanceLogsPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordWoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordWoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordWoVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PasswordWoVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateIpInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateIp\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkInput", typeJson: "{\"fqn\":\"scaleway.rdbInstance.RdbInstancePrivateNetwork\"}", isOptional: true)]
        public virtual scaleway.RdbInstance.IRdbInstancePrivateNetwork? PrivateNetworkInput
        {
            get => GetInstanceProperty<scaleway.RdbInstance.IRdbInstancePrivateNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "settingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SettingsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.rdbInstance.RdbInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeSizeInGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VolumeSizeInGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupSameRegion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object BackupSameRegion
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

        [JsiiProperty(name: "backupScheduleFrequency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupScheduleFrequency
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupScheduleRetention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupScheduleRetention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DisableBackup
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

        [JsiiProperty(name: "encryptionAtRest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object EncryptionAtRest
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

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
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

        [JsiiProperty(name: "initSettings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> InitSettings
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isHaCluster", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsHaCluster
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordWo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "passwordWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PasswordWoVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
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

        [JsiiProperty(name: "settings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Settings
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSizeInGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxOntapVolume.FsxOntapVolumeConfig")]
    public class FsxOntapVolumeConfig : aws.FsxOntapVolume.IFsxOntapVolumeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#name FsxOntapVolume#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#storage_virtual_machine_id FsxOntapVolume#storage_virtual_machine_id}.</summary>
        [JsiiProperty(name: "storageVirtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageVirtualMachineId
        {
            get;
            set;
        }

        /// <summary>aggregate_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#aggregate_configuration FsxOntapVolume#aggregate_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aggregateConfiguration", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeAggregateConfiguration\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeAggregateConfiguration? AggregateConfiguration
        {
            get;
            set;
        }

        private object? _bypassSnaplockEnterpriseRetention;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#bypass_snaplock_enterprise_retention FsxOntapVolume#bypass_snaplock_enterprise_retention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bypassSnaplockEnterpriseRetention", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BypassSnaplockEnterpriseRetention
        {
            get => _bypassSnaplockEnterpriseRetention;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _bypassSnaplockEnterpriseRetention = value;
            }
        }

        private object? _copyTagsToBackups;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#copy_tags_to_backups FsxOntapVolume#copy_tags_to_backups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToBackups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CopyTagsToBackups
        {
            get => _copyTagsToBackups;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _copyTagsToBackups = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#final_backup_tags FsxOntapVolume#final_backup_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "finalBackupTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FinalBackupTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#id FsxOntapVolume#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#junction_path FsxOntapVolume#junction_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "junctionPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JunctionPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#ontap_volume_type FsxOntapVolume#ontap_volume_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ontapVolumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OntapVolumeType
        {
            get;
            set;
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#region FsxOntapVolume#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#security_style FsxOntapVolume#security_style}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityStyle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#size_in_bytes FsxOntapVolume#size_in_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizeInBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SizeInBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#size_in_megabytes FsxOntapVolume#size_in_megabytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sizeInMegabytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SizeInMegabytes
        {
            get;
            set;
        }

        private object? _skipFinalBackup;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#skip_final_backup FsxOntapVolume#skip_final_backup}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipFinalBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SkipFinalBackup
        {
            get => _skipFinalBackup;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _skipFinalBackup = value;
            }
        }

        /// <summary>snaplock_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#snaplock_configuration FsxOntapVolume#snaplock_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snaplockConfiguration", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfiguration\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfiguration? SnaplockConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#snapshot_policy FsxOntapVolume#snapshot_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotPolicy
        {
            get;
            set;
        }

        private object? _storageEfficiencyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#storage_efficiency_enabled FsxOntapVolume#storage_efficiency_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageEfficiencyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StorageEfficiencyEnabled
        {
            get => _storageEfficiencyEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storageEfficiencyEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#tags FsxOntapVolume#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#tags_all FsxOntapVolume#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        /// <summary>tiering_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#tiering_policy FsxOntapVolume#tiering_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tieringPolicy", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeTieringPolicy\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeTieringPolicy? TieringPolicy
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#timeouts FsxOntapVolume#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeTimeouts\"}", isOptional: true)]
        public aws.FsxOntapVolume.IFsxOntapVolumeTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#volume_style FsxOntapVolume#volume_style}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeStyle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeStyle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/fsx_ontap_volume#volume_type FsxOntapVolume#volume_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeType
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case Io.Cdktn.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.ISSHProvisionerConnection).FullName}, {typeof(Io.Cdktn.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case Io.Cdktn.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(Io.Cdktn.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public Io.Cdktn.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
        public Io.Cdktn.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
        public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
        public Io.Cdktn.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case Io.Cdktn.IFileProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case Io.Cdktn.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(Io.Cdktn.IFileProvisioner).FullName}, {typeof(Io.Cdktn.ILocalExecProvisioner).FullName}, {typeof(Io.Cdktn.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}

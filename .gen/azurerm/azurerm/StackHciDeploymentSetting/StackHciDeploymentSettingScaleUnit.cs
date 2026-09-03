using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciDeploymentSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnit")]
    public class StackHciDeploymentSettingScaleUnit : azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#active_directory_organizational_unit_path StackHciDeploymentSetting#active_directory_organizational_unit_path}.</summary>
        [JsiiProperty(name: "activeDirectoryOrganizationalUnitPath", typeJson: "{\"primitive\":\"string\"}")]
        public string ActiveDirectoryOrganizationalUnitPath
        {
            get;
            set;
        }

        /// <summary>cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#cluster StackHciDeploymentSetting#cluster}
        /// </remarks>
        [JsiiProperty(name: "cluster", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitCluster\"}")]
        public azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitCluster Cluster
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#domain_fqdn StackHciDeploymentSetting#domain_fqdn}.</summary>
        [JsiiProperty(name: "domainFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainFqdn
        {
            get;
            set;
        }

        /// <summary>host_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#host_network StackHciDeploymentSetting#host_network}
        /// </remarks>
        [JsiiProperty(name: "hostNetwork", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitHostNetwork\"}")]
        public azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitHostNetwork HostNetwork
        {
            get;
            set;
        }

        private object _infrastructureNetwork;

        /// <summary>infrastructure_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#infrastructure_network StackHciDeploymentSetting#infrastructure_network}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetwork" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "infrastructureNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitInfrastructureNetwork\"},\"kind\":\"array\"}}]}}")]
        public object InfrastructureNetwork
        {
            get => _infrastructureNetwork;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetwork[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetwork).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitInfrastructureNetwork).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _infrastructureNetwork = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#name_prefix StackHciDeploymentSetting#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string NamePrefix
        {
            get;
            set;
        }

        /// <summary>optional_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#optional_service StackHciDeploymentSetting#optional_service}
        /// </remarks>
        [JsiiProperty(name: "optionalService", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitOptionalService\"}")]
        public azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitOptionalService OptionalService
        {
            get;
            set;
        }

        private object _physicalNode;

        /// <summary>physical_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#physical_node StackHciDeploymentSetting#physical_node}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitPhysicalNode" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "physicalNode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitPhysicalNode\"},\"kind\":\"array\"}}]}}")]
        public object PhysicalNode
        {
            get => _physicalNode;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitPhysicalNode[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitPhysicalNode).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitPhysicalNode).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _physicalNode = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#secrets_location StackHciDeploymentSetting#secrets_location}.</summary>
        [JsiiProperty(name: "secretsLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretsLocation
        {
            get;
            set;
        }

        /// <summary>storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#storage StackHciDeploymentSetting#storage}
        /// </remarks>
        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"azurerm.stackHciDeploymentSetting.StackHciDeploymentSettingScaleUnitStorage\"}")]
        public azurerm.StackHciDeploymentSetting.IStackHciDeploymentSettingScaleUnitStorage Storage
        {
            get;
            set;
        }

        private object? _bitlockerBootVolumeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#bitlocker_boot_volume_enabled StackHciDeploymentSetting#bitlocker_boot_volume_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bitlockerBootVolumeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BitlockerBootVolumeEnabled
        {
            get => _bitlockerBootVolumeEnabled;
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
                _bitlockerBootVolumeEnabled = value;
            }
        }

        private object? _bitlockerDataVolumeEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#bitlocker_data_volume_enabled StackHciDeploymentSetting#bitlocker_data_volume_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bitlockerDataVolumeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? BitlockerDataVolumeEnabled
        {
            get => _bitlockerDataVolumeEnabled;
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
                _bitlockerDataVolumeEnabled = value;
            }
        }

        private object? _credentialGuardEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#credential_guard_enabled StackHciDeploymentSetting#credential_guard_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentialGuardEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CredentialGuardEnabled
        {
            get => _credentialGuardEnabled;
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
                _credentialGuardEnabled = value;
            }
        }

        private object? _driftControlEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#drift_control_enabled StackHciDeploymentSetting#drift_control_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driftControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DriftControlEnabled
        {
            get => _driftControlEnabled;
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
                _driftControlEnabled = value;
            }
        }

        private object? _drtmProtectionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#drtm_protection_enabled StackHciDeploymentSetting#drtm_protection_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "drtmProtectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DrtmProtectionEnabled
        {
            get => _drtmProtectionEnabled;
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
                _drtmProtectionEnabled = value;
            }
        }

        private object? _episodicDataUploadEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#episodic_data_upload_enabled StackHciDeploymentSetting#episodic_data_upload_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "episodicDataUploadEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EpisodicDataUploadEnabled
        {
            get => _episodicDataUploadEnabled;
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
                _episodicDataUploadEnabled = value;
            }
        }

        private object? _euLocationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#eu_location_enabled StackHciDeploymentSetting#eu_location_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "euLocationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EuLocationEnabled
        {
            get => _euLocationEnabled;
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
                _euLocationEnabled = value;
            }
        }

        private object? _hvciProtectionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#hvci_protection_enabled StackHciDeploymentSetting#hvci_protection_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hvciProtectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? HvciProtectionEnabled
        {
            get => _hvciProtectionEnabled;
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
                _hvciProtectionEnabled = value;
            }
        }

        private object? _sideChannelMitigationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#side_channel_mitigation_enabled StackHciDeploymentSetting#side_channel_mitigation_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sideChannelMitigationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SideChannelMitigationEnabled
        {
            get => _sideChannelMitigationEnabled;
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
                _sideChannelMitigationEnabled = value;
            }
        }

        private object? _smbClusterEncryptionEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#smb_cluster_encryption_enabled StackHciDeploymentSetting#smb_cluster_encryption_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smbClusterEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SmbClusterEncryptionEnabled
        {
            get => _smbClusterEncryptionEnabled;
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
                _smbClusterEncryptionEnabled = value;
            }
        }

        private object? _smbSigningEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#smb_signing_enabled StackHciDeploymentSetting#smb_signing_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smbSigningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SmbSigningEnabled
        {
            get => _smbSigningEnabled;
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
                _smbSigningEnabled = value;
            }
        }

        private object? _streamingDataClientEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#streaming_data_client_enabled StackHciDeploymentSetting#streaming_data_client_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streamingDataClientEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? StreamingDataClientEnabled
        {
            get => _streamingDataClientEnabled;
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
                _streamingDataClientEnabled = value;
            }
        }

        private object? _wdacEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/stack_hci_deployment_setting#wdac_enabled StackHciDeploymentSetting#wdac_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wdacEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? WdacEnabled
        {
            get => _wdacEnabled;
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
                _wdacEnabled = value;
            }
        }
    }
}

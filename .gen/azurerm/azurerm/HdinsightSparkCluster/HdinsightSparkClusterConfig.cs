using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterConfig")]
    public class HdinsightSparkClusterConfig : azurerm.HdinsightSparkCluster.IHdinsightSparkClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#cluster_version HdinsightSparkCluster#cluster_version}.</summary>
        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterVersion
        {
            get;
            set;
        }

        /// <summary>component_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#component_version HdinsightSparkCluster#component_version}
        /// </remarks>
        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterComponentVersion\"}")]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComponentVersion ComponentVersion
        {
            get;
            set;
        }

        /// <summary>gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#gateway HdinsightSparkCluster#gateway}
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterGateway\"}")]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterGateway Gateway
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#location HdinsightSparkCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#name HdinsightSparkCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#resource_group_name HdinsightSparkCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>roles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#roles HdinsightSparkCluster#roles}
        /// </remarks>
        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRoles\"}")]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRoles Roles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#tier HdinsightSparkCluster#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        public string Tier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#tls_min_version HdinsightSparkCluster#tls_min_version}.</summary>
        [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string TlsMinVersion
        {
            get;
            set;
        }

        /// <summary>compute_isolation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#compute_isolation HdinsightSparkCluster#compute_isolation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterComputeIsolation\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComputeIsolation? ComputeIsolation
        {
            get;
            set;
        }

        private object? _diskEncryption;

        /// <summary>disk_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#disk_encryption HdinsightSparkCluster#disk_encryption}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterDiskEncryption" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DiskEncryption
        {
            get => _diskEncryption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.HdinsightSparkCluster.IHdinsightSparkClusterDiskEncryption[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterDiskEncryption).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _diskEncryption = value;
            }
        }

        private object? _encryptionInTransitEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#encryption_in_transit_enabled HdinsightSparkCluster#encryption_in_transit_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EncryptionInTransitEnabled
        {
            get => _encryptionInTransitEnabled;
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
                _encryptionInTransitEnabled = value;
            }
        }

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#extension HdinsightSparkCluster#extension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterExtension\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterExtension? Extension
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#id HdinsightSparkCluster#id}.</summary>
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

        /// <summary>metastores block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#metastores HdinsightSparkCluster#metastores}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastores\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores? Metastores
        {
            get;
            set;
        }

        /// <summary>monitor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#monitor HdinsightSparkCluster#monitor}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMonitor\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMonitor? Monitor
        {
            get;
            set;
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#network HdinsightSparkCluster#network}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterNetwork\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterNetwork? Network
        {
            get;
            set;
        }

        /// <summary>private_link_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#private_link_configuration HdinsightSparkCluster#private_link_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterPrivateLinkConfiguration\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterPrivateLinkConfiguration? PrivateLinkConfiguration
        {
            get;
            set;
        }

        /// <summary>security_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#security_profile HdinsightSparkCluster#security_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterSecurityProfile\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterSecurityProfile? SecurityProfile
        {
            get;
            set;
        }

        private object? _storageAccount;

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#storage_account HdinsightSparkCluster#storage_account}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccount" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StorageAccount
        {
            get => _storageAccount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _storageAccount = value;
            }
        }

        /// <summary>storage_account_gen2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#storage_account_gen2 HdinsightSparkCluster#storage_account_gen2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterStorageAccountGen2\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccountGen2? StorageAccountGen2
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#tags HdinsightSparkCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#timeouts HdinsightSparkCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterTimeouts\"}", isOptional: true)]
        public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#zones HdinsightSparkCluster#zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Zones
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
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
        /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
        /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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

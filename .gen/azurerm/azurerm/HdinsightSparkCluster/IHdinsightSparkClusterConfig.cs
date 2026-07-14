using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightSparkClusterConfig), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterConfig")]
    public interface IHdinsightSparkClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#cluster_version HdinsightSparkCluster#cluster_version}.</summary>
        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterVersion
        {
            get;
        }

        /// <summary>component_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#component_version HdinsightSparkCluster#component_version}
        /// </remarks>
        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterComponentVersion\"}")]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComponentVersion ComponentVersion
        {
            get;
        }

        /// <summary>gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#gateway HdinsightSparkCluster#gateway}
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterGateway\"}")]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterGateway Gateway
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#location HdinsightSparkCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#name HdinsightSparkCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#resource_group_name HdinsightSparkCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>roles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#roles HdinsightSparkCluster#roles}
        /// </remarks>
        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRoles\"}")]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRoles Roles
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#tier HdinsightSparkCluster#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        string Tier
        {
            get;
        }

        /// <summary>compute_isolation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#compute_isolation HdinsightSparkCluster#compute_isolation}
        /// </remarks>
        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterComputeIsolation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComputeIsolation? ComputeIsolation
        {
            get
            {
                return null;
            }
        }

        /// <summary>disk_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#disk_encryption HdinsightSparkCluster#disk_encryption}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterDiskEncryption" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DiskEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#encryption_in_transit_enabled HdinsightSparkCluster#encryption_in_transit_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "encryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EncryptionInTransitEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>extension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#extension HdinsightSparkCluster#extension}
        /// </remarks>
        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterExtension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterExtension? Extension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#id HdinsightSparkCluster#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>metastores block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#metastores HdinsightSparkCluster#metastores}
        /// </remarks>
        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastores\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores? Metastores
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#monitor HdinsightSparkCluster#monitor}
        /// </remarks>
        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMonitor\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMonitor? Monitor
        {
            get
            {
                return null;
            }
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#network HdinsightSparkCluster#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_link_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#private_link_configuration HdinsightSparkCluster#private_link_configuration}
        /// </remarks>
        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterPrivateLinkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterPrivateLinkConfiguration? PrivateLinkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#security_profile HdinsightSparkCluster#security_profile}
        /// </remarks>
        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterSecurityProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterSecurityProfile? SecurityProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#storage_account HdinsightSparkCluster#storage_account}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StorageAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account_gen2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#storage_account_gen2 HdinsightSparkCluster#storage_account_gen2}
        /// </remarks>
        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterStorageAccountGen2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccountGen2? StorageAccountGen2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#tags HdinsightSparkCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#timeouts HdinsightSparkCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightSparkCluster.IHdinsightSparkClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#tls_min_version HdinsightSparkCluster#tls_min_version}.</summary>
        [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsMinVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#zones HdinsightSparkCluster#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightSparkClusterConfig), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightSparkCluster.IHdinsightSparkClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#cluster_version HdinsightSparkCluster#cluster_version}.</summary>
            [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>component_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#component_version HdinsightSparkCluster#component_version}
            /// </remarks>
            [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterComponentVersion\"}")]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComponentVersion ComponentVersion
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComponentVersion>()!;
            }

            /// <summary>gateway block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#gateway HdinsightSparkCluster#gateway}
            /// </remarks>
            [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterGateway\"}")]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterGateway Gateway
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterGateway>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#location HdinsightSparkCluster#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#name HdinsightSparkCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#resource_group_name HdinsightSparkCluster#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>roles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#roles HdinsightSparkCluster#roles}
            /// </remarks>
            [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterRoles\"}")]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRoles Roles
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterRoles>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#tier HdinsightSparkCluster#tier}.</summary>
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
            public string Tier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>compute_isolation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#compute_isolation HdinsightSparkCluster#compute_isolation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterComputeIsolation\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComputeIsolation? ComputeIsolation
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterComputeIsolation?>();
            }

            /// <summary>disk_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#disk_encryption HdinsightSparkCluster#disk_encryption}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterDiskEncryption" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DiskEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#encryption_in_transit_enabled HdinsightSparkCluster#encryption_in_transit_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInTransitEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EncryptionInTransitEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>extension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#extension HdinsightSparkCluster#extension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterExtension\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterExtension? Extension
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterExtension?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#id HdinsightSparkCluster#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metastores block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#metastores HdinsightSparkCluster#metastores}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMetastores\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores? Metastores
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMetastores?>();
            }

            /// <summary>monitor block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#monitor HdinsightSparkCluster#monitor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterMonitor\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMonitor? Monitor
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterMonitor?>();
            }

            /// <summary>network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#network HdinsightSparkCluster#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterNetwork\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterNetwork? Network
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterNetwork?>();
            }

            /// <summary>private_link_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#private_link_configuration HdinsightSparkCluster#private_link_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterPrivateLinkConfiguration\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterPrivateLinkConfiguration? PrivateLinkConfiguration
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterPrivateLinkConfiguration?>();
            }

            /// <summary>security_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#security_profile HdinsightSparkCluster#security_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterSecurityProfile\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterSecurityProfile? SecurityProfile
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterSecurityProfile?>();
            }

            /// <summary>storage_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#storage_account HdinsightSparkCluster#storage_account}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_account_gen2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#storage_account_gen2 HdinsightSparkCluster#storage_account_gen2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterStorageAccountGen2\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccountGen2? StorageAccountGen2
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterStorageAccountGen2?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#tags HdinsightSparkCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#timeouts HdinsightSparkCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightSparkCluster.HdinsightSparkClusterTimeouts\"}", isOptional: true)]
            public azurerm.HdinsightSparkCluster.IHdinsightSparkClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.HdinsightSparkCluster.IHdinsightSparkClusterTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#tls_min_version HdinsightSparkCluster#tls_min_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsMinVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/hdinsight_spark_cluster#zones HdinsightSparkCluster#zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Zones
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

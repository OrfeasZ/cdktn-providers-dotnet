using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightInteractiveQueryClusterConfig), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterConfig")]
    public interface IHdinsightInteractiveQueryClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#cluster_version HdinsightInteractiveQueryCluster#cluster_version}.</summary>
        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterVersion
        {
            get;
        }

        /// <summary>component_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#component_version HdinsightInteractiveQueryCluster#component_version}
        /// </remarks>
        [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersion\"}")]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion ComponentVersion
        {
            get;
        }

        /// <summary>gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#gateway HdinsightInteractiveQueryCluster#gateway}
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGateway\"}")]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterGateway Gateway
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#location HdinsightInteractiveQueryCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#name HdinsightInteractiveQueryCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#resource_group_name HdinsightInteractiveQueryCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>roles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#roles HdinsightInteractiveQueryCluster#roles}
        /// </remarks>
        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRoles\"}")]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRoles Roles
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#tier HdinsightInteractiveQueryCluster#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        string Tier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#tls_min_version HdinsightInteractiveQueryCluster#tls_min_version}.</summary>
        [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}")]
        string TlsMinVersion
        {
            get;
        }

        /// <summary>compute_isolation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#compute_isolation HdinsightInteractiveQueryCluster#compute_isolation}
        /// </remarks>
        [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComputeIsolation? ComputeIsolation
        {
            get
            {
                return null;
            }
        }

        /// <summary>disk_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#disk_encryption HdinsightInteractiveQueryCluster#disk_encryption}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterDiskEncryption" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DiskEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#encryption_in_transit_enabled HdinsightInteractiveQueryCluster#encryption_in_transit_enabled}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#extension HdinsightInteractiveQueryCluster#extension}
        /// </remarks>
        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterExtension? Extension
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#id HdinsightInteractiveQueryCluster#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#metastores HdinsightInteractiveQueryCluster#metastores}
        /// </remarks>
        [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores? Metastores
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#monitor HdinsightInteractiveQueryCluster#monitor}
        /// </remarks>
        [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitor\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMonitor? Monitor
        {
            get
            {
                return null;
            }
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#network HdinsightInteractiveQueryCluster#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_link_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#private_link_configuration HdinsightInteractiveQueryCluster#private_link_configuration}
        /// </remarks>
        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterPrivateLinkConfiguration? PrivateLinkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#security_profile HdinsightInteractiveQueryCluster#security_profile}
        /// </remarks>
        [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterSecurityProfile? SecurityProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#storage_account HdinsightInteractiveQueryCluster#storage_account}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccount" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#storage_account_gen2 HdinsightInteractiveQueryCluster#storage_account_gen2}
        /// </remarks>
        [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccountGen2? StorageAccountGen2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#tags HdinsightInteractiveQueryCluster#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#timeouts HdinsightInteractiveQueryCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightInteractiveQueryClusterConfig), fullyQualifiedName: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#cluster_version HdinsightInteractiveQueryCluster#cluster_version}.</summary>
            [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>component_version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#component_version HdinsightInteractiveQueryCluster#component_version}
            /// </remarks>
            [JsiiProperty(name: "componentVersion", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersion\"}")]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion ComponentVersion
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion>()!;
            }

            /// <summary>gateway block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#gateway HdinsightInteractiveQueryCluster#gateway}
            /// </remarks>
            [JsiiProperty(name: "gateway", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGateway\"}")]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterGateway Gateway
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterGateway>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#location HdinsightInteractiveQueryCluster#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#name HdinsightInteractiveQueryCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#resource_group_name HdinsightInteractiveQueryCluster#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>roles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#roles HdinsightInteractiveQueryCluster#roles}
            /// </remarks>
            [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRoles\"}")]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRoles Roles
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterRoles>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#tier HdinsightInteractiveQueryCluster#tier}.</summary>
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
            public string Tier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#tls_min_version HdinsightInteractiveQueryCluster#tls_min_version}.</summary>
            [JsiiProperty(name: "tlsMinVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string TlsMinVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>compute_isolation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#compute_isolation HdinsightInteractiveQueryCluster#compute_isolation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeIsolation", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolation\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComputeIsolation? ComputeIsolation
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComputeIsolation?>();
            }

            /// <summary>disk_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#disk_encryption HdinsightInteractiveQueryCluster#disk_encryption}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterDiskEncryption" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "diskEncryption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DiskEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#encryption_in_transit_enabled HdinsightInteractiveQueryCluster#encryption_in_transit_enabled}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#extension HdinsightInteractiveQueryCluster#extension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtension\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterExtension? Extension
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterExtension?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#id HdinsightInteractiveQueryCluster#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#metastores HdinsightInteractiveQueryCluster#metastores}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metastores", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores? Metastores
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMetastores?>();
            }

            /// <summary>monitor block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#monitor HdinsightInteractiveQueryCluster#monitor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitor", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitor\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMonitor? Monitor
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterMonitor?>();
            }

            /// <summary>network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#network HdinsightInteractiveQueryCluster#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetwork\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterNetwork? Network
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterNetwork?>();
            }

            /// <summary>private_link_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#private_link_configuration HdinsightInteractiveQueryCluster#private_link_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfiguration\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterPrivateLinkConfiguration? PrivateLinkConfiguration
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterPrivateLinkConfiguration?>();
            }

            /// <summary>security_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#security_profile HdinsightInteractiveQueryCluster#security_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityProfile", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfile\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterSecurityProfile? SecurityProfile
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterSecurityProfile?>();
            }

            /// <summary>storage_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#storage_account HdinsightInteractiveQueryCluster#storage_account}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccount" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StorageAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>storage_account_gen2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#storage_account_gen2 HdinsightInteractiveQueryCluster#storage_account_gen2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccountGen2", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccountGen2? StorageAccountGen2
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterStorageAccountGen2?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#tags HdinsightInteractiveQueryCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/hdinsight_interactive_query_cluster#timeouts HdinsightInteractiveQueryCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeouts\"}", isOptional: true)]
            public azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterTimeouts?>();
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

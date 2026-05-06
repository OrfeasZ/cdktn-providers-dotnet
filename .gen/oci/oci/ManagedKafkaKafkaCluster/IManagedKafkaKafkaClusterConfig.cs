using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IManagedKafkaKafkaClusterConfig), fullyQualifiedName: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterConfig")]
    public interface IManagedKafkaKafkaClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>access_subnets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#access_subnets ManagedKafkaKafkaCluster#access_subnets}
        /// </remarks>
        [JsiiProperty(name: "accessSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterAccessSubnets\"},\"kind\":\"array\"}}]}}")]
        object AccessSubnets
        {
            get;
        }

        /// <summary>broker_shape block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#broker_shape ManagedKafkaKafkaCluster#broker_shape}
        /// </remarks>
        [JsiiProperty(name: "brokerShape", typeJson: "{\"fqn\":\"oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterBrokerShape\"}")]
        oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterBrokerShape BrokerShape
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#cluster_config_id ManagedKafkaKafkaCluster#cluster_config_id}.</summary>
        [JsiiProperty(name: "clusterConfigId", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterConfigId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#cluster_config_version ManagedKafkaKafkaCluster#cluster_config_version}.</summary>
        [JsiiProperty(name: "clusterConfigVersion", typeJson: "{\"primitive\":\"number\"}")]
        double ClusterConfigVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#cluster_type ManagedKafkaKafkaCluster#cluster_type}.</summary>
        [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#compartment_id ManagedKafkaKafkaCluster#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#coordination_type ManagedKafkaKafkaCluster#coordination_type}.</summary>
        [JsiiProperty(name: "coordinationType", typeJson: "{\"primitive\":\"string\"}")]
        string CoordinationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#kafka_version ManagedKafkaKafkaCluster#kafka_version}.</summary>
        [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
        string KafkaVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#client_certificate_bundle ManagedKafkaKafkaCluster#client_certificate_bundle}.</summary>
        [JsiiProperty(name: "clientCertificateBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateBundle
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#defined_tags ManagedKafkaKafkaCluster#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#display_name ManagedKafkaKafkaCluster#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#freeform_tags ManagedKafkaKafkaCluster#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#id ManagedKafkaKafkaCluster#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#timeouts ManagedKafkaKafkaCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedKafkaKafkaClusterConfig), fullyQualifiedName: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_subnets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#access_subnets ManagedKafkaKafkaCluster#access_subnets}
            /// </remarks>
            [JsiiProperty(name: "accessSubnets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterAccessSubnets\"},\"kind\":\"array\"}}]}}")]
            public object AccessSubnets
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>broker_shape block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#broker_shape ManagedKafkaKafkaCluster#broker_shape}
            /// </remarks>
            [JsiiProperty(name: "brokerShape", typeJson: "{\"fqn\":\"oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterBrokerShape\"}")]
            public oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterBrokerShape BrokerShape
            {
                get => GetInstanceProperty<oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterBrokerShape>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#cluster_config_id ManagedKafkaKafkaCluster#cluster_config_id}.</summary>
            [JsiiProperty(name: "clusterConfigId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterConfigId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#cluster_config_version ManagedKafkaKafkaCluster#cluster_config_version}.</summary>
            [JsiiProperty(name: "clusterConfigVersion", typeJson: "{\"primitive\":\"number\"}")]
            public double ClusterConfigVersion
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#cluster_type ManagedKafkaKafkaCluster#cluster_type}.</summary>
            [JsiiProperty(name: "clusterType", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#compartment_id ManagedKafkaKafkaCluster#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#coordination_type ManagedKafkaKafkaCluster#coordination_type}.</summary>
            [JsiiProperty(name: "coordinationType", typeJson: "{\"primitive\":\"string\"}")]
            public string CoordinationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#kafka_version ManagedKafkaKafkaCluster#kafka_version}.</summary>
            [JsiiProperty(name: "kafkaVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string KafkaVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#client_certificate_bundle ManagedKafkaKafkaCluster#client_certificate_bundle}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateBundle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#defined_tags ManagedKafkaKafkaCluster#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#display_name ManagedKafkaKafkaCluster#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#freeform_tags ManagedKafkaKafkaCluster#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#id ManagedKafkaKafkaCluster#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#timeouts ManagedKafkaKafkaCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterTimeouts\"}", isOptional: true)]
            public oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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

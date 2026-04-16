using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.KafkaCluster
{
    [JsiiInterface(nativeType: typeof(IKafkaClusterConfig), fullyQualifiedName: "scaleway.kafkaCluster.KafkaClusterConfig")]
    public interface IKafkaClusterConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Name of the Kafka cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#name KafkaCluster#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Number of nodes in the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#node_amount KafkaCluster#node_amount}
        /// </remarks>
        [JsiiProperty(name: "nodeAmount", typeJson: "{\"primitive\":\"number\"}")]
        double NodeAmount
        {
            get;
        }

        /// <summary>Node type to use for the cluster.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#node_type KafkaCluster#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        /// <summary>Kafka version to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#version KafkaCluster#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Volume size in GB.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#volume_size_in_gb KafkaCluster#volume_size_in_gb}
        /// </remarks>
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double VolumeSizeInGb
        {
            get;
        }

        /// <summary>Type of volume where data is stored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#volume_type KafkaCluster#volume_type}
        /// </remarks>
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#id KafkaCluster#id}.</summary>
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

        /// <summary>Password for the Kafka user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#password KafkaCluster#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#private_network KafkaCluster#private_network}
        /// </remarks>
        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.kafkaCluster.KafkaClusterPrivateNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.KafkaCluster.IKafkaClusterPrivateNetwork? PrivateNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#project_id KafkaCluster#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#region KafkaCluster#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of tags to apply.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#tags KafkaCluster#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#timeouts KafkaCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.kafkaCluster.KafkaClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.KafkaCluster.IKafkaClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Username for the Kafka user.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#user_name KafkaCluster#user_name}
        /// </remarks>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKafkaClusterConfig), fullyQualifiedName: "scaleway.kafkaCluster.KafkaClusterConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.KafkaCluster.IKafkaClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the Kafka cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#name KafkaCluster#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Number of nodes in the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#node_amount KafkaCluster#node_amount}
            /// </remarks>
            [JsiiProperty(name: "nodeAmount", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeAmount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Node type to use for the cluster.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#node_type KafkaCluster#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Kafka version to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#version KafkaCluster#version}
            /// </remarks>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Volume size in GB.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#volume_size_in_gb KafkaCluster#volume_size_in_gb}
            /// </remarks>
            [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double VolumeSizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Type of volume where data is stored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#volume_type KafkaCluster#volume_type}
            /// </remarks>
            [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#id KafkaCluster#id}.</summary>
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

            /// <summary>Password for the Kafka user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#password KafkaCluster#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>private_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#private_network KafkaCluster#private_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.kafkaCluster.KafkaClusterPrivateNetwork\"}", isOptional: true)]
            public scaleway.KafkaCluster.IKafkaClusterPrivateNetwork? PrivateNetwork
            {
                get => GetInstanceProperty<scaleway.KafkaCluster.IKafkaClusterPrivateNetwork?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#project_id KafkaCluster#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#region KafkaCluster#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of tags to apply.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#tags KafkaCluster#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Tags
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#timeouts KafkaCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.kafkaCluster.KafkaClusterTimeouts\"}", isOptional: true)]
            public scaleway.KafkaCluster.IKafkaClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.KafkaCluster.IKafkaClusterTimeouts?>();
            }

            /// <summary>Username for the Kafka user.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/kafka_cluster#user_name KafkaCluster#user_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbReadReplica
{
    [JsiiInterface(nativeType: typeof(IRdbReadReplicaConfig), fullyQualifiedName: "scaleway.rdbReadReplica.RdbReadReplicaConfig")]
    public interface IRdbReadReplicaConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Id of the rdb instance to replicate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#instance_id RdbReadReplica#instance_id}
        /// </remarks>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceId
        {
            get;
        }

        /// <summary>direct_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#direct_access RdbReadReplica#direct_access}
        /// </remarks>
        [JsiiProperty(name: "directAccess", typeJson: "{\"fqn\":\"scaleway.rdbReadReplica.RdbReadReplicaDirectAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.RdbReadReplica.IRdbReadReplicaDirectAccess? DirectAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#id RdbReadReplica#id}.</summary>
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

        /// <summary>private_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#private_network RdbReadReplica#private_network}
        /// </remarks>
        [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.rdbReadReplica.RdbReadReplicaPrivateNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.RdbReadReplica.IRdbReadReplicaPrivateNetwork? PrivateNetwork
        {
            get
            {
                return null;
            }
        }

        /// <summary>The region you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#region RdbReadReplica#region}
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

        /// <summary>Defines whether to create the replica in the same availability zone as the main instance nodes or not.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#same_zone RdbReadReplica#same_zone}
        /// </remarks>
        [JsiiProperty(name: "sameZone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SameZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#timeouts RdbReadReplica#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.rdbReadReplica.RdbReadReplicaTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.RdbReadReplica.IRdbReadReplicaTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdbReadReplicaConfig), fullyQualifiedName: "scaleway.rdbReadReplica.RdbReadReplicaConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.RdbReadReplica.IRdbReadReplicaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Id of the rdb instance to replicate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#instance_id RdbReadReplica#instance_id}
            /// </remarks>
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>direct_access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#direct_access RdbReadReplica#direct_access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "directAccess", typeJson: "{\"fqn\":\"scaleway.rdbReadReplica.RdbReadReplicaDirectAccess\"}", isOptional: true)]
            public scaleway.RdbReadReplica.IRdbReadReplicaDirectAccess? DirectAccess
            {
                get => GetInstanceProperty<scaleway.RdbReadReplica.IRdbReadReplicaDirectAccess?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#id RdbReadReplica#id}.</summary>
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

            /// <summary>private_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#private_network RdbReadReplica#private_network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateNetwork", typeJson: "{\"fqn\":\"scaleway.rdbReadReplica.RdbReadReplicaPrivateNetwork\"}", isOptional: true)]
            public scaleway.RdbReadReplica.IRdbReadReplicaPrivateNetwork? PrivateNetwork
            {
                get => GetInstanceProperty<scaleway.RdbReadReplica.IRdbReadReplicaPrivateNetwork?>();
            }

            /// <summary>The region you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#region RdbReadReplica#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Defines whether to create the replica in the same availability zone as the main instance nodes or not.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#same_zone RdbReadReplica#same_zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sameZone", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SameZone
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#timeouts RdbReadReplica#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.rdbReadReplica.RdbReadReplicaTimeouts\"}", isOptional: true)]
            public scaleway.RdbReadReplica.IRdbReadReplicaTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.RdbReadReplica.IRdbReadReplicaTimeouts?>();
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

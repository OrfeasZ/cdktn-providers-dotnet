using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayBaremetalPartitionSchema
{
    [JsiiInterface(nativeType: typeof(IDataScalewayBaremetalPartitionSchemaConfig), fullyQualifiedName: "scaleway.dataScalewayBaremetalPartitionSchema.DataScalewayBaremetalPartitionSchemaConfig")]
    public interface IDataScalewayBaremetalPartitionSchemaConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the server offer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#offer_id DataScalewayBaremetalPartitionSchema#offer_id}
        /// </remarks>
        [JsiiProperty(name: "offerId", typeJson: "{\"primitive\":\"string\"}")]
        string OfferId
        {
            get;
        }

        /// <summary>The base image of the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#os_id DataScalewayBaremetalPartitionSchema#os_id}
        /// </remarks>
        [JsiiProperty(name: "osId", typeJson: "{\"primitive\":\"string\"}")]
        string OsId
        {
            get;
        }

        /// <summary>Mount point must be an absolute path.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#ext_4_mountpoint DataScalewayBaremetalPartitionSchema#ext_4_mountpoint}
        /// </remarks>
        [JsiiProperty(name: "ext4Mountpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ext4Mountpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>set extra ext_4 partition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#extra_partition DataScalewayBaremetalPartitionSchema#extra_partition}
        /// </remarks>
        [JsiiProperty(name: "extraPartition", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExtraPartition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#id DataScalewayBaremetalPartitionSchema#id}.</summary>
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

        /// <summary>set swap partition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#swap DataScalewayBaremetalPartitionSchema#swap}
        /// </remarks>
        [JsiiProperty(name: "swap", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Swap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayBaremetalPartitionSchemaConfig), fullyQualifiedName: "scaleway.dataScalewayBaremetalPartitionSchema.DataScalewayBaremetalPartitionSchemaConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayBaremetalPartitionSchema.IDataScalewayBaremetalPartitionSchemaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the server offer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#offer_id DataScalewayBaremetalPartitionSchema#offer_id}
            /// </remarks>
            [JsiiProperty(name: "offerId", typeJson: "{\"primitive\":\"string\"}")]
            public string OfferId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The base image of the server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#os_id DataScalewayBaremetalPartitionSchema#os_id}
            /// </remarks>
            [JsiiProperty(name: "osId", typeJson: "{\"primitive\":\"string\"}")]
            public string OsId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Mount point must be an absolute path.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#ext_4_mountpoint DataScalewayBaremetalPartitionSchema#ext_4_mountpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ext4Mountpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ext4Mountpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>set extra ext_4 partition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#extra_partition DataScalewayBaremetalPartitionSchema#extra_partition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extraPartition", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExtraPartition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#id DataScalewayBaremetalPartitionSchema#id}.</summary>
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

            /// <summary>set swap partition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/baremetal_partition_schema#swap DataScalewayBaremetalPartitionSchema#swap}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "swap", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Swap
            {
                get => GetInstanceProperty<object?>();
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

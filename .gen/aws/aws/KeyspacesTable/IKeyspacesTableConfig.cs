using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiInterface(nativeType: typeof(IKeyspacesTableConfig), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableConfig")]
    public interface IKeyspacesTableConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#keyspace_name KeyspacesTable#keyspace_name}.</summary>
        [JsiiProperty(name: "keyspaceName", typeJson: "{\"primitive\":\"string\"}")]
        string KeyspaceName
        {
            get;
        }

        /// <summary>schema_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#schema_definition KeyspacesTable#schema_definition}
        /// </remarks>
        [JsiiProperty(name: "schemaDefinition", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinition\"}")]
        aws.KeyspacesTable.IKeyspacesTableSchemaDefinition SchemaDefinition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#table_name KeyspacesTable#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        /// <summary>capacity_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#capacity_specification KeyspacesTable#capacity_specification}
        /// </remarks>
        [JsiiProperty(name: "capacitySpecification", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableCapacitySpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KeyspacesTable.IKeyspacesTableCapacitySpecification? CapacitySpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>client_side_timestamps block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#client_side_timestamps KeyspacesTable#client_side_timestamps}
        /// </remarks>
        [JsiiProperty(name: "clientSideTimestamps", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableClientSideTimestamps\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps? ClientSideTimestamps
        {
            get
            {
                return null;
            }
        }

        /// <summary>comment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#comment KeyspacesTable#comment}
        /// </remarks>
        [JsiiProperty(name: "comment", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableComment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KeyspacesTable.IKeyspacesTableComment? Comment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#default_time_to_live KeyspacesTable#default_time_to_live}.</summary>
        [JsiiProperty(name: "defaultTimeToLive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultTimeToLive
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#encryption_specification KeyspacesTable#encryption_specification}
        /// </remarks>
        [JsiiProperty(name: "encryptionSpecification", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableEncryptionSpecification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification? EncryptionSpecification
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#id KeyspacesTable#id}.</summary>
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

        /// <summary>point_in_time_recovery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#point_in_time_recovery KeyspacesTable#point_in_time_recovery}
        /// </remarks>
        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTablePointInTimeRecovery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery? PointInTimeRecovery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#region KeyspacesTable#region}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#tags KeyspacesTable#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#tags_all KeyspacesTable#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#timeouts KeyspacesTable#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KeyspacesTable.IKeyspacesTableTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>ttl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#ttl KeyspacesTable#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTtl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KeyspacesTable.IKeyspacesTableTtl? Ttl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyspacesTableConfig), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableConfig")]
        internal sealed class _Proxy : DeputyBase, aws.KeyspacesTable.IKeyspacesTableConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#keyspace_name KeyspacesTable#keyspace_name}.</summary>
            [JsiiProperty(name: "keyspaceName", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyspaceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schema_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#schema_definition KeyspacesTable#schema_definition}
            /// </remarks>
            [JsiiProperty(name: "schemaDefinition", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableSchemaDefinition\"}")]
            public aws.KeyspacesTable.IKeyspacesTableSchemaDefinition SchemaDefinition
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableSchemaDefinition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#table_name KeyspacesTable#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>capacity_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#capacity_specification KeyspacesTable#capacity_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacitySpecification", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableCapacitySpecification\"}", isOptional: true)]
            public aws.KeyspacesTable.IKeyspacesTableCapacitySpecification? CapacitySpecification
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableCapacitySpecification?>();
            }

            /// <summary>client_side_timestamps block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#client_side_timestamps KeyspacesTable#client_side_timestamps}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientSideTimestamps", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableClientSideTimestamps\"}", isOptional: true)]
            public aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps? ClientSideTimestamps
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps?>();
            }

            /// <summary>comment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#comment KeyspacesTable#comment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "comment", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableComment\"}", isOptional: true)]
            public aws.KeyspacesTable.IKeyspacesTableComment? Comment
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableComment?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#default_time_to_live KeyspacesTable#default_time_to_live}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTimeToLive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultTimeToLive
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>encryption_specification block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#encryption_specification KeyspacesTable#encryption_specification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionSpecification", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableEncryptionSpecification\"}", isOptional: true)]
            public aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification? EncryptionSpecification
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#id KeyspacesTable#id}.</summary>
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

            /// <summary>point_in_time_recovery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#point_in_time_recovery KeyspacesTable#point_in_time_recovery}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTablePointInTimeRecovery\"}", isOptional: true)]
            public aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery? PointInTimeRecovery
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTablePointInTimeRecovery?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#region KeyspacesTable#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#tags KeyspacesTable#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#tags_all KeyspacesTable#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#timeouts KeyspacesTable#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTimeouts\"}", isOptional: true)]
            public aws.KeyspacesTable.IKeyspacesTableTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableTimeouts?>();
            }

            /// <summary>ttl block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/keyspaces_table#ttl KeyspacesTable#ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"fqn\":\"aws.keyspacesTable.KeyspacesTableTtl\"}", isOptional: true)]
            public aws.KeyspacesTable.IKeyspacesTableTtl? Ttl
            {
                get => GetInstanceProperty<aws.KeyspacesTable.IKeyspacesTableTtl?>();
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

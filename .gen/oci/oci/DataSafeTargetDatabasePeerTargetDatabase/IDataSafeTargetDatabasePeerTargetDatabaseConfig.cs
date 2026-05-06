using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabasePeerTargetDatabase
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseConfig), fullyQualifiedName: "oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseConfig")]
    public interface IDataSafeTargetDatabasePeerTargetDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>database_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#database_details DataSafeTargetDatabasePeerTargetDatabase#database_details}
        /// </remarks>
        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails\"}")]
        oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails DatabaseDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#target_database_id DataSafeTargetDatabasePeerTargetDatabase#target_database_id}.</summary>
        [JsiiProperty(name: "targetDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetDatabaseId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#dataguard_association_id DataSafeTargetDatabasePeerTargetDatabase#dataguard_association_id}.</summary>
        [JsiiProperty(name: "dataguardAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataguardAssociationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#description DataSafeTargetDatabasePeerTargetDatabase#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#display_name DataSafeTargetDatabasePeerTargetDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#id DataSafeTargetDatabasePeerTargetDatabase#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#timeouts DataSafeTargetDatabasePeerTargetDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#tls_config DataSafeTargetDatabasePeerTargetDatabase#tls_config}
        /// </remarks>
        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseTlsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseTlsConfig? TlsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabasePeerTargetDatabaseConfig), fullyQualifiedName: "oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>database_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#database_details DataSafeTargetDatabasePeerTargetDatabase#database_details}
            /// </remarks>
            [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails\"}")]
            public oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails DatabaseDetails
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDatabaseDetails>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#target_database_id DataSafeTargetDatabasePeerTargetDatabase#target_database_id}.</summary>
            [JsiiProperty(name: "targetDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#dataguard_association_id DataSafeTargetDatabasePeerTargetDatabase#dataguard_association_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataguardAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataguardAssociationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#description DataSafeTargetDatabasePeerTargetDatabase#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#display_name DataSafeTargetDatabasePeerTargetDatabase#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#id DataSafeTargetDatabasePeerTargetDatabase#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#timeouts DataSafeTargetDatabasePeerTargetDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseTimeouts\"}", isOptional: true)]
            public oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseTimeouts?>();
            }

            /// <summary>tls_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database_peer_target_database#tls_config DataSafeTargetDatabasePeerTargetDatabase#tls_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabasePeerTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseTlsConfig\"}", isOptional: true)]
            public oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseTlsConfig? TlsConfig
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabasePeerTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseTlsConfig?>();
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

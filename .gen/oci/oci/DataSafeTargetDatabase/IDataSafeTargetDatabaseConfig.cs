using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    [JsiiInterface(nativeType: typeof(IDataSafeTargetDatabaseConfig), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConfig")]
    public interface IDataSafeTargetDatabaseConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#compartment_id DataSafeTargetDatabase#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>database_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#database_details DataSafeTargetDatabase#database_details}
        /// </remarks>
        [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseDatabaseDetails\"}")]
        oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseDatabaseDetails DatabaseDetails
        {
            get;
        }

        /// <summary>connection_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#connection_option DataSafeTargetDatabase#connection_option}
        /// </remarks>
        [JsiiProperty(name: "connectionOption", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption? ConnectionOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#credentials DataSafeTargetDatabase#credentials}
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseCredentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials? Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#defined_tags DataSafeTargetDatabase#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#description DataSafeTargetDatabase#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#display_name DataSafeTargetDatabase#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#freeform_tags DataSafeTargetDatabase#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#id DataSafeTargetDatabase#id}.</summary>
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

        /// <summary>peer_target_database_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#peer_target_database_details DataSafeTargetDatabase#peer_target_database_details}
        /// </remarks>
        [JsiiProperty(name: "peerTargetDatabaseDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PeerTargetDatabaseDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#timeouts DataSafeTargetDatabase#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#tls_config DataSafeTargetDatabase#tls_config}
        /// </remarks>
        [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTlsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTlsConfig? TlsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeTargetDatabaseConfig), fullyQualifiedName: "oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#compartment_id DataSafeTargetDatabase#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>database_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#database_details DataSafeTargetDatabase#database_details}
            /// </remarks>
            [JsiiProperty(name: "databaseDetails", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseDatabaseDetails\"}")]
            public oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseDatabaseDetails DatabaseDetails
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseDatabaseDetails>()!;
            }

            /// <summary>connection_option block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#connection_option DataSafeTargetDatabase#connection_option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionOption", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseConnectionOption\"}", isOptional: true)]
            public oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption? ConnectionOption
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseConnectionOption?>();
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#credentials DataSafeTargetDatabase#credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseCredentials\"}", isOptional: true)]
            public oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials? Credentials
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseCredentials?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#defined_tags DataSafeTargetDatabase#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#description DataSafeTargetDatabase#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#display_name DataSafeTargetDatabase#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#freeform_tags DataSafeTargetDatabase#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#id DataSafeTargetDatabase#id}.</summary>
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

            /// <summary>peer_target_database_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#peer_target_database_details DataSafeTargetDatabase#peer_target_database_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "peerTargetDatabaseDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PeerTargetDatabaseDetails
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#timeouts DataSafeTargetDatabase#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTimeouts\"}", isOptional: true)]
            public oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTimeouts?>();
            }

            /// <summary>tls_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#tls_config DataSafeTargetDatabase#tls_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tlsConfig", typeJson: "{\"fqn\":\"oci.dataSafeTargetDatabase.DataSafeTargetDatabaseTlsConfig\"}", isOptional: true)]
            public oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTlsConfig? TlsConfig
            {
                get => GetInstanceProperty<oci.DataSafeTargetDatabase.IDataSafeTargetDatabaseTlsConfig?>();
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

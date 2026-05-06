using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionConfig), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionConfig")]
    public interface IDatabaseToolsDatabaseToolsConnectionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#compartment_id DatabaseToolsDatabaseToolsConnection#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#display_name DatabaseToolsDatabaseToolsConnection#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#type DatabaseToolsDatabaseToolsConnection#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_name DatabaseToolsDatabaseToolsConnection#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        /// <summary>user_password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_password DatabaseToolsDatabaseToolsConnection#user_password}
        /// </remarks>
        [JsiiProperty(name: "userPassword", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionUserPassword\"}")]
        oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionUserPassword UserPassword
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#advanced_properties DatabaseToolsDatabaseToolsConnection#advanced_properties}.</summary>
        [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdvancedProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#connection_string DatabaseToolsDatabaseToolsConnection#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#defined_tags DatabaseToolsDatabaseToolsConnection#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#freeform_tags DatabaseToolsDatabaseToolsConnection#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#id DatabaseToolsDatabaseToolsConnection#id}.</summary>
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

        /// <summary>key_stores block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#key_stores DatabaseToolsDatabaseToolsConnection#key_stores}
        /// </remarks>
        [JsiiProperty(name: "keyStores", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStores\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeyStores
        {
            get
            {
                return null;
            }
        }

        /// <summary>locks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#locks DatabaseToolsDatabaseToolsConnection#locks}
        /// </remarks>
        [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Locks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#private_endpoint_id DatabaseToolsDatabaseToolsConnection#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointId
        {
            get
            {
                return null;
            }
        }

        /// <summary>proxy_client block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#proxy_client DatabaseToolsDatabaseToolsConnection#proxy_client}
        /// </remarks>
        [JsiiProperty(name: "proxyClient", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClient\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClient? ProxyClient
        {
            get
            {
                return null;
            }
        }

        /// <summary>related_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#related_resource DatabaseToolsDatabaseToolsConnection#related_resource}
        /// </remarks>
        [JsiiProperty(name: "relatedResource", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionRelatedResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionRelatedResource? RelatedResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#runtime_support DatabaseToolsDatabaseToolsConnection#runtime_support}.</summary>
        [JsiiProperty(name: "runtimeSupport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RuntimeSupport
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#timeouts DatabaseToolsDatabaseToolsConnection#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#url DatabaseToolsDatabaseToolsConnection#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionConfig), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#compartment_id DatabaseToolsDatabaseToolsConnection#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#display_name DatabaseToolsDatabaseToolsConnection#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#type DatabaseToolsDatabaseToolsConnection#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_name DatabaseToolsDatabaseToolsConnection#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>user_password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_password DatabaseToolsDatabaseToolsConnection#user_password}
            /// </remarks>
            [JsiiProperty(name: "userPassword", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionUserPassword\"}")]
            public oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionUserPassword UserPassword
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionUserPassword>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#advanced_properties DatabaseToolsDatabaseToolsConnection#advanced_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advancedProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdvancedProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#connection_string DatabaseToolsDatabaseToolsConnection#connection_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#defined_tags DatabaseToolsDatabaseToolsConnection#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#freeform_tags DatabaseToolsDatabaseToolsConnection#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#id DatabaseToolsDatabaseToolsConnection#id}.</summary>
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

            /// <summary>key_stores block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#key_stores DatabaseToolsDatabaseToolsConnection#key_stores}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyStores", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionKeyStores\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KeyStores
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>locks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#locks DatabaseToolsDatabaseToolsConnection#locks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locks", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionLocks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Locks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#private_endpoint_id DatabaseToolsDatabaseToolsConnection#private_endpoint_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>proxy_client block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#proxy_client DatabaseToolsDatabaseToolsConnection#proxy_client}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "proxyClient", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClient\"}", isOptional: true)]
            public oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClient? ProxyClient
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClient?>();
            }

            /// <summary>related_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#related_resource DatabaseToolsDatabaseToolsConnection#related_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relatedResource", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionRelatedResource\"}", isOptional: true)]
            public oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionRelatedResource? RelatedResource
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionRelatedResource?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#runtime_support DatabaseToolsDatabaseToolsConnection#runtime_support}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeSupport", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RuntimeSupport
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#timeouts DatabaseToolsDatabaseToolsConnection#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionTimeouts\"}", isOptional: true)]
            public oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#url DatabaseToolsDatabaseToolsConnection#url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
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

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsDatabaseToolsConnection
{
    [JsiiInterface(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionProxyClient), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClient")]
    public interface IDatabaseToolsDatabaseToolsConnectionProxyClient
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#proxy_authentication_type DatabaseToolsDatabaseToolsConnection#proxy_authentication_type}.</summary>
        [JsiiProperty(name: "proxyAuthenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string ProxyAuthenticationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#roles DatabaseToolsDatabaseToolsConnection#roles}.</summary>
        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Roles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_name DatabaseToolsDatabaseToolsConnection#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_password DatabaseToolsDatabaseToolsConnection#user_password}
        /// </remarks>
        [JsiiProperty(name: "userPassword", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPassword\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword? UserPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseToolsDatabaseToolsConnectionProxyClient), fullyQualifiedName: "oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClient")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClient
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#proxy_authentication_type DatabaseToolsDatabaseToolsConnection#proxy_authentication_type}.</summary>
            [JsiiProperty(name: "proxyAuthenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProxyAuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#roles DatabaseToolsDatabaseToolsConnection#roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Roles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_name DatabaseToolsDatabaseToolsConnection#user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>user_password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_tools_database_tools_connection#user_password DatabaseToolsDatabaseToolsConnection#user_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userPassword", typeJson: "{\"fqn\":\"oci.databaseToolsDatabaseToolsConnection.DatabaseToolsDatabaseToolsConnectionProxyClientUserPassword\"}", isOptional: true)]
            public oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword? UserPassword
            {
                get => GetInstanceProperty<oci.DatabaseToolsDatabaseToolsConnection.IDatabaseToolsDatabaseToolsConnectionProxyClientUserPassword?>();
            }
        }
    }
}

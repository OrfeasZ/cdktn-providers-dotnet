using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateConnection
{
    [JsiiInterface(nativeType: typeof(IGoldenGateConnectionCatalogCatalogConfig), fullyQualifiedName: "oci.goldenGateConnection.GoldenGateConnectionCatalogCatalogConfig")]
    public interface IGoldenGateConnectionCatalogCatalogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#catalog_config_type GoldenGateConnection#catalog_config_type}.</summary>
        [JsiiProperty(name: "catalogConfigType", typeJson: "{\"primitive\":\"string\"}")]
        string CatalogConfigType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#database_id GoldenGateConnection#database_id}.</summary>
        [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#database_type GoldenGateConnection#database_type}.</summary>
        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#deployment_id GoldenGateConnection#deployment_id}.</summary>
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#password GoldenGateConnection#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#password_secret_id GoldenGateConnection#password_secret_id}.</summary>
        [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PasswordSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#username GoldenGateConnection#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateConnectionCatalogCatalogConfig), fullyQualifiedName: "oci.goldenGateConnection.GoldenGateConnectionCatalogCatalogConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateConnection.IGoldenGateConnectionCatalogCatalogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#catalog_config_type GoldenGateConnection#catalog_config_type}.</summary>
            [JsiiProperty(name: "catalogConfigType", typeJson: "{\"primitive\":\"string\"}")]
            public string CatalogConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#database_id GoldenGateConnection#database_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#database_type GoldenGateConnection#database_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#deployment_id GoldenGateConnection#deployment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#password GoldenGateConnection#password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Password
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#password_secret_id GoldenGateConnection#password_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PasswordSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/golden_gate_connection#username GoldenGateConnection#username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

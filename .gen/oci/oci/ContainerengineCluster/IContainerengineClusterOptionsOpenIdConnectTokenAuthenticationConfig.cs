using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    [JsiiInterface(nativeType: typeof(IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig")]
    public interface IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_open_id_connect_auth_enabled ContainerengineCluster#is_open_id_connect_auth_enabled}.</summary>
        [JsiiProperty(name: "isOpenIdConnectAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsOpenIdConnectAuthEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#ca_certificate ContainerengineCluster#ca_certificate}.</summary>
        [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#client_id ContainerengineCluster#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#configuration_file ContainerengineCluster#configuration_file}.</summary>
        [JsiiProperty(name: "configurationFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#groups_claim ContainerengineCluster#groups_claim}.</summary>
        [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupsClaim
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#groups_prefix ContainerengineCluster#groups_prefix}.</summary>
        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupsPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#issuer_url ContainerengineCluster#issuer_url}.</summary>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IssuerUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>required_claims block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#required_claims ContainerengineCluster#required_claims}
        /// </remarks>
        [JsiiProperty(name: "requiredClaims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequiredClaims
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#signing_algorithms ContainerengineCluster#signing_algorithms}.</summary>
        [JsiiProperty(name: "signingAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SigningAlgorithms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#username_claim ContainerengineCluster#username_claim}.</summary>
        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsernameClaim
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#username_prefix ContainerengineCluster#username_prefix}.</summary>
        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UsernamePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig), fullyQualifiedName: "oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_open_id_connect_auth_enabled ContainerengineCluster#is_open_id_connect_auth_enabled}.</summary>
            [JsiiProperty(name: "isOpenIdConnectAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsOpenIdConnectAuthEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#ca_certificate ContainerengineCluster#ca_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#client_id ContainerengineCluster#client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#configuration_file ContainerengineCluster#configuration_file}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configurationFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#groups_claim ContainerengineCluster#groups_claim}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupsClaim
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#groups_prefix ContainerengineCluster#groups_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupsPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#issuer_url ContainerengineCluster#issuer_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IssuerUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>required_claims block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#required_claims ContainerengineCluster#required_claims}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredClaims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequiredClaims
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#signing_algorithms ContainerengineCluster#signing_algorithms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signingAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SigningAlgorithms
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#username_claim ContainerengineCluster#username_claim}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsernameClaim
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#username_prefix ContainerengineCluster#username_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UsernamePrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

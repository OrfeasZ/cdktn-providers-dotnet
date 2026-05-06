using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig")]
    public class ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig : oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfig
    {
        private object _isOpenIdConnectAuthEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#is_open_id_connect_auth_enabled ContainerengineCluster#is_open_id_connect_auth_enabled}.</summary>
        [JsiiProperty(name: "isOpenIdConnectAuthEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsOpenIdConnectAuthEnabled
        {
            get => _isOpenIdConnectAuthEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isOpenIdConnectAuthEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#ca_certificate ContainerengineCluster#ca_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#client_id ContainerengineCluster#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#configuration_file ContainerengineCluster#configuration_file}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigurationFile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#groups_claim ContainerengineCluster#groups_claim}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupsClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupsClaim
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#groups_prefix ContainerengineCluster#groups_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupsPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#issuer_url ContainerengineCluster#issuer_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IssuerUrl
        {
            get;
            set;
        }

        private object? _requiredClaims;

        /// <summary>required_claims block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#required_claims ContainerengineCluster#required_claims}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiredClaims", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerengineCluster.ContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequiredClaims
        {
            get => _requiredClaims;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerengineCluster.IContainerengineClusterOptionsOpenIdConnectTokenAuthenticationConfigRequiredClaims).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requiredClaims = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#signing_algorithms ContainerengineCluster#signing_algorithms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signingAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SigningAlgorithms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#username_claim ContainerengineCluster#username_claim}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsernameClaim
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_cluster#username_prefix ContainerengineCluster#username_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsernamePrefix
        {
            get;
            set;
        }
    }
}

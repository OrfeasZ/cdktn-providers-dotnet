using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiByValue(fqn: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails")]
    public class CoreIpsecConnectionTunnelManagementPhaseOneDetails : oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_authentication_algorithm CoreIpsecConnectionTunnelManagement#custom_authentication_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customAuthenticationAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomAuthenticationAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_dh_group CoreIpsecConnectionTunnelManagement#custom_dh_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customDhGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomDhGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_encryption_algorithm CoreIpsecConnectionTunnelManagement#custom_encryption_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomEncryptionAlgorithm
        {
            get;
            set;
        }

        private object? _isCustomPhaseOneConfig;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#is_custom_phase_one_config CoreIpsecConnectionTunnelManagement#is_custom_phase_one_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isCustomPhaseOneConfig", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsCustomPhaseOneConfig
        {
            get => _isCustomPhaseOneConfig;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isCustomPhaseOneConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#lifetime CoreIpsecConnectionTunnelManagement#lifetime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Lifetime
        {
            get;
            set;
        }
    }
}

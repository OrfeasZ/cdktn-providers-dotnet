using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiInterface(nativeType: typeof(ICoreIpsecConnectionTunnelManagementPhaseOneDetails), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails")]
    public interface ICoreIpsecConnectionTunnelManagementPhaseOneDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_authentication_algorithm CoreIpsecConnectionTunnelManagement#custom_authentication_algorithm}.</summary>
        [JsiiProperty(name: "customAuthenticationAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomAuthenticationAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_dh_group CoreIpsecConnectionTunnelManagement#custom_dh_group}.</summary>
        [JsiiProperty(name: "customDhGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomDhGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_encryption_algorithm CoreIpsecConnectionTunnelManagement#custom_encryption_algorithm}.</summary>
        [JsiiProperty(name: "customEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomEncryptionAlgorithm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#is_custom_phase_one_config CoreIpsecConnectionTunnelManagement#is_custom_phase_one_config}.</summary>
        [JsiiProperty(name: "isCustomPhaseOneConfig", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsCustomPhaseOneConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#lifetime CoreIpsecConnectionTunnelManagement#lifetime}.</summary>
        [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Lifetime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreIpsecConnectionTunnelManagementPhaseOneDetails), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementPhaseOneDetails")]
        internal sealed class _Proxy : DeputyBase, oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementPhaseOneDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_authentication_algorithm CoreIpsecConnectionTunnelManagement#custom_authentication_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customAuthenticationAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomAuthenticationAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_dh_group CoreIpsecConnectionTunnelManagement#custom_dh_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customDhGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomDhGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#custom_encryption_algorithm CoreIpsecConnectionTunnelManagement#custom_encryption_algorithm}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomEncryptionAlgorithm
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#is_custom_phase_one_config CoreIpsecConnectionTunnelManagement#is_custom_phase_one_config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isCustomPhaseOneConfig", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsCustomPhaseOneConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#lifetime CoreIpsecConnectionTunnelManagement#lifetime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Lifetime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

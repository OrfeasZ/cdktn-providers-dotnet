using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiInterface(nativeType: typeof(ICoreIpsecConnectionTunnelManagementDpdConfig), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfig")]
    public interface ICoreIpsecConnectionTunnelManagementDpdConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_mode CoreIpsecConnectionTunnelManagement#dpd_mode}.</summary>
        [JsiiProperty(name: "dpdMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DpdMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_timeout_in_sec CoreIpsecConnectionTunnelManagement#dpd_timeout_in_sec}.</summary>
        [JsiiProperty(name: "dpdTimeoutInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DpdTimeoutInSec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreIpsecConnectionTunnelManagementDpdConfig), fullyQualifiedName: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementDpdConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_mode CoreIpsecConnectionTunnelManagement#dpd_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dpdMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DpdMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_timeout_in_sec CoreIpsecConnectionTunnelManagement#dpd_timeout_in_sec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dpdTimeoutInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DpdTimeoutInSec
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

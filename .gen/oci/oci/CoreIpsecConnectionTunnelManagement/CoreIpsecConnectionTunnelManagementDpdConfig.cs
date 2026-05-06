using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreIpsecConnectionTunnelManagement
{
    [JsiiByValue(fqn: "oci.coreIpsecConnectionTunnelManagement.CoreIpsecConnectionTunnelManagementDpdConfig")]
    public class CoreIpsecConnectionTunnelManagementDpdConfig : oci.CoreIpsecConnectionTunnelManagement.ICoreIpsecConnectionTunnelManagementDpdConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_mode CoreIpsecConnectionTunnelManagement#dpd_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dpdMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DpdMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_ipsec_connection_tunnel_management#dpd_timeout_in_sec CoreIpsecConnectionTunnelManagement#dpd_timeout_in_sec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dpdTimeoutInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DpdTimeoutInSec
        {
            get;
            set;
        }
    }
}

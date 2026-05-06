using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OdaOdaPrivateEndpointScanProxy
{
    [JsiiByValue(fqn: "oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyScanListenerInfos")]
    public class OdaOdaPrivateEndpointScanProxyScanListenerInfos : oci.OdaOdaPrivateEndpointScanProxy.IOdaOdaPrivateEndpointScanProxyScanListenerInfos
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_fqdn OdaOdaPrivateEndpointScanProxy#scan_listener_fqdn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scanListenerFqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScanListenerFqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_ip OdaOdaPrivateEndpointScanProxy#scan_listener_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scanListenerIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScanListenerIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_port OdaOdaPrivateEndpointScanProxy#scan_listener_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scanListenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScanListenerPort
        {
            get;
            set;
        }
    }
}

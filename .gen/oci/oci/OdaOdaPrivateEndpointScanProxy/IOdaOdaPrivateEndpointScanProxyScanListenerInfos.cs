using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OdaOdaPrivateEndpointScanProxy
{
    [JsiiInterface(nativeType: typeof(IOdaOdaPrivateEndpointScanProxyScanListenerInfos), fullyQualifiedName: "oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyScanListenerInfos")]
    public interface IOdaOdaPrivateEndpointScanProxyScanListenerInfos
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_fqdn OdaOdaPrivateEndpointScanProxy#scan_listener_fqdn}.</summary>
        [JsiiProperty(name: "scanListenerFqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScanListenerFqdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_ip OdaOdaPrivateEndpointScanProxy#scan_listener_ip}.</summary>
        [JsiiProperty(name: "scanListenerIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScanListenerIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_port OdaOdaPrivateEndpointScanProxy#scan_listener_port}.</summary>
        [JsiiProperty(name: "scanListenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScanListenerPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdaOdaPrivateEndpointScanProxyScanListenerInfos), fullyQualifiedName: "oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyScanListenerInfos")]
        internal sealed class _Proxy : DeputyBase, oci.OdaOdaPrivateEndpointScanProxy.IOdaOdaPrivateEndpointScanProxyScanListenerInfos
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_fqdn OdaOdaPrivateEndpointScanProxy#scan_listener_fqdn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanListenerFqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScanListenerFqdn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_ip OdaOdaPrivateEndpointScanProxy#scan_listener_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanListenerIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScanListenerIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#scan_listener_port OdaOdaPrivateEndpointScanProxy#scan_listener_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanListenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScanListenerPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OdaOdaPrivateEndpointScanProxy
{
    [JsiiByValue(fqn: "oci.odaOdaPrivateEndpointScanProxy.OdaOdaPrivateEndpointScanProxyTimeouts")]
    public class OdaOdaPrivateEndpointScanProxyTimeouts : oci.OdaOdaPrivateEndpointScanProxy.IOdaOdaPrivateEndpointScanProxyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#create OdaOdaPrivateEndpointScanProxy#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#delete OdaOdaPrivateEndpointScanProxy#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/oda_oda_private_endpoint_scan_proxy#update OdaOdaPrivateEndpointScanProxy#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

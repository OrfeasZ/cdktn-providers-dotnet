using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowPrivateEndpoint
{
    [JsiiByValue(fqn: "oci.dataflowPrivateEndpoint.DataflowPrivateEndpointScanDetails")]
    public class DataflowPrivateEndpointScanDetails : oci.DataflowPrivateEndpoint.IDataflowPrivateEndpointScanDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_private_endpoint#fqdn DataflowPrivateEndpoint#fqdn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_private_endpoint#port DataflowPrivateEndpoint#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Port
        {
            get;
            set;
        }
    }
}

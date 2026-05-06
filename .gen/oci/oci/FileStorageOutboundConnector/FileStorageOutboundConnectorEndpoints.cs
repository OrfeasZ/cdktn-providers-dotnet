using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageOutboundConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageOutboundConnector.FileStorageOutboundConnectorEndpoints")]
    public class FileStorageOutboundConnectorEndpoints : oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_outbound_connector#hostname FileStorageOutboundConnector#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public string Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_outbound_connector#port FileStorageOutboundConnector#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        public string Port
        {
            get;
            set;
        }
    }
}

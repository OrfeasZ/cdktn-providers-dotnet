using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageOutboundConnector
{
    [JsiiInterface(nativeType: typeof(IFileStorageOutboundConnectorEndpoints), fullyQualifiedName: "oci.fileStorageOutboundConnector.FileStorageOutboundConnectorEndpoints")]
    public interface IFileStorageOutboundConnectorEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_outbound_connector#hostname FileStorageOutboundConnector#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_outbound_connector#port FileStorageOutboundConnector#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        string Port
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageOutboundConnectorEndpoints), fullyQualifiedName: "oci.fileStorageOutboundConnector.FileStorageOutboundConnectorEndpoints")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageOutboundConnector.IFileStorageOutboundConnectorEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_outbound_connector#hostname FileStorageOutboundConnector#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_outbound_connector#port FileStorageOutboundConnector#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
            public string Port
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

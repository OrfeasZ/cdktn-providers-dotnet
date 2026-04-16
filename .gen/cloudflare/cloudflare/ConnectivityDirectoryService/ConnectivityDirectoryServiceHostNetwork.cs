using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork")]
    public class ConnectivityDirectoryServiceHostNetwork : cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#tunnel_id ConnectivityDirectoryService#tunnel_id}.</summary>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        public string TunnelId
        {
            get;
            set;
        }
    }
}

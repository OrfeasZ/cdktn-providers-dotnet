using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkflowmonitorMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkflowmonitorMonitor.NetworkflowmonitorMonitorRemoteResource")]
    public class NetworkflowmonitorMonitorRemoteResource : aws.NetworkflowmonitorMonitor.INetworkflowmonitorMonitorRemoteResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_monitor#identifier NetworkflowmonitorMonitor#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public string Identifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_monitor#type NetworkflowmonitorMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}

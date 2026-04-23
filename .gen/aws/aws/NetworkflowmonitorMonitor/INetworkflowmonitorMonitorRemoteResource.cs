using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkflowmonitorMonitor
{
    [JsiiInterface(nativeType: typeof(INetworkflowmonitorMonitorRemoteResource), fullyQualifiedName: "aws.networkflowmonitorMonitor.NetworkflowmonitorMonitorRemoteResource")]
    public interface INetworkflowmonitorMonitorRemoteResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_monitor#identifier NetworkflowmonitorMonitor#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        string Identifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_monitor#type NetworkflowmonitorMonitor#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkflowmonitorMonitorRemoteResource), fullyQualifiedName: "aws.networkflowmonitorMonitor.NetworkflowmonitorMonitorRemoteResource")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkflowmonitorMonitor.INetworkflowmonitorMonitorRemoteResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_monitor#identifier NetworkflowmonitorMonitor#identifier}.</summary>
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Identifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/networkflowmonitor_monitor#type NetworkflowmonitorMonitor#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

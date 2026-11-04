using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayMcpServer
{
    [JsiiInterface(nativeType: typeof(IActionGatewayMcpServerTimeouts), fullyQualifiedName: "digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeouts")]
    public interface IActionGatewayMcpServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#create ActionGatewayMcpServer#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#update ActionGatewayMcpServer#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayMcpServerTimeouts), fullyQualifiedName: "digitalocean.actionGatewayMcpServer.ActionGatewayMcpServerTimeouts")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayMcpServer.IActionGatewayMcpServerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#create ActionGatewayMcpServer#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_mcp_server#update ActionGatewayMcpServer#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

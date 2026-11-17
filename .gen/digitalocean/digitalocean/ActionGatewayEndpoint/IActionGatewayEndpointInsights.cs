using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiInterface(nativeType: typeof(IActionGatewayEndpointInsights), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointInsights")]
    public interface IActionGatewayEndpointInsights
    {
        /// <summary>Whether the endpoint's logs are sent to Insights. Your team can require this to be on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#logs ActionGatewayEndpoint#logs}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "logs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Logs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the endpoint's metrics are sent to Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#metrics ActionGatewayEndpoint#metrics}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "metrics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Metrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the endpoint's traces are sent to Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#traces ActionGatewayEndpoint#traces}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "traces", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Traces
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IActionGatewayEndpointInsights), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointInsights")]
        internal sealed class _Proxy : DeputyBase, digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointInsights
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the endpoint's logs are sent to Insights. Your team can require this to be on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#logs ActionGatewayEndpoint#logs}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logs", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Logs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the endpoint's metrics are sent to Insights.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#metrics ActionGatewayEndpoint#metrics}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metrics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Metrics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the endpoint's traces are sent to Insights.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.108.0/docs/resources/action_gateway_endpoint#traces ActionGatewayEndpoint#traces}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "traces", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Traces
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

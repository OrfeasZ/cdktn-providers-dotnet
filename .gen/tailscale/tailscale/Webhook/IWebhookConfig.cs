using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.Webhook
{
    [JsiiInterface(nativeType: typeof(IWebhookConfig), fullyQualifiedName: "tailscale.webhook.WebhookConfig")]
    public interface IWebhookConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The endpoint to send webhook events to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/webhook#endpoint_url Webhook#endpoint_url}
        /// </remarks>
        [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointUrl
        {
            get;
        }

        /// <summary>The set of events that trigger this webhook. For a full list of event types, see the [webhooks documentation](https://tailscale.com/kb/1213/webhooks#events).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/webhook#subscriptions Webhook#subscriptions}
        /// </remarks>
        [JsiiProperty(name: "subscriptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subscriptions
        {
            get;
        }

        /// <summary>The provider type of the endpoint URL.</summary>
        /// <remarks>
        /// This determines the payload format sent to the destination. Valid values are <c>slack</c>, <c>mattermost</c>, <c>googlechat</c>, and <c>discord</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/webhook#provider_type Webhook#provider_type}
        /// </remarks>
        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProviderType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebhookConfig), fullyQualifiedName: "tailscale.webhook.WebhookConfig")]
        internal sealed class _Proxy : DeputyBase, tailscale.Webhook.IWebhookConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The endpoint to send webhook events to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/webhook#endpoint_url Webhook#endpoint_url}
            /// </remarks>
            [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The set of events that trigger this webhook. For a full list of event types, see the [webhooks documentation](https://tailscale.com/kb/1213/webhooks#events).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/webhook#subscriptions Webhook#subscriptions}
            /// </remarks>
            [JsiiProperty(name: "subscriptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subscriptions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The provider type of the endpoint URL.</summary>
            /// <remarks>
            /// This determines the payload format sent to the destination. Valid values are <c>slack</c>, <c>mattermost</c>, <c>googlechat</c>, and <c>discord</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/webhook#provider_type Webhook#provider_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProviderType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}

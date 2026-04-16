using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.WebhookEndpoint
{
    [JsiiInterface(nativeType: typeof(IWebhookEndpointConfig), fullyQualifiedName: "stripe.webhookEndpoint.WebhookEndpointConfig")]
    public interface IWebhookEndpointConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The list of events to enable for this endpoint.</summary>
        /// <remarks>
        /// You may specify <c>['*']</c> to enable all events, except those that require explicit selection.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#enabled_events WebhookEndpoint#enabled_events}
        /// </remarks>
        [JsiiProperty(name: "enabledEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] EnabledEvents
        {
            get;
        }

        /// <summary>The URL of the webhook endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#url WebhookEndpoint#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>Events sent to this endpoint will be generated with this Stripe Version instead of your account's default Stripe Version.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#api_version WebhookEndpoint#api_version}
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this endpoint should receive events from connected accounts (`true`), or from your account (`false`). Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#connect WebhookEndpoint#connect}
        /// </remarks>
        [JsiiProperty(name: "connect", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Connect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#description WebhookEndpoint#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#metadata WebhookEndpoint#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebhookEndpointConfig), fullyQualifiedName: "stripe.webhookEndpoint.WebhookEndpointConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.WebhookEndpoint.IWebhookEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The list of events to enable for this endpoint.</summary>
            /// <remarks>
            /// You may specify <c>['*']</c> to enable all events, except those that require explicit selection.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#enabled_events WebhookEndpoint#enabled_events}
            /// </remarks>
            [JsiiProperty(name: "enabledEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] EnabledEvents
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>The URL of the webhook endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#url WebhookEndpoint#url}
            /// </remarks>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Events sent to this endpoint will be generated with this Stripe Version instead of your account's default Stripe Version.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#api_version WebhookEndpoint#api_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether this endpoint should receive events from connected accounts (`true`), or from your account (`false`). Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#connect WebhookEndpoint#connect}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connect", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Connect
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#description WebhookEndpoint#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/webhook_endpoint#metadata WebhookEndpoint#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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

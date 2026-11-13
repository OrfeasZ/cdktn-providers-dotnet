using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    [JsiiInterface(nativeType: typeof(IV2CoreEventDestinationConfig), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestinationConfig")]
    public interface IV2CoreEventDestinationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The list of event types enabled for delivery to this destination.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#enabled_events V2CoreEventDestination#enabled_events}
        /// </remarks>
        [JsiiProperty(name: "enabledEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] EnabledEvents
        {
            get;
        }

        /// <summary>Whether to deliver as snapshot or thin events.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#event_payload V2CoreEventDestination#event_payload}
        /// </remarks>
        [JsiiProperty(name: "eventPayload", typeJson: "{\"primitive\":\"string\"}")]
        string EventPayload
        {
            get;
        }

        /// <summary>A user-defined label for identifying the destination in Stripe.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#name V2CoreEventDestination#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The delivery transport. Chosen when the destination is created and cannot be changed by update.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#type V2CoreEventDestination#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>amazon_eventbridge block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#amazon_eventbridge V2CoreEventDestination#amazon_eventbridge}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "amazonEventbridge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AmazonEventbridge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configuration for delivering events through an Azure Event Grid partner topic.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#azure_event_grid V2CoreEventDestination#azure_event_grid}
        /// </remarks>
        [JsiiProperty(name: "azureEventGrid", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAzureEventGrid\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.V2CoreEventDestination.IV2CoreEventDestinationAzureEventGrid? AzureEventGrid
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional user-defined description of the destination's purpose.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#description V2CoreEventDestination#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies which accounts' events route to this destination.</summary>
        /// <remarks>
        /// <c>@self</c>: Receive events from the account that owns the event destination.
        /// <c>@accounts</c>: Receive events emitted from other accounts you manage which includes your v1 and v2 accounts.
        /// <c>@organization_members</c>: Receive events from accounts directly linked to the organization.
        /// <c>@organization_members/@accounts</c>: Receive events from all accounts connected to any platform accounts in the organization.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#events_from V2CoreEventDestination#events_from}
        /// </remarks>
        [JsiiProperty(name: "eventsFrom", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EventsFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include normally redacted webhook fields in the create response.</summary>
        /// <remarks>
        /// Public API clients must include <c>webhook_endpoint.signing_secret</c> to receive the signing secret.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#include V2CoreEventDestination#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Include
        {
            get
            {
                return null;
            }
        }

        /// <summary>User-defined key/value data for the destination; it has no effect on event matching or delivery.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#metadata V2CoreEventDestination#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>For snapshot events only, the Stripe API version used to render event objects.</summary>
        /// <remarks>
        /// You can't change this value after you create the event destination. Thin events are not pinned to an API version.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#snapshot_api_version V2CoreEventDestination#snapshot_api_version}
        /// </remarks>
        [JsiiProperty(name: "snapshotApiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnapshotApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>webhook_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#webhook_endpoint V2CoreEventDestination#webhook_endpoint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "webhookEndpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WebhookEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IV2CoreEventDestinationConfig), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.V2CoreEventDestination.IV2CoreEventDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The list of event types enabled for delivery to this destination.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#enabled_events V2CoreEventDestination#enabled_events}
            /// </remarks>
            [JsiiProperty(name: "enabledEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] EnabledEvents
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Whether to deliver as snapshot or thin events.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#event_payload V2CoreEventDestination#event_payload}
            /// </remarks>
            [JsiiProperty(name: "eventPayload", typeJson: "{\"primitive\":\"string\"}")]
            public string EventPayload
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A user-defined label for identifying the destination in Stripe.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#name V2CoreEventDestination#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The delivery transport. Chosen when the destination is created and cannot be changed by update.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#type V2CoreEventDestination#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>amazon_eventbridge block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#amazon_eventbridge V2CoreEventDestination#amazon_eventbridge}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amazonEventbridge", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AmazonEventbridge
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configuration for delivering events through an Azure Event Grid partner topic.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#azure_event_grid V2CoreEventDestination#azure_event_grid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureEventGrid", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAzureEventGrid\"}", isOptional: true)]
            public stripe.V2CoreEventDestination.IV2CoreEventDestinationAzureEventGrid? AzureEventGrid
            {
                get => GetInstanceProperty<stripe.V2CoreEventDestination.IV2CoreEventDestinationAzureEventGrid?>();
            }

            /// <summary>An optional user-defined description of the destination's purpose.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#description V2CoreEventDestination#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies which accounts' events route to this destination.</summary>
            /// <remarks>
            /// <c>@self</c>: Receive events from the account that owns the event destination.
            /// <c>@accounts</c>: Receive events emitted from other accounts you manage which includes your v1 and v2 accounts.
            /// <c>@organization_members</c>: Receive events from accounts directly linked to the organization.
            /// <c>@organization_members/@accounts</c>: Receive events from all accounts connected to any platform accounts in the organization.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#events_from V2CoreEventDestination#events_from}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventsFrom", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EventsFrom
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Include normally redacted webhook fields in the create response.</summary>
            /// <remarks>
            /// Public API clients must include <c>webhook_endpoint.signing_secret</c> to receive the signing secret.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#include V2CoreEventDestination#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Include
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>User-defined key/value data for the destination; it has no effect on event matching or delivery.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#metadata V2CoreEventDestination#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>For snapshot events only, the Stripe API version used to render event objects.</summary>
            /// <remarks>
            /// You can't change this value after you create the event destination. Thin events are not pinned to an API version.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#snapshot_api_version V2CoreEventDestination#snapshot_api_version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotApiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnapshotApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>webhook_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_core_event_destination#webhook_endpoint V2CoreEventDestination#webhook_endpoint}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhookEndpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WebhookEndpoint
            {
                get => GetInstanceProperty<object?>();
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

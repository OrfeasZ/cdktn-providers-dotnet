using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridNamespace
{
    [JsiiInterface(nativeType: typeof(IEventgridNamespaceTopicSpacesConfiguration), fullyQualifiedName: "azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfiguration")]
    public interface IEventgridNamespaceTopicSpacesConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#alternative_authentication_name_source EventgridNamespace#alternative_authentication_name_source}.</summary>
        [JsiiProperty(name: "alternativeAuthenticationNameSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AlternativeAuthenticationNameSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamic_routing_enrichment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#dynamic_routing_enrichment EventgridNamespace#dynamic_routing_enrichment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "dynamicRoutingEnrichment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DynamicRoutingEnrichment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#maximum_client_sessions_per_authentication_name EventgridNamespace#maximum_client_sessions_per_authentication_name}.</summary>
        [JsiiProperty(name: "maximumClientSessionsPerAuthenticationName", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumClientSessionsPerAuthenticationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#maximum_session_expiry_in_hours EventgridNamespace#maximum_session_expiry_in_hours}.</summary>
        [JsiiProperty(name: "maximumSessionExpiryInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumSessionExpiryInHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#route_topic_id EventgridNamespace#route_topic_id}.</summary>
        [JsiiProperty(name: "routeTopicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteTopicId
        {
            get
            {
                return null;
            }
        }

        /// <summary>static_routing_enrichment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#static_routing_enrichment EventgridNamespace#static_routing_enrichment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "staticRoutingEnrichment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StaticRoutingEnrichment
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventgridNamespaceTopicSpacesConfiguration), fullyQualifiedName: "azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#alternative_authentication_name_source EventgridNamespace#alternative_authentication_name_source}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alternativeAuthenticationNameSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AlternativeAuthenticationNameSource
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>dynamic_routing_enrichment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#dynamic_routing_enrichment EventgridNamespace#dynamic_routing_enrichment}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamicRoutingEnrichment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DynamicRoutingEnrichment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#maximum_client_sessions_per_authentication_name EventgridNamespace#maximum_client_sessions_per_authentication_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumClientSessionsPerAuthenticationName", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumClientSessionsPerAuthenticationName
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#maximum_session_expiry_in_hours EventgridNamespace#maximum_session_expiry_in_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumSessionExpiryInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumSessionExpiryInHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#route_topic_id EventgridNamespace#route_topic_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeTopicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteTopicId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>static_routing_enrichment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#static_routing_enrichment EventgridNamespace#static_routing_enrichment}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "staticRoutingEnrichment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StaticRoutingEnrichment
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

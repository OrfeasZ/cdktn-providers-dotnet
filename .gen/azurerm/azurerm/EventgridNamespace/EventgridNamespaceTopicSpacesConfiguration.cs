using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridNamespace
{
    [JsiiByValue(fqn: "azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfiguration")]
    public class EventgridNamespaceTopicSpacesConfiguration : azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#alternative_authentication_name_source EventgridNamespace#alternative_authentication_name_source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alternativeAuthenticationNameSource", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AlternativeAuthenticationNameSource
        {
            get;
            set;
        }

        private object? _dynamicRoutingEnrichment;

        /// <summary>dynamic_routing_enrichment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#dynamic_routing_enrichment EventgridNamespace#dynamic_routing_enrichment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicRoutingEnrichment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DynamicRoutingEnrichment
        {
            get => _dynamicRoutingEnrichment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationDynamicRoutingEnrichment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dynamicRoutingEnrichment = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#maximum_client_sessions_per_authentication_name EventgridNamespace#maximum_client_sessions_per_authentication_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumClientSessionsPerAuthenticationName", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumClientSessionsPerAuthenticationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#maximum_session_expiry_in_hours EventgridNamespace#maximum_session_expiry_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumSessionExpiryInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumSessionExpiryInHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#route_topic_id EventgridNamespace#route_topic_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routeTopicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RouteTopicId
        {
            get;
            set;
        }

        private object? _staticRoutingEnrichment;

        /// <summary>static_routing_enrichment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/eventgrid_namespace#static_routing_enrichment EventgridNamespace#static_routing_enrichment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "staticRoutingEnrichment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridNamespace.EventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StaticRoutingEnrichment
        {
            get => _staticRoutingEnrichment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventgridNamespace.IEventgridNamespaceTopicSpacesConfigurationStaticRoutingEnrichment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _staticRoutingEnrichment = value;
            }
        }
    }
}

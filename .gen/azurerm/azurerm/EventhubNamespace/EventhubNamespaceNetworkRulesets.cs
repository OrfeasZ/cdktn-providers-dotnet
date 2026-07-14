using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventhubNamespace
{
    [JsiiByValue(fqn: "azurerm.eventhubNamespace.EventhubNamespaceNetworkRulesets")]
    public class EventhubNamespaceNetworkRulesets : azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventhub_namespace#default_action EventhubNamespace#default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAction
        {
            get;
            set;
        }

        private object? _ipRule;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventhub_namespace#ip_rule EventhubNamespace#ip_rule}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsIpRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventhubNamespace.EventhubNamespaceNetworkRulesetsIpRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IpRule
        {
            get => _ipRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsIpRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsIpRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ipRule = value;
            }
        }

        private object? _publicNetworkAccessEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventhub_namespace#public_network_access_enabled EventhubNamespace#public_network_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PublicNetworkAccessEnabled
        {
            get => _publicNetworkAccessEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _publicNetworkAccessEnabled = value;
            }
        }

        private object? _trustedServiceAccessEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventhub_namespace#trusted_service_access_enabled EventhubNamespace#trusted_service_access_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustedServiceAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TrustedServiceAccessEnabled
        {
            get => _trustedServiceAccessEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _trustedServiceAccessEnabled = value;
            }
        }

        private object? _virtualNetworkRule;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/eventhub_namespace#virtual_network_rule EventhubNamespace#virtual_network_rule}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsVirtualNetworkRule" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventhubNamespace.EventhubNamespaceNetworkRulesetsVirtualNetworkRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualNetworkRule
        {
            get => _virtualNetworkRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsVirtualNetworkRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsVirtualNetworkRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualNetworkRule = value;
            }
        }
    }
}

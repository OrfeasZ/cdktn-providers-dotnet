using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServicebusNamespace
{
    [JsiiByValue(fqn: "azurerm.servicebusNamespace.ServicebusNamespaceNetworkRuleSet")]
    public class ServicebusNamespaceNetworkRuleSet : azurerm.ServicebusNamespace.IServicebusNamespaceNetworkRuleSet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/servicebus_namespace#default_action ServicebusNamespace#default_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/servicebus_namespace#ip_rules ServicebusNamespace#ip_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpRules
        {
            get;
            set;
        }

        private object? _networkRules;

        /// <summary>network_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/servicebus_namespace#network_rules ServicebusNamespace#network_rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ServicebusNamespace.IServicebusNamespaceNetworkRuleSetNetworkRules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.servicebusNamespace.ServicebusNamespaceNetworkRuleSetNetworkRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkRules
        {
            get => _networkRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ServicebusNamespace.IServicebusNamespaceNetworkRuleSetNetworkRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ServicebusNamespace.IServicebusNamespaceNetworkRuleSetNetworkRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkRules = value;
            }
        }

        private object? _publicNetworkAccessEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/servicebus_namespace#public_network_access_enabled ServicebusNamespace#public_network_access_enabled}.</summary>
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

        private object? _trustedServicesAllowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/servicebus_namespace#trusted_services_allowed ServicebusNamespace#trusted_services_allowed}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trustedServicesAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? TrustedServicesAllowed
        {
            get => _trustedServicesAllowed;
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
                _trustedServicesAllowed = value;
            }
        }
    }
}

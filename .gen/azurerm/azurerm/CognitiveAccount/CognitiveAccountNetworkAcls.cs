using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CognitiveAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cognitiveAccount.CognitiveAccountNetworkAcls")]
    public class CognitiveAccountNetworkAcls : azurerm.CognitiveAccount.ICognitiveAccountNetworkAcls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#default_action CognitiveAccount#default_action}.</summary>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#bypass CognitiveAccount#bypass}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bypass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Bypass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#ip_rules CognitiveAccount#ip_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipRules", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpRules
        {
            get;
            set;
        }

        private object? _virtualNetworkRules;

        /// <summary>virtual_network_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/cognitive_account#virtual_network_rules CognitiveAccount#virtual_network_rules}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cognitiveAccount.CognitiveAccountNetworkAclsVirtualNetworkRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualNetworkRules
        {
            get => _virtualNetworkRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CognitiveAccount.ICognitiveAccountNetworkAclsVirtualNetworkRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualNetworkRules = value;
            }
        }
    }
}

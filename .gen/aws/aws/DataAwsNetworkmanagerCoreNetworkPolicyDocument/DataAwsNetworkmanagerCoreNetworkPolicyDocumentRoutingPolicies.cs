using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPolicies")]
    public class DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPolicies : aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPolicies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_direction DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_direction}.</summary>
        [JsiiProperty(name: "routingPolicyDirection", typeJson: "{\"primitive\":\"string\"}")]
        public string RoutingPolicyDirection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_name DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_name}.</summary>
        [JsiiProperty(name: "routingPolicyName", typeJson: "{\"primitive\":\"string\"}")]
        public string RoutingPolicyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_number DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_number}.</summary>
        [JsiiProperty(name: "routingPolicyNumber", typeJson: "{\"primitive\":\"number\"}")]
        public double RoutingPolicyNumber
        {
            get;
            set;
        }

        private object _routingPolicyRules;

        /// <summary>routing_policy_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_rules DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_rules}
        /// </remarks>
        [JsiiProperty(name: "routingPolicyRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules\"},\"kind\":\"array\"}}]}}")]
        public object RoutingPolicyRules
        {
            get => _routingPolicyRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routingPolicyRules = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_description DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingPolicyDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingPolicyDescription
        {
            get;
            set;
        }
    }
}

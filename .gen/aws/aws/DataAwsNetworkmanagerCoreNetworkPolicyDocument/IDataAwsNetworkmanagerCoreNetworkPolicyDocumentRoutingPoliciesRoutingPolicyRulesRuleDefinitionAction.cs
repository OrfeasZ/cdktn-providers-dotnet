using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction")]
    public interface IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#type DataAwsNetworkmanagerCoreNetworkPolicyDocument#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#value DataAwsNetworkmanagerCoreNetworkPolicyDocument#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentRoutingPoliciesRoutingPolicyRulesRuleDefinitionAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#type DataAwsNetworkmanagerCoreNetworkPolicyDocument#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#value DataAwsNetworkmanagerCoreNetworkPolicyDocument#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

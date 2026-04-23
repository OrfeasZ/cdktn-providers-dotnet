using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentAttachmentRoutingPolicyRulesAction), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentAttachmentRoutingPolicyRulesAction")]
    public interface IDataAwsNetworkmanagerCoreNetworkPolicyDocumentAttachmentRoutingPolicyRulesAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#associate_routing_policies DataAwsNetworkmanagerCoreNetworkPolicyDocument#associate_routing_policies}.</summary>
        [JsiiProperty(name: "associateRoutingPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AssociateRoutingPolicies
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentAttachmentRoutingPolicyRulesAction), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentAttachmentRoutingPolicyRulesAction")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentAttachmentRoutingPolicyRulesAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#associate_routing_policies DataAwsNetworkmanagerCoreNetworkPolicyDocument#associate_routing_policies}.</summary>
            [JsiiProperty(name: "associateRoutingPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AssociateRoutingPolicies
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

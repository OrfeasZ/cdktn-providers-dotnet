using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation")]
    public interface IDataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#edge_location DataAwsNetworkmanagerCoreNetworkPolicyDocument#edge_location}.</summary>
        [JsiiProperty(name: "edgeLocation", typeJson: "{\"primitive\":\"string\"}")]
        string EdgeLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#peer_edge_location DataAwsNetworkmanagerCoreNetworkPolicyDocument#peer_edge_location}.</summary>
        [JsiiProperty(name: "peerEdgeLocation", typeJson: "{\"primitive\":\"string\"}")]
        string PeerEdgeLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_names DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_names}.</summary>
        [JsiiProperty(name: "routingPolicyNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] RoutingPolicyNames
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation), fullyQualifiedName: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#edge_location DataAwsNetworkmanagerCoreNetworkPolicyDocument#edge_location}.</summary>
            [JsiiProperty(name: "edgeLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string EdgeLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#peer_edge_location DataAwsNetworkmanagerCoreNetworkPolicyDocument#peer_edge_location}.</summary>
            [JsiiProperty(name: "peerEdgeLocation", typeJson: "{\"primitive\":\"string\"}")]
            public string PeerEdgeLocation
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_names DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_names}.</summary>
            [JsiiProperty(name: "routingPolicyNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] RoutingPolicyNames
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

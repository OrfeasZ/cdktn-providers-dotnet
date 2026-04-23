using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsNetworkmanagerCoreNetworkPolicyDocument.DataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation")]
    public class DataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation : aws.DataAwsNetworkmanagerCoreNetworkPolicyDocument.IDataAwsNetworkmanagerCoreNetworkPolicyDocumentSegmentActionsEdgeLocationAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#edge_location DataAwsNetworkmanagerCoreNetworkPolicyDocument#edge_location}.</summary>
        [JsiiProperty(name: "edgeLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string EdgeLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#peer_edge_location DataAwsNetworkmanagerCoreNetworkPolicyDocument#peer_edge_location}.</summary>
        [JsiiProperty(name: "peerEdgeLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string PeerEdgeLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/data-sources/networkmanager_core_network_policy_document#routing_policy_names DataAwsNetworkmanagerCoreNetworkPolicyDocument#routing_policy_names}.</summary>
        [JsiiProperty(name: "routingPolicyNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] RoutingPolicyNames
        {
            get;
            set;
        }
    }
}

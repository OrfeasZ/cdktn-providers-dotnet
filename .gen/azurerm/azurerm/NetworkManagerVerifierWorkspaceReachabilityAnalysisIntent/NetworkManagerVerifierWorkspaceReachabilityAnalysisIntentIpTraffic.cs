using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic")]
    public class NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic : azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_ips NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_ips}.</summary>
        [JsiiProperty(name: "destinationIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DestinationIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_ports NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_ports}.</summary>
        [JsiiProperty(name: "destinationPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] DestinationPorts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#protocols NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Protocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_ips NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_ips}.</summary>
        [JsiiProperty(name: "sourceIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SourceIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_ports NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_ports}.</summary>
        [JsiiProperty(name: "sourcePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SourcePorts
        {
            get;
            set;
        }
    }
}

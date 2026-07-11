using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent
{
    [JsiiInterface(nativeType: typeof(INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic), fullyQualifiedName: "azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic")]
    public interface INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_ips NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_ips}.</summary>
        [JsiiProperty(name: "destinationIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DestinationIps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_ports NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_ports}.</summary>
        [JsiiProperty(name: "destinationPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DestinationPorts
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#protocols NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#protocols}.</summary>
        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Protocols
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_ips NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_ips}.</summary>
        [JsiiProperty(name: "sourceIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SourceIps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_ports NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_ports}.</summary>
        [JsiiProperty(name: "sourcePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SourcePorts
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic), fullyQualifiedName: "azurerm.networkManagerVerifierWorkspaceReachabilityAnalysisIntent.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.INetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTraffic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_ips NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_ips}.</summary>
            [JsiiProperty(name: "destinationIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DestinationIps
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#destination_ports NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#destination_ports}.</summary>
            [JsiiProperty(name: "destinationPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DestinationPorts
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#protocols NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#protocols}.</summary>
            [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Protocols
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_ips NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_ips}.</summary>
            [JsiiProperty(name: "sourceIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SourceIps
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/network_manager_verifier_workspace_reachability_analysis_intent#source_ports NetworkManagerVerifierWorkspaceReachabilityAnalysisIntent#source_ports}.</summary>
            [JsiiProperty(name: "sourcePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SourcePorts
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

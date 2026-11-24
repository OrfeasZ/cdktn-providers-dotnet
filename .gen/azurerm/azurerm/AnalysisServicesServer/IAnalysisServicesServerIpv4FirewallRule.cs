using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AnalysisServicesServer
{
    [JsiiInterface(nativeType: typeof(IAnalysisServicesServerIpv4FirewallRule), fullyQualifiedName: "azurerm.analysisServicesServer.AnalysisServicesServerIpv4FirewallRule")]
    public interface IAnalysisServicesServerIpv4FirewallRule
    {
        /// <summary>The name of the firewall rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#name AnalysisServicesServer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>End of the firewall rule range as IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#range_end AnalysisServicesServer#range_end}
        /// </remarks>
        [JsiiProperty(name: "rangeEnd", typeJson: "{\"primitive\":\"string\"}")]
        string RangeEnd
        {
            get;
        }

        /// <summary>Start of the firewall rule range as IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#range_start AnalysisServicesServer#range_start}
        /// </remarks>
        [JsiiProperty(name: "rangeStart", typeJson: "{\"primitive\":\"string\"}")]
        string RangeStart
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAnalysisServicesServerIpv4FirewallRule), fullyQualifiedName: "azurerm.analysisServicesServer.AnalysisServicesServerIpv4FirewallRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.AnalysisServicesServer.IAnalysisServicesServerIpv4FirewallRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the firewall rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#name AnalysisServicesServer#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>End of the firewall rule range as IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#range_end AnalysisServicesServer#range_end}
            /// </remarks>
            [JsiiProperty(name: "rangeEnd", typeJson: "{\"primitive\":\"string\"}")]
            public string RangeEnd
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Start of the firewall rule range as IPv4 address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#range_start AnalysisServicesServer#range_start}
            /// </remarks>
            [JsiiProperty(name: "rangeStart", typeJson: "{\"primitive\":\"string\"}")]
            public string RangeStart
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

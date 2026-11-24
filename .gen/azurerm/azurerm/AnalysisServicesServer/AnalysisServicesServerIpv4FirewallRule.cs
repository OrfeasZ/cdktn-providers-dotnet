using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AnalysisServicesServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.analysisServicesServer.AnalysisServicesServerIpv4FirewallRule")]
    public class AnalysisServicesServerIpv4FirewallRule : azurerm.AnalysisServicesServer.IAnalysisServicesServerIpv4FirewallRule
    {
        /// <summary>The name of the firewall rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#name AnalysisServicesServer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>End of the firewall rule range as IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#range_end AnalysisServicesServer#range_end}
        /// </remarks>
        [JsiiProperty(name: "rangeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public string RangeEnd
        {
            get;
            set;
        }

        /// <summary>Start of the firewall rule range as IPv4 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/analysis_services_server#range_start AnalysisServicesServer#range_start}
        /// </remarks>
        [JsiiProperty(name: "rangeStart", typeJson: "{\"primitive\":\"string\"}")]
        public string RangeStart
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsAgentPools
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsAgentPools.DataAzuredevopsAgentPoolsTimeouts")]
    public class DataAzuredevopsAgentPoolsTimeouts : azuredevops.DataAzuredevopsAgentPools.IDataAzuredevopsAgentPoolsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/agent_pools#read DataAzuredevopsAgentPools#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

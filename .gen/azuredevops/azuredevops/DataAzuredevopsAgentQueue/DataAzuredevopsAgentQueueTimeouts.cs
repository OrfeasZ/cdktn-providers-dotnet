using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsAgentQueue
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsAgentQueue.DataAzuredevopsAgentQueueTimeouts")]
    public class DataAzuredevopsAgentQueueTimeouts : azuredevops.DataAzuredevopsAgentQueue.IDataAzuredevopsAgentQueueTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/agent_queue#read DataAzuredevopsAgentQueue#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

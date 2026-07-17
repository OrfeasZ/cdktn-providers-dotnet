using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsAgentQueue
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsAgentQueueTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsAgentQueue.DataAzuredevopsAgentQueueTimeouts")]
    public interface IDataAzuredevopsAgentQueueTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/agent_queue#read DataAzuredevopsAgentQueue#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsAgentQueueTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsAgentQueue.DataAzuredevopsAgentQueueTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsAgentQueue.IDataAzuredevopsAgentQueueTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/agent_queue#read DataAzuredevopsAgentQueue#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

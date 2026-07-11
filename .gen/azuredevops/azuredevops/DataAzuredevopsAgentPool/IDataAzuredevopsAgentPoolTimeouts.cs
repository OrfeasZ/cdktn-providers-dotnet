using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsAgentPool
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsAgentPoolTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsAgentPool.DataAzuredevopsAgentPoolTimeouts")]
    public interface IDataAzuredevopsAgentPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/agent_pool#read DataAzuredevopsAgentPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsAgentPoolTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsAgentPool.DataAzuredevopsAgentPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsAgentPool.IDataAzuredevopsAgentPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/agent_pool#read DataAzuredevopsAgentPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

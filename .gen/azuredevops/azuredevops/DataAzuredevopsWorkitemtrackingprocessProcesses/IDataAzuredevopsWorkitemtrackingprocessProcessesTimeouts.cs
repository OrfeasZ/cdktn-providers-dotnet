using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessProcessesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesTimeouts")]
    public interface IDataAzuredevopsWorkitemtrackingprocessProcessesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/workitemtrackingprocess_processes#read DataAzuredevopsWorkitemtrackingprocessProcesses#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessProcessesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessProcesses.DataAzuredevopsWorkitemtrackingprocessProcessesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsWorkitemtrackingprocessProcesses.IDataAzuredevopsWorkitemtrackingprocessProcessesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/workitemtrackingprocess_processes#read DataAzuredevopsWorkitemtrackingprocessProcesses#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

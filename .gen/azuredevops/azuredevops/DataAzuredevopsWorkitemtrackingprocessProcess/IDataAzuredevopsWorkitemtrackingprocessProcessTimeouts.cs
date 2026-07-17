using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsWorkitemtrackingprocessProcess
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessProcessTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessProcess.DataAzuredevopsWorkitemtrackingprocessProcessTimeouts")]
    public interface IDataAzuredevopsWorkitemtrackingprocessProcessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/workitemtrackingprocess_process#read DataAzuredevopsWorkitemtrackingprocessProcess#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessProcessTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessProcess.DataAzuredevopsWorkitemtrackingprocessProcessTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsWorkitemtrackingprocessProcess.IDataAzuredevopsWorkitemtrackingprocessProcessTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/workitemtrackingprocess_process#read DataAzuredevopsWorkitemtrackingprocessProcess#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtype
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessWorkitemtypeTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessWorkitemtype.DataAzuredevopsWorkitemtrackingprocessWorkitemtypeTimeouts")]
    public interface IDataAzuredevopsWorkitemtrackingprocessWorkitemtypeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/workitemtrackingprocess_workitemtype#read DataAzuredevopsWorkitemtrackingprocessWorkitemtype#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessWorkitemtypeTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessWorkitemtype.DataAzuredevopsWorkitemtrackingprocessWorkitemtypeTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtype.IDataAzuredevopsWorkitemtrackingprocessWorkitemtypeTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/workitemtrackingprocess_workitemtype#read DataAzuredevopsWorkitemtrackingprocessWorkitemtype#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

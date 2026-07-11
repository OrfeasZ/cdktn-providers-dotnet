using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtypes
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessWorkitemtypesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessWorkitemtypes.DataAzuredevopsWorkitemtrackingprocessWorkitemtypesTimeouts")]
    public interface IDataAzuredevopsWorkitemtrackingprocessWorkitemtypesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/workitemtrackingprocess_workitemtypes#read DataAzuredevopsWorkitemtrackingprocessWorkitemtypes#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsWorkitemtrackingprocessWorkitemtypesTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsWorkitemtrackingprocessWorkitemtypes.DataAzuredevopsWorkitemtrackingprocessWorkitemtypesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsWorkitemtrackingprocessWorkitemtypes.IDataAzuredevopsWorkitemtrackingprocessWorkitemtypesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/workitemtrackingprocess_workitemtypes#read DataAzuredevopsWorkitemtrackingprocessWorkitemtypes#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsArea
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsAreaTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsArea.DataAzuredevopsAreaTimeouts")]
    public interface IDataAzuredevopsAreaTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/area#read DataAzuredevopsArea#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsAreaTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsArea.DataAzuredevopsAreaTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsArea.IDataAzuredevopsAreaTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/area#read DataAzuredevopsArea#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsProject
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsProjectTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsProject.DataAzuredevopsProjectTimeouts")]
    public interface IDataAzuredevopsProjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/project#read DataAzuredevopsProject#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsProjectTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsProject.DataAzuredevopsProjectTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsProject.IDataAzuredevopsProjectTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/project#read DataAzuredevopsProject#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

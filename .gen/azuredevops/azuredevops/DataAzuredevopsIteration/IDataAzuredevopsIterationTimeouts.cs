using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsIteration
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsIterationTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsIteration.DataAzuredevopsIterationTimeouts")]
    public interface IDataAzuredevopsIterationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/iteration#read DataAzuredevopsIteration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsIterationTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsIteration.DataAzuredevopsIterationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsIteration.IDataAzuredevopsIterationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/iteration#read DataAzuredevopsIteration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

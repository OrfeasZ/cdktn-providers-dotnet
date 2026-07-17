using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsUser
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsUserTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsUser.DataAzuredevopsUserTimeouts")]
    public interface IDataAzuredevopsUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/user#read DataAzuredevopsUser#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsUserTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsUser.DataAzuredevopsUserTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsUser.IDataAzuredevopsUserTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/data-sources/user#read DataAzuredevopsUser#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsUsers
{
    [JsiiInterface(nativeType: typeof(IDataAzuredevopsUsersTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersTimeouts")]
    public interface IDataAzuredevopsUsersTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/users#read DataAzuredevopsUsers#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzuredevopsUsersTimeouts), fullyQualifiedName: "azuredevops.dataAzuredevopsUsers.DataAzuredevopsUsersTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuredevops.DataAzuredevopsUsers.IDataAzuredevopsUsersTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/users#read DataAzuredevopsUsers#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

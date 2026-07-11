using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackKeyVault
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackKeyVaultTimeouts), fullyQualifiedName: "azurestack.dataAzurestackKeyVault.DataAzurestackKeyVaultTimeouts")]
    public interface IDataAzurestackKeyVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault#read DataAzurestackKeyVault#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackKeyVaultTimeouts), fullyQualifiedName: "azurestack.dataAzurestackKeyVault.DataAzurestackKeyVaultTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackKeyVault.IDataAzurestackKeyVaultTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault#read DataAzurestackKeyVault#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

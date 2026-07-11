using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackKeyVaultAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurestackKeyVaultAccessPolicyTimeouts), fullyQualifiedName: "azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeouts")]
    public interface IDataAzurestackKeyVaultAccessPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_access_policy#read DataAzurestackKeyVaultAccessPolicyA#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurestackKeyVaultAccessPolicyTimeouts), fullyQualifiedName: "azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurestack.DataAzurestackKeyVaultAccessPolicy.IDataAzurestackKeyVaultAccessPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_access_policy#read DataAzurestackKeyVaultAccessPolicyA#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

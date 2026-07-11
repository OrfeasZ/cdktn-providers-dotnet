using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackKeyVaultKey
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackKeyVaultKey.DataAzurestackKeyVaultKeyTimeouts")]
    public class DataAzurestackKeyVaultKeyTimeouts : azurestack.DataAzurestackKeyVaultKey.IDataAzurestackKeyVaultKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_key#read DataAzurestackKeyVaultKey#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

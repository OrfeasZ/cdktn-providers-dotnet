using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackKeyVaultSecret
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackKeyVaultSecret.DataAzurestackKeyVaultSecretTimeouts")]
    public class DataAzurestackKeyVaultSecretTimeouts : azurestack.DataAzurestackKeyVaultSecret.IDataAzurestackKeyVaultSecretTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_secret#read DataAzurestackKeyVaultSecret#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

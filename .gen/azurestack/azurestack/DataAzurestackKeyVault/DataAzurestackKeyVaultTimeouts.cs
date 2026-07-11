using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackKeyVault
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackKeyVault.DataAzurestackKeyVaultTimeouts")]
    public class DataAzurestackKeyVaultTimeouts : azurestack.DataAzurestackKeyVault.IDataAzurestackKeyVaultTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault#read DataAzurestackKeyVault#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

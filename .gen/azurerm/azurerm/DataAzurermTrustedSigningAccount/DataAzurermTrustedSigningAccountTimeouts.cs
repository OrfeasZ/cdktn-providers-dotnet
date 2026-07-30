using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermTrustedSigningAccount
{
    [JsiiByValue(fqn: "azurerm.dataAzurermTrustedSigningAccount.DataAzurermTrustedSigningAccountTimeouts")]
    public class DataAzurermTrustedSigningAccountTimeouts : azurerm.DataAzurermTrustedSigningAccount.IDataAzurermTrustedSigningAccountTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/trusted_signing_account#read DataAzurermTrustedSigningAccount#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

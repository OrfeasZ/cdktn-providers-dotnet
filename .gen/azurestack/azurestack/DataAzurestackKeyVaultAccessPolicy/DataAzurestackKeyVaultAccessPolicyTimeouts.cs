using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackKeyVaultAccessPolicy
{
    [JsiiByValue(fqn: "azurestack.dataAzurestackKeyVaultAccessPolicy.DataAzurestackKeyVaultAccessPolicyTimeouts")]
    public class DataAzurestackKeyVaultAccessPolicyTimeouts : azurestack.DataAzurestackKeyVaultAccessPolicy.IDataAzurestackKeyVaultAccessPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/data-sources/key_vault_access_policy#read DataAzurestackKeyVaultAccessPolicyA#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

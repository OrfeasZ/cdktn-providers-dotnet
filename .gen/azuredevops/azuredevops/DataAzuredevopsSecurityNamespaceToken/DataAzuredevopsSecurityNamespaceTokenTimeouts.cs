using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsSecurityNamespaceToken
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsSecurityNamespaceToken.DataAzuredevopsSecurityNamespaceTokenTimeouts")]
    public class DataAzuredevopsSecurityNamespaceTokenTimeouts : azuredevops.DataAzuredevopsSecurityNamespaceToken.IDataAzuredevopsSecurityNamespaceTokenTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/security_namespace_token#read DataAzuredevopsSecurityNamespaceToken#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

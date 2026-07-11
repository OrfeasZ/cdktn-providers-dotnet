using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsServicePrincipal
{
    [JsiiByValue(fqn: "azuredevops.dataAzuredevopsServicePrincipal.DataAzuredevopsServicePrincipalTimeouts")]
    public class DataAzuredevopsServicePrincipalTimeouts : azuredevops.DataAzuredevopsServicePrincipal.IDataAzuredevopsServicePrincipalTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/service_principal#read DataAzuredevopsServicePrincipal#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}

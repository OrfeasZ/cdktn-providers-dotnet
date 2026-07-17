using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointAzurecr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointAzurecr.ServiceendpointAzurecrCredentials")]
    public class ServiceendpointAzurecrCredentials : azuredevops.ServiceendpointAzurecr.IServiceendpointAzurecrCredentials
    {
        /// <summary>The service principal id which should be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_azurecr#serviceprincipalid ServiceendpointAzurecr#serviceprincipalid}
        /// </remarks>
        [JsiiProperty(name: "serviceprincipalid", typeJson: "{\"primitive\":\"string\"}")]
        public string Serviceprincipalid
        {
            get;
            set;
        }
    }
}

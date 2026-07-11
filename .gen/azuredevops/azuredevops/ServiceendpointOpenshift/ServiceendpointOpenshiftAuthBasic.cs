using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointOpenshift
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthBasic")]
    public class ServiceendpointOpenshiftAuthBasic : azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthBasic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#password ServiceendpointOpenshift#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#username ServiceendpointOpenshift#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}

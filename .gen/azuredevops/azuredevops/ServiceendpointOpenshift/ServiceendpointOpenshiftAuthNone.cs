using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointOpenshift
{
    [JsiiByValue(fqn: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNone")]
    public class ServiceendpointOpenshiftAuthNone : azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#kube_config ServiceendpointOpenshift#kube_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kubeConfig", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KubeConfig
        {
            get;
            set;
        }
    }
}

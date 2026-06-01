using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ContainerTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.containerTrigger.ContainerTriggerDestinationConfig")]
    public class ContainerTriggerDestinationConfig : scaleway.ContainerTrigger.IContainerTriggerDestinationConfig
    {
        /// <summary>The HTTP method to use when sending the request (e.g., get, post, put, patch, delete).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#http_method ContainerTrigger#http_method}
        /// </remarks>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpMethod
        {
            get;
            set;
        }

        /// <summary>The HTTP path to send the request to (e.g., "/my-webhook-endpoint").</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.76.0/docs/resources/container_trigger#http_path ContainerTrigger#http_path}
        /// </remarks>
        [JsiiProperty(name: "httpPath", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpPath
        {
            get;
            set;
        }
    }
}

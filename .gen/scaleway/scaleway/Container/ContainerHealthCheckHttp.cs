using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.container.ContainerHealthCheckHttp")]
    public class ContainerHealthCheckHttp : scaleway.Container.IContainerHealthCheckHttp
    {
        /// <summary>Path to use for the HTTP health check.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/container#path Container#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}

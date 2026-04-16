using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceIp
{
    [JsiiByValue(fqn: "scaleway.instanceIp.InstanceIpTimeouts")]
    public class InstanceIpTimeouts : scaleway.InstanceIp.IInstanceIpTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_ip#default InstanceIp#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}

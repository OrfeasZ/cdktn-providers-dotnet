using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSecurityGroup
{
    [JsiiByValue(fqn: "scaleway.instanceSecurityGroup.InstanceSecurityGroupTimeouts")]
    public class InstanceSecurityGroupTimeouts : scaleway.InstanceSecurityGroup.IInstanceSecurityGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#default InstanceSecurityGroup#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.instanceServer.InstanceServerPrivateNetwork")]
    public class InstanceServerPrivateNetwork : scaleway.InstanceServer.IInstanceServerPrivateNetwork
    {
        /// <summary>The Private Network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#pn_id InstanceServer#pn_id}
        /// </remarks>
        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        public string PnId
        {
            get;
            set;
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#zone InstanceServer#zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zone
        {
            get;
            set;
        }
    }
}

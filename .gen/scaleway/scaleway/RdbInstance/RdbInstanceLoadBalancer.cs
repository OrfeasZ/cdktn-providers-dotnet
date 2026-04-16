using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    [JsiiByValue(fqn: "scaleway.rdbInstance.RdbInstanceLoadBalancer")]
    public class RdbInstanceLoadBalancer : scaleway.RdbInstance.IRdbInstanceLoadBalancer
    {
        /// <summary>The endpoint ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#endpoint_id RdbInstance#endpoint_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointId
        {
            get;
            set;
        }
    }
}

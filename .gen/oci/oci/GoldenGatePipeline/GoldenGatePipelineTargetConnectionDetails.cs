using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGatePipeline.GoldenGatePipelineTargetConnectionDetails")]
    public class GoldenGatePipelineTargetConnectionDetails : oci.GoldenGatePipeline.IGoldenGatePipelineTargetConnectionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#connection_id GoldenGatePipeline#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionId
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParameters")]
    public class CloudwatchEventConnectionAuthParametersConnectivityParameters : aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParameters
    {
        /// <summary>resource_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_event_connection#resource_parameters CloudwatchEventConnection#resource_parameters}
        /// </remarks>
        [JsiiProperty(name: "resourceParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters\"}")]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionAuthParametersConnectivityParametersResourceParameters ResourceParameters
        {
            get;
            set;
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateNetworkPerformanceOptions")]
    public class LaunchTemplateNetworkPerformanceOptions : aws.LaunchTemplate.ILaunchTemplateNetworkPerformanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/launch_template#bandwidth_weighting LaunchTemplate#bandwidth_weighting}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bandwidthWeighting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BandwidthWeighting
        {
            get;
            set;
        }
    }
}

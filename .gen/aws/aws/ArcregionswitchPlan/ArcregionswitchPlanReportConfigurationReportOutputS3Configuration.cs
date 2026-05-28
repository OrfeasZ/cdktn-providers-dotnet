using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutputS3Configuration")]
    public class ArcregionswitchPlanReportConfigurationReportOutputS3Configuration : aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfigurationReportOutputS3Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#bucket_owner ArcregionswitchPlan#bucket_owner}.</summary>
        [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketOwner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#bucket_path ArcregionswitchPlan#bucket_path}.</summary>
        [JsiiProperty(name: "bucketPath", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketPath
        {
            get;
            set;
        }
    }
}

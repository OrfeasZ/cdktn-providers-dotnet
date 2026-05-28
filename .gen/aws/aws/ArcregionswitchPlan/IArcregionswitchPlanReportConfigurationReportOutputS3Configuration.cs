using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiInterface(nativeType: typeof(IArcregionswitchPlanReportConfigurationReportOutputS3Configuration), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutputS3Configuration")]
    public interface IArcregionswitchPlanReportConfigurationReportOutputS3Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#bucket_owner ArcregionswitchPlan#bucket_owner}.</summary>
        [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}")]
        string BucketOwner
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#bucket_path ArcregionswitchPlan#bucket_path}.</summary>
        [JsiiProperty(name: "bucketPath", typeJson: "{\"primitive\":\"string\"}")]
        string BucketPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcregionswitchPlanReportConfigurationReportOutputS3Configuration), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanReportConfigurationReportOutputS3Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.ArcregionswitchPlan.IArcregionswitchPlanReportConfigurationReportOutputS3Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#bucket_owner ArcregionswitchPlan#bucket_owner}.</summary>
            [JsiiProperty(name: "bucketOwner", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketOwner
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/arcregionswitch_plan#bucket_path ArcregionswitchPlan#bucket_path}.</summary>
            [JsiiProperty(name: "bucketPath", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

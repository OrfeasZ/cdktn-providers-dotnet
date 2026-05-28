using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlMultiRegionAccessPointRoutes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlMultiRegionAccessPointRoutes.S3ControlMultiRegionAccessPointRoutesRoute")]
    public class S3ControlMultiRegionAccessPointRoutesRoute : aws.S3ControlMultiRegionAccessPointRoutes.IS3ControlMultiRegionAccessPointRoutesRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/s3control_multi_region_access_point_routes#bucket S3ControlMultiRegionAccessPointRoutes#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/s3control_multi_region_access_point_routes#region S3ControlMultiRegionAccessPointRoutes#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/s3control_multi_region_access_point_routes#traffic_dial_percentage S3ControlMultiRegionAccessPointRoutes#traffic_dial_percentage}.</summary>
        [JsiiProperty(name: "trafficDialPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double TrafficDialPercentage
        {
            get;
            set;
        }
    }
}

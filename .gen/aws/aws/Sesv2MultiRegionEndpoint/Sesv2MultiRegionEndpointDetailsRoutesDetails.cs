using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2MultiRegionEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetailsRoutesDetails")]
    public class Sesv2MultiRegionEndpointDetailsRoutesDetails : aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetailsRoutesDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/sesv2_multi_region_endpoint#region Sesv2MultiRegionEndpoint#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }
    }
}

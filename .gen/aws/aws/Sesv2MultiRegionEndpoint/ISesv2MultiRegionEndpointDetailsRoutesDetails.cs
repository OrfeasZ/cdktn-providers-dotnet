using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2MultiRegionEndpoint
{
    [JsiiInterface(nativeType: typeof(ISesv2MultiRegionEndpointDetailsRoutesDetails), fullyQualifiedName: "aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetailsRoutesDetails")]
    public interface ISesv2MultiRegionEndpointDetailsRoutesDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/sesv2_multi_region_endpoint#region Sesv2MultiRegionEndpoint#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2MultiRegionEndpointDetailsRoutesDetails), fullyQualifiedName: "aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetailsRoutesDetails")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetailsRoutesDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/sesv2_multi_region_endpoint#region Sesv2MultiRegionEndpoint#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2MultiRegionEndpoint
{
    [JsiiByValue(fqn: "aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetails")]
    public class Sesv2MultiRegionEndpointDetails : aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetails
    {
        private object? _routesDetails;

        /// <summary>routes_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/sesv2_multi_region_endpoint#routes_details Sesv2MultiRegionEndpoint#routes_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetailsRoutesDetails" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routesDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetailsRoutesDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RoutesDetails
        {
            get => _routesDetails;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetailsRoutesDetails[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetailsRoutesDetails).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routesDetails = value;
            }
        }
    }
}

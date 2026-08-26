using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2MultiRegionEndpoint
{
    [JsiiInterface(nativeType: typeof(ISesv2MultiRegionEndpointDetails), fullyQualifiedName: "aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetails")]
    public interface ISesv2MultiRegionEndpointDetails
    {
        /// <summary>routes_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/sesv2_multi_region_endpoint#routes_details Sesv2MultiRegionEndpoint#routes_details}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetailsRoutesDetails" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "routesDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetailsRoutesDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoutesDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2MultiRegionEndpointDetails), fullyQualifiedName: "aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetails")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>routes_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/sesv2_multi_region_endpoint#routes_details Sesv2MultiRegionEndpoint#routes_details}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.Sesv2MultiRegionEndpoint.ISesv2MultiRegionEndpointDetailsRoutesDetails" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routesDetails", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sesv2MultiRegionEndpoint.Sesv2MultiRegionEndpointDetailsRoutesDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RoutesDetails
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

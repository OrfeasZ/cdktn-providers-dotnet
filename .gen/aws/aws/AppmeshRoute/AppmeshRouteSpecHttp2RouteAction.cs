using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmeshRoute.AppmeshRouteSpecHttp2RouteAction")]
    public class AppmeshRouteSpecHttp2RouteAction : aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteAction
    {
        private object _weightedTarget;

        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteActionWeightedTarget\"},\"kind\":\"array\"}}]}}")]
        public object WeightedTarget
        {
            get => _weightedTarget;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteActionWeightedTarget[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteActionWeightedTarget).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttp2RouteActionWeightedTarget).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _weightedTarget = value;
            }
        }
    }
}

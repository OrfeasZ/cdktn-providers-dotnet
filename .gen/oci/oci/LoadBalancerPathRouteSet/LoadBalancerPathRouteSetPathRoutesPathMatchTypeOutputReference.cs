using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerPathRouteSet
{
    [JsiiClass(nativeType: typeof(oci.LoadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference), fullyQualifiedName: "oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerPathRouteSetPathRoutesPathMatchTypeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MatchTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "matchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MatchType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.loadBalancerPathRouteSet.LoadBalancerPathRouteSetPathRoutesPathMatchType\"}", isOptional: true)]
        public virtual oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType? InternalValue
        {
            get => GetInstanceProperty<oci.LoadBalancerPathRouteSet.ILoadBalancerPathRouteSetPathRoutesPathMatchType?>();
            set => SetInstanceProperty(value);
        }
    }
}

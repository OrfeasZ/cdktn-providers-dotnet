using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancerPools
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "origin", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOriginOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOriginOutputReference Origin
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOriginOutputReference>()!;
        }

        [JsiiProperty(name: "pool", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterPoolOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterPoolOutputReference Pool
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterPoolOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilter\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.IDataCloudflareLoadBalancerPoolsResultNotificationFilter? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.IDataCloudflareLoadBalancerPoolsResultNotificationFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}

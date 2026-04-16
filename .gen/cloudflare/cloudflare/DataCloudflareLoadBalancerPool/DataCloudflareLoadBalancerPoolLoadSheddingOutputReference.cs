using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancerPool
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolLoadSheddingOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolLoadSheddingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareLoadBalancerPoolLoadSheddingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareLoadBalancerPoolLoadSheddingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareLoadBalancerPoolLoadSheddingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancerPoolLoadSheddingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultPercent
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "defaultPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionPercent
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sessionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolLoadShedding\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolLoadShedding? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolLoadShedding?>();
            set => SetInstanceProperty(value);
        }
    }
}

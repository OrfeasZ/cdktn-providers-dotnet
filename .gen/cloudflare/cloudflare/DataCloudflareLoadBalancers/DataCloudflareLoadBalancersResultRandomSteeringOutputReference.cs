using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultRandomSteeringOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultRandomSteeringOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareLoadBalancersResultRandomSteeringOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareLoadBalancersResultRandomSteeringOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareLoadBalancersResultRandomSteeringOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancersResultRandomSteeringOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultWeight
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "poolWeights", typeJson: "{\"fqn\":\"cdktn.NumberMap\"}")]
        public virtual Io.Cdktn.NumberMap PoolWeights
        {
            get => GetInstanceProperty<Io.Cdktn.NumberMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancers.DataCloudflareLoadBalancersResultRandomSteering\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLoadBalancers.IDataCloudflareLoadBalancersResultRandomSteering? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancers.IDataCloudflareLoadBalancersResultRandomSteering?>();
            set => SetInstanceProperty(value);
        }
    }
}

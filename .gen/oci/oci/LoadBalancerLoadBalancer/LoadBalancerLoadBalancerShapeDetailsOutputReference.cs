using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerLoadBalancer
{
    [JsiiClass(nativeType: typeof(oci.LoadBalancerLoadBalancer.LoadBalancerLoadBalancerShapeDetailsOutputReference), fullyQualifiedName: "oci.loadBalancerLoadBalancer.LoadBalancerLoadBalancerShapeDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoadBalancerLoadBalancerShapeDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoadBalancerLoadBalancerShapeDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LoadBalancerLoadBalancerShapeDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerLoadBalancerShapeDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBandwidthInMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBandwidthInMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumBandwidthInMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumBandwidthInMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maximumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBandwidthInMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumBandwidthInMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.loadBalancerLoadBalancer.LoadBalancerLoadBalancerShapeDetails\"}", isOptional: true)]
        public virtual oci.LoadBalancerLoadBalancer.ILoadBalancerLoadBalancerShapeDetails? InternalValue
        {
            get => GetInstanceProperty<oci.LoadBalancerLoadBalancer.ILoadBalancerLoadBalancerShapeDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

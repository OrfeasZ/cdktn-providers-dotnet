using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiClass(nativeType: typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterLoadBalancerConfigOutputReference), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterLoadBalancerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchOpensearchClusterLoadBalancerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchOpensearchClusterLoadBalancerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchOpensearchClusterLoadBalancerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOpensearchClusterLoadBalancerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLoadBalancerMaxBandwidthInMbps")]
        public virtual void ResetLoadBalancerMaxBandwidthInMbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerMinBandwidthInMbps")]
        public virtual void ResetLoadBalancerMinBandwidthInMbps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerMaxBandwidthInMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoadBalancerMaxBandwidthInMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerMinBandwidthInMbpsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoadBalancerMinBandwidthInMbpsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerServiceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerServiceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "loadBalancerMaxBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoadBalancerMaxBandwidthInMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerMinBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoadBalancerMinBandwidthInMbps
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerServiceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerServiceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterLoadBalancerConfig\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterLoadBalancerConfig? InternalValue
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterLoadBalancerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

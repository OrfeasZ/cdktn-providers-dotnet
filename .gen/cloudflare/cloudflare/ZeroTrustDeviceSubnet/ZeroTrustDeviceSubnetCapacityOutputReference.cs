using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDeviceSubnet
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustDeviceSubnet.ZeroTrustDeviceSubnetCapacityOutputReference), fullyQualifiedName: "cloudflare.zeroTrustDeviceSubnet.ZeroTrustDeviceSubnetCapacityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustDeviceSubnetCapacityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustDeviceSubnetCapacityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustDeviceSubnetCapacityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustDeviceSubnetCapacityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Total
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "used", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Used
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDeviceSubnet.ZeroTrustDeviceSubnetCapacity\"}", isOptional: true)]
        public virtual cloudflare.ZeroTrustDeviceSubnet.IZeroTrustDeviceSubnetCapacity? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustDeviceSubnet.IZeroTrustDeviceSubnetCapacity?>();
            set => SetInstanceProperty(value);
        }
    }
}

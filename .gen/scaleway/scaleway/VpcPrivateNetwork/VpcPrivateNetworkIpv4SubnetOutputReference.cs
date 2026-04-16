using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPrivateNetwork
{
    [JsiiClass(nativeType: typeof(scaleway.VpcPrivateNetwork.VpcPrivateNetworkIpv4SubnetOutputReference), fullyQualifiedName: "scaleway.vpcPrivateNetwork.VpcPrivateNetworkIpv4SubnetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpcPrivateNetworkIpv4SubnetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpcPrivateNetworkIpv4SubnetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpcPrivateNetworkIpv4SubnetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPrivateNetworkIpv4SubnetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSubnet")]
        public virtual void ResetSubnet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "prefixLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrefixLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "subnetMask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetMask
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subnet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.vpcPrivateNetwork.VpcPrivateNetworkIpv4Subnet\"}", isOptional: true)]
        public virtual scaleway.VpcPrivateNetwork.IVpcPrivateNetworkIpv4Subnet? InternalValue
        {
            get => GetInstanceProperty<scaleway.VpcPrivateNetwork.IVpcPrivateNetworkIpv4Subnet?>();
            set => SetInstanceProperty(value);
        }
    }
}

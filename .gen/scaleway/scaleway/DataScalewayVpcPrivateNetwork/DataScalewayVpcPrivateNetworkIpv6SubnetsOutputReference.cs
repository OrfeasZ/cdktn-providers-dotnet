using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayVpcPrivateNetwork
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayVpcPrivateNetwork.DataScalewayVpcPrivateNetworkIpv6SubnetsOutputReference), fullyQualifiedName: "scaleway.dataScalewayVpcPrivateNetwork.DataScalewayVpcPrivateNetworkIpv6SubnetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayVpcPrivateNetworkIpv6SubnetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayVpcPrivateNetworkIpv6SubnetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayVpcPrivateNetworkIpv6SubnetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayVpcPrivateNetworkIpv6SubnetsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subnet
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayVpcPrivateNetwork.DataScalewayVpcPrivateNetworkIpv6Subnets\"}", isOptional: true)]
        public virtual scaleway.DataScalewayVpcPrivateNetwork.IDataScalewayVpcPrivateNetworkIpv6Subnets? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayVpcPrivateNetwork.IDataScalewayVpcPrivateNetworkIpv6Subnets?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLoadBalancerLoadBalancers
{
    [JsiiClass(nativeType: typeof(oci.DataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersOutputReference), fullyQualifiedName: "oci.dataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLoadBalancerLoadBalancersLoadBalancersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLoadBalancerLoadBalancersLoadBalancersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLoadBalancerLoadBalancersLoadBalancersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLoadBalancerLoadBalancersLoadBalancersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddressDetails", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersIpAddressDetailsList\"}")]
        public virtual oci.DataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersIpAddressDetailsList IpAddressDetails
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersIpAddressDetailsList>()!;
        }

        [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ipMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6SubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6SubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDeleteProtectionEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDeleteProtectionEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPrivate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPrivate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRequestIdEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRequestIdEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requestIdHeader", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestIdHeader
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reservedIps", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersReservedIpsList\"}")]
        public virtual oci.DataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersReservedIpsList ReservedIps
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersReservedIpsList>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shapeDetails", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersShapeDetailsList\"}")]
        public virtual oci.DataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersShapeDetailsList ShapeDetails
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancersShapeDetailsList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLoadBalancerLoadBalancers.DataOciLoadBalancerLoadBalancersLoadBalancers\"}", isOptional: true)]
        public virtual oci.DataOciLoadBalancerLoadBalancers.IDataOciLoadBalancerLoadBalancersLoadBalancers? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLoadBalancerLoadBalancers.IDataOciLoadBalancerLoadBalancersLoadBalancers?>();
            set => SetInstanceProperty(value);
        }
    }
}

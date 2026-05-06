using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMulticloudNetworkAnchor
{
    [JsiiClass(nativeType: typeof(oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemOutputReference), fullyQualifiedName: "oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMulticloudNetworkAnchorOciMetadataItemOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMulticloudNetworkAnchorOciMetadataItemOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMulticloudNetworkAnchorOciMetadataItemOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMulticloudNetworkAnchorOciMetadataItemOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemDnsList\"}")]
        public virtual oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemDnsList Dns
        {
            get => GetInstanceProperty<oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemDnsList>()!;
        }

        [JsiiProperty(name: "dnsForwardingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsForwardingConfig
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dnsForwardingEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsForwardingEndpointIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsListeningEndpointIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsListeningEndpointIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkAnchorConnectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAnchorConnectionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"fqn\":\"oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemSubnetsList\"}")]
        public virtual oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemSubnetsList Subnets
        {
            get => GetInstanceProperty<oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemSubnetsList>()!;
        }

        [JsiiProperty(name: "vcn", typeJson: "{\"fqn\":\"oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemVcnList\"}")]
        public virtual oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemVcnList Vcn
        {
            get => GetInstanceProperty<oci.DataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItemVcnList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMulticloudNetworkAnchor.DataOciMulticloudNetworkAnchorOciMetadataItem\"}", isOptional: true)]
        public virtual oci.DataOciMulticloudNetworkAnchor.IDataOciMulticloudNetworkAnchorOciMetadataItem? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMulticloudNetworkAnchor.IDataOciMulticloudNetworkAnchorOciMetadataItem?>();
            set => SetInstanceProperty(value);
        }
    }
}

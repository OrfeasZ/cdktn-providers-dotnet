using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataccVmClusterNetworks
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "baseVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseVmClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerType
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

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServers
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "infrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isScanEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsScanEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "listenerPortSsl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenerPortSsl
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ntpServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NtpServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scans", typeJson: "{\"fqn\":\"oci.dataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsScansList\"}")]
        public virtual oci.DataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsScansList Scans
        {
            get => GetInstanceProperty<oci.DataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsScansList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmNetworks", typeJson: "{\"fqn\":\"oci.dataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsVmNetworksList\"}")]
        public virtual oci.DataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsVmNetworksList VmNetworks
        {
            get => GetInstanceProperty<oci.DataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItemsVmNetworksList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataccVmClusterNetworks.DataOciDataccVmClusterNetworksVmClusterNetworkCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataccVmClusterNetworks.IDataOciDataccVmClusterNetworksVmClusterNetworkCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataccVmClusterNetworks.IDataOciDataccVmClusterNetworksVmClusterNetworkCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}

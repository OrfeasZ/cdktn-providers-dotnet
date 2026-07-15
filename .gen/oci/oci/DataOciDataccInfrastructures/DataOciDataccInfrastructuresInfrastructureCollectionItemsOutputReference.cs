using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataccInfrastructures
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataccInfrastructuresInfrastructureCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataccInfrastructuresInfrastructureCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataccInfrastructuresInfrastructureCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccInfrastructuresInfrastructureCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acfsFileSystemStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcfsFileSystemStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "acfsFileSystemUsedStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcfsFileSystemUsedStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "adminNetworkcidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminNetworkcidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeCapacity", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsComputeCapacityList\"}")]
        public virtual oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsComputeCapacityList ComputeCapacity
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsComputeCapacityList>()!;
        }

        [JsiiProperty(name: "contacts", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsContactsList\"}")]
        public virtual oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsContactsList Contacts
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsContactsList>()!;
        }

        [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CorporateProxy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpsNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpsNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpsNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpsNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataDiskPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataDiskPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gateway
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsMaintenanceWindowList\"}")]
        public virtual oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Netmask
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkAdapterConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAdapterConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ntpServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NtpServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "rackSerialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RackSerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recoDiskPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoDiskPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scaleStorageTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScaleStorageTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "servers", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsServersList\"}")]
        public virtual oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsServersList Servers
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsServersList>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ssdConfigurationRequested", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SsdConfigurationRequested
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageCapacity", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsStorageCapacityList\"}")]
        public virtual oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsStorageCapacityList StorageCapacity
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsStorageCapacityList>()!;
        }

        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionPlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemStorageCapacity", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsSystemStorageCapacityList\"}")]
        public virtual oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsSystemStorageCapacityList SystemStorageCapacity
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItemsSystemStorageCapacityList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeActivated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeActivated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastStateUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastStateUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructures.DataOciDataccInfrastructuresInfrastructureCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataccInfrastructures.IDataOciDataccInfrastructuresInfrastructureCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructures.IDataOciDataccInfrastructuresInfrastructureCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}

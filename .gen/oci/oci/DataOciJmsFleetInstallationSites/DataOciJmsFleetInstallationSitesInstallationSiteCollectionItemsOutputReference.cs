using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsFleetInstallationSites
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "approximateApplicationCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApproximateApplicationCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "blocklist", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsBlocklistStructList\"}")]
        public virtual oci.DataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsBlocklistStructList Blocklist
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsBlocklistStructList>()!;
        }

        [JsiiProperty(name: "installationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstallationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jre", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsJreList\"}")]
        public virtual oci.DataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsJreList Jre
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsJreList>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOperatingSystemList\"}")]
        public virtual oci.DataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOperatingSystemList OperatingSystem
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItemsOperatingSystemList>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastSeen", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastSeen
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsFleetInstallationSites.DataOciJmsFleetInstallationSitesInstallationSiteCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciJmsFleetInstallationSites.IDataOciJmsFleetInstallationSitesInstallationSiteCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsFleetInstallationSites.IDataOciJmsFleetInstallationSitesInstallationSiteCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}

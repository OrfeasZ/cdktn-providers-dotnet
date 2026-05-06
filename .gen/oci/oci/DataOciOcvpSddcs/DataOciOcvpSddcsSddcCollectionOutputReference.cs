using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOcvpSddcs
{
    [JsiiClass(nativeType: typeof(oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionOutputReference), fullyQualifiedName: "oci.dataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOcvpSddcsSddcCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOcvpSddcsSddcCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOcvpSddcsSddcCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpSddcsSddcCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actualEsxiHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActualEsxiHostsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clustersCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClustersCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeAvailabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeAvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "datastores", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionDatastoresList\"}")]
        public virtual oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionDatastoresList Datastores
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionDatastoresList>()!;
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

        [JsiiProperty(name: "esxiHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EsxiHostsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "esxiSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EsxiSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hcxAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hcxFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hcxInitialPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxInitialPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hcxMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hcxOnPremKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxOnPremKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hcxOnPremLicenses", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionHcxOnPremLicensesList\"}")]
        public virtual oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionHcxOnPremLicensesList HcxOnPremLicenses
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionHcxOnPremLicensesList>()!;
        }

        [JsiiProperty(name: "hcxPrivateIpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxPrivateIpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hcxVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initialConfiguration", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionInitialConfigurationList\"}")]
        public virtual oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionInitialConfigurationList InitialConfiguration
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionInitialConfigurationList>()!;
        }

        [JsiiProperty(name: "initialHostOcpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialHostOcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "initialHostShapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialHostShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initialSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InitialSku
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceDisplayNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceDisplayNamePrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHcxEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHcxEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHcxEnterpriseEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHcxEnterpriseEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHcxPendingDowngrade", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHcxPendingDowngrade
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isShieldedInstanceEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsShieldedInstanceEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSingleHostSddc", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSingleHostSddc
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nsxEdgeUplink1VlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxEdgeUplink1VlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxEdgeUplink2VlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxEdgeUplink2VlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxEdgeUplinkIpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxEdgeUplinkIpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxEdgeVtepVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxEdgeVtepVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxManagerFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxManagerFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxManagerInitialPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxManagerInitialPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxManagerPrivateIpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxManagerPrivateIpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxManagerUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxManagerUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxOverlaySegmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxOverlaySegmentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxVtepVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxVtepVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningSubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refreshHcxLicenseStatus", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RefreshHcxLicenseStatus
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "replicationVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reservingHcxOnPremiseLicenseKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReservingHcxOnPremiseLicenseKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sshAuthorizedKeys", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SshAuthorizedKeys
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "timeHcxBillingCycleEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeHcxBillingCycleEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeHcxLicenseStatusUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeHcxLicenseStatusUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upgradeLicenses", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionUpgradeLicensesList\"}")]
        public virtual oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionUpgradeLicensesList UpgradeLicenses
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionUpgradeLicensesList>()!;
        }

        [JsiiProperty(name: "vcenterFqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterFqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcenterInitialPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterInitialPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcenterPrivateIpId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterPrivateIpId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcenterUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmotionVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmotionVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmwareSoftwareVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmwareSoftwareVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vsanVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsanVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vsphereUpgradeGuide", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsphereUpgradeGuide
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vsphereUpgradeObjects", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionVsphereUpgradeObjectsList\"}")]
        public virtual oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionVsphereUpgradeObjectsList VsphereUpgradeObjects
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddcs.DataOciOcvpSddcsSddcCollectionVsphereUpgradeObjectsList>()!;
        }

        [JsiiProperty(name: "vsphereVlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VsphereVlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workloadNetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadNetworkCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddcs.DataOciOcvpSddcsSddcCollection\"}", isOptional: true)]
        public virtual oci.DataOciOcvpSddcs.IDataOciOcvpSddcsSddcCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddcs.IDataOciOcvpSddcsSddcCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}

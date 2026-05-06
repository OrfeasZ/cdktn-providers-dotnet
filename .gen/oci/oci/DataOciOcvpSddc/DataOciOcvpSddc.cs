using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOcvpSddc
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_sddc oci_ocvp_sddc}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOcvpSddc.DataOciOcvpSddc), fullyQualifiedName: "oci.dataOciOcvpSddc.DataOciOcvpSddc", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOcvpSddc.DataOciOcvpSddcConfig\"}}]")]
    public class DataOciOcvpSddc : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_sddc oci_ocvp_sddc} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOcvpSddc(Constructs.Construct scope, string id, oci.DataOciOcvpSddc.IDataOciOcvpSddcConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOcvpSddc.IDataOciOcvpSddcConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpSddc(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOcvpSddc(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOcvpSddc resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOcvpSddc to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOcvpSddc that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOcvpSddc to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOcvpSddc to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/ocvp_sddc#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOcvpSddc that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOcvpSddc to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOcvpSddc.DataOciOcvpSddc), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciOcvpSddc.DataOciOcvpSddc))!;

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

        [JsiiProperty(name: "datastores", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddc.DataOciOcvpSddcDatastoresList\"}")]
        public virtual oci.DataOciOcvpSddc.DataOciOcvpSddcDatastoresList Datastores
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddc.DataOciOcvpSddcDatastoresList>()!;
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

        [JsiiProperty(name: "hcxOnPremLicenses", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddc.DataOciOcvpSddcHcxOnPremLicensesList\"}")]
        public virtual oci.DataOciOcvpSddc.DataOciOcvpSddcHcxOnPremLicensesList HcxOnPremLicenses
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddc.DataOciOcvpSddcHcxOnPremLicensesList>()!;
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

        [JsiiProperty(name: "initialConfiguration", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddc.DataOciOcvpSddcInitialConfigurationList\"}")]
        public virtual oci.DataOciOcvpSddc.DataOciOcvpSddcInitialConfigurationList InitialConfiguration
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddc.DataOciOcvpSddcInitialConfigurationList>()!;
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

        [JsiiProperty(name: "upgradeLicenses", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddc.DataOciOcvpSddcUpgradeLicensesList\"}")]
        public virtual oci.DataOciOcvpSddc.DataOciOcvpSddcUpgradeLicensesList UpgradeLicenses
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddc.DataOciOcvpSddcUpgradeLicensesList>()!;
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

        [JsiiProperty(name: "vsphereUpgradeObjects", typeJson: "{\"fqn\":\"oci.dataOciOcvpSddc.DataOciOcvpSddcVsphereUpgradeObjectsList\"}")]
        public virtual oci.DataOciOcvpSddc.DataOciOcvpSddcVsphereUpgradeObjectsList VsphereUpgradeObjects
        {
            get => GetInstanceProperty<oci.DataOciOcvpSddc.DataOciOcvpSddcVsphereUpgradeObjectsList>()!;
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
        [JsiiProperty(name: "sddcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SddcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "sddcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SddcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

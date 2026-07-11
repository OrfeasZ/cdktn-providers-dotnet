using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNetappVolumeGroupOracle
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeOutputReference), fullyQualifiedName: "azurerm.dataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermNetappVolumeGroupOracleVolumeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermNetappVolumeGroupOracleVolumeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermNetappVolumeGroupOracleVolumeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermNetappVolumeGroupOracleVolumeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "capacityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityPoolId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataProtectionReplication", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeDataProtectionReplicationList\"}")]
        public virtual azurerm.DataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeDataProtectionReplicationList DataProtectionReplication
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeDataProtectionReplicationList>()!;
        }

        [JsiiProperty(name: "dataProtectionSnapshotPolicy", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicyList\"}")]
        public virtual azurerm.DataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicyList DataProtectionSnapshotPolicy
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicyList>()!;
        }

        [JsiiProperty(name: "encryptionKeySource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKeySource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "exportPolicyRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeExportPolicyRuleList\"}")]
        public virtual azurerm.DataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeExportPolicyRuleList ExportPolicyRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolumeExportPolicyRuleList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyVaultPrivateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyVaultPrivateEndpointId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mountIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MountIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkFeatures", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkFeatures
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocols
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProximityPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityStyle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityStyle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotDirectoryVisible", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SnapshotDirectoryVisible
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "storageQuotaInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageQuotaInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Tags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "throughputInMibps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThroughputInMibps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumePath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumeSpecName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeSpecName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermNetappVolumeGroupOracle.DataAzurermNetappVolumeGroupOracleVolume\"}", isOptional: true)]
        public virtual azurerm.DataAzurermNetappVolumeGroupOracle.IDataAzurermNetappVolumeGroupOracleVolume? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermNetappVolumeGroupOracle.IDataAzurermNetappVolumeGroupOracleVolume?>();
            set => SetInstanceProperty(value);
        }
    }
}

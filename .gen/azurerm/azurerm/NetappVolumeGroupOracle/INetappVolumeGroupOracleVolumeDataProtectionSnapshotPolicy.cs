using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeGroupOracle
{
    [JsiiInterface(nativeType: typeof(INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy), fullyQualifiedName: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy")]
    public interface INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#snapshot_policy_id NetappVolumeGroupOracle#snapshot_policy_id}.</summary>
        [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        string SnapshotPolicyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy), fullyQualifiedName: "azurerm.netappVolumeGroupOracle.NetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeGroupOracle.INetappVolumeGroupOracleVolumeDataProtectionSnapshotPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/netapp_volume_group_oracle#snapshot_policy_id NetappVolumeGroupOracle#snapshot_policy_id}.</summary>
            [JsiiProperty(name: "snapshotPolicyId", typeJson: "{\"primitive\":\"string\"}")]
            public string SnapshotPolicyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

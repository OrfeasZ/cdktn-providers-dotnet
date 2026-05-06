using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreIpsecConnectionTunnels
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsOutputReference), fullyQualifiedName: "oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedVirtualCircuits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AssociatedVirtualCircuits
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "bgpSessionInfo", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsBgpSessionInfoList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsBgpSessionInfoList BgpSessionInfo
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsBgpSessionInfoList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpeIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpeIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dpdConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsDpdConfigList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsDpdConfigList DpdConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsDpdConfigList>()!;
        }

        [JsiiProperty(name: "dpdMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DpdMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dpdTimeoutInSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DpdTimeoutInSec
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "encryptionDomainConfig", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsEncryptionDomainConfigList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsEncryptionDomainConfigList EncryptionDomainConfig
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsEncryptionDomainConfigList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ikeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IkeVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipsecId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpsecId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "natTranslationEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NatTranslationEnabled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleCanInitiate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleCanInitiate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phaseOneDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseOneDetailsList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseOneDetailsList PhaseOneDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseOneDetailsList>()!;
        }

        [JsiiProperty(name: "phaseTwoDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsList\"}")]
        public virtual oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsList PhaseTwoDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsList>()!;
        }

        [JsiiProperty(name: "routing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Routing
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sharedSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStatusUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStatusUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TunnelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpnIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnels\"}", isOptional: true)]
        public virtual oci.DataOciCoreIpsecConnectionTunnels.IDataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnels? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnels.IDataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnels?>();
            set => SetInstanceProperty(value);
        }
    }
}

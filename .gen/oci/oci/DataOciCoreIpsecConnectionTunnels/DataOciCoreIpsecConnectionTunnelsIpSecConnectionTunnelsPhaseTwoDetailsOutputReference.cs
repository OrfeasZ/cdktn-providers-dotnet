using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreIpsecConnectionTunnels
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsOutputReference), fullyQualifiedName: "oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customAuthenticationAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomAuthenticationAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomEncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DhGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCustomPhaseTwoConfig", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCustomPhaseTwoConfig
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEspEstablished", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEspEstablished
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPfsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPfsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifetime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Lifetime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "negotiatedAuthenticationAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NegotiatedAuthenticationAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "negotiatedDhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NegotiatedDhGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "negotiatedEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NegotiatedEncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remainingLifetime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemainingLifetime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "remainingLifetimeInt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RemainingLifetimeInt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "remainingLifetimeLastRetrieved", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemainingLifetimeLastRetrieved
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreIpsecConnectionTunnels.DataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetails\"}", isOptional: true)]
        public virtual oci.DataOciCoreIpsecConnectionTunnels.IDataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreIpsecConnectionTunnels.IDataOciCoreIpsecConnectionTunnelsIpSecConnectionTunnelsPhaseTwoDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

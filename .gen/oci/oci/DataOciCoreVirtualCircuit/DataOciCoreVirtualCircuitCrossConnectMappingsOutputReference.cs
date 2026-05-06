using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreVirtualCircuit
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitCrossConnectMappingsOutputReference), fullyQualifiedName: "oci.dataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitCrossConnectMappingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreVirtualCircuitCrossConnectMappingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreVirtualCircuitCrossConnectMappingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreVirtualCircuitCrossConnectMappingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreVirtualCircuitCrossConnectMappingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bgpMd5AuthKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpMd5AuthKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crossConnectOrCrossConnectGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossConnectOrCrossConnectGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerBgpPeeringIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerBgpPeeringIpv6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleBgpPeeringIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleBgpPeeringIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oracleBgpPeeringIpv6", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OracleBgpPeeringIpv6
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vlan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Vlan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreVirtualCircuit.DataOciCoreVirtualCircuitCrossConnectMappings\"}", isOptional: true)]
        public virtual oci.DataOciCoreVirtualCircuit.IDataOciCoreVirtualCircuitCrossConnectMappings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreVirtualCircuit.IDataOciCoreVirtualCircuitCrossConnectMappings?>();
            set => SetInstanceProperty(value);
        }
    }
}

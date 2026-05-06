using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAnalyticsAnalyticsInstance
{
    [JsiiClass(nativeType: typeof(oci.DataOciAnalyticsAnalyticsInstance.DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference), fullyQualifiedName: "oci.dataOciAnalyticsAnalyticsInstance.DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkEndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "whitelistedIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WhitelistedIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "whitelistedServices", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WhitelistedServices
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "whitelistedVcns", typeJson: "{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstance.DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcnsList\"}")]
        public virtual oci.DataOciAnalyticsAnalyticsInstance.DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcnsList WhitelistedVcns
        {
            get => GetInstanceProperty<oci.DataOciAnalyticsAnalyticsInstance.DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetailsWhitelistedVcnsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAnalyticsAnalyticsInstance.DataOciAnalyticsAnalyticsInstanceNetworkEndpointDetails\"}", isOptional: true)]
        public virtual oci.DataOciAnalyticsAnalyticsInstance.IDataOciAnalyticsAnalyticsInstanceNetworkEndpointDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAnalyticsAnalyticsInstance.IDataOciAnalyticsAnalyticsInstanceNetworkEndpointDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

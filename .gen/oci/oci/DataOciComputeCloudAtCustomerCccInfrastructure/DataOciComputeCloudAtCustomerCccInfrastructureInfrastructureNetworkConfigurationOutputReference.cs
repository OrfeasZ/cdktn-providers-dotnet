using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciComputeCloudAtCustomerCccInfrastructure
{
    [JsiiClass(nativeType: typeof(oci.DataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference), fullyQualifiedName: "oci.dataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "infrastructureRoutingDynamic", typeJson: "{\"fqn\":\"oci.dataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingDynamicList\"}")]
        public virtual oci.DataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingDynamicList InfrastructureRoutingDynamic
        {
            get => GetInstanceProperty<oci.DataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingDynamicList>()!;
        }

        [JsiiProperty(name: "infrastructureRoutingStatic", typeJson: "{\"fqn\":\"oci.dataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingStaticList\"}")]
        public virtual oci.DataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingStaticList InfrastructureRoutingStatic
        {
            get => GetInstanceProperty<oci.DataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingStaticList>()!;
        }

        [JsiiProperty(name: "managementNodes", typeJson: "{\"fqn\":\"oci.dataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationManagementNodesList\"}")]
        public virtual oci.DataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationManagementNodesList ManagementNodes
        {
            get => GetInstanceProperty<oci.DataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationManagementNodesList>()!;
        }

        [JsiiProperty(name: "mgmtVipHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MgmtVipHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mgmtVipIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MgmtVipIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spineIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SpineIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "spineVip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpineVip
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uplinkDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UplinkDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uplinkGatewayIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UplinkGatewayIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uplinkNetmask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UplinkNetmask
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uplinkPortCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UplinkPortCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "uplinkPortForwardErrorCorrection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UplinkPortForwardErrorCorrection
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uplinkPortSpeedInGbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UplinkPortSpeedInGbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "uplinkVlanMtu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UplinkVlanMtu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciComputeCloudAtCustomerCccInfrastructure.DataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.DataOciComputeCloudAtCustomerCccInfrastructure.IDataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciComputeCloudAtCustomerCccInfrastructure.IDataOciComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

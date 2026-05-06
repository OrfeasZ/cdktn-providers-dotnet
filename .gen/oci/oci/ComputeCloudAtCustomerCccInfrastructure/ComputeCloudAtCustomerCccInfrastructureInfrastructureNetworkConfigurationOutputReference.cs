using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ComputeCloudAtCustomerCccInfrastructure
{
    [JsiiClass(nativeType: typeof(oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference), fullyQualifiedName: "oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "infrastructureRoutingDynamic", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingDynamicList\"}")]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingDynamicList InfrastructureRoutingDynamic
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingDynamicList>()!;
        }

        [JsiiProperty(name: "infrastructureRoutingStatic", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingStaticList\"}")]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingStaticList InfrastructureRoutingStatic
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationInfrastructureRoutingStaticList>()!;
        }

        [JsiiProperty(name: "managementNodes", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationManagementNodesList\"}")]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationManagementNodesList ManagementNodes
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfigurationManagementNodesList>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.computeCloudAtCustomerCccInfrastructure.ComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.ComputeCloudAtCustomerCccInfrastructure.IComputeCloudAtCustomerCccInfrastructureInfrastructureNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

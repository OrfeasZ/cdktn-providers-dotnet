using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.DataAzurestackVirtualNetworkGateway
{
    [JsiiClass(nativeType: typeof(azurestack.DataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationOutputReference), fullyQualifiedName: "azurestack.dataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurestackVirtualNetworkGatewayVpnClientConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurestackVirtualNetworkGatewayVpnClientConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurestackVirtualNetworkGatewayVpnClientConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurestackVirtualNetworkGatewayVpnClientConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressSpace", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AddressSpace
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "radiusServerAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RadiusServerAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "radiusServerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RadiusServerSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revokedCertificate", typeJson: "{\"fqn\":\"azurestack.dataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationRevokedCertificateList\"}")]
        public virtual azurestack.DataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationRevokedCertificateList RevokedCertificate
        {
            get => GetInstanceProperty<azurestack.DataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationRevokedCertificateList>()!;
        }

        [JsiiProperty(name: "rootCertificate", typeJson: "{\"fqn\":\"azurestack.dataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationRootCertificateList\"}")]
        public virtual azurestack.DataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationRootCertificateList RootCertificate
        {
            get => GetInstanceProperty<azurestack.DataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfigurationRootCertificateList>()!;
        }

        [JsiiProperty(name: "vpnClientProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpnClientProtocols
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurestack.dataAzurestackVirtualNetworkGateway.DataAzurestackVirtualNetworkGatewayVpnClientConfiguration\"}", isOptional: true)]
        public virtual azurestack.DataAzurestackVirtualNetworkGateway.IDataAzurestackVirtualNetworkGatewayVpnClientConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurestack.DataAzurestackVirtualNetworkGateway.IDataAzurestackVirtualNetworkGatewayVpnClientConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}

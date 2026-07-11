using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    [JsiiClass(nativeType: typeof(azurestack.VirtualNetworkGateway.VirtualNetworkGatewayBgpSettingsOutputReference), fullyQualifiedName: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualNetworkGatewayBgpSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualNetworkGatewayBgpSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGatewayBgpSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGatewayBgpSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAsn")]
        public virtual void ResetAsn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeeringAddress")]
        public virtual void ResetPeeringAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerWeight")]
        public virtual void ResetPeerWeight()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "asnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AsnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peeringAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeeringAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerWeightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeerWeightInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Asn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeeringAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerWeight
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayBgpSettings\"}", isOptional: true)]
        public virtual azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings? InternalValue
        {
            get => GetInstanceProperty<azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayBgpSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

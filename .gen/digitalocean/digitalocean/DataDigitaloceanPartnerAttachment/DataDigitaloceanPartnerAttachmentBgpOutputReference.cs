using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanPartnerAttachment
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgpOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataDigitaloceanPartnerAttachmentBgpOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataDigitaloceanPartnerAttachmentBgpOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataDigitaloceanPartnerAttachmentBgpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanPartnerAttachmentBgpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLocalRouterIp")]
        public virtual void ResetLocalRouterIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerRouterAsn")]
        public virtual void ResetPeerRouterAsn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerRouterIp")]
        public virtual void ResetPeerRouterIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "localRouterIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalRouterIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerRouterAsnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeerRouterAsnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerRouterIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeerRouterIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "localRouterIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalRouterIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerRouterAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerRouterAsn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerRouterIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRouterIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanPartnerAttachment.DataDigitaloceanPartnerAttachmentBgp\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentBgp? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanPartnerAttachment.IDataDigitaloceanPartnerAttachmentBgp?>();
            set => SetInstanceProperty(value);
        }
    }
}

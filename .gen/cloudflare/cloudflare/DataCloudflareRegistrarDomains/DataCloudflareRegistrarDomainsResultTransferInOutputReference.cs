using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRegistrarDomains
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRegistrarDomains.DataCloudflareRegistrarDomainsResultTransferInOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRegistrarDomains.DataCloudflareRegistrarDomainsResultTransferInOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRegistrarDomainsResultTransferInOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRegistrarDomainsResultTransferInOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRegistrarDomainsResultTransferInOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRegistrarDomainsResultTransferInOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acceptFoa", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptFoa
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "approveTransfer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApproveTransfer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "canCancelTransfer", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanCancelTransfer
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "disablePrivacy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisablePrivacy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enterAuthCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnterAuthCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unlockDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnlockDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRegistrarDomains.DataCloudflareRegistrarDomainsResultTransferIn\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRegistrarDomains.IDataCloudflareRegistrarDomainsResultTransferIn? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRegistrarDomains.IDataCloudflareRegistrarDomainsResultTransferIn?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationsResultScimConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessApplicationsResultScimConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessApplicationsResultScimConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationsResultScimConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference Authentication
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "deactivateOnDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeactivateOnDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idpUid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdpUid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mappings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigMappingsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigMappingsList Mappings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigMappingsList>()!;
        }

        [JsiiProperty(name: "remoteUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultScimConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultScimConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

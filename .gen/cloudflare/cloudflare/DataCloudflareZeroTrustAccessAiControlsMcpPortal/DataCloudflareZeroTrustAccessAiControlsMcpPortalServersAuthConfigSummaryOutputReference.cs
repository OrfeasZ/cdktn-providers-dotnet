using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecretVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClientSecretVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryConfigOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryConfigOutputReference Config
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryConfigOutputReference>()!;
        }

        [JsiiProperty(name: "hasClientSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasClientSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "registrationInfo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryRegistrationInfoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryRegistrationInfoOutputReference RegistrationInfo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummaryRegistrationInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpPortal.DataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummary\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.IDataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummary? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortal.IDataCloudflareZeroTrustAccessAiControlsMcpPortalServersAuthConfigSummary?>();
            set => SetInstanceProperty(value);
        }
    }
}

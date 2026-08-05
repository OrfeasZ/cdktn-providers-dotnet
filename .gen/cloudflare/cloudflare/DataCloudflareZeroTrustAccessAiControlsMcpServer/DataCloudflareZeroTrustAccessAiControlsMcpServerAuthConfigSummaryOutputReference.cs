using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryConfigOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryConfigOutputReference Config
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryConfigOutputReference>()!;
        }

        [JsiiProperty(name: "hasClientSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasClientSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "registrationInfo", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryRegistrationInfoOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryRegistrationInfoOutputReference RegistrationInfo
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummaryRegistrationInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServer.DataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummary\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.IDataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummary? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServer.IDataCloudflareZeroTrustAccessAiControlsMcpServerAuthConfigSummary?>();
            set => SetInstanceProperty(value);
        }
    }
}

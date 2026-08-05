using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServers.DataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServers.DataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Resource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "revocationEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevocationEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpServers.DataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServers.IDataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpServers.IDataCloudflareZeroTrustAccessAiControlsMcpServersResultAuthConfigSummaryConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortals
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortals.DataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfoOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpPortals.DataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokenEndpointAuthMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenEndpointAuthMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessAiControlsMcpPortals.DataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfo\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortals.IDataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfo? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessAiControlsMcpPortals.IDataCloudflareZeroTrustAccessAiControlsMcpPortalsResultServersAuthConfigSummaryRegistrationInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}

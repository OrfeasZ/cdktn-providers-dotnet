using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "fnrId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FnrId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vips", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigVipsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigVipsList Vips
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigVipsList>()!;
        }

        [JsiiProperty(name: "vipsPrevious", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigVipsPreviousList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigVipsPreviousList VipsPrevious
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfigVipsPreviousList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustTunnelWarpConnectorConfig.DataCloudflareZeroTrustTunnelWarpConnectorConfigConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig.IDataCloudflareZeroTrustTunnelWarpConnectorConfigConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustTunnelWarpConnectorConfig.IDataCloudflareZeroTrustTunnelWarpConnectorConfigConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

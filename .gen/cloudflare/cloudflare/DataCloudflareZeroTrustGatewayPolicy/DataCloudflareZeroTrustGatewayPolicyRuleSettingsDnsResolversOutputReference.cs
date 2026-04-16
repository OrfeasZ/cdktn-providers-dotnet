using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewayPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversIpv4List\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversIpv4List Ipv4
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversIpv4List>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversIpv6List\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversIpv6List Ipv6
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversIpv6List>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolvers\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.IDataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolvers? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.IDataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolvers?>();
            set => SetInstanceProperty(value);
        }
    }
}

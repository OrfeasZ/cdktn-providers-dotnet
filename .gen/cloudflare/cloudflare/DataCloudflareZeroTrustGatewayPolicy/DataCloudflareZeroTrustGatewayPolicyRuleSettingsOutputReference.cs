using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewayPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewayPolicyRuleSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addHeaders", typeJson: "{\"fqn\":\"cdktn.StringListMap\"}")]
        public virtual Io.Cdktn.StringListMap AddHeaders
        {
            get => GetInstanceProperty<Io.Cdktn.StringListMap>()!;
        }

        [JsiiProperty(name: "allowChildBypass", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowChildBypass
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "auditSsh", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsAuditSshOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsAuditSshOutputReference AuditSsh
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsAuditSshOutputReference>()!;
        }

        [JsiiProperty(name: "bisoAdminControls", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsBisoAdminControlsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsBisoAdminControlsOutputReference BisoAdminControls
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsBisoAdminControlsOutputReference>()!;
        }

        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsBlockPageOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsBlockPageOutputReference BlockPage
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsBlockPageOutputReference>()!;
        }

        [JsiiProperty(name: "blockPageEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BlockPageEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "blockReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bypassParentRule", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable BypassParentRule
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "checkSession", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsCheckSessionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsCheckSessionOutputReference CheckSession
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsCheckSessionOutputReference>()!;
        }

        [JsiiProperty(name: "dnsResolvers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference DnsResolvers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference>()!;
        }

        [JsiiProperty(name: "egress", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsEgressOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsEgressOutputReference Egress
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsEgressOutputReference>()!;
        }

        [JsiiProperty(name: "forensicCopy", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsForensicCopyOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsForensicCopyOutputReference ForensicCopy
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsForensicCopyOutputReference>()!;
        }

        [JsiiProperty(name: "ignoreCnameCategoryMatches", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IgnoreCnameCategoryMatches
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "insecureDisableDnssecValidation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable InsecureDisableDnssecValidation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ipCategories", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IpCategories
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ipIndicatorFeeds", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IpIndicatorFeeds
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "l4Override", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsL4OverrideOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsL4OverrideOutputReference L4Override
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsL4OverrideOutputReference>()!;
        }

        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsNotificationSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsNotificationSettingsOutputReference NotificationSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsNotificationSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "overrideHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverrideHost
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "overrideIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OverrideIps
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "payloadLog", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsPayloadLogOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsPayloadLogOutputReference PayloadLog
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsPayloadLogOutputReference>()!;
        }

        [JsiiProperty(name: "quarantine", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsQuarantineOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsQuarantineOutputReference Quarantine
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsQuarantineOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsRedirectOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsRedirectOutputReference>()!;
        }

        [JsiiProperty(name: "resolveDnsInternally", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsResolveDnsInternallyOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsResolveDnsInternallyOutputReference ResolveDnsInternally
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsResolveDnsInternallyOutputReference>()!;
        }

        [JsiiProperty(name: "resolveDnsThroughCloudflare", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ResolveDnsThroughCloudflare
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "untrustedCert", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsUntrustedCertOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsUntrustedCertOutputReference UntrustedCert
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettingsUntrustedCertOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicy.DataCloudflareZeroTrustGatewayPolicyRuleSettings\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicy.IDataCloudflareZeroTrustGatewayPolicyRuleSettings? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicy.IDataCloudflareZeroTrustGatewayPolicyRuleSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

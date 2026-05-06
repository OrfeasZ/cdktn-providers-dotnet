using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewayPolicies
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "auditSsh", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsAuditSshOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsAuditSshOutputReference AuditSsh
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsAuditSshOutputReference>()!;
        }

        [JsiiProperty(name: "bisoAdminControls", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsBisoAdminControlsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsBisoAdminControlsOutputReference BisoAdminControls
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsBisoAdminControlsOutputReference>()!;
        }

        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsBlockPageOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsBlockPageOutputReference BlockPage
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsBlockPageOutputReference>()!;
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

        [JsiiProperty(name: "checkSession", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsCheckSessionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsCheckSessionOutputReference CheckSession
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsCheckSessionOutputReference>()!;
        }

        [JsiiProperty(name: "dnsResolvers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsDnsResolversOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsDnsResolversOutputReference DnsResolvers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsDnsResolversOutputReference>()!;
        }

        [JsiiProperty(name: "egress", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsEgressOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsEgressOutputReference Egress
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsEgressOutputReference>()!;
        }

        [JsiiProperty(name: "forensicCopy", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsForensicCopyOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsForensicCopyOutputReference ForensicCopy
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsForensicCopyOutputReference>()!;
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

        [JsiiProperty(name: "l4Override", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsL4OverrideOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsL4OverrideOutputReference L4Override
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsL4OverrideOutputReference>()!;
        }

        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsNotificationSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsNotificationSettingsOutputReference NotificationSettings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsNotificationSettingsOutputReference>()!;
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

        [JsiiProperty(name: "payloadLog", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsPayloadLogOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsPayloadLogOutputReference PayloadLog
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsPayloadLogOutputReference>()!;
        }

        [JsiiProperty(name: "quarantine", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsQuarantineOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsQuarantineOutputReference Quarantine
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsQuarantineOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsRedirectOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsRedirectOutputReference>()!;
        }

        [JsiiProperty(name: "resolveDnsInternally", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsResolveDnsInternallyOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsResolveDnsInternallyOutputReference ResolveDnsInternally
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsResolveDnsInternallyOutputReference>()!;
        }

        [JsiiProperty(name: "resolveDnsThroughCloudflare", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ResolveDnsThroughCloudflare
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "untrustedCert", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsUntrustedCertOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsUntrustedCertOutputReference UntrustedCert
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettingsUntrustedCertOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewayPolicies.DataCloudflareZeroTrustGatewayPoliciesResultRuleSettings\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustGatewayPolicies.IDataCloudflareZeroTrustGatewayPoliciesResultRuleSettings? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewayPolicies.IDataCloudflareZeroTrustGatewayPoliciesResultRuleSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

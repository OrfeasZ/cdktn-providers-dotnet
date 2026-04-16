using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsOutputReference), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustGatewayPolicyRuleSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustGatewayPolicyRuleSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustGatewayPolicyRuleSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustGatewayPolicyRuleSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuditSsh", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsAuditSsh\"}}]")]
        public virtual void PutAuditSsh(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsAuditSsh @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsAuditSsh)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBisoAdminControls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls\"}}]")]
        public virtual void PutBisoAdminControls(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlockPage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPage\"}}]")]
        public virtual void PutBlockPage(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBlockPage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBlockPage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCheckSession", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsCheckSession\"}}]")]
        public virtual void PutCheckSession(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsCheckSession @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsCheckSession)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDnsResolvers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsDnsResolvers\"}}]")]
        public virtual void PutDnsResolvers(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsDnsResolvers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsDnsResolvers)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEgress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgress\"}}]")]
        public virtual void PutEgress(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsEgress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsEgress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForensicCopy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForensicCopy\"}}]")]
        public virtual void PutForensicCopy(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsForensicCopy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsForensicCopy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putL4Override", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsL4Override\"}}]")]
        public virtual void PutL4Override(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsL4Override @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsL4Override)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotificationSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsNotificationSettings\"}}]")]
        public virtual void PutNotificationSettings(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsNotificationSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsNotificationSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPayloadLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLog\"}}]")]
        public virtual void PutPayloadLog(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsPayloadLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsPayloadLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQuarantine", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantine\"}}]")]
        public virtual void PutQuarantine(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsQuarantine @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsQuarantine)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirect\"}}]")]
        public virtual void PutRedirect(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsRedirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResolveDnsInternally", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally\"}}]")]
        public virtual void PutResolveDnsInternally(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUntrustedCert", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCert\"}}]")]
        public virtual void PutUntrustedCert(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsUntrustedCert @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsUntrustedCert)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddHeaders")]
        public virtual void ResetAddHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowChildBypass")]
        public virtual void ResetAllowChildBypass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuditSsh")]
        public virtual void ResetAuditSsh()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBisoAdminControls")]
        public virtual void ResetBisoAdminControls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockPage")]
        public virtual void ResetBlockPage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockPageEnabled")]
        public virtual void ResetBlockPageEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockReason")]
        public virtual void ResetBlockReason()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBypassParentRule")]
        public virtual void ResetBypassParentRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCheckSession")]
        public virtual void ResetCheckSession()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsResolvers")]
        public virtual void ResetDnsResolvers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEgress")]
        public virtual void ResetEgress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForensicCopy")]
        public virtual void ResetForensicCopy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreCnameCategoryMatches")]
        public virtual void ResetIgnoreCnameCategoryMatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInsecureDisableDnssecValidation")]
        public virtual void ResetInsecureDisableDnssecValidation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpCategories")]
        public virtual void ResetIpCategories()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpIndicatorFeeds")]
        public virtual void ResetIpIndicatorFeeds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetL4Override")]
        public virtual void ResetL4Override()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationSettings")]
        public virtual void ResetNotificationSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideHost")]
        public virtual void ResetOverrideHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideIps")]
        public virtual void ResetOverrideIps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayloadLog")]
        public virtual void ResetPayloadLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuarantine")]
        public virtual void ResetQuarantine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirect")]
        public virtual void ResetRedirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResolveDnsInternally")]
        public virtual void ResetResolveDnsInternally()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResolveDnsThroughCloudflare")]
        public virtual void ResetResolveDnsThroughCloudflare()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUntrustedCert")]
        public virtual void ResetUntrustedCert()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "auditSsh", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsAuditSshOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsAuditSshOutputReference AuditSsh
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsAuditSshOutputReference>()!;
        }

        [JsiiProperty(name: "bisoAdminControls", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControlsOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControlsOutputReference BisoAdminControls
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControlsOutputReference>()!;
        }

        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPageOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPageOutputReference BlockPage
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPageOutputReference>()!;
        }

        [JsiiProperty(name: "checkSession", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsCheckSessionOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsCheckSessionOutputReference CheckSession
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsCheckSessionOutputReference>()!;
        }

        [JsiiProperty(name: "dnsResolvers", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference DnsResolvers
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsDnsResolversOutputReference>()!;
        }

        [JsiiProperty(name: "egress", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgressOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgressOutputReference Egress
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgressOutputReference>()!;
        }

        [JsiiProperty(name: "forensicCopy", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForensicCopyOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForensicCopyOutputReference ForensicCopy
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForensicCopyOutputReference>()!;
        }

        [JsiiProperty(name: "l4Override", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsL4OverrideOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsL4OverrideOutputReference L4Override
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsL4OverrideOutputReference>()!;
        }

        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsNotificationSettingsOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsNotificationSettingsOutputReference NotificationSettings
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsNotificationSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "payloadLog", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLogOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLogOutputReference PayloadLog
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLogOutputReference>()!;
        }

        [JsiiProperty(name: "quarantine", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantineOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantineOutputReference Quarantine
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantineOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirectOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirectOutputReference>()!;
        }

        [JsiiProperty(name: "resolveDnsInternally", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternallyOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternallyOutputReference ResolveDnsInternally
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternallyOutputReference>()!;
        }

        [JsiiProperty(name: "untrustedCert", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCertOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCertOutputReference UntrustedCert
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCertOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addHeadersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? AddHeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowChildBypassInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowChildBypassInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditSshInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsAuditSsh\"}]}}", isOptional: true)]
        public virtual object? AuditSshInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bisoAdminControlsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls\"}]}}", isOptional: true)]
        public virtual object? BisoAdminControlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockPageEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BlockPageEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockPageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBlockPage\"}]}}", isOptional: true)]
        public virtual object? BlockPageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockReasonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockReasonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bypassParentRuleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BypassParentRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkSessionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsCheckSession\"}]}}", isOptional: true)]
        public virtual object? CheckSessionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsResolversInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsDnsResolvers\"}]}}", isOptional: true)]
        public virtual object? DnsResolversInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "egressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsEgress\"}]}}", isOptional: true)]
        public virtual object? EgressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forensicCopyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsForensicCopy\"}]}}", isOptional: true)]
        public virtual object? ForensicCopyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreCnameCategoryMatchesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IgnoreCnameCategoryMatchesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "insecureDisableDnssecValidationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InsecureDisableDnssecValidationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipCategoriesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IpCategoriesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipIndicatorFeedsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IpIndicatorFeedsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "l4OverrideInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsL4Override\"}]}}", isOptional: true)]
        public virtual object? L4OverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsNotificationSettings\"}]}}", isOptional: true)]
        public virtual object? NotificationSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideHostInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OverrideHostInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideIpsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OverrideIpsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "payloadLogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsPayloadLog\"}]}}", isOptional: true)]
        public virtual object? PayloadLogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quarantineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsQuarantine\"}]}}", isOptional: true)]
        public virtual object? QuarantineInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsRedirect\"}]}}", isOptional: true)]
        public virtual object? RedirectInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resolveDnsInternallyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsResolveDnsInternally\"}]}}", isOptional: true)]
        public virtual object? ResolveDnsInternallyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resolveDnsThroughCloudflareInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ResolveDnsThroughCloudflareInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "untrustedCertInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsUntrustedCert\"}]}}", isOptional: true)]
        public virtual object? UntrustedCertInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "addHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}]}}")]
        public virtual object AddHeaders
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, string[]> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, string[]>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "allowChildBypass", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AllowChildBypass
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "blockPageEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object BlockPageEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "blockReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockReason
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bypassParentRule", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object BypassParentRule
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "ignoreCnameCategoryMatches", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IgnoreCnameCategoryMatches
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "insecureDisableDnssecValidation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object InsecureDisableDnssecValidation
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "ipCategories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IpCategories
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "ipIndicatorFeeds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IpIndicatorFeeds
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "overrideHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverrideHost
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overrideIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OverrideIps
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resolveDnsThroughCloudflare", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ResolveDnsThroughCloudflare
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettings\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

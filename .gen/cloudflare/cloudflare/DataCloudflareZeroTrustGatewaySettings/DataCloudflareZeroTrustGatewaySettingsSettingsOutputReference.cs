using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewaySettings
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustGatewaySettingsSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustGatewaySettingsSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustGatewaySettingsSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewaySettingsSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activityLog", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsActivityLogOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsActivityLogOutputReference ActivityLog
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsActivityLogOutputReference>()!;
        }

        [JsiiProperty(name: "antivirus", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsAntivirusOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsAntivirusOutputReference Antivirus
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsAntivirusOutputReference>()!;
        }

        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference BlockPage
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference>()!;
        }

        [JsiiProperty(name: "bodyScanning", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBodyScanningOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBodyScanningOutputReference BodyScanning
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBodyScanningOutputReference>()!;
        }

        [JsiiProperty(name: "browserIsolation", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBrowserIsolationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBrowserIsolationOutputReference BrowserIsolation
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBrowserIsolationOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "customCertificate", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsCustomCertificateOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsCustomCertificateOutputReference CustomCertificate
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsCustomCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "extendedEmailMatching", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsExtendedEmailMatchingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsExtendedEmailMatchingOutputReference ExtendedEmailMatching
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsExtendedEmailMatchingOutputReference>()!;
        }

        [JsiiProperty(name: "fips", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsFipsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsFipsOutputReference Fips
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsFipsOutputReference>()!;
        }

        [JsiiProperty(name: "hostSelector", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsHostSelectorOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsHostSelectorOutputReference HostSelector
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsHostSelectorOutputReference>()!;
        }

        [JsiiProperty(name: "inspection", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsInspectionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsInspectionOutputReference Inspection
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsInspectionOutputReference>()!;
        }

        [JsiiProperty(name: "protocolDetection", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsProtocolDetectionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsProtocolDetectionOutputReference ProtocolDetection
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsProtocolDetectionOutputReference>()!;
        }

        [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsSandboxOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsSandboxOutputReference Sandbox
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsSandboxOutputReference>()!;
        }

        [JsiiProperty(name: "tlsDecrypt", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsTlsDecryptOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsTlsDecryptOutputReference TlsDecrypt
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsTlsDecryptOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettings\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.IDataCloudflareZeroTrustGatewaySettingsSettings? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.IDataCloudflareZeroTrustGatewaySettingsSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

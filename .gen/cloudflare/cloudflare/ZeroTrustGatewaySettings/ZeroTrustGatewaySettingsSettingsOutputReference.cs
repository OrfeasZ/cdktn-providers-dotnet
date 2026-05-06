using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewaySettings
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsOutputReference), fullyQualifiedName: "cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustGatewaySettingsSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustGatewaySettingsSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustGatewaySettingsSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustGatewaySettingsSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActivityLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLog\"}}]")]
        public virtual void PutActivityLog(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsActivityLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsActivityLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAntivirus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirus\"}}]")]
        public virtual void PutAntivirus(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsAntivirus)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlockPage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage\"}}]")]
        public virtual void PutBlockPage(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBlockPage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBodyScanning", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanning\"}}]")]
        public virtual void PutBodyScanning(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBodyScanning @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBodyScanning)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBrowserIsolation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolation\"}}]")]
        public virtual void PutBrowserIsolation(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBrowserIsolation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsBrowserIsolation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificate\"}}]")]
        public virtual void PutCertificate(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificate\"}}]")]
        public virtual void PutCustomCertificate(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCustomCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsCustomCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtendedEmailMatching", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatching\"}}]")]
        public virtual void PutExtendedEmailMatching(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsExtendedEmailMatching @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsExtendedEmailMatching)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFips", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFips\"}}]")]
        public virtual void PutFips(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsFips @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsFips)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHostSelector", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelector\"}}]")]
        public virtual void PutHostSelector(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsHostSelector @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsHostSelector)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInspection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsInspection\"}}]")]
        public virtual void PutInspection(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsInspection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsInspection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocolDetection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetection\"}}]")]
        public virtual void PutProtocolDetection(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsProtocolDetection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsProtocolDetection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSandbox", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandbox\"}}]")]
        public virtual void PutSandbox(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsSandbox @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsSandbox)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTlsDecrypt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecrypt\"}}]")]
        public virtual void PutTlsDecrypt(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsTlsDecrypt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettingsTlsDecrypt)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivityLog")]
        public virtual void ResetActivityLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAntivirus")]
        public virtual void ResetAntivirus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockPage")]
        public virtual void ResetBlockPage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBodyScanning")]
        public virtual void ResetBodyScanning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBrowserIsolation")]
        public virtual void ResetBrowserIsolation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomCertificate")]
        public virtual void ResetCustomCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtendedEmailMatching")]
        public virtual void ResetExtendedEmailMatching()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFips")]
        public virtual void ResetFips()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostSelector")]
        public virtual void ResetHostSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInspection")]
        public virtual void ResetInspection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocolDetection")]
        public virtual void ResetProtocolDetection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSandbox")]
        public virtual void ResetSandbox()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsDecrypt")]
        public virtual void ResetTlsDecrypt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activityLog", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLogOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLogOutputReference ActivityLog
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLogOutputReference>()!;
        }

        [JsiiProperty(name: "antivirus", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirusOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirusOutputReference Antivirus
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirusOutputReference>()!;
        }

        [JsiiProperty(name: "blockPage", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPageOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPageOutputReference BlockPage
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPageOutputReference>()!;
        }

        [JsiiProperty(name: "bodyScanning", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanningOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanningOutputReference BodyScanning
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanningOutputReference>()!;
        }

        [JsiiProperty(name: "browserIsolation", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolationOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolationOutputReference BrowserIsolation
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolationOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "customCertificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificateOutputReference CustomCertificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "extendedEmailMatching", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatchingOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatchingOutputReference ExtendedEmailMatching
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatchingOutputReference>()!;
        }

        [JsiiProperty(name: "fips", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFipsOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFipsOutputReference Fips
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFipsOutputReference>()!;
        }

        [JsiiProperty(name: "hostSelector", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelectorOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelectorOutputReference HostSelector
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelectorOutputReference>()!;
        }

        [JsiiProperty(name: "inspection", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsInspectionOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsInspectionOutputReference Inspection
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsInspectionOutputReference>()!;
        }

        [JsiiProperty(name: "protocolDetection", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetectionOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetectionOutputReference ProtocolDetection
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetectionOutputReference>()!;
        }

        [JsiiProperty(name: "sandbox", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandboxOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandboxOutputReference Sandbox
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandboxOutputReference>()!;
        }

        [JsiiProperty(name: "tlsDecrypt", typeJson: "{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecryptOutputReference\"}")]
        public virtual cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecryptOutputReference TlsDecrypt
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecryptOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activityLogInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsActivityLog\"}]}}", isOptional: true)]
        public virtual object? ActivityLogInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "antivirusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsAntivirus\"}]}}", isOptional: true)]
        public virtual object? AntivirusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockPageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBlockPage\"}]}}", isOptional: true)]
        public virtual object? BlockPageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyScanningInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBodyScanning\"}]}}", isOptional: true)]
        public virtual object? BodyScanningInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "browserIsolationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsBrowserIsolation\"}]}}", isOptional: true)]
        public virtual object? BrowserIsolationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCertificate\"}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsCustomCertificate\"}]}}", isOptional: true)]
        public virtual object? CustomCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedEmailMatchingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsExtendedEmailMatching\"}]}}", isOptional: true)]
        public virtual object? ExtendedEmailMatchingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fipsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsFips\"}]}}", isOptional: true)]
        public virtual object? FipsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostSelectorInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsHostSelector\"}]}}", isOptional: true)]
        public virtual object? HostSelectorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inspectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsInspection\"}]}}", isOptional: true)]
        public virtual object? InspectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolDetectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsProtocolDetection\"}]}}", isOptional: true)]
        public virtual object? ProtocolDetectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sandboxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsSandbox\"}]}}", isOptional: true)]
        public virtual object? SandboxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsDecryptInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettingsTlsDecrypt\"}]}}", isOptional: true)]
        public virtual object? TlsDecryptInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.zeroTrustGatewaySettings.ZeroTrustGatewaySettingsSettings\"}]}}", isOptional: true)]
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
                        case cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.ZeroTrustGatewaySettings.IZeroTrustGatewaySettingsSettings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

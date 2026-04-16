using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustGatewaySettings
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustGatewaySettingsSettingsBlockPageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackgroundColor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FooterText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeaderText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includeContext", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeContext
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logoPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mailtoAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailtoAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mailtoSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MailtoSubject
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReadOnly
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sourceAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suppressFooter", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SuppressFooter
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "targetUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustGatewaySettings.DataCloudflareZeroTrustGatewaySettingsSettingsBlockPage\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustGatewaySettings.IDataCloudflareZeroTrustGatewaySettingsSettingsBlockPage? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustGatewaySettings.IDataCloudflareZeroTrustGatewaySettingsSettingsBlockPage?>();
            set => SetInstanceProperty(value);
        }
    }
}

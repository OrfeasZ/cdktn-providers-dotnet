using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostname
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameSslOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareCustomHostnameSslOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareCustomHostnameSslOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareCustomHostnameSslOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCustomHostnameSslOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bundleMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BundleMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthority
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customCsrId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomCsrId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dcvDelegationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameSslDcvDelegationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslDcvDelegationRecordsList DcvDelegationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslDcvDelegationRecordsList>()!;
        }

        [JsiiProperty(name: "expiresOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiresOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Method
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameSslSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslSettingsOutputReference Settings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Signature
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uploadedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UploadedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validationErrors", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameSslValidationErrorsList\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslValidationErrorsList ValidationErrors
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslValidationErrorsList>()!;
        }

        [JsiiProperty(name: "validationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameSslValidationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslValidationRecordsList ValidationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.DataCloudflareCustomHostnameSslValidationRecordsList>()!;
        }

        [JsiiProperty(name: "wildcard", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Wildcard
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostname.DataCloudflareCustomHostnameSsl\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameSsl? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostname.IDataCloudflareCustomHostnameSsl?>();
            set => SetInstanceProperty(value);
        }
    }
}

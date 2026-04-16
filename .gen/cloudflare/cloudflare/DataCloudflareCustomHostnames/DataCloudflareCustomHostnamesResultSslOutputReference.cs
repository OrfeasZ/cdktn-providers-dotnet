using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareCustomHostnames
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareCustomHostnamesResultSslOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareCustomHostnamesResultSslOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareCustomHostnamesResultSslOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareCustomHostnamesResultSslOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "dcvDelegationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslDcvDelegationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslDcvDelegationRecordsList DcvDelegationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslDcvDelegationRecordsList>()!;
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

        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslSettingsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslSettingsOutputReference Settings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslSettingsOutputReference>()!;
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

        [JsiiProperty(name: "validationErrors", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslValidationErrorsList\"}")]
        public virtual cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslValidationErrorsList ValidationErrors
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslValidationErrorsList>()!;
        }

        [JsiiProperty(name: "validationRecords", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslValidationRecordsList\"}")]
        public virtual cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslValidationRecordsList ValidationRecords
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSslValidationRecordsList>()!;
        }

        [JsiiProperty(name: "wildcard", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Wildcard
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareCustomHostnames.DataCloudflareCustomHostnamesResultSsl\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareCustomHostnames.IDataCloudflareCustomHostnamesResultSsl? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareCustomHostnames.IDataCloudflareCustomHostnamesResultSsl?>();
            set => SetInstanceProperty(value);
        }
    }
}

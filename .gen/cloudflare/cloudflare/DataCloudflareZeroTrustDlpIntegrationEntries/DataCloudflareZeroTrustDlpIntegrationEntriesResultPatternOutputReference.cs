using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDlpIntegrationEntries
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDlpIntegrationEntries.DataCloudflareZeroTrustDlpIntegrationEntriesResultPatternOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDlpIntegrationEntries.DataCloudflareZeroTrustDlpIntegrationEntriesResultPatternOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustDlpIntegrationEntriesResultPatternOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustDlpIntegrationEntriesResultPatternOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustDlpIntegrationEntriesResultPatternOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDlpIntegrationEntriesResultPatternOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Regex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "validation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Validation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpIntegrationEntries.DataCloudflareZeroTrustDlpIntegrationEntriesResultPattern\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDlpIntegrationEntries.IDataCloudflareZeroTrustDlpIntegrationEntriesResultPattern? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpIntegrationEntries.IDataCloudflareZeroTrustDlpIntegrationEntriesResultPattern?>();
            set => SetInstanceProperty(value);
        }
    }
}

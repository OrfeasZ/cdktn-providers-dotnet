using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigOutputReference), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionViewerMtlsConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionViewerMtlsConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontDistributionViewerMtlsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionViewerMtlsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTrustStoreConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig\"}}]")]
        public virtual void PutTrustStoreConfig(aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustStoreConfig")]
        public virtual void ResetTrustStoreConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "trustStoreConfig", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfigOutputReference\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfigOutputReference TrustStoreConfig
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustStoreConfigInput", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig? TrustStoreConfigInput
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig?>();
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareHyperdriveConfigs
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareHyperdriveConfigs.DataCloudflareHyperdriveConfigsResultMtlsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareHyperdriveConfigs.DataCloudflareHyperdriveConfigsResultMtlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareHyperdriveConfigsResultMtlsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareHyperdriveConfigsResultMtlsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareHyperdriveConfigsResultMtlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareHyperdriveConfigsResultMtlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "caCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaCertificateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mtlsCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MtlsCertificateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslmode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sslmode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareHyperdriveConfigs.DataCloudflareHyperdriveConfigsResultMtls\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareHyperdriveConfigs.IDataCloudflareHyperdriveConfigsResultMtls? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareHyperdriveConfigs.IDataCloudflareHyperdriveConfigsResultMtls?>();
            set => SetInstanceProperty(value);
        }
    }
}

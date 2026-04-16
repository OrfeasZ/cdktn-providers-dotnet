using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessPolicy
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessPolicyRequireEmailDomainOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessPolicy.DataCloudflareZeroTrustAccessPolicyRequireEmailDomain\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessPolicy.IDataCloudflareZeroTrustAccessPolicyRequireEmailDomain? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessPolicy.IDataCloudflareZeroTrustAccessPolicyRequireEmailDomain?>();
            set => SetInstanceProperty(value);
        }
    }
}

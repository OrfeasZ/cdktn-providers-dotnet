using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroup
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupRequireGithubOrganizationOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupRequireGithubOrganizationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessGroupRequireGithubOrganizationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessGroupRequireGithubOrganizationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessGroupRequireGithubOrganizationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroupRequireGithubOrganizationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "team", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Team
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroup.DataCloudflareZeroTrustAccessGroupRequireGithubOrganization\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupRequireGithubOrganization? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroup.IDataCloudflareZeroTrustAccessGroupRequireGithubOrganization?>();
            set => SetInstanceProperty(value);
        }
    }
}

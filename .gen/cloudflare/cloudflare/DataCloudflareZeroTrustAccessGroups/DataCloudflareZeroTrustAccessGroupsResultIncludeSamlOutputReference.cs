using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroups
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeSamlOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeSamlOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessGroupsResultIncludeSamlOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessGroupsResultIncludeSamlOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessGroupsResultIncludeSamlOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroupsResultIncludeSamlOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributeValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeSaml\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroups.IDataCloudflareZeroTrustAccessGroupsResultIncludeSaml? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroups.IDataCloudflareZeroTrustAccessGroupsResultIncludeSaml?>();
            set => SetInstanceProperty(value);
        }
    }
}

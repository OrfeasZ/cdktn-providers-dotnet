using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessGroups
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustAccessGroupsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustAccessGroupsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroupsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessGroupsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultExcludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultExcludeList Exclude
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultExcludeList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeList Include
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIncludeList>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIsDefaultList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIsDefaultList IsDefault
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultIsDefaultList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "require", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultRequireList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultRequireList Require
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResultRequireList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessGroups.DataCloudflareZeroTrustAccessGroupsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessGroups.IDataCloudflareZeroTrustAccessGroupsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessGroups.IDataCloudflareZeroTrustAccessGroupsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOrganizations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareOrganizationsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareOrganizationsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareOrganizationsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOrganizationsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaOutputReference Meta
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultMetaOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parent", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultParentOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultParentOutputReference Parent
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultParentOutputReference>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResultProfileOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultProfileOutputReference Profile
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.DataCloudflareOrganizationsResultProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOrganizations.DataCloudflareOrganizationsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOrganizations.IDataCloudflareOrganizationsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

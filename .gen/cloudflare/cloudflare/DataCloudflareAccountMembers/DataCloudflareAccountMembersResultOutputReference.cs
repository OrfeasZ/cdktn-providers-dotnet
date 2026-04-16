using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareAccountMembers
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareAccountMembersResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareAccountMembersResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareAccountMembersResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareAccountMembersResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policies", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultPoliciesList\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultPoliciesList Policies
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultPoliciesList>()!;
        }

        [JsiiProperty(name: "roles", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesList\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesList Roles
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultRolesList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResultUserOutputReference\"}")]
        public virtual cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultUserOutputReference User
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.DataCloudflareAccountMembersResultUserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareAccountMembers.DataCloudflareAccountMembersResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareAccountMembers.IDataCloudflareAccountMembersResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareAccountMembers.IDataCloudflareAccountMembersResult?>();
            set => SetInstanceProperty(value);
        }
    }
}

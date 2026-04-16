using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiTokens
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiTokens.DataCloudflareApiTokensResultPoliciesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiTokens.DataCloudflareApiTokensResultPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareApiTokensResultPoliciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareApiTokensResultPoliciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareApiTokensResultPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiTokensResultPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Effect
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permissionGroups", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiTokens.DataCloudflareApiTokensResultPoliciesPermissionGroupsList\"}")]
        public virtual cloudflare.DataCloudflareApiTokens.DataCloudflareApiTokensResultPoliciesPermissionGroupsList PermissionGroups
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiTokens.DataCloudflareApiTokensResultPoliciesPermissionGroupsList>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Resources
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiTokens.DataCloudflareApiTokensResultPolicies\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiTokens.IDataCloudflareApiTokensResultPolicies? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiTokens.IDataCloudflareApiTokensResultPolicies?>();
            set => SetInstanceProperty(value);
        }
    }
}

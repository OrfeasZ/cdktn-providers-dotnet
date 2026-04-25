using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.UserGroupMembers
{
    [JsiiInterface(nativeType: typeof(IUserGroupMembersMembers), fullyQualifiedName: "cloudflare.userGroupMembers.UserGroupMembersMembers")]
    public interface IUserGroupMembersMembers
    {
        /// <summary>The identifier of an existing account Member.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group_members#id UserGroupMembers#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IUserGroupMembersMembers), fullyQualifiedName: "cloudflare.userGroupMembers.UserGroupMembersMembers")]
        internal sealed class _Proxy : DeputyBase, cloudflare.UserGroupMembers.IUserGroupMembersMembers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The identifier of an existing account Member.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group_members#id UserGroupMembers#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

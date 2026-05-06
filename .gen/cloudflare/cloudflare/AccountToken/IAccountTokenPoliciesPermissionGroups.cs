using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    [JsiiInterface(nativeType: typeof(IAccountTokenPoliciesPermissionGroups), fullyQualifiedName: "cloudflare.accountToken.AccountTokenPoliciesPermissionGroups")]
    public interface IAccountTokenPoliciesPermissionGroups
    {
        /// <summary>Identifier of the permission group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#id AccountToken#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Attributes associated to the permission group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#meta AccountToken#meta}
        /// </remarks>
        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"cloudflare.accountToken.AccountTokenPoliciesPermissionGroupsMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroupsMeta? Meta
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountTokenPoliciesPermissionGroups), fullyQualifiedName: "cloudflare.accountToken.AccountTokenPoliciesPermissionGroups")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier of the permission group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#id AccountToken#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Attributes associated to the permission group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_token#meta AccountToken#meta}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"cloudflare.accountToken.AccountTokenPoliciesPermissionGroupsMeta\"}", isOptional: true)]
            public cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroupsMeta? Meta
            {
                get => GetInstanceProperty<cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroupsMeta?>();
            }
        }
    }
}

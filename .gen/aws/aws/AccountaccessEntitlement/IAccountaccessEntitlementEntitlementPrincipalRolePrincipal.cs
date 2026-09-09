using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessEntitlement
{
    [JsiiInterface(nativeType: typeof(IAccountaccessEntitlementEntitlementPrincipalRolePrincipal), fullyQualifiedName: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipal")]
    public interface IAccountaccessEntitlementEntitlementPrincipalRolePrincipal
    {
        /// <summary>identity_center block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#identity_center AccountaccessEntitlement#identity_center}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityCenter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountaccessEntitlementEntitlementPrincipalRolePrincipal), fullyQualifiedName: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity_center block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#identity_center AccountaccessEntitlement#identity_center}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityCenter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

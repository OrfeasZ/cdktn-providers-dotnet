using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessEntitlement
{
    [JsiiInterface(nativeType: typeof(IAccountaccessEntitlementEntitlement), fullyQualifiedName: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlement")]
    public interface IAccountaccessEntitlementEntitlement
    {
        /// <summary>principal_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#principal_role AccountaccessEntitlement#principal_role}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRole" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "principalRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrincipalRole
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountaccessEntitlementEntitlement), fullyQualifiedName: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlement")]
        internal sealed class _Proxy : DeputyBase, aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>principal_role block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#principal_role AccountaccessEntitlement#principal_role}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRole" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "principalRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrincipalRole
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

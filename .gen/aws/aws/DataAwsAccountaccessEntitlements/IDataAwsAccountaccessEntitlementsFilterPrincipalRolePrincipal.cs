using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAccountaccessEntitlements
{
    [JsiiInterface(nativeType: typeof(IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal), fullyQualifiedName: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal")]
    public interface IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal
    {
        /// <summary>identity_center block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#identity_center DataAwsAccountaccessEntitlements#identity_center}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IdentityCenter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal), fullyQualifiedName: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity_center block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#identity_center DataAwsAccountaccessEntitlements#identity_center}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IdentityCenter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

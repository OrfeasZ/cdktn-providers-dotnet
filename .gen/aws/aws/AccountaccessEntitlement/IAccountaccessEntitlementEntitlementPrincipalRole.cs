using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessEntitlement
{
    [JsiiInterface(nativeType: typeof(IAccountaccessEntitlementEntitlementPrincipalRole), fullyQualifiedName: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRole")]
    public interface IAccountaccessEntitlementEntitlementPrincipalRole
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#role_arn AccountaccessEntitlement#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#principal AccountaccessEntitlement#principal}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipal" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "principal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Principal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountaccessEntitlementEntitlementPrincipalRole), fullyQualifiedName: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRole")]
        internal sealed class _Proxy : DeputyBase, aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRole
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#role_arn AccountaccessEntitlement#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>principal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#principal AccountaccessEntitlement#principal}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipal" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "principal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Principal
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

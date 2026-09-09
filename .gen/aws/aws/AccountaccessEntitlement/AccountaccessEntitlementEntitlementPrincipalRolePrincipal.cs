using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessEntitlement
{
    [JsiiByValue(fqn: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipal")]
    public class AccountaccessEntitlementEntitlementPrincipalRolePrincipal : aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipal
    {
        private object? _identityCenter;

        /// <summary>identity_center block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#identity_center AccountaccessEntitlement#identity_center}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IdentityCenter
        {
            get => _identityCenter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityCenter = value;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessEntitlement
{
    [JsiiByValue(fqn: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlement")]
    public class AccountaccessEntitlementEntitlement : aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlement
    {
        private object? _principalRole;

        /// <summary>principal_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#principal_role AccountaccessEntitlement#principal_role}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRole" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principalRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrincipalRole
        {
            get => _principalRole;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRole[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRole).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principalRole = value;
            }
        }
    }
}

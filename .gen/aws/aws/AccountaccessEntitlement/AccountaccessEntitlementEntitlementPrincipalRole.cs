using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessEntitlement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRole")]
    public class AccountaccessEntitlementEntitlementPrincipalRole : aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRole
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#role_arn AccountaccessEntitlement#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        private object? _principal;

        /// <summary>principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#principal AccountaccessEntitlement#principal}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipal" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Principal
        {
            get => _principal;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipal[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipal).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principal = value;
            }
        }
    }
}

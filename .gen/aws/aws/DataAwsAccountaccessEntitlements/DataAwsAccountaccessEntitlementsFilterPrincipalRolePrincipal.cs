using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAccountaccessEntitlements
{
    [JsiiByValue(fqn: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal")]
    public class DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal : aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipal
    {
        private object? _identityCenter;

        /// <summary>identity_center block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#identity_center DataAwsAccountaccessEntitlements#identity_center}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityCenter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identityCenter = value;
            }
        }
    }
}

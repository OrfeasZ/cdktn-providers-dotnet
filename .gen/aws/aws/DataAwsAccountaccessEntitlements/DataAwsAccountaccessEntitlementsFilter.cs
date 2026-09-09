using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAccountaccessEntitlements
{
    [JsiiByValue(fqn: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilter")]
    public class DataAwsAccountaccessEntitlementsFilter : aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilter
    {
        private object? _principalRole;

        /// <summary>principal_role block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#principal_role DataAwsAccountaccessEntitlements#principal_role}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRole" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principalRole", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRole\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRole[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRole).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principalRole = value;
            }
        }
    }
}

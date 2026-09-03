using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiByValue(fqn: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUser")]
    public class DatazonePolicyGrantPrincipalUser : aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUser
    {
        private object? _allUsersGrantFilter;

        /// <summary>all_users_grant_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#all_users_grant_filter DatazonePolicyGrant#all_users_grant_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUserAllUsersGrantFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allUsersGrantFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUserAllUsersGrantFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllUsersGrantFilter
        {
            get => _allUsersGrantFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUserAllUsersGrantFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUserAllUsersGrantFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allUsersGrantFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#user_identifier DatazonePolicyGrant#user_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserIdentifier
        {
            get;
            set;
        }
    }
}

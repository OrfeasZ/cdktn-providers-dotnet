using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiInterface(nativeType: typeof(IDatazonePolicyGrantPrincipalUser), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUser")]
    public interface IDatazonePolicyGrantPrincipalUser
    {
        /// <summary>all_users_grant_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#all_users_grant_filter DatazonePolicyGrant#all_users_grant_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUserAllUsersGrantFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "allUsersGrantFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUserAllUsersGrantFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllUsersGrantFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#user_identifier DatazonePolicyGrant#user_identifier}.</summary>
        [JsiiProperty(name: "userIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazonePolicyGrantPrincipalUser), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUser")]
        internal sealed class _Proxy : DeputyBase, aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_users_grant_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#all_users_grant_filter DatazonePolicyGrant#all_users_grant_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUserAllUsersGrantFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allUsersGrantFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUserAllUsersGrantFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllUsersGrantFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#user_identifier DatazonePolicyGrant#user_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainCognitoOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainCognitoOptions")]
    public interface IOpensearchDomainCognitoOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#identity_pool_id OpensearchDomain#identity_pool_id}.</summary>
        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#role_arn OpensearchDomain#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#user_pool_id OpensearchDomain#user_pool_id}.</summary>
        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainCognitoOptions), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainCognitoOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomain.IOpensearchDomainCognitoOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#identity_pool_id OpensearchDomain#identity_pool_id}.</summary>
            [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#role_arn OpensearchDomain#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#user_pool_id OpensearchDomain#user_pool_id}.</summary>
            [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/opensearch_domain#enabled OpensearchDomain#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

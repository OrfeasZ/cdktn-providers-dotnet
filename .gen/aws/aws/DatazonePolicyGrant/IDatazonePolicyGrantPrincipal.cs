using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiInterface(nativeType: typeof(IDatazonePolicyGrantPrincipal), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipal")]
    public interface IDatazonePolicyGrantPrincipal
    {
        /// <summary>domain_unit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit DatazonePolicyGrant#domain_unit}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnit" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "domainUnit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DomainUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#group DatazonePolicyGrant#group}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalGroup" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>project block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project DatazonePolicyGrant#project}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProject" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "project", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProject\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Project
        {
            get
            {
                return null;
            }
        }

        /// <summary>user block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#user DatazonePolicyGrant#user}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUser" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? User
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazonePolicyGrantPrincipal), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantPrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>domain_unit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#domain_unit DatazonePolicyGrant#domain_unit}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalDomainUnit" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "domainUnit", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalDomainUnit\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DomainUnit
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#group DatazonePolicyGrant#group}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalGroup" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Group
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>project block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#project DatazonePolicyGrant#project}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalProject" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "project", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalProject\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Project
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>user block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#user DatazonePolicyGrant#user}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.DatazonePolicyGrant.IDatazonePolicyGrantPrincipalUser" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datazonePolicyGrant.DatazonePolicyGrantPrincipalUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? User
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

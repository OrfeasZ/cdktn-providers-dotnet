using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicy
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsPolicyDefinitionTemplateLinked), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinked")]
    public interface IVerifiedpermissionsPolicyDefinitionTemplateLinked
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/verifiedpermissions_policy#policy_template_id VerifiedpermissionsPolicy#policy_template_id}.</summary>
        [JsiiProperty(name: "policyTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyTemplateId
        {
            get;
        }

        /// <summary>principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/verifiedpermissions_policy#principal VerifiedpermissionsPolicy#principal}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "principal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Principal
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/verifiedpermissions_policy#resource VerifiedpermissionsPolicy#resource}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedResource" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Resource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsPolicyDefinitionTemplateLinked), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinked")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinked
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/verifiedpermissions_policy#policy_template_id VerifiedpermissionsPolicy#policy_template_id}.</summary>
            [JsiiProperty(name: "policyTemplateId", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyTemplateId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>principal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/verifiedpermissions_policy#principal VerifiedpermissionsPolicy#principal}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "principal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Principal
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/verifiedpermissions_policy#resource VerifiedpermissionsPolicy#resource}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedResource" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Resource
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

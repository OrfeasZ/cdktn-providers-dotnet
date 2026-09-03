using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazonePolicyGrant
{
    [JsiiInterface(nativeType: typeof(IDatazonePolicyGrantDetailCreateGlossary), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossary")]
    public interface IDatazonePolicyGrantDetailCreateGlossary
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#include_child_domain_units DatazonePolicyGrant#include_child_domain_units}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "includeChildDomainUnits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeChildDomainUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatazonePolicyGrantDetailCreateGlossary), fullyQualifiedName: "aws.datazonePolicyGrant.DatazonePolicyGrantDetailCreateGlossary")]
        internal sealed class _Proxy : DeputyBase, aws.DatazonePolicyGrant.IDatazonePolicyGrantDetailCreateGlossary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/datazone_policy_grant#include_child_domain_units DatazonePolicyGrant#include_child_domain_units}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeChildDomainUnits", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeChildDomainUnits
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditionsPlatforms), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms")]
    public interface IConditionalAccessPolicyConditionsPlatforms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_platforms ConditionalAccessPolicy#included_platforms}.</summary>
        [JsiiProperty(name: "includedPlatforms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IncludedPlatforms
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_platforms ConditionalAccessPolicy#excluded_platforms}.</summary>
        [JsiiProperty(name: "excludedPlatforms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedPlatforms
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditionsPlatforms), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_platforms ConditionalAccessPolicy#included_platforms}.</summary>
            [JsiiProperty(name: "includedPlatforms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IncludedPlatforms
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_platforms ConditionalAccessPolicy#excluded_platforms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedPlatforms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedPlatforms
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

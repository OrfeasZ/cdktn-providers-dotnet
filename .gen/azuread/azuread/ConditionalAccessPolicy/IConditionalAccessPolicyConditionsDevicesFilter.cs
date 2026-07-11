using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditionsDevicesFilter), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilter")]
    public interface IConditionalAccessPolicyConditionsDevicesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#mode ConditionalAccessPolicy#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#rule ConditionalAccessPolicy#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        string Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditionsDevicesFilter), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevicesFilter")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevicesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#mode ConditionalAccessPolicy#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#rule ConditionalAccessPolicy#rule}.</summary>
            [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
            public string Rule
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

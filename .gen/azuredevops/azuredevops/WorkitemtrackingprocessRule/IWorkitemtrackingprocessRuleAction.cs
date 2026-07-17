using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessRule
{
    [JsiiInterface(nativeType: typeof(IWorkitemtrackingprocessRuleAction), fullyQualifiedName: "azuredevops.workitemtrackingprocessRule.WorkitemtrackingprocessRuleAction")]
    public interface IWorkitemtrackingprocessRuleAction
    {
        /// <summary>Type of action.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#action_type WorkitemtrackingprocessRule#action_type}
        /// </remarks>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionType
        {
            get;
        }

        /// <summary>Field (reference name) to act on.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#target_field WorkitemtrackingprocessRule#target_field}
        /// </remarks>
        [JsiiProperty(name: "targetField", typeJson: "{\"primitive\":\"string\"}")]
        string TargetField
        {
            get;
        }

        /// <summary>Value to set on the target field.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#value WorkitemtrackingprocessRule#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkitemtrackingprocessRuleAction), fullyQualifiedName: "azuredevops.workitemtrackingprocessRule.WorkitemtrackingprocessRuleAction")]
        internal sealed class _Proxy : DeputyBase, azuredevops.WorkitemtrackingprocessRule.IWorkitemtrackingprocessRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of action.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#action_type WorkitemtrackingprocessRule#action_type}
            /// </remarks>
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Field (reference name) to act on.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#target_field WorkitemtrackingprocessRule#target_field}
            /// </remarks>
            [JsiiProperty(name: "targetField", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Value to set on the target field.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#value WorkitemtrackingprocessRule#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

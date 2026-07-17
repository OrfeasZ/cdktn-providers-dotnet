using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessRule
{
    [JsiiInterface(nativeType: typeof(IWorkitemtrackingprocessRuleCondition), fullyQualifiedName: "azuredevops.workitemtrackingprocessRule.WorkitemtrackingprocessRuleCondition")]
    public interface IWorkitemtrackingprocessRuleCondition
    {
        /// <summary>Type of condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#condition_type WorkitemtrackingprocessRule#condition_type}
        /// </remarks>
        [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConditionType
        {
            get;
        }

        /// <summary>Field reference name for the condition.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#field WorkitemtrackingprocessRule#field}
        /// </remarks>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Field
        {
            get
            {
                return null;
            }
        }

        /// <summary>Value to match for the condition.</summary>
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

        [JsiiTypeProxy(nativeType: typeof(IWorkitemtrackingprocessRuleCondition), fullyQualifiedName: "azuredevops.workitemtrackingprocessRule.WorkitemtrackingprocessRuleCondition")]
        internal sealed class _Proxy : DeputyBase, azuredevops.WorkitemtrackingprocessRule.IWorkitemtrackingprocessRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of condition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#condition_type WorkitemtrackingprocessRule#condition_type}
            /// </remarks>
            [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConditionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Field reference name for the condition.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/workitemtrackingprocess_rule#field WorkitemtrackingprocessRule#field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Field
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Value to match for the condition.</summary>
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

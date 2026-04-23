using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts")]
    public interface IDlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execution_handler DlmLifecyclePolicy#execution_handler}.</summary>
        [JsiiProperty(name: "executionHandler", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionHandler
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execute_operation_on_script_failure DlmLifecyclePolicy#execute_operation_on_script_failure}.</summary>
        [JsiiProperty(name: "executeOperationOnScriptFailure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExecuteOperationOnScriptFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execution_handler_service DlmLifecyclePolicy#execution_handler_service}.</summary>
        [JsiiProperty(name: "executionHandlerService", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionHandlerService
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execution_timeout DlmLifecyclePolicy#execution_timeout}.</summary>
        [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExecutionTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#maximum_retry_count DlmLifecyclePolicy#maximum_retry_count}.</summary>
        [JsiiProperty(name: "maximumRetryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumRetryCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#stages DlmLifecyclePolicy#stages}.</summary>
        [JsiiProperty(name: "stages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Stages
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts")]
        internal sealed class _Proxy : DeputyBase, aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execution_handler DlmLifecyclePolicy#execution_handler}.</summary>
            [JsiiProperty(name: "executionHandler", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionHandler
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execute_operation_on_script_failure DlmLifecyclePolicy#execute_operation_on_script_failure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executeOperationOnScriptFailure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExecuteOperationOnScriptFailure
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execution_handler_service DlmLifecyclePolicy#execution_handler_service}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionHandlerService", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionHandlerService
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#execution_timeout DlmLifecyclePolicy#execution_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExecutionTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#maximum_retry_count DlmLifecyclePolicy#maximum_retry_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumRetryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumRetryCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/dlm_lifecycle_policy#stages DlmLifecyclePolicy#stages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Stages
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

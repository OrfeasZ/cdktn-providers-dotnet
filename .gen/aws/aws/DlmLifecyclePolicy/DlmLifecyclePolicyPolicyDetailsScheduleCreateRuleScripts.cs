using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts : aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRuleScripts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#execution_handler DlmLifecyclePolicy#execution_handler}.</summary>
        [JsiiProperty(name: "executionHandler", typeJson: "{\"primitive\":\"string\"}")]
        public string ExecutionHandler
        {
            get;
            set;
        }

        private object? _executeOperationOnScriptFailure;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#execute_operation_on_script_failure DlmLifecyclePolicy#execute_operation_on_script_failure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executeOperationOnScriptFailure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExecuteOperationOnScriptFailure
        {
            get => _executeOperationOnScriptFailure;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _executeOperationOnScriptFailure = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#execution_handler_service DlmLifecyclePolicy#execution_handler_service}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionHandlerService", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExecutionHandlerService
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#execution_timeout DlmLifecyclePolicy#execution_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExecutionTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#maximum_retry_count DlmLifecyclePolicy#maximum_retry_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumRetryCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#stages DlmLifecyclePolicy#stages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Stages
        {
            get;
            set;
        }
    }
}

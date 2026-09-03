using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppWorkflow
{
    [JsiiByValue(fqn: "azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTrigger")]
    public class LogicAppWorkflowAccessControlTrigger : azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/logic_app_workflow#allowed_caller_ip_address_range LogicAppWorkflow#allowed_caller_ip_address_range}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedCallerIpAddressRange", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedCallerIpAddressRange
        {
            get;
            set;
        }

        private object? _openAuthenticationPolicy;

        /// <summary>open_authentication_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/logic_app_workflow#open_authentication_policy LogicAppWorkflow#open_authentication_policy}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openAuthenticationPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.logicAppWorkflow.LogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OpenAuthenticationPolicy
        {
            get => _openAuthenticationPolicy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.LogicAppWorkflow.ILogicAppWorkflowAccessControlTriggerOpenAuthenticationPolicy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _openAuthenticationPolicy = value;
            }
        }
    }
}

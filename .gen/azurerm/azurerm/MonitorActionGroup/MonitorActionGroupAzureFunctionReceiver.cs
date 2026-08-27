using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorActionGroup.MonitorActionGroupAzureFunctionReceiver")]
    public class MonitorActionGroupAzureFunctionReceiver : azurerm.MonitorActionGroup.IMonitorActionGroupAzureFunctionReceiver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_action_group#function_app_resource_id MonitorActionGroup#function_app_resource_id}.</summary>
        [JsiiProperty(name: "functionAppResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionAppResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_action_group#function_name MonitorActionGroup#function_name}.</summary>
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_action_group#http_trigger_url MonitorActionGroup#http_trigger_url}.</summary>
        [JsiiProperty(name: "httpTriggerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpTriggerUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _useCommonAlertSchema;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/monitor_action_group#use_common_alert_schema MonitorActionGroup#use_common_alert_schema}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useCommonAlertSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseCommonAlertSchema
        {
            get => _useCommonAlertSchema;
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
                _useCommonAlertSchema = value;
            }
        }
    }
}

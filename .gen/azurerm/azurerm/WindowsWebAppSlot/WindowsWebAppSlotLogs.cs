using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiByValue(fqn: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogs")]
    public class WindowsWebAppSlotLogs : azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogs
    {
        /// <summary>application_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app_slot#application_logs WindowsWebAppSlot#application_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogs\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogs? ApplicationLogs
        {
            get;
            set;
        }

        private object? _detailedErrorMessages;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app_slot#detailed_error_messages WindowsWebAppSlot#detailed_error_messages}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DetailedErrorMessages
        {
            get => _detailedErrorMessages;
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
                _detailedErrorMessages = value;
            }
        }

        private object? _failedRequestTracing;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app_slot#failed_request_tracing WindowsWebAppSlot#failed_request_tracing}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? FailedRequestTracing
        {
            get => _failedRequestTracing;
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
                _failedRequestTracing = value;
            }
        }

        /// <summary>http_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app_slot#http_logs WindowsWebAppSlot#http_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogs\"}", isOptional: true)]
        public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs? HttpLogs
        {
            get;
            set;
        }
    }
}

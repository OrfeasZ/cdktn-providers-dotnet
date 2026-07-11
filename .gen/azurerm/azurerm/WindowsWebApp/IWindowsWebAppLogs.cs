using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppLogs), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppLogs")]
    public interface IWindowsWebAppLogs
    {
        /// <summary>application_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#application_logs WindowsWebApp#application_logs}
        /// </remarks>
        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsApplicationLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogs? ApplicationLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#detailed_error_messages WindowsWebApp#detailed_error_messages}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DetailedErrorMessages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#failed_request_tracing WindowsWebApp#failed_request_tracing}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailedRequestTracing
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#http_logs WindowsWebApp#http_logs}
        /// </remarks>
        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogs? HttpLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppLogs), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#application_logs WindowsWebApp#application_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsApplicationLogs\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogs? ApplicationLogs
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsApplicationLogs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#detailed_error_messages WindowsWebApp#detailed_error_messages}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DetailedErrorMessages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#failed_request_tracing WindowsWebApp#failed_request_tracing}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FailedRequestTracing
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/windows_web_app#http_logs WindowsWebApp#http_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppLogsHttpLogs\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogs? HttpLogs
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppLogsHttpLogs?>();
            }
        }
    }
}

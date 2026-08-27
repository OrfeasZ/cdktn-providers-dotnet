using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSlotLogs), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogs")]
    public interface ILinuxWebAppSlotLogs
    {
        /// <summary>application_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#application_logs LinuxWebAppSlot#application_logs}
        /// </remarks>
        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs? ApplicationLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#detailed_error_messages LinuxWebAppSlot#detailed_error_messages}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#failed_request_tracing LinuxWebAppSlot#failed_request_tracing}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#http_logs LinuxWebAppSlot#http_logs}
        /// </remarks>
        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs? HttpLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSlotLogs), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#application_logs LinuxWebAppSlot#application_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsApplicationLogs\"}", isOptional: true)]
            public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs? ApplicationLogs
            {
                get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsApplicationLogs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#detailed_error_messages LinuxWebAppSlot#detailed_error_messages}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DetailedErrorMessages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#failed_request_tracing LinuxWebAppSlot#failed_request_tracing}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/linux_web_app_slot#http_logs LinuxWebAppSlot#http_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebAppSlot.LinuxWebAppSlotLogsHttpLogs\"}", isOptional: true)]
            public azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs? HttpLogs
            {
                get => GetInstanceProperty<azurerm.LinuxWebAppSlot.ILinuxWebAppSlotLogsHttpLogs?>();
            }
        }
    }
}

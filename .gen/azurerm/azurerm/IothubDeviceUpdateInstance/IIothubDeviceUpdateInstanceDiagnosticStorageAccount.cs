using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IothubDeviceUpdateInstance
{
    [JsiiInterface(nativeType: typeof(IIothubDeviceUpdateInstanceDiagnosticStorageAccount), fullyQualifiedName: "azurerm.iothubDeviceUpdateInstance.IothubDeviceUpdateInstanceDiagnosticStorageAccount")]
    public interface IIothubDeviceUpdateInstanceDiagnosticStorageAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#id IothubDeviceUpdateInstance#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#connection_string IothubDeviceUpdateInstance#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#connection_string_wo IothubDeviceUpdateInstance#connection_string_wo}.</summary>
        [JsiiProperty(name: "connectionStringWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionStringWo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#connection_string_wo_version IothubDeviceUpdateInstance#connection_string_wo_version}.</summary>
        [JsiiProperty(name: "connectionStringWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionStringWoVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIothubDeviceUpdateInstanceDiagnosticStorageAccount), fullyQualifiedName: "azurerm.iothubDeviceUpdateInstance.IothubDeviceUpdateInstanceDiagnosticStorageAccount")]
        internal sealed class _Proxy : DeputyBase, azurerm.IothubDeviceUpdateInstance.IIothubDeviceUpdateInstanceDiagnosticStorageAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#id IothubDeviceUpdateInstance#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#connection_string IothubDeviceUpdateInstance#connection_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#connection_string_wo IothubDeviceUpdateInstance#connection_string_wo}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionStringWo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionStringWo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.6.0/docs/resources/iothub_device_update_instance#connection_string_wo_version IothubDeviceUpdateInstance#connection_string_wo_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionStringWoVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionStringWoVersion
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

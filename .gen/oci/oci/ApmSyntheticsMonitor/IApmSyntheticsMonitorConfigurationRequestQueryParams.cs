using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorConfigurationRequestQueryParams), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParams")]
    public interface IApmSyntheticsMonitorConfigurationRequestQueryParams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_name ApmSyntheticsMonitor#param_name}.</summary>
        [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParamName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_value ApmSyntheticsMonitor#param_value}.</summary>
        [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParamValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorConfigurationRequestQueryParams), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationRequestQueryParams")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationRequestQueryParams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_name ApmSyntheticsMonitor#param_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParamName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_value ApmSyntheticsMonitor#param_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParamValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

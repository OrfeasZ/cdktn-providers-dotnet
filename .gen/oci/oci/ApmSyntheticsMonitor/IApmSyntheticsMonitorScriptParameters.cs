using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorScriptParameters), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorScriptParameters")]
    public interface IApmSyntheticsMonitorScriptParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_name ApmSyntheticsMonitor#param_name}.</summary>
        [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}")]
        string ParamName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_value ApmSyntheticsMonitor#param_value}.</summary>
        [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}")]
        string ParamValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorScriptParameters), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorScriptParameters")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorScriptParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_name ApmSyntheticsMonitor#param_name}.</summary>
            [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}")]
            public string ParamName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#param_value ApmSyntheticsMonitor#param_value}.</summary>
            [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ParamValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

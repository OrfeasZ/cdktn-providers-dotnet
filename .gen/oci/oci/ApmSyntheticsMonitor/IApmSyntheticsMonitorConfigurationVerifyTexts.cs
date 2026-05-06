using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorConfigurationVerifyTexts), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTexts")]
    public interface IApmSyntheticsMonitorConfigurationVerifyTexts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#text ApmSyntheticsMonitor#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Text
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorConfigurationVerifyTexts), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationVerifyTexts")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationVerifyTexts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#text ApmSyntheticsMonitor#text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Text
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

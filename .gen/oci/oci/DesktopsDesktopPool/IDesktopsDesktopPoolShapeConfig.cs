using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DesktopsDesktopPool
{
    [JsiiInterface(nativeType: typeof(IDesktopsDesktopPoolShapeConfig), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolShapeConfig")]
    public interface IDesktopsDesktopPoolShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#baseline_ocpu_utilization DesktopsDesktopPool#baseline_ocpu_utilization}.</summary>
        [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaselineOcpuUtilization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#memory_in_gbs DesktopsDesktopPool#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MemoryInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#ocpus DesktopsDesktopPool#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ocpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDesktopsDesktopPoolShapeConfig), fullyQualifiedName: "oci.desktopsDesktopPool.DesktopsDesktopPoolShapeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DesktopsDesktopPool.IDesktopsDesktopPoolShapeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#baseline_ocpu_utilization DesktopsDesktopPool#baseline_ocpu_utilization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaselineOcpuUtilization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#memory_in_gbs DesktopsDesktopPool#memory_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MemoryInGbs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/desktops_desktop_pool#ocpus DesktopsDesktopPool#ocpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ocpus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

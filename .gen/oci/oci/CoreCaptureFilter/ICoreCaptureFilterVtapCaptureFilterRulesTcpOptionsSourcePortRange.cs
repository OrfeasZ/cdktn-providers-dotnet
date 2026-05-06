using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreCaptureFilter
{
    [JsiiInterface(nativeType: typeof(ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange")]
    public interface ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#max CoreCaptureFilter#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        double Max
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#min CoreCaptureFilter#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        double Min
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange), fullyQualifiedName: "oci.coreCaptureFilter.CoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange")]
        internal sealed class _Proxy : DeputyBase, oci.CoreCaptureFilter.ICoreCaptureFilterVtapCaptureFilterRulesTcpOptionsSourcePortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#max CoreCaptureFilter#max}.</summary>
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
            public double Max
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_capture_filter#min CoreCaptureFilter#min}.</summary>
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
            public double Min
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

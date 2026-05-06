using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsDedicatedVantagePoint
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsDedicatedVantagePointDvpStackDetails), fullyQualifiedName: "oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetails")]
    public interface IApmSyntheticsDedicatedVantagePointDvpStackDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stack_id ApmSyntheticsDedicatedVantagePoint#dvp_stack_id}.</summary>
        [JsiiProperty(name: "dvpStackId", typeJson: "{\"primitive\":\"string\"}")]
        string DvpStackId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stack_type ApmSyntheticsDedicatedVantagePoint#dvp_stack_type}.</summary>
        [JsiiProperty(name: "dvpStackType", typeJson: "{\"primitive\":\"string\"}")]
        string DvpStackType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stream_id ApmSyntheticsDedicatedVantagePoint#dvp_stream_id}.</summary>
        [JsiiProperty(name: "dvpStreamId", typeJson: "{\"primitive\":\"string\"}")]
        string DvpStreamId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_version ApmSyntheticsDedicatedVantagePoint#dvp_version}.</summary>
        [JsiiProperty(name: "dvpVersion", typeJson: "{\"primitive\":\"string\"}")]
        string DvpVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsDedicatedVantagePointDvpStackDetails), fullyQualifiedName: "oci.apmSyntheticsDedicatedVantagePoint.ApmSyntheticsDedicatedVantagePointDvpStackDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsDedicatedVantagePoint.IApmSyntheticsDedicatedVantagePointDvpStackDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stack_id ApmSyntheticsDedicatedVantagePoint#dvp_stack_id}.</summary>
            [JsiiProperty(name: "dvpStackId", typeJson: "{\"primitive\":\"string\"}")]
            public string DvpStackId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stack_type ApmSyntheticsDedicatedVantagePoint#dvp_stack_type}.</summary>
            [JsiiProperty(name: "dvpStackType", typeJson: "{\"primitive\":\"string\"}")]
            public string DvpStackType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_stream_id ApmSyntheticsDedicatedVantagePoint#dvp_stream_id}.</summary>
            [JsiiProperty(name: "dvpStreamId", typeJson: "{\"primitive\":\"string\"}")]
            public string DvpStreamId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_dedicated_vantage_point#dvp_version ApmSyntheticsDedicatedVantagePoint#dvp_version}.</summary>
            [JsiiProperty(name: "dvpVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string DvpVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

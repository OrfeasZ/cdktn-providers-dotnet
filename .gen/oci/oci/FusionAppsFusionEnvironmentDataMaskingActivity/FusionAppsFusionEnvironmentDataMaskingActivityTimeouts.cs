using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentDataMaskingActivity
{
    [JsiiByValue(fqn: "oci.fusionAppsFusionEnvironmentDataMaskingActivity.FusionAppsFusionEnvironmentDataMaskingActivityTimeouts")]
    public class FusionAppsFusionEnvironmentDataMaskingActivityTimeouts : oci.FusionAppsFusionEnvironmentDataMaskingActivity.IFusionAppsFusionEnvironmentDataMaskingActivityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#create FusionAppsFusionEnvironmentDataMaskingActivity#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#delete FusionAppsFusionEnvironmentDataMaskingActivity#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#update FusionAppsFusionEnvironmentDataMaskingActivity#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}

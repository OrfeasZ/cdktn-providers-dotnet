using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentDataMaskingActivity
{
    [JsiiInterface(nativeType: typeof(IFusionAppsFusionEnvironmentDataMaskingActivityTimeouts), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentDataMaskingActivity.FusionAppsFusionEnvironmentDataMaskingActivityTimeouts")]
    public interface IFusionAppsFusionEnvironmentDataMaskingActivityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#create FusionAppsFusionEnvironmentDataMaskingActivity#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#delete FusionAppsFusionEnvironmentDataMaskingActivity#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#update FusionAppsFusionEnvironmentDataMaskingActivity#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFusionAppsFusionEnvironmentDataMaskingActivityTimeouts), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentDataMaskingActivity.FusionAppsFusionEnvironmentDataMaskingActivityTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.FusionAppsFusionEnvironmentDataMaskingActivity.IFusionAppsFusionEnvironmentDataMaskingActivityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#create FusionAppsFusionEnvironmentDataMaskingActivity#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#delete FusionAppsFusionEnvironmentDataMaskingActivity#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_data_masking_activity#update FusionAppsFusionEnvironmentDataMaskingActivity#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

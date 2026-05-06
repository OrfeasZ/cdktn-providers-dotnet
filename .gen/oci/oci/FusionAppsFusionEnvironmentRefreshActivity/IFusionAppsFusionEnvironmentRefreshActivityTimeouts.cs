using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentRefreshActivity
{
    [JsiiInterface(nativeType: typeof(IFusionAppsFusionEnvironmentRefreshActivityTimeouts), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeouts")]
    public interface IFusionAppsFusionEnvironmentRefreshActivityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_refresh_activity#create FusionAppsFusionEnvironmentRefreshActivity#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFusionAppsFusionEnvironmentRefreshActivityTimeouts), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.FusionAppsFusionEnvironmentRefreshActivity.IFusionAppsFusionEnvironmentRefreshActivityTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_refresh_activity#create FusionAppsFusionEnvironmentRefreshActivity#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

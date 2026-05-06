using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsRepositorySettingMergeChecks), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecks")]
    public interface IDevopsRepositorySettingMergeChecks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#last_build_succeeded DevopsRepositorySetting#last_build_succeeded}.</summary>
        [JsiiProperty(name: "lastBuildSucceeded", typeJson: "{\"primitive\":\"string\"}")]
        string LastBuildSucceeded
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsRepositorySettingMergeChecks), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecks")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#last_build_succeeded DevopsRepositorySetting#last_build_succeeded}.</summary>
            [JsiiProperty(name: "lastBuildSucceeded", typeJson: "{\"primitive\":\"string\"}")]
            public string LastBuildSucceeded
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsRepositorySettingApprovalRulesItemsReviewers), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesItemsReviewers")]
    public interface IDevopsRepositorySettingApprovalRulesItemsReviewers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#principal_id DevopsRepositorySetting#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsRepositorySettingApprovalRulesItemsReviewers), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesItemsReviewers")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRulesItemsReviewers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#principal_id DevopsRepositorySetting#principal_id}.</summary>
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

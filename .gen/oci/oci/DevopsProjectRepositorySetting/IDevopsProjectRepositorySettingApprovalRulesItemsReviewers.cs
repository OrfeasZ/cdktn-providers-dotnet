using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProjectRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsProjectRepositorySettingApprovalRulesItemsReviewers), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItemsReviewers")]
    public interface IDevopsProjectRepositorySettingApprovalRulesItemsReviewers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#principal_id DevopsProjectRepositorySetting#principal_id}.</summary>
        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        string PrincipalId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsProjectRepositorySettingApprovalRulesItemsReviewers), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItemsReviewers")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRulesItemsReviewers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#principal_id DevopsProjectRepositorySetting#principal_id}.</summary>
            [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

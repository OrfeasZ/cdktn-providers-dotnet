using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentCategoryLogDetailsAccess), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccess")]
    public interface IDatascienceModelDeploymentCategoryLogDetailsAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#log_group_id DatascienceModelDeployment#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#log_id DatascienceModelDeployment#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        string LogId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentCategoryLogDetailsAccess), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccess")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#log_group_id DatascienceModelDeployment#log_group_id}.</summary>
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#log_id DatascienceModelDeployment#log_id}.</summary>
            [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}

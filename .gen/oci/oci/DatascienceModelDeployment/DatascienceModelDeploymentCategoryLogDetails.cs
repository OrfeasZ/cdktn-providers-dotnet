using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetails")]
    public class DatascienceModelDeploymentCategoryLogDetails : oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetails
    {
        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#access DatascienceModelDeployment#access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccess\"}", isOptional: true)]
        public oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess? Access
        {
            get;
            set;
        }

        /// <summary>predict block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#predict DatascienceModelDeployment#predict}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "predict", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredict\"}", isOptional: true)]
        public oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict? Predict
        {
            get;
            set;
        }
    }
}

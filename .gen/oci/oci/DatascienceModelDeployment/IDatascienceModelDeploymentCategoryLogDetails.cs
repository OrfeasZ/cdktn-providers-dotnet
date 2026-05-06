using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentCategoryLogDetails), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetails")]
    public interface IDatascienceModelDeploymentCategoryLogDetails
    {
        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#access DatascienceModelDeployment#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>predict block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#predict DatascienceModelDeployment#predict}
        /// </remarks>
        [JsiiProperty(name: "predict", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredict\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict? Predict
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentCategoryLogDetails), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#access DatascienceModelDeployment#access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsAccess\"}", isOptional: true)]
            public oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess? Access
            {
                get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsAccess?>();
            }

            /// <summary>predict block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_model_deployment#predict DatascienceModelDeployment#predict}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "predict", typeJson: "{\"fqn\":\"oci.datascienceModelDeployment.DatascienceModelDeploymentCategoryLogDetailsPredict\"}", isOptional: true)]
            public oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict? Predict
            {
                get => GetInstanceProperty<oci.DatascienceModelDeployment.IDatascienceModelDeploymentCategoryLogDetailsPredict?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiInterface(nativeType: typeof(IDevopsDeployStageFailurePolicy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageFailurePolicy")]
    public interface IDevopsDeployStageFailurePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#policy_type DevopsDeployStage#policy_type}.</summary>
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_count DevopsDeployStage#failure_count}.</summary>
        [JsiiProperty(name: "failureCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_percentage DevopsDeployStage#failure_percentage}.</summary>
        [JsiiProperty(name: "failurePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailurePercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsDeployStageFailurePolicy), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageFailurePolicy")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsDeployStage.IDevopsDeployStageFailurePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#policy_type DevopsDeployStage#policy_type}.</summary>
            [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_count DevopsDeployStage#failure_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_deploy_stage#failure_percentage DevopsDeployStage#failure_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failurePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailurePercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

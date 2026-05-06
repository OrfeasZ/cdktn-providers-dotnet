using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AdmRemediationRecipe
{
    [JsiiInterface(nativeType: typeof(IAdmRemediationRecipeVerifyConfiguration), fullyQualifiedName: "oci.admRemediationRecipe.AdmRemediationRecipeVerifyConfiguration")]
    public interface IAdmRemediationRecipeVerifyConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#build_service_type AdmRemediationRecipe#build_service_type}.</summary>
        [JsiiProperty(name: "buildServiceType", typeJson: "{\"primitive\":\"string\"}")]
        string BuildServiceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#additional_parameters AdmRemediationRecipe#additional_parameters}.</summary>
        [JsiiProperty(name: "additionalParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdditionalParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#jenkins_url AdmRemediationRecipe#jenkins_url}.</summary>
        [JsiiProperty(name: "jenkinsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JenkinsUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#job_name AdmRemediationRecipe#job_name}.</summary>
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#pat_secret_id AdmRemediationRecipe#pat_secret_id}.</summary>
        [JsiiProperty(name: "patSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PatSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#pipeline_id AdmRemediationRecipe#pipeline_id}.</summary>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#repository_url AdmRemediationRecipe#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#trigger_secret_id AdmRemediationRecipe#trigger_secret_id}.</summary>
        [JsiiProperty(name: "triggerSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TriggerSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#username AdmRemediationRecipe#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#workflow_name AdmRemediationRecipe#workflow_name}.</summary>
        [JsiiProperty(name: "workflowName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkflowName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAdmRemediationRecipeVerifyConfiguration), fullyQualifiedName: "oci.admRemediationRecipe.AdmRemediationRecipeVerifyConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.AdmRemediationRecipe.IAdmRemediationRecipeVerifyConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#build_service_type AdmRemediationRecipe#build_service_type}.</summary>
            [JsiiProperty(name: "buildServiceType", typeJson: "{\"primitive\":\"string\"}")]
            public string BuildServiceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#additional_parameters AdmRemediationRecipe#additional_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdditionalParameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#jenkins_url AdmRemediationRecipe#jenkins_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jenkinsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JenkinsUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#job_name AdmRemediationRecipe#job_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#pat_secret_id AdmRemediationRecipe#pat_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PatSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#pipeline_id AdmRemediationRecipe#pipeline_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#repository_url AdmRemediationRecipe#repository_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#trigger_secret_id AdmRemediationRecipe#trigger_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggerSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TriggerSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#username AdmRemediationRecipe#username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/adm_remediation_recipe#workflow_name AdmRemediationRecipe#workflow_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workflowName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkflowName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

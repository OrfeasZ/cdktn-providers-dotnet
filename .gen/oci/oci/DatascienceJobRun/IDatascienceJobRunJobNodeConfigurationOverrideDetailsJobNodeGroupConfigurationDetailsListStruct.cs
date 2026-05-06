using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListStruct), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListStruct")]
    public interface IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#name DatascienceJobRun#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>job_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_configuration_details DatascienceJobRun#job_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "jobConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails? JobConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_environment_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_environment_configuration_details DatascienceJobRun#job_environment_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "jobEnvironmentConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails? JobEnvironmentConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_infrastructure_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_infrastructure_configuration_details DatascienceJobRun#job_infrastructure_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails? JobInfrastructureConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#minimum_success_replicas DatascienceJobRun#minimum_success_replicas}.</summary>
        [JsiiProperty(name: "minimumSuccessReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumSuccessReplicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#replicas DatascienceJobRun#replicas}.</summary>
        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Replicas
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListStruct), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#name DatascienceJobRun#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>job_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_configuration_details DatascienceJobRun#job_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails? JobConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobConfigurationDetails?>();
            }

            /// <summary>job_environment_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_environment_configuration_details DatascienceJobRun#job_environment_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobEnvironmentConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails? JobEnvironmentConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobEnvironmentConfigurationDetails?>();
            }

            /// <summary>job_infrastructure_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_infrastructure_configuration_details DatascienceJobRun#job_infrastructure_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails? JobInfrastructureConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#minimum_success_replicas DatascienceJobRun#minimum_success_replicas}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumSuccessReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumSuccessReplicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#replicas DatascienceJobRun#replicas}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Replicas
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

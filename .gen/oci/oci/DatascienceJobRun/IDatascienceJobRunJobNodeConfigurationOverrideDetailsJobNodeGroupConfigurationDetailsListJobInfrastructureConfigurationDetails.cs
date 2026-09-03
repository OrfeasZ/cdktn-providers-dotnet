using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails")]
    public interface IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#job_infrastructure_type DatascienceJobRun#job_infrastructure_type}.</summary>
        [JsiiProperty(name: "jobInfrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        string JobInfrastructureType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#block_storage_size_in_gbs DatascienceJobRun#block_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockStorageSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#compute_target_id DatascienceJobRun#compute_target_id}.</summary>
        [JsiiProperty(name: "computeTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeTargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_shape_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#job_shape_config_details DatascienceJobRun#job_shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "jobShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsJobShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsJobShapeConfigDetails? JobShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#resource_configuration DatascienceJobRun#resource_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration? ResourceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#shape_name DatascienceJobRun#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShapeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#subnet_id DatascienceJobRun#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#job_infrastructure_type DatascienceJobRun#job_infrastructure_type}.</summary>
            [JsiiProperty(name: "jobInfrastructureType", typeJson: "{\"primitive\":\"string\"}")]
            public string JobInfrastructureType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#block_storage_size_in_gbs DatascienceJobRun#block_storage_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockStorageSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#compute_target_id DatascienceJobRun#compute_target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeTargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>job_shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#job_shape_config_details DatascienceJobRun#job_shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsJobShapeConfigDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsJobShapeConfigDetails? JobShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsJobShapeConfigDetails?>();
            }

            /// <summary>resource_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#resource_configuration DatascienceJobRun#resource_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration? ResourceConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#shape_name DatascienceJobRun#shape_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShapeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#subnet_id DatascienceJobRun#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobJobInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetails")]
    public interface IDatascienceJobJobInfrastructureConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#job_infrastructure_type DatascienceJob#job_infrastructure_type}.</summary>
        [JsiiProperty(name: "jobInfrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        string JobInfrastructureType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#block_storage_size_in_gbs DatascienceJob#block_storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockStorageSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#compute_target_id DatascienceJob#compute_target_id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#job_shape_config_details DatascienceJob#job_shape_config_details}
        /// </remarks>
        [JsiiProperty(name: "jobShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsJobShapeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsJobShapeConfigDetails? JobShapeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#resource_configuration DatascienceJob#resource_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration? ResourceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#shape_name DatascienceJob#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShapeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#subnet_id DatascienceJob#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobJobInfrastructureConfigurationDetails), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#job_infrastructure_type DatascienceJob#job_infrastructure_type}.</summary>
            [JsiiProperty(name: "jobInfrastructureType", typeJson: "{\"primitive\":\"string\"}")]
            public string JobInfrastructureType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#block_storage_size_in_gbs DatascienceJob#block_storage_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockStorageSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#compute_target_id DatascienceJob#compute_target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeTargetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeTargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>job_shape_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#job_shape_config_details DatascienceJob#job_shape_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobShapeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsJobShapeConfigDetails\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsJobShapeConfigDetails? JobShapeConfigDetails
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsJobShapeConfigDetails?>();
            }

            /// <summary>resource_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#resource_configuration DatascienceJob#resource_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration? ResourceConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#shape_name DatascienceJob#shape_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShapeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/datascience_job#subnet_id DatascienceJob#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

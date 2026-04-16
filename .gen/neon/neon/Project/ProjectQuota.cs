using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiByValue(fqn: "neon.project.ProjectQuota")]
    public class ProjectQuota : neon.Project.IProjectQuota
    {
        /// <summary>The total amount of wall-clock time allowed to be spent by the project's compute endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#active_time_seconds Project#active_time_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ActiveTimeSeconds
        {
            get;
            set;
        }

        /// <summary>The total amount of CPU seconds allowed to be spent by the project's compute endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#compute_time_seconds Project#compute_time_seconds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "computeTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ComputeTimeSeconds
        {
            get;
            set;
        }

        /// <summary>Total amount of data transferred from all of a project's branches using the proxy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#data_transfer_bytes Project#data_transfer_bytes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataTransferBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DataTransferBytes
        {
            get;
            set;
        }

        /// <summary>Limit on the logical size of every project's branch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#logical_size_bytes Project#logical_size_bytes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logicalSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LogicalSizeBytes
        {
            get;
            set;
        }

        /// <summary>Total amount of data written to all of a project's branches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#written_data_bytes Project#written_data_bytes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "writtenDataBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WrittenDataBytes
        {
            get;
            set;
        }
    }
}

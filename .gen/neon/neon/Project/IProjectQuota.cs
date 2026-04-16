using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiInterface(nativeType: typeof(IProjectQuota), fullyQualifiedName: "neon.project.ProjectQuota")]
    public interface IProjectQuota
    {
        /// <summary>The total amount of wall-clock time allowed to be spent by the project's compute endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#active_time_seconds Project#active_time_seconds}
        /// </remarks>
        [JsiiProperty(name: "activeTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ActiveTimeSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The total amount of CPU seconds allowed to be spent by the project's compute endpoints.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#compute_time_seconds Project#compute_time_seconds}
        /// </remarks>
        [JsiiProperty(name: "computeTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ComputeTimeSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Total amount of data transferred from all of a project's branches using the proxy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#data_transfer_bytes Project#data_transfer_bytes}
        /// </remarks>
        [JsiiProperty(name: "dataTransferBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DataTransferBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Limit on the logical size of every project's branch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#logical_size_bytes Project#logical_size_bytes}
        /// </remarks>
        [JsiiProperty(name: "logicalSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LogicalSizeBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Total amount of data written to all of a project's branches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#written_data_bytes Project#written_data_bytes}
        /// </remarks>
        [JsiiProperty(name: "writtenDataBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WrittenDataBytes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProjectQuota), fullyQualifiedName: "neon.project.ProjectQuota")]
        internal sealed class _Proxy : DeputyBase, neon.Project.IProjectQuota
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The total amount of wall-clock time allowed to be spent by the project's compute endpoints.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#active_time_seconds Project#active_time_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ActiveTimeSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The total amount of CPU seconds allowed to be spent by the project's compute endpoints.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#compute_time_seconds Project#compute_time_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "computeTimeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ComputeTimeSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Total amount of data transferred from all of a project's branches using the proxy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#data_transfer_bytes Project#data_transfer_bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataTransferBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DataTransferBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Limit on the logical size of every project's branch.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#logical_size_bytes Project#logical_size_bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logicalSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LogicalSizeBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Total amount of data written to all of a project's branches.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#written_data_bytes Project#written_data_bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "writtenDataBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WrittenDataBytes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

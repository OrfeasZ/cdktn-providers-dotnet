using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    [JsiiInterface(nativeType: typeof(IBatchBatchContextFleetsShape), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextFleetsShape")]
    public interface IBatchBatchContextFleetsShape
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#memory_in_gbs BatchBatchContext#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double MemoryInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#ocpus BatchBatchContext#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        double Ocpus
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#disk_size_in_gbs BatchBatchContext#disk_size_in_gbs}.</summary>
        [JsiiProperty(name: "diskSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskSizeInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#shape_name BatchBatchContext#shape_name}.</summary>
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShapeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchBatchContextFleetsShape), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextFleetsShape")]
        internal sealed class _Proxy : DeputyBase, oci.BatchBatchContext.IBatchBatchContextFleetsShape
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#memory_in_gbs BatchBatchContext#memory_in_gbs}.</summary>
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double MemoryInGbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#ocpus BatchBatchContext#ocpus}.</summary>
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
            public double Ocpus
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#disk_size_in_gbs BatchBatchContext#disk_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#shape_name BatchBatchContext#shape_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShapeName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/batch_batch_context#type BatchBatchContext#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}

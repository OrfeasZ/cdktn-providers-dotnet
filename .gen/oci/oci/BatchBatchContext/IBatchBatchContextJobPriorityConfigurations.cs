using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    [JsiiInterface(nativeType: typeof(IBatchBatchContextJobPriorityConfigurations), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextJobPriorityConfigurations")]
    public interface IBatchBatchContextJobPriorityConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#tag_key BatchBatchContext#tag_key}.</summary>
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
        string TagKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#tag_namespace BatchBatchContext#tag_namespace}.</summary>
        [JsiiProperty(name: "tagNamespace", typeJson: "{\"primitive\":\"string\"}")]
        string TagNamespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#values BatchBatchContext#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#weight BatchBatchContext#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchBatchContextJobPriorityConfigurations), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextJobPriorityConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.BatchBatchContext.IBatchBatchContextJobPriorityConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#tag_key BatchBatchContext#tag_key}.</summary>
            [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
            public string TagKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#tag_namespace BatchBatchContext#tag_namespace}.</summary>
            [JsiiProperty(name: "tagNamespace", typeJson: "{\"primitive\":\"string\"}")]
            public string TagNamespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#values BatchBatchContext#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Values
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/batch_batch_context#weight BatchBatchContext#weight}.</summary>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}

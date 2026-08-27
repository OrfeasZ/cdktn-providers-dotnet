using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BatchBatchContext
{
    [JsiiInterface(nativeType: typeof(IBatchBatchContextNetwork), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextNetwork")]
    public interface IBatchBatchContextNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/batch_batch_context#subnet_id BatchBatchContext#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/batch_batch_context#nsg_ids BatchBatchContext#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NsgIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchBatchContextNetwork), fullyQualifiedName: "oci.batchBatchContext.BatchBatchContextNetwork")]
        internal sealed class _Proxy : DeputyBase, oci.BatchBatchContext.IBatchBatchContextNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/batch_batch_context#subnet_id BatchBatchContext#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/batch_batch_context#nsg_ids BatchBatchContext#nsg_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NsgIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}

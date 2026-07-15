using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataLabelingServiceDataset
{
    [JsiiInterface(nativeType: typeof(IDataLabelingServiceDatasetLabelSet), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSet")]
    public interface IDataLabelingServiceDatasetLabelSet
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/data_labeling_service_dataset#items DataLabelingServiceDataset#items}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSetItems" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSetItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLabelingServiceDatasetLabelSet), fullyQualifiedName: "oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSet")]
        internal sealed class _Proxy : DeputyBase, oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/data_labeling_service_dataset#items DataLabelingServiceDataset#items}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataLabelingServiceDataset.IDataLabelingServiceDatasetLabelSetItems" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataLabelingServiceDataset.DataLabelingServiceDatasetLabelSetItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}

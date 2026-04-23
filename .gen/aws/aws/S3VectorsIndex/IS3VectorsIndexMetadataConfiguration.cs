using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3VectorsIndex
{
    [JsiiInterface(nativeType: typeof(IS3VectorsIndexMetadataConfiguration), fullyQualifiedName: "aws.s3VectorsIndex.S3VectorsIndexMetadataConfiguration")]
    public interface IS3VectorsIndexMetadataConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3vectors_index#non_filterable_metadata_keys S3VectorsIndex#non_filterable_metadata_keys}.</summary>
        [JsiiProperty(name: "nonFilterableMetadataKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] NonFilterableMetadataKeys
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3VectorsIndexMetadataConfiguration), fullyQualifiedName: "aws.s3VectorsIndex.S3VectorsIndexMetadataConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3VectorsIndex.IS3VectorsIndexMetadataConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/s3vectors_index#non_filterable_metadata_keys S3VectorsIndex#non_filterable_metadata_keys}.</summary>
            [JsiiProperty(name: "nonFilterableMetadataKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] NonFilterableMetadataKeys
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}

using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3VectorsIndex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3VectorsIndex.S3VectorsIndexMetadataConfiguration")]
    public class S3VectorsIndexMetadataConfiguration : aws.S3VectorsIndex.IS3VectorsIndexMetadataConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/s3vectors_index#non_filterable_metadata_keys S3VectorsIndex#non_filterable_metadata_keys}.</summary>
        [JsiiProperty(name: "nonFilterableMetadataKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] NonFilterableMetadataKeys
        {
            get;
            set;
        }
    }
}

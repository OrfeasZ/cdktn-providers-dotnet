using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ObjectstorageObject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.objectstorageObject.ObjectstorageObjectSourceUriDetails")]
    public class ObjectstorageObjectSourceUriDetails : oci.ObjectstorageObject.IObjectstorageObjectSourceUriDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#bucket ObjectstorageObject#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#namespace ObjectstorageObject#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#object ObjectstorageObject#object}.</summary>
        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public string Object
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#region ObjectstorageObject#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#destination_object_if_match_etag ObjectstorageObject#destination_object_if_match_etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationObjectIfMatchEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationObjectIfMatchEtag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#destination_object_if_none_match_etag ObjectstorageObject#destination_object_if_none_match_etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationObjectIfNoneMatchEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationObjectIfNoneMatchEtag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#source_object_if_match_etag ObjectstorageObject#source_object_if_match_etag}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceObjectIfMatchEtag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceObjectIfMatchEtag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/objectstorage_object#source_version_id ObjectstorageObject#source_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVersionId
        {
            get;
            set;
        }
    }
}

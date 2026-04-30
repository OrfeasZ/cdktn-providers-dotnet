using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessCollectionGroup
{
    [JsiiByValue(fqn: "aws.opensearchserverlessCollectionGroup.OpensearchserverlessCollectionGroupCapacityLimits")]
    public class OpensearchserverlessCollectionGroupCapacityLimits : aws.OpensearchserverlessCollectionGroup.IOpensearchserverlessCollectionGroupCapacityLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearchserverless_collection_group#max_indexing_capacity_in_ocu OpensearchserverlessCollectionGroup#max_indexing_capacity_in_ocu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxIndexingCapacityInOcu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearchserverless_collection_group#max_search_capacity_in_ocu OpensearchserverlessCollectionGroup#max_search_capacity_in_ocu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSearchCapacityInOcu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearchserverless_collection_group#min_indexing_capacity_in_ocu OpensearchserverlessCollectionGroup#min_indexing_capacity_in_ocu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinIndexingCapacityInOcu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/opensearchserverless_collection_group#min_search_capacity_in_ocu OpensearchserverlessCollectionGroup#min_search_capacity_in_ocu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinSearchCapacityInOcu
        {
            get;
            set;
        }
    }
}

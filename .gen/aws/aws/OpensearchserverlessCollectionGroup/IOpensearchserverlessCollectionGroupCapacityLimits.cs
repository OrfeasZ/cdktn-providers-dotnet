using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchserverlessCollectionGroup
{
    [JsiiInterface(nativeType: typeof(IOpensearchserverlessCollectionGroupCapacityLimits), fullyQualifiedName: "aws.opensearchserverlessCollectionGroup.OpensearchserverlessCollectionGroupCapacityLimits")]
    public interface IOpensearchserverlessCollectionGroupCapacityLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#max_indexing_capacity_in_ocu OpensearchserverlessCollectionGroup#max_indexing_capacity_in_ocu}.</summary>
        [JsiiProperty(name: "maxIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxIndexingCapacityInOcu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#max_search_capacity_in_ocu OpensearchserverlessCollectionGroup#max_search_capacity_in_ocu}.</summary>
        [JsiiProperty(name: "maxSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSearchCapacityInOcu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#min_indexing_capacity_in_ocu OpensearchserverlessCollectionGroup#min_indexing_capacity_in_ocu}.</summary>
        [JsiiProperty(name: "minIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinIndexingCapacityInOcu
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#min_search_capacity_in_ocu OpensearchserverlessCollectionGroup#min_search_capacity_in_ocu}.</summary>
        [JsiiProperty(name: "minSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSearchCapacityInOcu
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchserverlessCollectionGroupCapacityLimits), fullyQualifiedName: "aws.opensearchserverlessCollectionGroup.OpensearchserverlessCollectionGroupCapacityLimits")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchserverlessCollectionGroup.IOpensearchserverlessCollectionGroupCapacityLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#max_indexing_capacity_in_ocu OpensearchserverlessCollectionGroup#max_indexing_capacity_in_ocu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxIndexingCapacityInOcu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#max_search_capacity_in_ocu OpensearchserverlessCollectionGroup#max_search_capacity_in_ocu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSearchCapacityInOcu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#min_indexing_capacity_in_ocu OpensearchserverlessCollectionGroup#min_indexing_capacity_in_ocu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minIndexingCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinIndexingCapacityInOcu
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearchserverless_collection_group#min_search_capacity_in_ocu OpensearchserverlessCollectionGroup#min_search_capacity_in_ocu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minSearchCapacityInOcu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSearchCapacityInOcu
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}

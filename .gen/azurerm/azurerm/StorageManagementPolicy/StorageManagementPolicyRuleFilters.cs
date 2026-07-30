using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.storageManagementPolicy.StorageManagementPolicyRuleFilters")]
    public class StorageManagementPolicyRuleFilters : azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_management_policy#blob_types StorageManagementPolicy#blob_types}.</summary>
        [JsiiProperty(name: "blobTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] BlobTypes
        {
            get;
            set;
        }

        private object? _matchBlobIndexTag;

        /// <summary>match_blob_index_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_management_policy#match_blob_index_tag StorageManagementPolicy#match_blob_index_tag}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFiltersMatchBlobIndexTag" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchBlobIndexTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageManagementPolicy.StorageManagementPolicyRuleFiltersMatchBlobIndexTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchBlobIndexTag
        {
            get => _matchBlobIndexTag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFiltersMatchBlobIndexTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.StorageManagementPolicy.IStorageManagementPolicyRuleFiltersMatchBlobIndexTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchBlobIndexTag = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/storage_management_policy#prefix_match StorageManagementPolicy#prefix_match}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefixMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PrefixMatch
        {
            get;
            set;
        }
    }
}

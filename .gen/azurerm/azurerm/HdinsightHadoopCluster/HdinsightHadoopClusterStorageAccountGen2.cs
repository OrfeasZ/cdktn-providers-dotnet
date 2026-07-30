using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountGen2")]
    public class HdinsightHadoopClusterStorageAccountGen2 : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterStorageAccountGen2
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hadoop_cluster#filesystem_id HdinsightHadoopCluster#filesystem_id}.</summary>
        [JsiiProperty(name: "filesystemId", typeJson: "{\"primitive\":\"string\"}")]
        public string FilesystemId
        {
            get;
            set;
        }

        private object _isDefault;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hadoop_cluster#is_default HdinsightHadoopCluster#is_default}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDefault", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsDefault
        {
            get => _isDefault;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isDefault = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hadoop_cluster#storage_account_id HdinsightHadoopCluster#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/hdinsight_hadoop_cluster#user_assigned_identity_id HdinsightHadoopCluster#user_assigned_identity_id}.</summary>
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}

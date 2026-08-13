using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterNetwork")]
    public class HdinsightSparkClusterNetwork : azurerm.HdinsightSparkCluster.IHdinsightSparkClusterNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#connection_direction HdinsightSparkCluster#connection_direction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionDirection
        {
            get;
            set;
        }

        private object? _privateLinkEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/hdinsight_spark_cluster#private_link_enabled HdinsightSparkCluster#private_link_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateLinkEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PrivateLinkEnabled
        {
            get => _privateLinkEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _privateLinkEnabled = value;
            }
        }
    }
}

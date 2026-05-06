using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagedKafkaKafkaClusterConfigs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataOciManagedKafkaKafkaClusterConfigs.DataOciManagedKafkaKafkaClusterConfigsFilter")]
    public class DataOciManagedKafkaKafkaClusterConfigsFilter : oci.DataOciManagedKafkaKafkaClusterConfigs.IDataOciManagedKafkaKafkaClusterConfigsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/managed_kafka_kafka_cluster_configs#name DataOciManagedKafkaKafkaClusterConfigs#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/managed_kafka_kafka_cluster_configs#values DataOciManagedKafkaKafkaClusterConfigs#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }

        private object? _regex;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/managed_kafka_kafka_cluster_configs#regex DataOciManagedKafkaKafkaClusterConfigs#regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Regex
        {
            get => _regex;
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
                _regex = value;
            }
        }
    }
}

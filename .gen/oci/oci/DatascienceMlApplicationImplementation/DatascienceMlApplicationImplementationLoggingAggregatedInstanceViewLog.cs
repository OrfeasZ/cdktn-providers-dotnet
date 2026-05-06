using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationImplementation
{
    [JsiiByValue(fqn: "oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog")]
    public class DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog : oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog
    {
        private object? _enableLogging;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_implementation#enable_logging DatascienceMlApplicationImplementation#enable_logging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableLogging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableLogging
        {
            get => _enableLogging;
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
                _enableLogging = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_implementation#log_group_id DatascienceMlApplicationImplementation#log_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_implementation#log_id DatascienceMlApplicationImplementation#log_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogId
        {
            get;
            set;
        }
    }
}

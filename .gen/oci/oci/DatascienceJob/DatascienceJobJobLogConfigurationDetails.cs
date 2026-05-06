using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobLogConfigurationDetails")]
    public class DatascienceJobJobLogConfigurationDetails : oci.DatascienceJob.IDatascienceJobJobLogConfigurationDetails
    {
        private object? _enableAutoLogCreation;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#enable_auto_log_creation DatascienceJob#enable_auto_log_creation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableAutoLogCreation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableAutoLogCreation
        {
            get => _enableAutoLogCreation;
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
                _enableAutoLogCreation = value;
            }
        }

        private object? _enableLogging;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#enable_logging DatascienceJob#enable_logging}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#log_group_id DatascienceJob#log_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#log_id DatascienceJob#log_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogId
        {
            get;
            set;
        }
    }
}
